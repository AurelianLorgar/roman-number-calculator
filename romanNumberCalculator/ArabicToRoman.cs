using System.Text;
using System;
using System.IO;

namespace romanNumberCalculator {
    class ArabicToRoman {

        public static string transfer(int number) {

            StringBuilder romanNumber = new StringBuilder("");

            int romanNumM1 = 0;
            int romanNumM2 = 0;
            int romanNumC1 = 0;
            int romanNumC2 = 0;
            int romanNumD1 = 0;
            int romanNumD2 = 0;
            int romanNumL1 = 0;
            int romanNumL2 = 0;
            int romanNumX1 = 0;
            int romanNumX2 = 0;

            romanNumM1 = number / 1000;
            romanNumber.Append(M(romanNumM1));
            romanNumM2 = number % 1000;

            romanNumD1 = romanNumM2 / 500;
            romanNumber.Append(D(romanNumD1));
            romanNumD2 = romanNumM2 % 500;

            romanNumC1 = romanNumD2 / 100;
            romanNumber.Append(C(romanNumC1));
            romanNumC2 = romanNumD2 % 100;

            romanNumL1 = romanNumC2 / 50;
            romanNumber.Append(L(romanNumL1));
            romanNumL2 = romanNumC2 % 50;

            romanNumX1 = romanNumL2 / 10;
            romanNumber.Append(X(romanNumX1));
            romanNumX2 = romanNumL2 % 10;

            romanNumber.Append(basic(romanNumX2));
            return romanNumber.ToString();
        }

        private static string M(int number) {
            StringBuilder romanNumber = new StringBuilder("");
            int i = 0;
            while (i < number) {
                romanNumber.Append("M");
                i++;
            }
            return romanNumber.ToString();
        }

        private static string D(int number) {
            if (number.ToString().Length >= 3) {
                if (number == 4) {
                    return "CM";
                } else {
                    return "D";
                }
            }
            else {
                return "";
            }
        }

        private static string C(int number) {
            if (number == 4) {
                return "CD";
            } else if ((number != 0) & (number < 4)) {
                StringBuilder romanNumber = new StringBuilder("");
                int i = 0;
                while (i < number) {
                    romanNumber.Append("C");
                    i++;
                }
                return romanNumber.ToString();
            } else return "";
        }

        private static string L(int number) {
            if (number != 0) {
                if (number == 4) {
                    return "XC";
                } else {
                    return "L";
                }
            }
            else {
                return "";
            }
        }

        private static string X(int number) {
            if (number == 4) {
                return "XL";
            } else if ((number != 0) & (number < 4)) {
                StringBuilder romanNumber = new StringBuilder("");
                int i = 0;
                while (i < number) {
                    romanNumber.Append("X");
                    i++;
                }
                return romanNumber.ToString();
            } else {
                return "";
            }
        }

        private static string basic(int number) {
            string[] romanNumber = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            return romanNumber[number];
        }

    }
}
