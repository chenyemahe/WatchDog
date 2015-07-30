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

#ifndef __TYPES_H__
#define __TYPES_H__

#include <stdbool.h>

enum
{
    DISP_MAX_DIGITS = 1,

    DISP_STR_LEN = 1,
    DISP_STR_SIZE = DISP_STR_LEN + 1
};

typedef enum
{
    RES_OK = 0,

    RES_FAIL = -1,
    RES_OUT_OF_MEMORY = -2,

    RES_ILLEGAL_ARGUMENT = -3,
    RES_ILLEGAL_STATE = -4,

    RES_INTERNAL_ERROR = -5,
    RES_UNDEFINED_VALUE = -6

} result_type;

typedef enum
{
    CALC_KEY_NONE = 0,
    CALC_KEY_ERASE = 1,
    CALC_KEY_RESET = 2,

    CALC_KEY_TYPE_MASK = 0xFF00,

    CALC_KEY_TYPE_NUM = 0x0100,

    CALC_KEY_0 = CALC_KEY_TYPE_NUM | 0,
    CALC_KEY_1 = CALC_KEY_TYPE_NUM | 1,
    CALC_KEY_2 = CALC_KEY_TYPE_NUM | 2,
    CALC_KEY_3 = CALC_KEY_TYPE_NUM | 3,
    CALC_KEY_4 = CALC_KEY_TYPE_NUM | 4,
    CALC_KEY_5 = CALC_KEY_TYPE_NUM | 5,
    CALC_KEY_6 = CALC_KEY_TYPE_NUM | 6,
    CALC_KEY_7 = CALC_KEY_TYPE_NUM | 7,
    CALC_KEY_8 = CALC_KEY_TYPE_NUM | 8,
    CALC_KEY_9 = CALC_KEY_TYPE_NUM | 9,
    CALC_KEY_DEC = CALC_KEY_TYPE_NUM | 10,

} key_type;

typedef void (*notify_cb)(void *cb_data);

#endif /* __TYPES_H__ */
