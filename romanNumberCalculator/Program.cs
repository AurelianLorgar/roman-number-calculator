// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using RomanCalculator;
using System.Data;

namespace romanNumberCalculator {
    class Program {

        static int Main(string[] args) {

            RomanToArabic romanToArabic = new RomanToArabic();
            ArabicToRoman arabicToRoman = new ArabicToRoman();
            FileOperations fileOperations = new FileOperations();

            char[] numbers = { 'M', 'D', 'C', 'L', 'X', 'V', 'I' };
            string[] signs = { "+", "-", "*", "/" };

            if (args.Length < 2) {
                Console.WriteLine("Введите имя файла, в котором записано выражение, над которым необходимо провести математическую операцию," +
                    " и имя файла, в который будет записан ответ");
                Console.ReadKey();
                return 1;
            }

            string fileNumbers = args[0];
            string fileSolution = args[1];
            string solutionRomanNumberString;
            string romanNumbersString = fileOperations.ReadFromFile(fileNumbers).ToUpper();
            string transferString = "";
            string[] numbersArray = { "" };
            int solutionInt = 0;
            int err = 0;
            char delimiter = '@';
            bool check;

            if (Check.CheckRead(romanNumbersString).Equals(false)) {
                Console.ReadKey();
                return -1;
            }

            for (int i = 0; i < romanNumbersString.Length; i++) {
                for (int j = 0; j < numbers.Length; j++) {
                    if (!romanNumbersString[i].Equals(numbers[j])) {
                        err++;
                    }
                }
                for (int j = 0; j < signs.Length; j++) {
                    if (romanNumbersString[i].Equals(signs[j])) {
                        err++;
                    }
                }

                if (err == 11) {
                    Console.WriteLine("Обнаружен недопустимый символ");
                    Console.ReadKey();
                    return -1;
                }
            }

            for (int i = 0; i < signs.Length; i++) {
                romanNumbersString = romanNumbersString.Replace(signs[i], delimiter + signs[i] + delimiter);
            }

            for (int i = 0; i < romanNumbersString.Length; i++) {
                if (romanNumbersString[i].Equals(delimiter)) {
                    numbersArray = romanNumbersString.Split(delimiter);
                }
            }

            string[] numbersArabicArray = new string[numbersArray.Length];

            for (int i = 0; i < numbersArray.Length; i++) {
                check = true;
                for (int j = 0; j < signs.Length; j++) {
                    if (numbersArray[i].Equals(signs[j])) {
                        numbersArabicArray[i] += numbersArray[i];
                        check = false;
                    }
                }
                if (check) {
                    numbersArabicArray[i] += romanToArabic.Transfer(numbersArray[i].ToCharArray()).ToString();
                }
            }

            transferString = string.Join(null, numbersArabicArray);

            try {
                var solution = new DataTable().Compute(transferString, null);
                double solutionDouble = Convert.ToDouble(solution.ToString());
                solutionInt = Convert.ToInt32(Math.Round(solutionDouble, 0));
                solutionRomanNumberString = arabicToRoman.Transfer(solutionInt);
            }
            catch (Exception e) {
                Console.WriteLine("Ошибка вычисления");
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return -1;
            }

            fileOperations.WriteToFile(fileSolution, solutionRomanNumberString);
            Console.Write("Ответ: " +  solutionRomanNumberString);
            Console.ReadKey();
            return 0;
        }
    }
}