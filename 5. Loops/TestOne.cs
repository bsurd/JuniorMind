using System;

namespace JuniorMind.Loops
{
    public class TestOne
    {
        public static void Multiplication(string[] input, int count = 1)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == "x")
                {
                    break;
                }

                count *= Convert.ToInt32(input[i]);

            }

            Console.WriteLine(count);
        }

        public static void MinNumber(int[] input, int min = 0, int i = 0)
        {
            while (i < input.Length)
            {
                if (min > input[i])
                {
                    min = input[i];
                }

                if (input[i] == 0)
                {
                    Console.WriteLine(min);
                    break;
                }
                i++;
            }
        }

        public static void SumofSquares(double number) => Console.WriteLine((number * (number + 1) * (2 * number + 1)) / 6);

        public static void CountPositiveNumbers(string[] isPositive, int count = 0, int i = 0)
        {
            while (i < isPositive.Length)
            {
                if (isPositive[i] == "x")
                {
                    Console.WriteLine(count);
                    break;
                }

                if (Convert.ToInt32(isPositive[i]) > 0)
                {
                    count++;
                }
                i++;

            }

        }
    }
}
