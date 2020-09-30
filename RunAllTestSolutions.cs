using System;

using JuniorMind.TestDataGenerator;
using JuniorMind.FirstApp;
using JuniorMind.BaseVariableTypes;
using JuniorMind.VariablesAndStatements;

namespace JuniorMind
{
    class RunAllTestSolutions
    {
        public static void RunSolutions()
        {
            var rand = new Random();

            Console.WriteLine("1.1 Solution");
            FirstApp.TestOne.PrintHelloWorld();

            Console.WriteLine("\n2.1 Solution");
            BaseVariableTypes.TestOne.TruAndTru();
            BaseVariableTypes.TestOne.TruOrTru();
            BaseVariableTypes.TestOne.TruXorTru();
            BaseVariableTypes.TestOne.NotTrue();

            Console.WriteLine("\n2.2 Solution");
            BaseVariableTypes.TestTwo.ProblemOne();
            BaseVariableTypes.TestTwo.ProblemTwo();
            BaseVariableTypes.TestTwo.ProblemThree();
            BaseVariableTypes.TestTwo.ProblemFour();
            BaseVariableTypes.TestTwo.ProblemFive();
            BaseVariableTypes.TestTwo.ProblemSix();
            BaseVariableTypes.TestTwo.ProblemSeven();
            BaseVariableTypes.TestTwo.ProblemEight();
            BaseVariableTypes.TestTwo.ProblemNine();
            BaseVariableTypes.TestTwo.ProblemTen();
            BaseVariableTypes.TestTwo.ProblemEleven();

            Console.WriteLine("\n2.3 Solution");
            BaseVariableTypes.TestThree.ProblemOne();
            BaseVariableTypes.TestThree.ProblemTwo();

            Console.WriteLine("\n3.1 Solution");
            int a = rand.Next(1, 15);
            int b = rand.Next(1, 100);
            double c = rand.NextDouble() * 10;
            Console.Write("Input values were {0} and {1}, result: ", a, b);
            VariablesAndStatements.TestOne.Subtraction(a, b);
            Console.Write("Input value was {0:0.00}, result: ", c);
            VariablesAndStatements.TestOne.DoubledNumber(c);
            Console.Write("Input value was {0}, result: ", a);
            VariablesAndStatements.TestOne.IsNumberOdd(a);

            Console.WriteLine("\n3.2 Solution");
            int x = rand.Next(2, 20);
            int y = rand.Next(100, 1000);
            int z = rand.Next(1, 30);
            int w = rand.Next(2, 10);
            int q = rand.Next(10, 2000);
            Console.Write("With consumption {0} and fuel {1}, travel was: ", a, b);
            VariablesAndStatements.TestTwo.CarTravel(a, b);
            Console.Write("Group 1: {0}, StudBudget: {1}, Days: {2}, Group2: {3}, TotalBudget: {4}, result: ", x, y, z, w, q);
            VariablesAndStatements.TestTwo.StudentDays(x, y, z, w, q);
            double areaWidth = rand.Next(4, 10);
            double areaLength = rand.Next(4, 10);
            double tileSide = rand.Next(2, 4);
            Console.Write("With the following width: {0}, length: {1}, tile: {2}, result is: ", areaWidth, areaLength, tileSide);
            VariablesAndStatements.TestThree.TileRequirements(areaWidth, areaLength, tileSide);
            double roomWidth = rand.Next(4, 10);
            double roomLength = rand.Next(4, 10);
            double flooringWidth = rand.Next(2, 4);
            double flooringLength = rand.Next(2, 4);
            Console.Write("With the following width: {0}, length: {1}, flooringWidth: {2}, flooringLength: {2} result is: ", roomWidth, roomLength, flooringWidth, flooringLength);
            VariablesAndStatements.TestThree.LaminatedFlooringRequirement(roomWidth, roomLength, flooringWidth, flooringLength);
        }
    }
}
