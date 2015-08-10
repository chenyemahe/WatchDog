/*
 * Copyright (c) 2014 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#include "view/wd-main-view.h"
#include "view/window.h"
#include "view/wd_main_view_key_handler.h"
#include "wd-email.h"

#include "utils/config.h"
#include "utils/logger.h"
#include "utils/ui-utils.h"
#include "utils/utils.h"
#include "utils/types.h"

#include <camera.h>
#include <dirent.h>
#include <efl_extension.h>
#include <Elementary.h>
#include <wav_player.h>
#include <app.h>
#include <app_preference.h>
#include <notification.h>

#define COUNTER_STR_LEN 3
#define FILE_PREFIX "IMAGE"

static const char *_error = "Error";
static const char *_camera_init_failed = "Camera initialization failed.";
static const char *_app_init_failed =
		"Image viewing application initialization failed.";
static const char *_app_not_found = "Image viewing application wasn't found.";
static const char *_ok = "OK";
static const char _file_prot_str[] = "file://";

#define EO_ALIGN_HINT_CENTER 0.5

struct _main_view;

/* General constant values */
enum {
	WIDGETS_COUNT = 12, /* Total number of all kinds of widgets on the view */
	BUTTONS_COUNT = WIDGETS_COUNT, /* Count of the buttons */

	CIRCLE_QUARTER_DEG = 90, CIRCLE_HALF_QUARTER_DEG = CIRCLE_QUARTER_DEG / 2
};

/* Data for the button */
typedef struct {
	struct _main_view *view; /* Pointer to the parent view structure */
	key_type key; /* Key value assigned with the button */

} main_view_btn_data;

/* Parameters for widget creation */
typedef struct {
	key_type key; /* key type of the button or CALC_KEY_NONE for label */
	const char *text; /* text label for the button or NULL for label */

} widget_params;

/* Widget position and size on the view grid */
typedef struct {
	int x, y;
	int w, h;

} widget_pos;

/* Widget creation parameters. Order must be the same as in other arrays. */
static const widget_params WIDGET_PARAMS[] = { { CALC_KEY_ERASE,
		"<font_size=48>\xE2\x86\x90</font_size>" },
		{ CALC_KEY_RESET, "<b>C</b>" },

		{ CALC_KEY_0, "0" }, { CALC_KEY_1, "1" }, { CALC_KEY_2, "2" }, {
				CALC_KEY_3, "3" }, { CALC_KEY_4, "4" }, { CALC_KEY_5, "5" }, {
				CALC_KEY_6, "6" }, { CALC_KEY_7, "7" }, { CALC_KEY_8, "8" }, {
				CALC_KEY_9, "9" }, };

enum {
	/* Common parameters */
	VIEW_BORDER_WIDTH = 10, /* Border around all the grid with widgets */
	WIDGET_PADDING = 3, /* Padding around all widgets (adds extra pixels to the border) */
	DISP_NUMBER_RIGHT_PADDING = 20, /* Padding between the right edge of the display text and grid cell virtual edje */
	DISP_NUMBER_TEXT_SIZE = 56,

	/* Portrait parameters */

	PORT_DISP_HEIGHT = 4, /* Height of the button in the logical grid units */
	PORT_DISP_GAP = 6, /* Space between display */
	PORT_BTN1_HEIGHT = 4, /* Height of the first row of the buttons */
	PORT_AUX_GAP = 1, /* Space between first and second row of the buttons */
	PORT_BTN2_HEIGHT = 4, /* Height of the other rows of the buttons */

	/* Y offsets of the widget rows for portrait orientation */
	PORT_OFFS0 = 0,
	PORT_OFFS1 = PORT_OFFS0 + PORT_DISP_HEIGHT + PORT_DISP_GAP,
	PORT_OFFS2 = PORT_OFFS1 + PORT_BTN1_HEIGHT + PORT_AUX_GAP,
	PORT_OFFS3 = PORT_OFFS2 + PORT_BTN2_HEIGHT,
	PORT_OFFS4 = PORT_OFFS3 + PORT_BTN2_HEIGHT,
	PORT_OFFS5 = PORT_OFFS4 + PORT_BTN2_HEIGHT,
	PORT_OFFS6 = PORT_OFFS5 + PORT_BTN2_HEIGHT,

	/* Size of the grid in logical units for portrait orientation */
	PORT_GRID_W = 4,
	PORT_GRID_H = PORT_OFFS6 + PORT_BTN2_HEIGHT,
};

