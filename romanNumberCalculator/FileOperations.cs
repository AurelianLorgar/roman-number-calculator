// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.IO;
using System.Text;

namespace romanNumberCalculator {
    class FileOperations {

        public static string readFromFile(string file) {
            StringBuilder numberStringBuilder = new StringBuilder("");
            try {
                using (StreamReader sr = new StreamReader(file)) {
                    
                    string numberString;
                    while ((numberString = sr.ReadLine()) != null) {
                        numberStringBuilder.Append(numberString.ToUpper());
                    }
                }
            }
            catch (Exception e) {
                Console.Write("Файл невозможно прочитать: ");
                Console.WriteLine(e.Message);
                return "-";
            }
            return numberStringBuilder.ToString();
        }

        public static void writeToFile(string file, string number) {
            try {
                using (StreamWriter sw = new StreamWriter(file, false, System.Text.Encoding.Default)) {
                    sw.WriteLine(number);
                }
            } catch (Exception e) {
                Console.Write("Невозможно записать в файл: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}