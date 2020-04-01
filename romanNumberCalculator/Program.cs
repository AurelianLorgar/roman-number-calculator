//TODO: ИНТЕРФЕЙС!!!11 и сдать!!!11

using System;
using System.IO;

namespace romanNumberCalculator {
    class Program {
        static void Main(string[] args) {

            //TODO: переделать так, чтобы имя файла вводилось с клавиатуры
            string pathFirst = @"C:\Users\Aurelian\Documents\Visual Studio 2015\Projects\Технология программирования\romanNumberCalculator\firstNumber.txt";
            string pathSecond = @"C:\Users\Aurelian\Documents\Visual Studio 2015\Projects\Технология программирования\romanNumberCalculator\secondNumber.txt";
            string pathSolution = @"C:\Users\Aurelian\Documents\Visual Studio 2015\Projects\Технология программирования\romanNumberCalculator\solution.txt";

            string mathSign = null;
            string firstRomanNumberString = null;
            string secondRomanNumberString = null;
            string solutionRomanNumberString = null;

            char[] romanNumbersChar = { 'M', 'D', 'C', 'L', 'X', 'V', 'I' };
            char[] firstRomanNumberChar;
            char[] secondRomanNumberChar;
            char[] solutionArabicNumberChar;
            char[] solutionRomanNumberChar = null;

            int firstArabicNumberInt = 0;
            int secondArabicNumberInt = 0;
            int solutionArabicNumberInt = 0;

            int checkFirst = 0;
            int checkSecond = 0;

            //TODO: перенести в класс ArabicToRoman
            int romanNumM1 = 0;
            int romanNumM2 = 0;
            int romanNumC1 = 0;
            int romanNumC2 = 0;
            int romanNumD1 = 0;
            int romanNumD2 = 0;
            int romanNumL1 = 0;
            int romanNumL2 = 0;
            int romanNumX1 = 0;
            int romanNumX2 = 0;

            //TODO: выделить в метод "Что-то про считывание из файла" и добавить try-catch
            if (File.Exists(pathFirst)) {
                firstRomanNumberString = File.ReadAllText(pathFirst);
                firstRomanNumberChar = firstRomanNumberString.ToCharArray();
            } 
            else {
                Console.WriteLine("Файл firstNumber.txt не существует");
                Console.ReadKey();
                return;
            }

            //TODO: удалить к чертям кхорнячьим, потому что это будет отдельным методом
            if (File.Exists(pathSecond)) {
                secondRomanNumberString = File.ReadAllText(pathSecond);
                secondRomanNumberChar = secondRomanNumberString.ToCharArray();
            } else {
                Console.WriteLine("Файл secondNumber.txt не существует");
                Console.ReadKey();
                return;
            }


            //TODO: выделить в класс RomanToArabic и сделать проверку на наличие в файле всякой ереси (кроме чисел в римской нотации)
            for (int pos = 0; pos < firstRomanNumberChar.Length; pos++) {
                checkFirst = pos + 1;

                if (firstRomanNumberChar[pos].Equals('M')) {
                    firstArabicNumberInt += 1000;
                }

                if (firstRomanNumberChar[pos].Equals('D')) {
                    if (checkFirst < firstRomanNumberChar.Length) {
                        if (firstRomanNumberChar[pos + 1].Equals('M')) {
                            firstArabicNumberInt -= 500;
                        } else {
                            firstArabicNumberInt += 500;
                        }
                    } else {
                        firstArabicNumberInt += 500;
                    }
                }

                if (firstRomanNumberChar[pos].Equals('С')) {
                    if (checkFirst < firstRomanNumberChar.Length) {
                        if (firstRomanNumberChar[pos + 1].Equals('M') || firstRomanNumberChar[pos + 1].Equals('D')) {
                            firstArabicNumberInt -= 100;
                        } else {
                            firstArabicNumberInt += 100;
                        }
                    } else {
                        firstArabicNumberInt += 100;
                    }
                }

                if (firstRomanNumberChar[pos].Equals('L')) {
                    if (checkFirst < firstRomanNumberChar.Length) {
                        if (firstRomanNumberChar[pos + 1].Equals('M') || firstRomanNumberChar[pos + 1].Equals('D')
                        || firstRomanNumberChar[pos + 1].Equals('C')) {
                            firstArabicNumberInt -= 50;
                        } else {
                            firstArabicNumberInt += 50;
                        }
                    } else {
                        firstArabicNumberInt += 50;
                    }
                }


                if (firstRomanNumberChar[pos].Equals('X')) {
                    if (checkFirst < firstRomanNumberChar.Length) {
                        if (firstRomanNumberChar[pos + 1].Equals('M') || firstRomanNumberChar[pos + 1].Equals('D')
                        || firstRomanNumberChar[pos + 1].Equals('C') || firstRomanNumberChar[pos + 1].Equals('L')) {
                            firstArabicNumberInt -= 10;
                        } else {
                            firstArabicNumberInt += 10;
                        }
                    } else {
                        firstArabicNumberInt += 10;
                    }
                }

                if (firstRomanNumberChar[pos].Equals('V')) {
                    if (checkFirst < firstRomanNumberChar.Length) {
                        if (firstRomanNumberChar[pos + 1].Equals('M') || firstRomanNumberChar[pos + 1].Equals('D')
                        || firstRomanNumberChar[pos + 1].Equals('C') || firstRomanNumberChar[pos + 1].Equals('L')
                        || firstRomanNumberChar[pos + 1].Equals('X')) {
                            firstArabicNumberInt -= 5;
                        } else {
                            firstArabicNumberInt += 5;
                        }
                    } else {
                        firstArabicNumberInt += 5;
                    }
                }

                if (firstRomanNumberChar[pos].Equals('I')) {
                    if (checkFirst < firstRomanNumberChar.Length) {
                        if (firstRomanNumberChar[pos + 1].Equals('M') || firstRomanNumberChar[pos + 1].Equals('D')
                        || firstRomanNumberChar[pos + 1].Equals('C') || firstRomanNumberChar[pos + 1].Equals('L')
                        || firstRomanNumberChar[pos + 1].Equals('X') || firstRomanNumberChar[pos + 1].Equals('V')) {
                            firstArabicNumberInt -= 1;
                        } else {
                            firstArabicNumberInt += 1;
                        }
                    } else {
                        firstArabicNumberInt += 1;
                    }
                }
            }

            //TODO: удалить к чертям кхорнячьим, потому что это будет отдельным классом
            for (int pos = 0; pos < secondRomanNumberChar.Length; pos++) {
                checkSecond = pos + 1;

                if (secondRomanNumberChar[pos].Equals('M')) {
                    secondArabicNumberInt += 1000;
                }

                if (secondRomanNumberChar[pos].Equals('D')) {
                    if (checkSecond < secondRomanNumberChar.Length) {
                        if (secondRomanNumberChar[pos + 1].Equals('M')) {
                            secondArabicNumberInt -= 500;
                        } else {
                            secondArabicNumberInt += 500;
                        }
                    } else {
                        secondArabicNumberInt += 500;
                    }
                }

                if (secondRomanNumberChar[pos].Equals('С')) {
                    if (checkSecond < secondRomanNumberChar.Length) {
                        if (secondRomanNumberChar[pos + 1].Equals('M') || secondRomanNumberChar[pos + 1].Equals('D')) {
                            secondArabicNumberInt -= 100;
                        } else {
                            secondArabicNumberInt += 100;
                        }
                    } else {
                        secondArabicNumberInt += 100;
                    }
                }

                if (secondRomanNumberChar[pos].Equals('L')) {
                    if (checkSecond < secondRomanNumberChar.Length) {
                        if (secondRomanNumberChar[pos + 1].Equals('M') || secondRomanNumberChar[pos + 1].Equals('D')
                        || secondRomanNumberChar[pos + 1].Equals('C')) {
                            secondArabicNumberInt -= 50;
                        } else {
                            secondArabicNumberInt += 50;
                        }
                    } else {
                        secondArabicNumberInt += 50;
                    }
                }


                if (secondRomanNumberChar[pos].Equals('X')) {
                    if (checkSecond < secondRomanNumberChar.Length) {
                        if (secondRomanNumberChar[pos + 1].Equals('M') || secondRomanNumberChar[pos + 1].Equals('D')
                        || secondRomanNumberChar[pos + 1].Equals('C') || secondRomanNumberChar[pos + 1].Equals('L')) {
                            secondArabicNumberInt -= 10;
                        } else {
                            secondArabicNumberInt += 10;
                        }
                    } else {
                        secondArabicNumberInt += 10;
                    }
                }

                if (secondRomanNumberChar[pos].Equals('V')) {
                    if (checkSecond < secondRomanNumberChar.Length) {
                        if (secondRomanNumberChar[pos + 1].Equals('M') || secondRomanNumberChar[pos + 1].Equals('D')
                        || secondRomanNumberChar[pos + 1].Equals('C') || secondRomanNumberChar[pos + 1].Equals('L')
                        || secondRomanNumberChar[pos + 1].Equals('X')) {
                            secondArabicNumberInt -= 5;
                        } else {
                            secondArabicNumberInt += 5;
                        }
                    } else {
                        secondArabicNumberInt += 5;
                    }
                }

                if (secondRomanNumberChar[pos].Equals('I')) {
                    if (checkSecond < secondRomanNumberChar.Length) {
                        if (secondRomanNumberChar[pos + 1].Equals('M') || secondRomanNumberChar[pos + 1].Equals('D')
                        || secondRomanNumberChar[pos + 1].Equals('C') || secondRomanNumberChar[pos + 1].Equals('L')
                        || secondRomanNumberChar[pos + 1].Equals('X') || secondRomanNumberChar[pos + 1].Equals('V')) {
                            secondArabicNumberInt -= 1;
                        } else {
                            secondArabicNumberInt += 1;
                        }
                    } else {
                        secondArabicNumberInt += 1;
                    }
                }
            }

            //TODO: добавить ввод имени файлов в консоль, из которых берется решение
            Console.Write("Введите знак математического действия: ");
            mathSign = Console.ReadLine();

            switch (mathSign) {
                case ("+"):
                    solutionArabicNumberInt = firstArabicNumberInt + secondArabicNumberInt;
                    break;
                case ("-"):
                    solutionArabicNumberInt = firstArabicNumberInt - secondArabicNumberInt;
                    break;
                case ("*"):
                    solutionArabicNumberInt = firstArabicNumberInt * secondArabicNumberInt;
                    break;
                case ("/"):
                    solutionArabicNumberInt = firstArabicNumberInt / secondArabicNumberInt;
                    break;
                default:
                    Console.WriteLine("Вы ввели неверный знак");
                    break;
            }

            //TODO: дописать (https://habr.com/ru/post/136646/) и выделить в класс ArabicToRoman 
            romanNumM1 = solutionArabicNumberInt / 1000;
            romanNumM2 = solutionArabicNumberInt % 1000;

            romanNumD1 = romanNumM2 / 500;
            romanNumD2 = romanNumM2 % 500;

            romanNumC1 = romanNumD1 / 100;
            romanNumC2 = romanNumD2 % 100;

            romanNumL1 = romanNumD2 / 50;
            romanNumL2 = romanNumD2 % 50;

            romanNumX1 = romanNumL2 / 10;
            romanNumX2 = romanNumL2 % 10;

            Console.WriteLine();


            //TODO: удалить к чертям кхорнячьим (информация для проверки работы, в самой программе не нужна)
            Console.WriteLine(solutionArabicNumberInt);

            for(int i = 0; i < solutionRomanNumberChar.Length; i++) {
                Console.Write(solutionRomanNumberChar[i]);
            }

            Console.ReadKey();
        }
    }
}