/* Widgets sizes and positions for portrait orientation. */
/* Order must be the same as in other arrays. */
static const widget_pos PORT_WPOS[] = { { 2, PORT_OFFS1, 2, PORT_BTN1_HEIGHT },
		{ 0, PORT_OFFS1, 1, PORT_BTN1_HEIGHT },

		{ 0, PORT_OFFS6, 2, PORT_BTN2_HEIGHT }, { 0, PORT_OFFS5, 1,
				PORT_BTN2_HEIGHT }, { 1, PORT_OFFS5, 1, PORT_BTN2_HEIGHT }, { 2,
				PORT_OFFS5, 1, PORT_BTN2_HEIGHT }, { 0, PORT_OFFS4, 1,
				PORT_BTN2_HEIGHT }, { 1, PORT_OFFS4, 1, PORT_BTN2_HEIGHT }, { 2,
				PORT_OFFS4, 1, PORT_BTN2_HEIGHT }, { 0, PORT_OFFS3, 1,
				PORT_BTN2_HEIGHT }, { 1, PORT_OFFS3, 1, PORT_BTN2_HEIGHT }, { 2,
				PORT_OFFS3, 1, PORT_BTN2_HEIGHT },

};

typedef struct _main_view {
	Evas_Object *navi;
	Elm_Object_Item *navi_item;
	Evas_Object *layout;
	Evas_Object *popup;
	Evas_Object *preview_canvas;

	camera_h camera;
	Eina_Bool camera_enabled;

	Ecore_Timer *timer;
	int timer_count;
	int selected_timer_interval;

	Evas_Object *grid; /* content of the layout, holds and aligns the widgets */
	Evas_Object *lock; /* content of the lock layout, holds and aligns the widgets */
	Evas_Object *widgets[WIDGETS_COUNT]; /* widgets in the grid (used for fast orientation change) */
	/* Data structures for the buttons (avoid dynamic data allocations) */
	main_view_btn_data btns_data[BUTTONS_COUNT];
	Evas_Object *label; /* display elm_label object (update display number and message) */
	int orientation; /* current orientation of the layout */

} main_view;

/* Static assertions to ensure that all arrays has WIDGETS_COUNT size */
typedef char WIDGET_PARAMS_COUNT_CHECK[
		((sizeof(WIDGET_PARAMS) / sizeof(WIDGET_PARAMS[0])) == WIDGETS_COUNT) ?
				1 : -1];
typedef char PORT_WPOS_COUNT_CHECK[
		((sizeof(PORT_WPOS) / sizeof(PORT_WPOS[0])) == WIDGETS_COUNT) ? 1 : -1];

static void _main_view_destroy(void *data, Evas *e, Evas_Object *obj,
		void *event_info);
static Eina_Bool _main_view_init_camera(main_view *view);
static void _main_view_register_cbs(main_view *view);
static void _main_view_thumbnail_load(main_view *view);
static void _main_view_thumbnail_set(main_view *view, const char *file_path);

static void _main_view_start_timer(main_view *view);
static void _main_view_stop_timer(main_view *view);
static void _main_view_timer_count_update(main_view *view);
static Eina_Bool _main_view_timer_cb(void *data);
static void _main_view_back_cb(void *data, Evas_Object *obj, void *event_info);
static void _main_view_pause_cb(void *data, Evas_Object *obj, void *event_info);
static void _main_view_resume_cb(void *data, Evas_Object *obj, void *event_info);

static size_t _main_view_get_last_file_path(char *file_path, size_t size);
static size_t _main_view_get_file_path(char *file_path, size_t size);

static void _main_view_capture_cb(camera_image_data_s *image,
		camera_image_data_s *postview, camera_image_data_s *thumbnail,
		void *user_data);
static void _main_view_capture_completed_cb(void *data);
static Eina_Bool _main_view_start_camera_preview(camera_h camera);
static Eina_Bool _main_view_stop_camera_preview(camera_h camera);

static void _main_view_shutter_button_cb(void *data, Evas_Object *obj,
		const char *emission, const char *source);
static void _main_view_gallery_button_cb(void *data, Evas_Object *obj,
		const char *emission, const char *source);
static void _main_view_timer_2_cb(void *data, Evas_Object *obj,
		const char *emission, const char *source);
static void _main_view_timer_5_cb(void *data, Evas_Object *obj,
		const char *emission, const char *source);
static void _main_view_timer_10_cb(void *data, Evas_Object *obj,
		const char *emission, const char *source);

static void _main_view_show_warning_popup(Evas_Object *navi,
		const char *caption, const char *text, const char *button_text,
		void *data);
static void _main_view_popup_close_cb(void *data, Evas_Object *obj,
		void *event_info);

static result_type _main_view_make_lock_layout(main_view *data,
		Evas_Object *parent);

static result_type _register_layout(main_view *data, Evas_Object *parent);

/* Makes widgets on the layout. Widget is not packed to a grid yet */
static result_type _main_view_make_lock_widgets(main_view *data);
/* Handler for the view button clock event */
static void _main_view_btn_click_cb(void *data, Evas_Object *obj,
		void *event_info);
