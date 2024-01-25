using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_project.MenuLogic
{
    internal class ShowOptions
    {
        public static void ShowAvialableActions()
        {
            ConsoleKeyInfo keyInfo;
            List<Options> optionsCount = OptionsMenu.Optionss;
            int indexVkladki = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Choose your action:");
                for (int optionNumber = 0; optionNumber < optionsCount.Count; optionNumber++)
                {
                    if (optionNumber == indexVkladki)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        if (indexVkladki == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    }
                    

                    Console.WriteLine(optionsCount[optionNumber].Title);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow) { indexVkladki = (indexVkladki - 1 + optionsCount.Count()) % optionsCount.Count(); }
                if (keyInfo.Key == ConsoleKey.DownArrow) { indexVkladki = (indexVkladki + 1) % optionsCount.Count(); }
                
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    optionsCount[indexVkladki].OpenOperation();
                        if (keyInfo.Key == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            Console.WriteLine("Okay. Goodbye!");
                        }
                }
                else if (keyInfo.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.WriteLine("Okay. Goodbye!");
                }

            } while (keyInfo.Key != ConsoleKey.Escape);

        }
    }
}
