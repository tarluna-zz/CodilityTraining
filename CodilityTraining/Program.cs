using System;
using System.Linq;

namespace CodilityTraining {
    class Program {
        static void Main (string[] args) {
            int[] A = new int[] { 9, 3, 9, 3, 9, 7, 9 };
            int[] b = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] c = new int[] { 1000, 2000 };
            int[] d = new int[] { 1, 1, -1, -1, -1, -1, -1, 1, 1 };
            BinaryGap (529);
            OddOccurency (A);
            CyclicRotation (b, 3);
            TapeEquilibrium (c);
            CodilityChallenge (d);
        }
        #region Challenges
        public static int CodilityChallenge (int[] A) {
            int result = int.MinValue, longestStreak = 1;

            for (int i = 1; i < A.Length - 1; i++) {
                if (A[i] + A[i + 1] >= 0) {
                    longestStreak++;
                }
                result = Math.Max (longestStreak, result);
            }

            return result;
        }
        #endregion

        #region Lessons Region
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

        public static int[] CyclicRotation (int[] A, int K) {
            int arrayLength = A.Length;
            int[] reversedArray = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++) {
                if (i + K >= arrayLength)
                    reversedArray[(i + K) % arrayLength] = A[i];
                else
                    reversedArray[i + K] = A[i];

            }
            return reversedArray;
        }

        public static int TapeEquilibrium (int[] A) {
            int currentMin = Int32.MaxValue, currentValue = 0, arrayLength = A.Length, max = A.Sum ();

            if (arrayLength < 3) {
                return 0;
            }

            for (int i = arrayLength - 1; i >= 0; i--) {
                max = max - A[i];
                currentValue += A[i];
                currentMin = Math.Min (currentMin, Math.Abs (max - currentValue));
            }

            return currentMin;
        }
        #endregion
    }
}