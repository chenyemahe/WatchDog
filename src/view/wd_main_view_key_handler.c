#include "view/wd_main_view_key_handler.h"

/*sets the default secret code*/
void _main_view_set_seceret_code() {
	passc->secret_passcode[0] = '0';
	passc->secret_passcode[1] = '0';
	passc->secret_passcode[2] = '0';
	passc->secret_passcode[3] = '0';
}

void _main_view_reset_user_code() {
	passc->user_passcode[0] = '\0';
	passc->user_passcode[1] = '\0';
	passc->user_passcode[2] = '\0';
	passc->user_passcode[3] = '\0';
}

void _main_view_set_recall_code() {
	passc->recall_passcode[0] = '0';
	passc->recall_passcode[1] = '1';
	passc->recall_passcode[2] = '2';
	passc->recall_passcode[3] = '3';
}

Eina_Bool _main_view_is_user_code_entered() {
	int i = 0;
	for (i = 0; i < 4; i++) {
		if (passc->user_passcode[i] == '\0')
			return 0;
	}
	return 1;
}

void _main_view_set_user_code(char num) {
	int i = 0;
	for (i = 0; i < 4; i++) {
		if (passc->user_passcode[i] == '\0') {
			passc->user_passcode[i] = num;
			break;
		}
	}
}
