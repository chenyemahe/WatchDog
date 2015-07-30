#include "wd-password-checking.h"
#include "view/wd-main-view.h"

Eina_Bool _is_user_code_exist() {
	int i = 0;
	for(i = 0; i<4; i++) {

		if(passc->user_passcode[i] == '\0')
			return 0;
	}

	return 1;
}

static Eina_Bool _main_view_is_user_code_entered() {
	int i = 0;
	for(i = 0; i<4; i++) {

		if(passc->user_passcode[i] == '\0')
			return 0;
	}

	return 1;
}
