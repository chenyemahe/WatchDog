#include "wd-email.h"
#include "utils/logger.h"
#include "utils/utils.h"

void _main_view_send_email(char filePath[]){
	email_h msg;
	int error_code = EMAILS_ERROR_NONE;
	error_code = email_create_message(&msg);
	if (error_code != EMAILS_ERROR_NONE)
	{
	   dlog_print(DLOG_INFO, LOG_TAG, "Failed to create email message\n");
	}
	email_error_code_checking(error_code);

	error_code = email_add_recipient(msg, EMAIL_RECIPIENT_TYPE_TO, "chenyemh2@gmail.com");
	if (error_code != EMAILS_ERROR_NONE)
	{
	   dlog_print(DLOG_INFO, LOG_TAG, "Failed to add recipient\n");
	}

	error_code = email_set_subject(msg, WARNING_EMAIL_SUBJECT);
	if (error_code != EMAILS_ERROR_NONE)
	{
	   dlog_print(DLOG_INFO, LOG_TAG, "Failed to add subject\n");
	}

	error_code = email_set_body(msg, WARNING_EMAIL_BODY);
	if (error_code != EMAILS_ERROR_NONE)
	{
	   dlog_print(DLOG_INFO, LOG_TAG, "Failed to add body\n");
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
