using System;

namespace JuniorMind.ConditionalStatements
{
    class TestTwo
    {
        public static void FizzBuzz(int isFizzy) => Console.WriteLine(isFizzy % 3 == 0 && isFizzy % 5 == 0 ? "FizzBuzz" : isFizzy % 5 == 0 ? "Buzz" : isFizzy % 3 == 0 ? "Fizz" : isFizzy.ToString());

        public static void ShoppingList(double cash)
        {
            double[,] shoppingList = { { 2, 10, 3 }, { 5, 0.5, 3 } };
            int[] count = new int[shoppingList.Length / 2];

            for (int i = 0; i < shoppingList.Length / 2; i++)
            {
                if (cash >= shoppingList[1, i] && shoppingList[0, i] > 0)
                {
                    cash -= shoppingList[1, i];
                    shoppingList[0, i]--;
                    count[i]++;
                    i--;
                }
            }

            for (int i = 0; i < count.Length; i++)
            {
                Console.WriteLine(count[i]);

            }

            if (count[count.Length - 1] == 3)
            {
                Console.WriteLine("DA");
            }
            else
            {
                Console.WriteLine("NU");
            }
        }
    }
}
