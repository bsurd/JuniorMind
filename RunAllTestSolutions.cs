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
            VariablesAndStatements.TestOne.Subtraction(TestDataGenerator.DataGenerator.RandomIntArray()[0], TestDataGenerator.DataGenerator.RandomIntArray()[1]);
            VariablesAndStatements.TestOne.DoubledNumber(TestDataGenerator.DataGenerator.RandomDouble());
            VariablesAndStatements.TestOne.OddOrEven(TestDataGenerator.DataGenerator.RandomInt());

        }
    }
}