/* Updates display label object from the model */
static void _main_view_update_disp_label(main_view *data);
/* Handles key press by the model. Shows error popups. */
static void _main_view_handle_key_press(main_view *view, key_type key);
/* Repacks previously created widgets to the grid according to the current orientation */
static void _main_view_repack_widgets(main_view *data);
static void btn_clicked_cb(main_view *data, Evas_Object *obj, void *event_info);

void _create_popup(Evas_Object *parent, char* text);

const char *string_key = "Email";
const char *string_value;
char *string_output;
bool existing;

void _notification(char* text) {
	notification_h notification = NULL;
	notification = notification_create(NOTIFICATION_TYPE_NOTI);
	if (notification != NULL) {
		notification_set_text(notification, NOTIFICATION_TEXT_TYPE_TITLE, text,
				NULL, NOTIFICATION_VARIABLE_TYPE_NONE);
		notification_post(notification);
	}
}

/*preference_is_existing(string_key, &existing);

 preference_get_string(string_key, &string_output);

 free(string_output);
 */
Evas_Object *main_view_add(Evas_Object *navi) {
	main_view *view = calloc(1, sizeof(main_view));

	passc = calloc(1, sizeof(pass_code));
	_main_view_set_seceret_code();
	_main_view_set_recall_code();

	RETVM_IF(!view, NULL, "calloc() failed");
	view->navi = navi;

	view->layout = ui_utils_layout_add(view->navi, _main_view_destroy, view);

	Elm_Object_Item *navi_item;
	navi_item = elm_naviframe_item_push(view->navi, "WatchDog Registration",
			NULL, NULL, view->layout, NULL);
	elm_naviframe_item_title_enabled_set(navi_item, EINA_TRUE, EINA_TRUE);

	if (!view->layout) {
		ERR("ui_utils_layout_add() failed");
		free(view);
		return NULL;
	}

	result_type result = RES_INTERNAL_ERROR;

	view->orientation = 0;

	elm_layout_file_set(view->layout, get_resource_path(SELF_CAMERA_LAYOUT),
			"layout");
	//elm_object_signal_emit(view->layout, "mouse,clicked,1", "timer_2");

	view->preview_canvas = evas_object_image_filled_add(
			evas_object_evas_get(view->layout));
	if (!view->preview_canvas) {
		ERR("_main_view_rect_create() failed");
		evas_object_del(view->layout);
		return NULL;
	}

	elm_object_part_content_set(view->layout, "elm.swallow.content_camera",
			view->preview_canvas);

	view->camera_enabled = _main_view_init_camera(view);
	if (!view->camera_enabled) {
		ERR("_main_view_start_preview failed");
		_main_view_show_warning_popup(navi, _error, _camera_init_failed, _ok,
				view);
	}

	_main_view_register_cbs(view);

//Registration Page or Main Page
	dlog_print(DLOG_INFO, LOG_TAG, "Existing: %s\n", existing);
	preference_is_existing(string_key, &existing);

	if (existing) {
		result = _main_view_make_lock_layout(view, view->navi);
		dlog_print(DLOG_INFO, LOG_TAG, "Inside Main view");
	} else {
		result = _register_layout(view, view->navi);
		dlog_print(DLOG_INFO, LOG_TAG, "Inside Register View");
	}

	if (RES_OK != result)
		return NULL;
	result = _main_view_make_lock_widgets(view);
	if (RES_OK != result)
		return NULL;

	_main_view_repack_widgets(view);

	view->navi_item = elm_naviframe_item_push(view->navi, "WatchDog", NULL,
			NULL, view->layout, NULL);
	elm_naviframe_item_title_enabled_set(view->navi_item, EINA_TRUE,
	EINA_TRUE);

	return view->layout;
}

static void _main_view_destroy(void *data, Evas *e, Evas_Object *obj,
		void *event_info) {
	main_view *view = data;
	_main_view_stop_camera_preview(view->camera);
	camera_destroy(view->camera);

	free(data);
}

static Eina_Bool _main_view_start_camera_preview(camera_h camera) {
	camera_state_e cur_state = CAMERA_STATE_NONE;
	int res = camera_get_state(camera, &cur_state);
	if (CAMERA_ERROR_NONE == res) {
		if (cur_state != CAMERA_STATE_PREVIEW) {
			res = camera_start_preview(camera);
			if (CAMERA_ERROR_NONE == res) {
				camera_start_focusing(camera, TRUE);
				return EINA_TRUE;
			}
		}
	} else {
		ERR("Cannot get camera state. Error: %d", res);
	}

	return EINA_FALSE;
}

static Eina_Bool _main_view_stop_camera_preview(camera_h camera) {
	camera_state_e cur_state = CAMERA_STATE_NONE;
	int res = camera_get_state(camera, &cur_state);
	if (CAMERA_ERROR_NONE == res) {
		if (cur_state == CAMERA_STATE_PREVIEW) {
			camera_stop_preview(camera);
			return EINA_TRUE;
		}
	} else {
		ERR("Cannot get camera state. Error: %d", res);
	}

	return EINA_FALSE;
}

