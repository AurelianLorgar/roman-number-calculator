﻿namespace romanNumberCalculator {
    class RomanToArabic {

        //TODO: сделать проверку на наличие в файле всякой ереси, если она есть - выводить сообщение об ошибке и прерывать выполнение
        public static int transfer(char[] arrayOfNumbers) {
            char[] romanNumbersChar = { 'M', 'D', 'C', 'L', 'X', 'V', 'I' };

            int arabicNumberInt = 0;
            int checkPos = 0;

            for (int pos = 0; pos < arrayOfNumbers.Length; pos++) {
                checkPos = pos + 1;

                if (arrayOfNumbers[pos].Equals('M')) {
                        arabicNumberInt += 1000;
                }

                if (arrayOfNumbers[pos].Equals('D')) {
                    if (checkPos < arrayOfNumbers.Length) {
                        if (arrayOfNumbers[pos + 1].Equals('M')) {
                            arabicNumberInt -= 500;
                        } else {
                            arabicNumberInt += 500;
                        }
                    } else {
                        arabicNumberInt += 500;
                    }
                }

                if (arrayOfNumbers[pos].Equals('С')) {
                    if (checkPos < arrayOfNumbers.Length) {
                        if (arrayOfNumbers[pos + 1].Equals('M') || arrayOfNumbers[pos + 1].Equals('D')) {
                            arabicNumberInt -= 100;
                        } else {
                            arabicNumberInt += 100;
                        }
                    } else {
                        arabicNumberInt += 100;
                    }
                }

                if (arrayOfNumbers[pos].Equals('L')) {
                    if (checkPos < arrayOfNumbers.Length) {
                        if (arrayOfNumbers[pos + 1].Equals('M') || arrayOfNumbers[pos + 1].Equals('D') 
                            || arrayOfNumbers[pos + 1].Equals('C')) {
                            arabicNumberInt -= 50;
                        } else {
                            arabicNumberInt += 50;
                        }
                    } else {
                        arabicNumberInt += 50;
                    }
                }

                if (arrayOfNumbers[pos].Equals('X')) {
                    if (checkPos < arrayOfNumbers.Length) {
                        if (arrayOfNumbers[pos + 1].Equals('M') || arrayOfNumbers[pos + 1].Equals('D') 
                            || arrayOfNumbers[pos + 1].Equals('C') || arrayOfNumbers[pos + 1].Equals('L')) {
                            arabicNumberInt -= 10;
                        } else {
                            arabicNumberInt += 10;
                        }
                    } else {
                        arabicNumberInt += 10;
                    }
                }

                if (arrayOfNumbers[pos].Equals('V')) {
                    if (checkPos < arrayOfNumbers.Length) {
                        if (arrayOfNumbers[pos + 1].Equals('M') || arrayOfNumbers[pos + 1].Equals('D') 
                            || arrayOfNumbers[pos + 1].Equals('C') || arrayOfNumbers[pos + 1].Equals('L') 
                            || arrayOfNumbers[pos + 1].Equals('X')) {
                            arabicNumberInt -= 5;
                        } else {
                            arabicNumberInt += 5;
                        }
                    } else {
                        arabicNumberInt += 5;
                    }
                }

                if (arrayOfNumbers[pos].Equals('I')) {
                    if (checkPos < arrayOfNumbers.Length) {
                        if (arrayOfNumbers[pos + 1].Equals('M') || arrayOfNumbers[pos + 1].Equals('D') 
                            || arrayOfNumbers[pos + 1].Equals('C') || arrayOfNumbers[pos + 1].Equals('L') 
                            || arrayOfNumbers[pos + 1].Equals('X') || arrayOfNumbers[pos + 1].Equals('V')) {
                            arabicNumberInt -= 1;
                        } else {
                            arabicNumberInt += 1;
                        }
                    } else {
                        arabicNumberInt += 1;
                    }
                }
            }
            return arabicNumberInt;
        }
    }
}