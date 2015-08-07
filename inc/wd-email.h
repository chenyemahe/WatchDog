#ifndef __WD_EMAIL__
#define __WD_EMAIL__

#include <email.h>

void _main_view_send_email(char filePath[]);
void email_send_status(email_h email, email_sending_e result, void *user_data);

#endif /* __WD_EMAIL__ */
