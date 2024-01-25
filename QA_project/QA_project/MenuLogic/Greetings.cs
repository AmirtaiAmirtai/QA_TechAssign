using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_project.MenuLogic
{
    internal class Greetings
    {

        public static void Greet()
        {
            Console.SetCursorPosition(45, 15);
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the calculator3000!");
            Thread.Sleep(1000);
            Console.ResetColor();
            Console.Clear();
        }
        public static void Stop()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Okay. Goodbye!");
            Console.ResetColor();
            Environment.Exit(0);
        }
    }
}
