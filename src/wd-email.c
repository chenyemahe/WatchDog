#include "wd-email.h"
#include "utils/logger.h"
#include "utils/utils.h"
#include <app_preference.h>

void _main_view_send_email(char filePath[]){
	email_h msg;
	const char *string_key = "Email";
	char *email;
	int error_code = EMAILS_ERROR_NONE;
	error_code = email_create_message(&msg);
	if (error_code != EMAILS_ERROR_NONE)
	{
	   dlog_print(DLOG_INFO, LOG_TAG, "Failed to create email message\n");
	}
	email_error_code_checking(error_code);

	preference_get_string(string_key, &email);
    dlog_print(DLOG_INFO, LOG_TAG, "Email: %s\n",email);
	error_code = email_add_recipient(msg, EMAIL_RECIPIENT_TYPE_TO, email);
	free(email);
	if (error_code != EMAILS_ERROR_NONE)
	{
	   dlog_print(DLOG_INFO, LOG_TAG, "Failed to add recipient\n");
	}

	error_code = email_add_attach(msg, filePath);
	if (error_code != EMAILS_ERROR_NONE)
	{
	   dlog_print(DLOG_INFO, LOG_TAG, "Failed to add attachment\n");
	}

	error_code = email_save_message(msg);
	if (error_code != EMAILS_ERROR_NONE)
	{
	   dlog_print(DLOG_INFO, LOG_TAG, "Failed to save email\n");
	}

	error_code = email_set_message_sent_cb(msg, email_send_status, NULL);
	if (error_code != EMAILS_ERROR_NONE)
	{
	   dlog_print(DLOG_INFO, LOG_TAG, "Failed to set sending status callback\n");
	}

	error_code = email_send_message(msg, false);
	if (error_code != EMAILS_ERROR_NONE)
	{
	   dlog_print(DLOG_INFO, LOG_TAG, "");
	}
}

void email_send_status(email_h email, email_sending_e result, void *user_data)
{
   if (result == EMAIL_SENDING_FAILED)
   {
      // Error handling
      dlog_print(DLOG_INFO, LOG_TAG, "Failed to send email\n");
   }
   else if (result == EMAIL_SENDING_SUCCEEDED)
   {
      // Sending was successful
      dlog_print(DLOG_INFO, LOG_TAG, "Email sending finished with success\n");
   }
}
