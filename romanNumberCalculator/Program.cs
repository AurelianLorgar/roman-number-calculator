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

            int firstArabicNumber = 0;
            int secondArabicNumber = 0;

            int check = 0;
            int pos = 0;

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

            if (pos < firstRomanNumberChar.Length) {
                check = pos + 1;

                 {
                    switch (firstRomanNumberChar[pos]) {
                        case ('M'):
                            firstArabicNumber += 1000;
                            break;

                        case ('D'):
                            if (check < firstRomanNumberChar.Length) {
                                if (firstRomanNumberChar[pos + 1].Equals('M')) {
                                    firstArabicNumber -= 500;
                                } else {
                                    firstArabicNumber += 500;
                                }
                            } else {
                                firstArabicNumber += 500;
                            }
                            break;

                        case ('C'):
                            if (check < firstRomanNumberChar.Length) {
                                if (firstRomanNumberChar[pos + 1].Equals('M') || firstRomanNumberChar[pos + 1].Equals('D')) {
                                    firstArabicNumber -= 100;
                                } else {
                                    firstArabicNumber += 100;
                                }
                            } else {
                                firstArabicNumber += 100;
                            }
                            break;

                        case ('L'):
                            if (check < firstRomanNumberChar.Length) {
                                if (firstRomanNumberChar[pos + 1].Equals('M') || firstRomanNumberChar[pos + 1].Equals('D')
                                || firstRomanNumberChar[pos + 1].Equals('C')) {
                                    firstArabicNumber -= 50;
                                } else {
                                    firstArabicNumber += 50;
                                }
                            } else {
                                firstArabicNumber += 50;
                            }
                            break;

                        case ('X'):
                            if (check < firstRomanNumberChar.Length) {
                                if (firstRomanNumberChar[pos + 1].Equals('M') || firstRomanNumberChar[pos + 1].Equals('D')
                                || firstRomanNumberChar[pos + 1].Equals('C') || firstRomanNumberChar[pos + 1].Equals('L')) {
                                    firstArabicNumber -= 10;
                                } else {
                                    firstArabicNumber += 10;
                                }
                            } else {
                                firstArabicNumber += 10;
                            }
                            break;

                        case ('V'):
                            if (check < firstRomanNumberChar.Length) {
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
                            break;

                        case ('I'):
                            if (check < firstRomanNumberChar.Length) {
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
                            break;
                        default:
                            firstArabicNumber = 0;
                            Console.WriteLine("Введите число в римской нотации");
                            break;
                    }
                }
                /*else {
                    switch (firstRomanNumberChar[pos]) {
                        case ('M'):
                            firstArabicNumber += 1000;
                            break;
                        case ('D'):
                            firstArabicNumber += 500;
                            break;
                        case ('C'):
                            firstArabicNumber += 100;
                            break;
                        case ('L'):
                            firstArabicNumber += 50;
                            break;
                        case ('X'):
                            firstArabicNumber += 10;
                            break;
                        case ('V'):
                            firstArabicNumber += 5;
                            break;
                        case ('I'):
                            firstArabicNumber += 1;
                            break;
                        default:
                            firstArabicNumber = 0;
                            Console.WriteLine("Введите число в римской нотации");
                            break;
                    }
                }*/
            }

            if (File.Exists(pathSecond)) {
                secondRomanNumber = File.ReadAllText(pathSecond);
                secondRomanNumberChar = secondRomanNumber.ToCharArray();
            } else {
                Console.WriteLine("Файл secondNumber.txt не существует");
                Console.ReadKey();
                return;
            }

            /*foreach (int pos in firstRomanNumberChar) {
                switch (pos) {
                    case (1):
                        switch (firstRomanNumberChar[pos]) {
                            case ('M'):
                                firstArabicNumber += 1000;
                                break;
                            case ('D'):
                                firstArabicNumber += 500;
                                break;
                            case ('C'):
                                firstArabicNumber += 100;
                                break;
                            case ('L'):
                                firstArabicNumber += 50;
                                break;
                            case ('X'):
                                firstArabicNumber += 10;
                                break;
                            case ('V'):
                                firstArabicNumber = +5;
                                break;
                            case ('I'):
                                firstArabicNumber += 1;
                                break;
                        }
                        break;
                    case (2):
                        switch (firstRomanNumberChar[pos]) {

                        }
                }
            }*/

            /* solution = firstNumber + secondNumber;
             Console.WriteLine(solution);
             Console.ReadKey();*/

            Console.WriteLine(firstArabicNumber);
            Console.ReadKey();
        }
    }
}