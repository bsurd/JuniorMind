using System;

namespace JuniorMind.BaseVariableTypes
{
    public class TestOne
    {
        public static void TruAndTru() => Console.WriteLine(true && true);

        public static void TruOrTru() => Console.WriteLine(true || true);

        public static void TruXorTru() => Console.WriteLine(true ^ true);
        public static void NotTrue() => Console.WriteLine(!true);

    }
}
