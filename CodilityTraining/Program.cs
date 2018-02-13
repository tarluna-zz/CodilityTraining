using System;

namespace CodilityTraining {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine (BinaryGap (529));
        }

        public static int BinaryGap (int N) {
            string binary = Convert.ToString (N, 2);
            int result = 0, current = 0;

            for (int i = 0; i < binary.Length; i++) {
                if (binary[i] != '0') {
                    result = Math.Max (result, current);
                    current = 0;
                } else {
                    current++;
                }
            }
            return result;
        }
    }
}