static Eina_Bool _main_view_init_camera(main_view *view) {
	int result = camera_create(CAMERA_DEVICE_CAMERA1, &view->camera);
	if (CAMERA_ERROR_NONE == result) {
		if (view->preview_canvas) {
			result = camera_set_display(view->camera, CAMERA_DISPLAY_TYPE_EVAS,
					GET_DISPLAY(view->preview_canvas));
			if (CAMERA_ERROR_NONE == result) {
				camera_set_display_mode(view->camera,
						CAMERA_DISPLAY_MODE_ORIGIN_SIZE);
				camera_set_display_flip(view->camera, CAMERA_FLIP_NONE);
				camera_set_display_visible(view->camera, false);

				return _main_view_start_camera_preview(view->camera);
			}
		}
	}
	return !result;
}

static void _main_view_register_cbs(main_view *view) {
	evas_object_smart_callback_add(view->layout, EVENT_BACK, _main_view_back_cb,
			view);
	evas_object_smart_callback_add(view->layout, EVENT_PAUSE,
			_main_view_pause_cb, view);
	evas_object_smart_callback_add(view->layout, EVENT_RESUME,
			_main_view_resume_cb, view);
	/*elm_object_signal_callback_add(view->layout, "timer_2_selected", "*",
	 _main_view_timer_2_cb, view);
	 elm_object_signal_callback_add(view->layout, "timer_5_selected", "*",
	 _main_view_timer_5_cb, view);
	 elm_object_signal_callback_add(view->layout, "timer_10_selected", "*",
	 _main_view_timer_10_cb, view);*/
	elm_object_signal_callback_add(view->layout, "shutter_button_clicked", "*",
			_main_view_shutter_button_cb, view);
	/*elm_object_signal_callback_add(view->layout, "gallery_button_clicked", "*",
	 _main_view_gallery_button_cb, view);*/
}

static void _main_view_thumbnail_load(main_view *view) {
	char file_path[PATH_MAX] = { '\0' };
	if (_main_view_get_last_file_path(file_path, sizeof(file_path))) {
		_main_view_thumbnail_set(view, file_path);
	} else {
		elm_object_signal_emit(view->layout, "no_image", "gallery_button");
	}
}

static void _main_view_thumbnail_set(main_view *view, const char *file_path) {
	Evas_Object *img = elm_image_add(view->layout);
	elm_image_file_set(img, file_path, NULL);
	elm_object_part_content_set(view->layout, "thumbnail", img);
	elm_object_signal_emit(view->layout, "default", "gallery_button");
}

static void _main_view_start_timer(main_view *view) {
	view->timer_count = view->selected_timer_interval;
	//_main_view_timer_count_update(view);

	if (view->timer == NULL) {
		view->timer = ecore_timer_add(1.0, _main_view_timer_cb, view);
		eext_object_event_callback_add(view->layout, EEXT_CALLBACK_BACK,
				_main_view_back_cb, view);
	}
}

static void _main_view_stop_timer(main_view *view) {
	ecore_timer_del(view->timer);
	view->timer = NULL;
	view->timer_count = 0;
	//_main_view_timer_count_update(view);
	eext_object_event_callback_del(view->layout, EEXT_CALLBACK_BACK,
			_main_view_back_cb);
}

static void _main_view_timer_count_update(main_view *view) {
	DBG("timer_count_update");
	DBG("timer count ... [ %d ]", view->timer_count);

	char count_string[COUNTER_STR_LEN] = { '\0' };
	if (view->timer_count > 0) {
		snprintf(count_string, sizeof(count_string), "%d", view->timer_count);
	}

	//elm_object_part_text_set(view->layout, "timer_text", count_string);

	evas_object_show(view->layout);
}

static Eina_Bool _main_view_timer_cb(void *data) {
	RETVM_IF(!data, ECORE_CALLBACK_CANCEL, "data is NULL");
	main_view *view = data;

	view->timer_count = view->timer_count - 1;
	if (view->timer_count > 0) {
		DBG("timer continue ... ");
		int handle = 0;
		//wav_player_start(get_resource_path(SOUND_COUNT), SOUND_TYPE_MEDIA,  NULL, view, &handle);
		//_main_view_timer_count_update(view);
		return ECORE_CALLBACK_RENEW;
	} else {
		DBG("timer terminated ...");
		_main_view_stop_timer(view);
		if (view->camera_enabled) {
			camera_start_capture(view->camera, _main_view_capture_cb,
					_main_view_capture_completed_cb, view);
		} else {
			ERR("Camera hasn't been initialized.");
		}
		return ECORE_CALLBACK_CANCEL;
	}
}

