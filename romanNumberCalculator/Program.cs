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
            string solutionRomanNumberString = null;

            char[] firstRomanNumberChar;
            char[] secondRomanNumberChar;
            char[] solutionArabicNumberChar;
            char[] solutionRomanNumberChar = null;

            int firstArabicNumberInt = 0;
            int secondArabicNumberInt = 0;
            int solutionArabicNumberInt = 0;

            //TODO: перенести в класс ArabicToRoman

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

            solutionRomanNumberString = ArabicToRoman.transfer(3999);

            //TODO: удалить к чертям кхорнячьим (информация для проверки работы, в самой программе не нужна)
            //Console.WriteLine(solutionArabicNumberInt);
            Console.WriteLine(solutionRomanNumberString);
            Console.ReadKey();
        }
    }
}