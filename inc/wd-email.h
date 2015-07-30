#ifndef __WD_EMAIL__
#define __WD_EMAIL__

#include <email.h>

void _main_view_send_email(char filePath[]);
void email_send_status(email_h email, email_sending_e result, void *user_data);

static const char *WARNING_EMAIL_BODY = "WARING! There is an unauthorized user try to log in to your Z1 device. Please refer the attached photo!";
static const char *WARNING_EMAIL_SUBJECT = "[Watch Dog] Someone try to unlock your device";
#endif /* __WD_EMAIL__ */