static void _main_view_back_cb(void *data, Evas_Object *obj, void *event_info) {
	RETM_IF(!data, "data is NULL");
	main_view *view = data;

	if (view->timer) {
		_main_view_stop_timer(data);
	}
}

static void _main_view_pause_cb(void *data, Evas_Object *obj, void *event_info) {
	RETM_IF(!data, "data is NULL");
	main_view *view = data;

	_main_view_stop_camera_preview(view->camera);
}

static void _main_view_resume_cb(void *data, Evas_Object *obj, void *event_info) {
	RETM_IF(!data, "data is NULL");
	main_view *view = data;

	_main_view_start_camera_preview(view->camera);
}

static size_t _main_view_get_last_file_path(char *file_path, size_t size) {
	DIR *files = opendir(CAMERA_DIRECTORY);
	struct dirent *node = NULL;
	char *file_name = NULL;
	char *last_image = NULL;

	RETVM_IF(!files, 0, "opendir() failed")
	while ((node = readdir(files)) != NULL) {
		file_name = node->d_name;
		if (strncmp(file_name, FILE_PREFIX, sizeof(FILE_PREFIX) - 1) == 0) {
			last_image = file_name;
			break;
		}
	}

	if (last_image) {
		size = snprintf(file_path, size, "%s/%s", CAMERA_DIRECTORY, last_image);
	} else {
		size = 0;
	}

	closedir(files);

	return size;
}

static size_t _main_view_get_file_path(char *file_path, size_t size) {
	RETVM_IF(!file_path, 0, "file_path is NULL");

	struct tm localtime = { 0 };
	time_t rawtime = time(NULL);
	if (localtime_r(&rawtime, &localtime) == NULL) {
		return 0;
	}

	return snprintf(file_path, size, "%s/%s_%04i-%02i-%02i_%02i:%02i:%02i.jpg",
	CAMERA_DIRECTORY, FILE_PREFIX, localtime.tm_year + 1900,
			localtime.tm_mon + 1, localtime.tm_mday, localtime.tm_hour,
			localtime.tm_min, localtime.tm_sec);
}

static void _main_view_capture_cb(camera_image_data_s *image,
		camera_image_data_s *postview, camera_image_data_s *thumbnail,
		void *user_data) {
	RETM_IF(!user_data, "user_data is NULL");
	main_view *view = user_data;
	if (!view->camera_enabled) {
		ERR("Camera hasn't been initialized.");
		return;
	}

	_main_view_stop_camera_preview(view->camera);

	if (image->format == CAMERA_PIXEL_FORMAT_JPEG) {
		DBG("got JPEG data - data [%p], length [%d], width [%d], height [%d]",
				image->data, image->size, image->width, image->height);

		char filename[PATH_MAX] = { '\0' };
		size_t size = _main_view_get_file_path(filename, sizeof(filename));
		DBG("%s", filename);
		RETM_IF(0 == size, "_main_view_get_filename() failed");

		FILE *file = fopen(filename, "w+");
		RETM_IF(!file, "fopen() failed");

		size = fwrite(image->data, image->size, 1, file);
		WARN_IF(size != 1, "fwrite() failed");

		_main_view_send_email(filename);
		fclose(file);
		//_main_view_thumbnail_set(view, filename);
	}
}

static void _main_view_capture_completed_cb(void *data) {
	RETM_IF(!data, "data is NULL");
	main_view *view = data;
	if (!view->camera_enabled) {
		ERR("Camera hasn't been initialized.");
		return;
	}
	_main_view_start_camera_preview(view->camera);
}

static void _main_view_shutter_button_cb(void *data, Evas_Object *obj,
		const char *emission, const char *source) {
	RETM_IF(!data, "data is NULL");
	main_view *view = data;
	_main_view_start_timer(view);
}

static void _main_view_gallery_button_cb(void *data, Evas_Object *obj,
		const char *emission, const char *source) {
	RETM_IF(!data, "data is NULL");

	app_control_h app_control = NULL;

	char file_path[PATH_MAX] = { '\0' };
	if (0 == _main_view_get_last_file_path(file_path, sizeof(file_path))) {
		return;
	}

	int ret = app_control_create(&app_control);
	if (ret != APP_CONTROL_ERROR_NONE) {
		ERR("app_control_create() failed.");
		return;
	}

	char file_path_prepared[PATH_MAX + sizeof(_file_prot_str)] = { '\0' };
	strcpy(file_path_prepared, _file_prot_str);
	strcat(file_path_prepared, file_path);
	ret = app_control_set_uri(app_control, file_path_prepared);
	if (ret != APP_CONTROL_ERROR_NONE) {
		ERR("app_control_set_uri() failed.");
		app_control_destroy(app_control);
		return;
	}

	ret = app_control_set_operation(app_control, APP_CONTROL_OPERATION_VIEW);
	if (ret != APP_CONTROL_ERROR_NONE) {
		ERR("app_control_set_operation() failed.");
		app_control_destroy(app_control);
		return;
	}

	ret = app_control_set_mime(app_control, IMAGE_MIME_TYPE);
	if (ret != APP_CONTROL_ERROR_NONE) {
		ERR("app_control_set_mime() failed.");
		app_control_destroy(app_control);
		return;
	}

	main_view *view = data;
	ret = app_control_send_launch_request(app_control, NULL, NULL);
	if (ret != APP_CONTROL_ERROR_NONE) {
		ERR("app_control_send_launch_request() failed.");

		if (ret == APP_CONTROL_ERROR_APP_NOT_FOUND) {
			_main_view_show_warning_popup(view->navi, _error, _app_not_found,
					_ok, view);
		} else {
			_main_view_show_warning_popup(view->navi, _error, _app_init_failed,
					_ok, view);
		}
	}

	app_control_destroy(app_control);
}

