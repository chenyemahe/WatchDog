/*
 * Copyright 2014 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
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

#include "utils/utils.h"
#include <email.h>
#include "utils/logger.h"

long long utils_round(double value)
{
    long long whole = (long long)(value);
    double fract = value - (double)(whole);
    if (fract >= 0.5)
    {
        return whole + 1;
    }
    if (fract < -0.5)
    {
        return whole - 1;
    }
    return whole;
}

void substr(char s[], char sub[], int p, int l) {
   int c = 0;

   while (c < l) {
      sub[c] = s[p+c-1];
      c++;
   }
   sub[c] = '\0';
}

void email_error_code_checking(int error_code){
	if (error_code == EMAILS_ERROR_OUT_OF_MEMORY)
	{
	   dlog_print(DLOG_INFO, LOG_TAG, "EMAILS_ERROR_OUT_OF_MEMORY\n");
	}
    if (error_code == EMAILS_ERROR_INVALID_PARAMETER)
	{
	   dlog_print(DLOG_INFO, LOG_TAG, "EMAILS_ERROR_INVALID_PARAMETER\n");
	}
    if (error_code == EMAILS_ERROR_SERVER_NOT_READY )
	{
	   dlog_print(DLOG_INFO, LOG_TAG, "EMAILS_ERROR_SERVER_NOT_READY\n");
	}
    if (error_code == EMAILS_ERROR_COMMUNICATION_WITH_SERVER_FAILED )
	{
	   dlog_print(DLOG_INFO, LOG_TAG, "EMAILS_ERROR_COMMUNICATION_WITH_SERVER_FAILED\n");
	}
    if (error_code == EMAILS_ERROR_OPERATION_FAILED)
	{
	   dlog_print(DLOG_INFO, LOG_TAG, "EMAILS_ERROR_OPERATION_FAILED\n");
	}
    if (error_code == EMAILS_ERROR_ACCOUNT_NOT_FOUND)
	{
	   dlog_print(DLOG_INFO, LOG_TAG, "EMAILS_ERROR_ACCOUNT_NOT_FOUND\n");
	}
    if (error_code == EMAILS_ERROR_DB_FAILED)
	{
	   dlog_print(DLOG_INFO, LOG_TAG, "EMAILS_ERROR_DB_FAILED\n");
	}
    if (error_code == EMAILS_ERROR_PERMISSION_DENIED)
	{
	   dlog_print(DLOG_INFO, LOG_TAG, "EMAILS_ERROR_PERMISSION_DENIED\n");
	}
}
