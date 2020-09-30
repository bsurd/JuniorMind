using System;

namespace JuniorMind.VariablesAndStatements
{
    public class TestTwo
    {
        public static void CarTravel(int a, int b) => Console.WriteLine((b / a) * 100);

        public static void StudentDays(int studentGroupOne, int individualStudentBudget, int numberOfDays, int studentGroupTwo, int totalBudget) => Console.WriteLine((totalBudget / studentGroupTwo) / (individualStudentBudget / numberOfDays));

    }
}