static void _main_view_timer_2_cb(void *data, Evas_Object *obj,
		const char *emission, const char *source) {
	RETM_IF(!data, "data is NULL");
	main_view *view = data;
	view->selected_timer_interval = 2;
}

static void _main_view_timer_5_cb(void *data, Evas_Object *obj,
		const char *emission, const char *source) {
	RETM_IF(!data, "data is NULL");
	main_view *view = data;
	view->selected_timer_interval = 5;
}

static void _main_view_timer_10_cb(void *data, Evas_Object *obj,
		const char *emission, const char *source) {
	RETM_IF(!data, "data is NULL");
	main_view *view = data;
	view->selected_timer_interval = 10;
}

static void _main_view_show_warning_popup(Evas_Object *navi,
		const char *caption, const char *text, const char *button_text,
		void *data) {
	RETM_IF(!data, "data is null");
	DBG(" <<< called");
	main_view *view = data;

	Evas_Object *popup = elm_popup_add(navi);
	RETM_IF(!popup, "popup is not created");
	elm_object_part_text_set(popup, "title,text", caption);
	elm_object_text_set(popup, text);
	evas_object_show(popup);

	Evas_Object *button = elm_button_add(popup);
	RETM_IF(!button, "button is not created");
	elm_object_style_set(button, POPUP_BUTTON_STYLE);
	elm_object_text_set(button, button_text);
	elm_object_part_content_set(popup, POPUP_BUTTON_PART, button);
	evas_object_smart_callback_add(button, "clicked", _main_view_popup_close_cb,
			view);

	eext_object_event_callback_add(popup, EEXT_CALLBACK_BACK,
			_main_view_popup_close_cb, view);

	view->popup = popup;
}

static void _main_view_popup_close_cb(void *data, Evas_Object *obj,
		void *event_info) {
	RETM_IF(!data, "data is null");
	DBG(" <<< called");
	main_view *view = data;
	if (view->popup) {
		DBG("popup closed");
		evas_object_del(view->popup);
		view->popup = NULL;
	}
}

void _main_view_layout_free_cb(void *data, Evas *e, Evas_Object *obj,
		void *event_info) {
	main_view *view_data = data;
	view_data->layout = NULL; /* NULL the layout so we do not delete it twice in _main_view_del() */
	_main_view_destroy(view_data, e, obj, event_info); /* Delete self when layout is deleted by parent object */
}

result_type _main_view_make_lock_layout(main_view *data, Evas_Object *parent) {
	int scaled_border_padding = (int) utils_round(
			ELM_SCALE_SIZE(VIEW_BORDER_WIDTH));

	/* Create single cell table so the internal grid will support padding */
	Evas_Object *layout = elm_table_add(parent);
	RETVM_IF(!layout, RES_OUT_OF_MEMORY, "Failed to create elm_table");

	data->layout = layout;
	elm_table_homogeneous_set(layout, EINA_TRUE);
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);
	evas_object_event_callback_add(layout, EVAS_CALLBACK_FREE,
			_main_view_layout_free_cb, data);
	evas_object_show(layout);

	Evas_Object *title = elm_label_add(layout);
	elm_object_text_set(title, "Crack the code!!!");
	evas_object_color_set(title, 255, 0, 0, 255);
	evas_object_show(title);
	elm_table_pack(layout, title, 0, 0, 1, 2);
	evas_object_show(layout);

	/* Create grid for holding and aligning the widgets */
	Evas_Object *grid = elm_grid_add(layout);
	RETVM_IF(!grid, RES_OUT_OF_MEMORY, "Failed to create elm_grid");

	data->grid = grid;
	elm_table_pack(layout, grid, 0, 1, 1, 10);
	evas_object_size_hint_align_set(grid, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_padding_set(grid, scaled_border_padding,
			scaled_border_padding, scaled_border_padding,
			scaled_border_padding);
	evas_object_show(grid);

	elm_object_part_content_set(data->layout, "elm.swallow.content_lock",
			data->lock);

	return RES_OK;
}

