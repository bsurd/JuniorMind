using System;

namespace JuniorMind.VariablesAndStatements
{
    public class TestOne
    {
        /**
         * Same as the one that uses doubles but if both inputs are of int type this will be used instead.
         * And I also wanted to overload the method, you might consider looking it up.
         */
        public static void Subtraction(int a, int b) => Console.WriteLine(a - b);

        /**
         * Actual code used for this:
         * double a = Convert.ToDouble(Console.ReadLine());
         * double b = Convert.ToDouble(Console.ReadLine());
         * Console.WriteLine(a - b);
         */
        public static void Subtraction(double a, double b) => Console.WriteLine(a - b);

        /**
         * double a = Convert.ToDouble(Console.ReadLine());
         * a *= 2;
         * Console.WriteLine(a);
         */
        public static void DoubledNumber(double a)
        {
            a *= 2;
            Console.WriteLine("{0,0:N2}", a);
        }

        /**
         * int a = Convert.ToInt32(Console.ReadLine());
         * Console.WriteLine(a % 2 == 1);
         */
        public static void OddOrEven(int a) => Console.WriteLine(a % 2 == 1);
    }
}
