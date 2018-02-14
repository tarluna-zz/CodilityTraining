using System;
using System.Linq;

namespace CodilityTraining {
    public static class OperatorsPlayground {
        static void XOR () {
            Console.WriteLine ("Bitwise result: {0}", Convert.ToString (010000 ^ 0111, 2));

            int a = 5550 ^ 800;
            Console.WriteLine (GetIntBinaryString (5550));
            Console.WriteLine (GetIntBinaryString (800));
            Console.WriteLine (GetIntBinaryString (a));
            Console.WriteLine ();
        }
        public static void test () {
            UnaryOperator (true & false);
            //UnaryOperator();

            int i = 0;
            if (false | ++i == 1) {
                // i is incremented, but the conditional
                // expression evaluates to false, so
                // this block does not execute.
                string t = "";
            }

            checked {
                int overFlow = 10;
                int a = unchecked (2147483647 + overFlow);
            }
        }

        public static void UnaryOperator (bool t) {
            System.Console.WriteLine (t);
        }

        public static void Mod () {

        }

        static string GetIntBinaryString (int n) {
            char[] b = new char[32];
            int pos = 31;
            int i = 0;

            while (i < 32) {
                if ((n & (1 << i)) != 0) {
                    b[pos] = '1';
                } else {
                    b[pos] = '0';
                }
                pos--;
                i++;
            }
            return new string (b);
        }
    }
}