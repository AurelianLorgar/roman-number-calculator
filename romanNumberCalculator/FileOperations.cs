using System;
using System.IO;

namespace romanNumberCalculator {
    class FileOperations {

        public static string readFromFile(string file) {
            try {
                using (StreamReader sr = new StreamReader(file)) {
                    string numberString;
                    while ((numberString = sr.ReadLine()) != null) {
                        return numberString.ToUpper();
                    }
                }
            }
            catch (Exception e) {
                Console.Write("Файл невозможно прочитать: ");
                Console.WriteLine(e.Message);
                return "-";
            }
            return "";
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