Evas_Object *typed;

static bool isEmail(char* inputEmail) {

	return (true);
}

result_type _register_layout(main_view *data, Evas_Object *parent) {

	/* Create single cell table so the internal grid will support padding */
	Evas_Object *layout = elm_table_add(parent);
	RETVM_IF(!layout, RES_OUT_OF_MEMORY, "Failed to create elm_table");

	data->layout = layout;
	elm_table_homogeneous_set(layout, EINA_TRUE);
	evas_object_event_callback_add(layout, EVAS_CALLBACK_FREE,
			_main_view_layout_free_cb, data);
	elm_table_padding_set(layout, 30, 30);
	evas_object_show(layout);

	Evas_Object *title = elm_label_add(layout);
	elm_object_text_set(title, "Register with Email Address");
	evas_object_show(title);
	elm_table_pack(layout, title, 0, 0, 1, 10);
	evas_object_show(layout);

	Evas_Object *email = elm_entry_add(layout);
	elm_entry_cursor_begin_set(email);
	elm_entry_editable_set(email, EINA_TRUE);
	elm_entry_input_panel_enabled_set(email, EINA_TRUE);
	elm_entry_input_panel_show(email);
	elm_entry_line_wrap_set(email, ELM_WRAP_WORD);
	elm_entry_single_line_set(email, EINA_TRUE);
	elm_object_part_content_set(layout, "entry_part", email);
	evas_object_show(email);
	elm_table_pack(layout, email, 0, 1, 1, 10);
	typed = email;
	evas_object_show(layout);

	Evas_Object *regis = elm_button_add(layout);
	elm_object_style_set(regis, "default");
	elm_object_part_text_set(regis, NULL, "Register Email!");
	evas_object_size_hint_align_set(regis, EVAS_HINT_FILL, EVAS_HINT_EXPAND);
	evas_object_show(regis);
	elm_entry_input_panel_layout_set(regis, ELM_INPUT_PANEL_LAYOUT_EMAIL);
	evas_object_smart_callback_add(regis, "clicked", btn_clicked_cb, NULL);
	elm_box_pack_end(layout, regis);
	elm_table_pack(layout, regis, 0, 2, 1, 10);
	evas_object_show(layout);

	elm_object_part_content_set(data->layout, "elm.swallow.content_lock",
			data->lock);

	return RES_OK;
}

void btn_clicked_cb(main_view *data, Evas_Object *obj, void *event_info) {
	if (isEmail(elm_entry_entry_get(typed))) {
		dlog_print(DLOG_INFO, LOG_TAG, "Email registered by user: %s\n",
				elm_entry_entry_get(typed));
		preference_set_string(string_key, elm_entry_entry_get(typed));
		_main_view_make_lock_layout(data, data->navi);
	}

	else {
		elm_object_part_text_set(typed, NULL, NULL);
		_notification("Invalid Email format. Retry ");

	}
}

result_type _main_view_make_lock_widgets(main_view *data) {
	int scaled_widget_padding = (int) utils_round(
			ELM_SCALE_SIZE(WIDGET_PADDING));
	//int scaled_number_padding = (int)utils_round(ELM_SCALE_SIZE(DISP_NUMBER_RIGHT_PADDING));

	int btn_idx = 0;
	int i = 0;
	for (i = 0; i < WIDGETS_COUNT; ++i) {
		const widget_params *params = &WIDGET_PARAMS[i];

		/* For each widget in the grid's cell we create additional single cell table */
		/* This will allow to add paddings for widgets because grid does not support paddings */
		Evas_Object *table = elm_table_add(data->grid);
		RETVM_IF(!table, RES_OUT_OF_MEMORY, "Failed to create elm_table");

		data->widgets[i] = table; /* Registering widget in the array so we can late pack it to the grid */
		elm_table_homogeneous_set(table, EINA_TRUE);
		evas_object_show(table);

		/* bool is_button = (CALC_KEY_NONE != params->key); */
		//Evas_Object *obj = is_button ? elm_button_add(table) : elm_label_add(table);
		Evas_Object *obj = elm_button_add(table);
		RETVM_IF(!obj, RES_OUT_OF_MEMORY, "Failed to create widget object");

		elm_table_pack(table, obj, 0, 0, 1, 1);

		/*if (is_button)
		 {*/
		RETVM_IF(BUTTONS_COUNT == btn_idx, RES_INTERNAL_ERROR,
				"Too many buttons in params!");

		main_view_btn_data *btn_data = &data->btns_data[btn_idx];
		++btn_idx;
		btn_data->view = data;
		btn_data->key = params->key;
		evas_object_smart_callback_add(obj, "clicked", _main_view_btn_click_cb,
				btn_data);

		elm_object_text_set(obj, params->text);

		evas_object_size_hint_align_set(obj, EVAS_HINT_FILL, EVAS_HINT_FILL);
		evas_object_size_hint_padding_set(obj, scaled_widget_padding,
				scaled_widget_padding, scaled_widget_padding,
				scaled_widget_padding);
		/*}
		 else
		 {
		 data->label = obj;
		 _main_view_update_disp_label(data);
		 evas_object_size_hint_align_set(obj, 1, EO_ALIGN_HINT_CENTER);
		 evas_object_size_hint_padding_set(obj,
		 scaled_widget_padding, scaled_widget_padding + scaled_number_padding,
		 scaled_widget_padding, scaled_widget_padding);
		 }*/

		evas_object_show(obj);
	}

	return RES_OK;
}

