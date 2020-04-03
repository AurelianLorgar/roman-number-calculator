// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace romanNumberCalculator {
    class Check {

        public static bool checkRead(string checkString) {
            bool result;

            if (checkString.Equals("-")) {
                result = false;
            } else {
                result = true;
            }
            return result;
        }

        public static bool checkTransfer(char[] arrayOfNumbersCheck) {
            char[] romanNumbersChar = { 'M', 'D', 'C', 'L', 'X', 'V', 'I' };
            int errTest = 0;
            int err = 0;
            bool result;

            for (int i = 0; i < arrayOfNumbersCheck.Length; i++) {
                for (int j = 0; j < romanNumbersChar.Length; j++) {
                    if (romanNumbersChar[j] != arrayOfNumbersCheck[i]) {
                        errTest++;
                    }
                }
                if (errTest != 7) {
                    errTest = 0;
                } else {
                    err++;
                }
            }
            if (err > 0) {
                result = false;
            } else {
                result = true;
            }
            return result;
        }
    }
}
