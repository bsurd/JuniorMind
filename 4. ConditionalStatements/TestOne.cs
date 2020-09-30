using System;

namespace JuniorMind.ConditionalStatements
{
    public class TestOne
    {
        public static void MinimumOfTwoNumbers(double a, double b) => Console.WriteLine(a < b ? a : b);
        public static void RaceWinner(string firstRacer, double racerOne, string secondRacer, double racerTwo) => Console.WriteLine(racerOne < racerTwo ? firstRacer : secondRacer);
    }
}
