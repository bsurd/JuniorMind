using System;

namespace JuniorMind.TestDataGenerator
{
    class DataGenerator
    {
        public static double RandomDouble()
        {
            var rand = new Random();
            return rand.NextDouble() * 10;
        }

        public static int RandomInt()
        {
            var rand = new Random();
            return rand.Next();
        }

        public static int[] RandomIntArray()
        {
            var rand = new Random();
            int[] intArray = new int[2];
            for (int i = 0; i < 2; i++)
            {
                intArray[i] = rand.Next(0, 10);
            }
            return intArray;
        }
    }
}
