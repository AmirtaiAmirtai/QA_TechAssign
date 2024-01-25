﻿using System.Numerics;
namespace QA_project.actions
{
    internal class Multiplying
    {
        internal static void ShowMultiplyResults()
        {

            Console.Clear();
            BigInteger val1;
            do
            {
                Console.Clear();
                Console.WriteLine("Your first value:");
            } while (!BigInteger.TryParse(Console.ReadLine(), out val1));

            BigInteger val2;
            do
            {
                Console.Clear();
                Console.WriteLine("Your first value:");
                Console.WriteLine(val1);

                Console.WriteLine("Your second value:");
            } while (!BigInteger.TryParse(Console.ReadLine(), out val2));

            BigInteger result = BigIntegers.MultiplyBigIntegers(val1, val2);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"result: {result}");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press something to continue");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
