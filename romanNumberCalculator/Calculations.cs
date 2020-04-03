using System;

namespace romanNumberCalculator {
    class Calculations {

        public static string mathOperations(int firstNumber, int secondNumber) {
            Console.Write("Введите знак математического действия: ");
            string mathSign = null;
            string solution = null;

            mathSign = Console.ReadLine();

            switch (mathSign) {
                case ("+"):
                    return solution = ArabicToRoman.transfer(firstNumber + secondNumber);
                case ("-"):
                    return solution = ArabicToRoman.transfer(firstNumber - secondNumber);
                case ("*"):
                    return solution = ArabicToRoman.transfer(firstNumber * secondNumber);
                case ("/"):
                    return solution = ArabicToRoman.transfer(firstNumber / secondNumber);
                default:
                    Console.WriteLine("Вы ввели неверный знак");
                    return "";
            }
        }
    }
}