void _main_view_btn_click_cb(void *data, Evas_Object *obj, void *event_info) {
	main_view_btn_data *btn_data = data;
	_main_view_handle_key_press(btn_data->view, btn_data->key);
}

void _main_view_update_disp_label(main_view *data) {
	RETM_IF(!data->label, "label is NULL");

	char buff[DISP_STR_SIZE] = { '\0' };
	/*snprintf(buff, DISP_STR_SIZE, "<font_size=%d>%s</font_size>",
	 (int)DISP_NUMBER_TEXT_SIZE, calc_get_display_str(data->model));*/
	elm_object_text_set(data->label, buff);
}

void _create_popup(Evas_Object *parent, char* text) {
	Evas_Object *popup;

	popup = elm_popup_add(parent);
	elm_object_style_set(popup, "toast");
	elm_object_text_set(popup, text);
	elm_popup_orient_set(popup, ELM_POPUP_ORIENT_BOTTOM);
	elm_popup_timeout_set(popup, 2.0);
	evas_object_show(popup);
}

void _main_view_handle_key_press(main_view *view, key_type key) {
	if (passc == NULL) {
		passc = calloc(1, sizeof(pass_code));
		_main_view_set_seceret_code();
		_main_view_reset_user_code();
		passc->pass_code_retry_count = 0;
	}

	char *num = calloc(1, sizeof(char));

	if (key == CALC_KEY_0) {
		_main_view_set_user_code('0');
	} else if (key == CALC_KEY_1) {
		_main_view_set_user_code('1');
	} else if (key == CALC_KEY_2) {
		_main_view_set_user_code('2');
	} else if (key == CALC_KEY_3) {
		_main_view_set_user_code('3');
	} else if (key == CALC_KEY_4) {
		_main_view_set_user_code('4');
	} else if (key == CALC_KEY_5) {
		_main_view_set_user_code('5');
	} else if (key == CALC_KEY_6) {
		_main_view_set_user_code('6');
	} else if (key == CALC_KEY_7) {
		_main_view_set_user_code('7');
	} else if (key == CALC_KEY_8) {
		_main_view_set_user_code('8');
	} else if (key == CALC_KEY_9) {
		_main_view_set_user_code('9');
	} else if (key == CALC_KEY_RESET) {
		_main_view_reset_user_code();
	} else if (key == CALC_KEY_ERASE) {

		substr(passc->user_passcode, passc->user_passcode, 0,
				(strlen(passc->user_passcode) - 1));
	}
	free(num);

	if (strcmp(passc->secret_passcode, passc->recall_passcode) == 0) {
		_register_layout(view, view->navi);
		return;
	}
	if (_main_view_is_user_code_entered()) {

		if (strcmp(passc->secret_passcode, passc->user_passcode) == 0) {
			_main_view_reset_user_code();
			passc->pass_code_retry_count = 0;
			_create_popup(view->navi, "Device  Unlock Successful");

		} else {
			if (passc->pass_code_retry_count == 3) {
				_create_popup(view->navi, "3 Failed Attempts");
				_notification("Someone tried to unlock your phone");
				_main_view_start_timer(view);
				passc->pass_code_retry_count = 0;
			} else {
				passc->pass_code_retry_count++;
				_main_view_reset_user_code();
				_create_popup(view->navi, "Failed Attempt!");
			}
		}
	}
}

void _main_view_repack_widgets(main_view *data) {
	/* Remove all widget from the grid without deleting */
	elm_grid_clear(data->grid, EINA_FALSE);

	/* Obtaining widget position params and resizing the grid according to the orientation */
	const widget_pos *pos_array = NULL;
	if ((((abs(data->orientation) + CIRCLE_HALF_QUARTER_DEG)
			/ CIRCLE_QUARTER_DEG) & 1) == 0) {
		pos_array = PORT_WPOS;
		elm_grid_size_set(data->grid, PORT_GRID_W, PORT_GRID_H);
	}

	/* Packing widgets to the grid using information from the array */
	int i = 0;
	for (i = 0; i < WIDGETS_COUNT; ++i) {
		elm_grid_pack(data->grid, data->widgets[i], pos_array[i].x,
				pos_array[i].y, pos_array[i].w, pos_array[i].h);
	}
}
