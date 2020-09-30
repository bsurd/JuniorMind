using System;

namespace JuniorMind.VariablesAndStatements
{
    public class TestThree
    {
        public static void TileRequirements(double width, double length, double tileSide) => Console.WriteLine(Math.Ceiling(width / tileSide) * Math.Ceiling(length / tileSide) * ((5 + 100) / 100));

        public static void LaminatedFlooringRequirement(double width, double length, double flooringWidth, double flooringLength) => Console.WriteLine(Math.Ceiling(((width * length) / (flooringWidth * flooringLength)) * 1.15));


    }
}
