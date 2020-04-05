// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

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
                    try {
                        return solution = ArabicToRoman.transfer(firstNumber / secondNumber);
                    } catch (Exception e) {
                        Console.WriteLine(e.Message);
                        return "";
                    }
                default:
                    Console.WriteLine("Вы ввели неверный знак");
                    return "";
            }
        }
    }
}