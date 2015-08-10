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


#ifndef __wd_main_view_key_handler__
#define __wd_main_view_key_handler__

#include <eina_types.h>

void _main_view_set_seceret_code();
void _main_view_reset_user_code();
Eina_Bool _main_view_is_user_code_entered();
void _main_view_set_user_code(char num);
void _main_view_set_recall_code();

/* holds user entered passcode */
typedef struct {
	char user_passcode[5];
	char secret_passcode[5];
	char recall_passcode[5];
	int pass_code_retry_count;
} pass_code;

pass_code *passc;

#endif /* __wd_main_view_key_handler__*/
