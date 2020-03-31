using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace romanNumberCalculator {
    class Program {
        static void Main(string[] args) {
            string pathFirst = @"C:\Users\Aurelian\Documents\Visual Studio 2015\Projects\Технология программирования\romanNumberCalculator\firstNumber.txt";
            string pathSecond = @"C:\Users\Aurelian\Documents\Visual Studio 2015\Projects\Технология программирования\romanNumberCalculator\secondNumber.txt";
            string pathSolution = @"C:\Users\Aurelian\Documents\Visual Studio 2015\Projects\Технология программирования\romanNumberCalculator\solution.txt";

            string firstRomanNumber = null;
            string secondRomanNumber = null;

            char[] firstRomanNumberChar;
            char[] secondRomanNumberChar;
            char[] romanNumbers = {'M', 'D', 'C', 'L', 'X', 'V', 'I'};

            int firstArabicNumber = 0;
            int secondArabicNumber = 0;

            int checkFirst = 0;
            int checkSecond = 0;
           // int pos = 0;

            string solution = null;

            if (File.Exists(pathFirst)) {
                firstRomanNumber = File.ReadAllText(pathFirst);
                firstRomanNumberChar = firstRomanNumber.ToCharArray();
            } 
            else {
                Console.WriteLine("Файл firstNumber.txt не существует");
                Console.ReadKey();
                return;
            }

            for (int pos = 0; pos < firstRomanNumberChar.Length; pos++) {
                checkFirst = pos + 1;

                if (firstRomanNumberChar[pos].Equals('M')) {
                    firstArabicNumber += 1000;
                }

                if (firstRomanNumberChar[pos].Equals('D')) {
                    if (checkFirst < firstRomanNumberChar.Length) {
                        if (firstRomanNumberChar[pos + 1].Equals('M')) {
                            firstArabicNumber -= 500;
                        } else {
                            firstArabicNumber += 500;
                        }
                    } else {
                        firstArabicNumber += 500;
                    }
                }

                if (firstRomanNumberChar[pos].Equals('С')) {
                    if (checkFirst < firstRomanNumberChar.Length) {
                        if (firstRomanNumberChar[pos + 1].Equals('M') || firstRomanNumberChar[pos + 1].Equals('D')) {
                            firstArabicNumber -= 100;
                        } else {
                            firstArabicNumber += 100;
                        }
                    } else {
                        firstArabicNumber += 100;
                    }
                }

                if (firstRomanNumberChar[pos].Equals('L')) {
                    if (checkFirst < firstRomanNumberChar.Length) {
                        if (firstRomanNumberChar[pos + 1].Equals('M') || firstRomanNumberChar[pos + 1].Equals('D')
                        || firstRomanNumberChar[pos + 1].Equals('C')) {
                            firstArabicNumber -= 50;
                        } else {
                            firstArabicNumber += 50;
                        }
                    } else {
                        firstArabicNumber += 50;
                    }
                }


                if (firstRomanNumberChar[pos].Equals('X')) {
                    if (checkFirst < firstRomanNumberChar.Length) {
                        if (firstRomanNumberChar[pos + 1].Equals('M') || firstRomanNumberChar[pos + 1].Equals('D')
                        || firstRomanNumberChar[pos + 1].Equals('C') || firstRomanNumberChar[pos + 1].Equals('L')) {
                            firstArabicNumber -= 10;
                        } else {
                            firstArabicNumber += 10;
                        }
                    } else {
                        firstArabicNumber += 10;
                    }
                }

                if (firstRomanNumberChar[pos].Equals('V')) {
                    if (checkFirst < firstRomanNumberChar.Length) {
                        if (firstRomanNumberChar[pos + 1].Equals('M') || firstRomanNumberChar[pos + 1].Equals('D')
                        || firstRomanNumberChar[pos + 1].Equals('C') || firstRomanNumberChar[pos + 1].Equals('L')
                        || firstRomanNumberChar[pos + 1].Equals('X')) {
                            firstArabicNumber -= 5;
                        } else {
                            firstArabicNumber += 5;
                        }
                    } else {
                        firstArabicNumber += 5;
                    }
                }

                if (firstRomanNumberChar[pos].Equals('I')) {
                    if (checkFirst < firstRomanNumberChar.Length) {
                        if (firstRomanNumberChar[pos + 1].Equals('M') || firstRomanNumberChar[pos + 1].Equals('D')
                        || firstRomanNumberChar[pos + 1].Equals('C') || firstRomanNumberChar[pos + 1].Equals('L')
                        || firstRomanNumberChar[pos + 1].Equals('X') || firstRomanNumberChar[pos + 1].Equals('V')) {
                            firstArabicNumber -= 1;
                        } else {
                            firstArabicNumber += 1;
                        }
                    } else {
                        firstArabicNumber += 1;
                    }
                }
            }

            if (File.Exists(pathSecond)) {
                secondRomanNumber = File.ReadAllText(pathSecond);
                secondRomanNumberChar = secondRomanNumber.ToCharArray();
            } else {
                Console.WriteLine("Файл secondNumber.txt не существует");
                Console.ReadKey();
                return;
            }

            for (int pos = 0; pos < secondRomanNumberChar.Length; pos++) {
                checkSecond = pos + 1;

                if (secondRomanNumberChar[pos].Equals('M')) {
                    secondArabicNumber += 1000;
                }

                if (secondRomanNumberChar[pos].Equals('D')) {
                    if (checkSecond < secondRomanNumberChar.Length) {
                        if (secondRomanNumberChar[pos + 1].Equals('M')) {
                            secondArabicNumber -= 500;
                        } else {
                            secondArabicNumber += 500;
                        }
                    } else {
                        secondArabicNumber += 500;
                    }
                }

                if (secondRomanNumberChar[pos].Equals('С')) {
                    if (checkSecond < secondRomanNumberChar.Length) {
                        if (secondRomanNumberChar[pos + 1].Equals('M') || secondRomanNumberChar[pos + 1].Equals('D')) {
                            secondArabicNumber -= 100;
                        } else {
                            secondArabicNumber += 100;
                        }
                    } else {
                        secondArabicNumber += 100;
                    }
                }

                if (secondRomanNumberChar[pos].Equals('L')) {
                    if (checkSecond < secondRomanNumberChar.Length) {
                        if (secondRomanNumberChar[pos + 1].Equals('M') || secondRomanNumberChar[pos + 1].Equals('D')
                        || secondRomanNumberChar[pos + 1].Equals('C')) {
                            secondArabicNumber -= 50;
                        } else {
                            secondArabicNumber += 50;
                        }
                    } else {
                        secondArabicNumber += 50;
                    }
                }


                if (secondRomanNumberChar[pos].Equals('X')) {
                    if (checkSecond < secondRomanNumberChar.Length) {
                        if (secondRomanNumberChar[pos + 1].Equals('M') || secondRomanNumberChar[pos + 1].Equals('D')
                        || secondRomanNumberChar[pos + 1].Equals('C') || secondRomanNumberChar[pos + 1].Equals('L')) {
                            secondArabicNumber -= 10;
                        } else {
                            secondArabicNumber += 10;
                        }
                    } else {
                        secondArabicNumber += 10;
                    }
                }

                if (secondRomanNumberChar[pos].Equals('V')) {
                    if (checkSecond < secondRomanNumberChar.Length) {
                        if (secondRomanNumberChar[pos + 1].Equals('M') || secondRomanNumberChar[pos + 1].Equals('D')
                        || secondRomanNumberChar[pos + 1].Equals('C') || secondRomanNumberChar[pos + 1].Equals('L')
                        || secondRomanNumberChar[pos + 1].Equals('X')) {
                            secondArabicNumber -= 5;
                        } else {
                            secondArabicNumber += 5;
                        }
                    } else {
                        secondArabicNumber += 5;
                    }
                }

                if (secondRomanNumberChar[pos].Equals('I')) {
                    if (checkSecond < secondRomanNumberChar.Length) {
                        if (secondRomanNumberChar[pos + 1].Equals('M') || secondRomanNumberChar[pos + 1].Equals('D')
                        || secondRomanNumberChar[pos + 1].Equals('C') || secondRomanNumberChar[pos + 1].Equals('L')
                        || secondRomanNumberChar[pos + 1].Equals('X') || secondRomanNumberChar[pos + 1].Equals('V')) {
                            secondArabicNumber -= 1;
                        } else {
                            secondArabicNumber += 1;
                        }
                    } else {
                        secondArabicNumber += 1;
                    }
                }
            }

            /* solution = firstNumber + secondNumber;
             Console.WriteLine(solution);
             Console.ReadKey();*/

            Console.WriteLine(firstArabicNumber);
            Console.WriteLine(secondArabicNumber);
            Console.ReadKey();
        }
    }
}