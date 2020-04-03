// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;

namespace romanNumberCalculator {
    class Program {
        static int Main(string[] args) {

           if (args.Length < 3) {
                Console.WriteLine("Введите имена файлов, в которых записаны римские цифры, и имя файла, в который будет записан ответ");
                Console.ReadKey();
                return 1;
            }
            
            string fileFirst = args[0];
            string fileSecond = args[1];
            string fileSolution = args[2];

            string solutionRomanNumberString = null;

            string firstRomanNumberString;
            string secondRomanNumberString;

            int firstArabicNumberInt = 0;
            int secondArabicNumberInt = 0;

            firstRomanNumberString = FileOperations.readFromFile(fileFirst);
            secondRomanNumberString = FileOperations.readFromFile(fileSecond);

            if ((Check.checkRead(firstRomanNumberString) == false) 
                || (Check.checkRead(secondRomanNumberString) == false)) {
                Console.ReadKey();
                return -1;
            }

            firstArabicNumberInt = RomanToArabic.transfer(firstRomanNumberString.ToCharArray());
            secondArabicNumberInt = RomanToArabic.transfer(secondRomanNumberString.ToCharArray());

            if ((firstArabicNumberInt == -1) || (secondArabicNumberInt == -1)) {
                Console.WriteLine("Проверьте правильность ввода римских чисел или выберите другой файл.");
                Console.ReadKey();
                return -1;
            }
 
            solutionRomanNumberString = Calculations.mathOperations(firstArabicNumberInt, secondArabicNumberInt);

            FileOperations.writeToFile(fileSolution, solutionRomanNumberString);
            Console.Write("Ответ: " + solutionRomanNumberString);
            Console.ReadKey();
            return 0;
        }
    }
}