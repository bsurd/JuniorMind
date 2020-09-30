using System;

namespace JuniorMind.ConditionalStatements
{
    class TestTwo
    {
        public static void FizzBuzz(int isFizzy) => Console.WriteLine(isFizzy % 3 == 0 && isFizzy % 5 == 0 ? "FizzBuzz" : isFizzy % 5 == 0 ? "Buzz" : isFizzy % 3 == 0 ? "Fizz" : isFizzy.ToString());

    }
}
