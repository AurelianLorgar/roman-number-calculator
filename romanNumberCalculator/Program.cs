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

            char[] firstRomanNumberChar;
            char[] secondRomanNumberChar;

            int firstArabicNumberInt = 0;
            int secondArabicNumberInt = 0;

            //firstRomanNumberChar = FileOperations.readFromFile(fileFirst).ToCharArray();
            //secondRomanNumberChar = FileOperations.readFromFile(fileSecond).ToCharArray();

            //Console.WriteLine(firstRomanNumberChar);

            if (FileOperations.readFromFile(fileFirst).Equals("-")) {
                Console.ReadKey();
                return -1;
            }

            firstRomanNumberChar = FileOperations.readFromFile(fileFirst).ToCharArray();

            if (FileOperations.readFromFile(fileSecond).Equals("-")) {
                Console.ReadKey();
                return -1;
            }

            secondRomanNumberChar = FileOperations.readFromFile(fileSecond).ToCharArray();

            firstArabicNumberInt = RomanToArabic.transfer(firstRomanNumberChar);
            secondArabicNumberInt = RomanToArabic.transfer(secondRomanNumberChar);

            if (firstArabicNumberInt == -1) {
                Console.WriteLine("Проверьте правильность ввода римских чисел в файле " + fileFirst + " или выберите другой файл.");
                Console.ReadKey();
                return -1;
            } else if (secondArabicNumberInt == -1) {
                Console.WriteLine("Проверьте правильность ввода римских чисел в файле " + fileSecond + " или выберите другой файл.");
                Console.ReadKey();
                return -1;
            }
            
            solutionRomanNumberString = mathOperations(firstArabicNumberInt, secondArabicNumberInt);

            FileOperations.writeToFile(fileSolution, solutionRomanNumberString);

            Console.Write(solutionRomanNumberString);
            Console.ReadKey();

            return 0;
        }

        static string mathOperations(int firstNumber, int secondNumber) {
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