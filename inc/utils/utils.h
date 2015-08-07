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

#ifndef __UTILS_H__
#define __UTILS_H__

/**
 * @brief Rounds double values to an integer number
 * Rounding is not symmetric relative to 0. (2.5 -> 3; -2.5 -> -2)
 * @param[in] value     Double value to round
 * @return Integer number the result of the rounding
 */
long long utils_round(double value);

void substr(char [], char[], int, int);

void email_error_code_checking(int error_code);

#endif /* __UTILS_H__ */
