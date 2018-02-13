using System;
using System.Linq;

namespace CodilityTraining {
    class Program {
        static void Main (string[] args) {
            BinaryGap (529);
            OddOccurency (new int[] { 9, 3, 9, 3, 9, 7, 9 });
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

        public static int OddOccurency (int[] A) {
            //return A.Aggregate((x, y) => x ^ y);
            A = A.OrderBy (t => t).ToArray ();
            int i;
            for (i = 0; i < A.Length - 1 && A[i] == A[i + 1]; i += 2);
            return A[i];
        }
    }
}