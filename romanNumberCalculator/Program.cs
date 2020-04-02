// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

//TODO: ИНТЕРФЕЙС!!!11 и сдать!!!11

using System;
using System.IO;

namespace romanNumberCalculator {
    class Program {
        static void Main(string[] args) {

            //TODO: переделать так, чтобы имя файла вводилось с клавиатуры
            string pathFirst = @"firstNumber.txt";
            string pathSecond = @"secondNumber.txt";
            string pathSolution = @"solution.txt";

            string mathSign = null;
            string solutionRomanNumberString = null;

            char[] firstRomanNumberChar;
            char[] secondRomanNumberChar;

            int firstArabicNumberInt = 0;
            int secondArabicNumberInt = 0;
            int solutionArabicNumberInt = 0;

            //TODO: выделить в метод "Что-то про считывание из файла" и добавить try-catch
            if (File.Exists(pathFirst)) {
                firstRomanNumberChar = File.ReadAllText(pathFirst).ToCharArray();
            } else {
                Console.WriteLine("Файл firstNumber.txt не существует");
                Console.ReadKey();
                return;
            }

            //TODO: удалить к чертям кхорнячьим, потому что это будет отдельным методом
            if (File.Exists(pathSecond)) {
                secondRomanNumberChar = File.ReadAllText(pathSecond).ToCharArray();
            } else {
                Console.WriteLine("Файл secondNumber.txt не существует");
                Console.ReadKey();
                return;
            }

            firstArabicNumberInt = RomanToArabic.transfer(firstRomanNumberChar);
            secondArabicNumberInt = RomanToArabic.transfer(secondRomanNumberChar);

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

            solutionRomanNumberString = ArabicToRoman.transfer(solutionArabicNumberInt);

            //TODO: удалить к чертям кхорнячьим (информация для проверки работы, в самой программе не нужна)
            //Console.WriteLine(solutionArabicNumberInt);
            Console.WriteLine(solutionRomanNumberString);
            Console.ReadKey();
        }
    }
}