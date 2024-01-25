using System.Numerics;

namespace QA_project.actions
{
    internal class Division //деление
    {
        internal static void ShowDivisionResults()
        {

            Console.Clear();
            
            BigInteger val1;

            do
            {
                Console.Clear ();
                Console.WriteLine("Your first value:");
                string userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput) || !BigInteger.TryParse(userInput, out val1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid non-empty number for the first value:");
                    continue; // Пропускаем оставшуюся часть цикла и начинаем заново
                }

                break; // Выход из цикла при успешном вводе
            } while (true);
            BigInteger val2;



            do
            {
                Console.WriteLine("Your second value:");
                string userInput = Console.ReadLine();
                var isEmpty = string.IsNullOrWhiteSpace(userInput);
                var parseResult = BigInteger.TryParse(userInput, out val2);
                var isZero = val2 == 0;

                var isNotValid = isEmpty || !parseResult || isZero;

                if (isNotValid)
                {
                    Console.Clear();
                    Console.WriteLine("Your first value:");
                    Console.WriteLine(val1);
                    continue;
                }

                break;
            } while (true);
            BigInteger result = BigIntegers.DivideBigIntegers(ref val1, ref val2);
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
