using System;

namespace JuniorMind.ConditionalStatements
{
    public class TestThree
    {
        public static void Zodiac(string starSign)
        {
            switch (starSign)
            {
                case "berbec":
                    Console.WriteLine("martie\naprilie");
                    break;

                case "taur":
                    Console.WriteLine("aprilie\nmai");
                    break;

                case "gemeni":
                    Console.WriteLine("mai\niulie");
                    break;

                case "rac":
                    Console.WriteLine("iunie\niulie");
                    break;

                case "leu":
                    Console.WriteLine("iulie\naugust");
                    break;

                case "fecioara":
                    Console.WriteLine("august\nseptembrie");
                    break;

                case "balanta":
                    Console.WriteLine("septembrie\noctombrie");
                    break;

                case "scorpion":
                    Console.WriteLine("octombrie\nnoiembrie");
                    break;

                case "sagetator":
                    Console.WriteLine("noiembrie\ndecembrie");
                    break;

                case "capricorn":
                    Console.WriteLine("decembrie\nianuarie");
                    break;

                case "varsator":
                    Console.WriteLine("ianuarie\nfebruarie");
                    break;

                case "pesti":
                    Console.WriteLine("februarie\nmartie");
                    break;

                default:
                    Console.WriteLine("zodie invalida");
                    break;
            }
        }
    }
}
