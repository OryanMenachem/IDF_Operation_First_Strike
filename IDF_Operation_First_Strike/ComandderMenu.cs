using IDF_Operation_First_Strike.strikes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal class CommanderMenu
    {
        public static void Show()
        {
            Console.WriteLine("┌───────────────────────────────────────────────┐");
            Console.WriteLine("│            Strategic Control Menu             │");
            Console.WriteLine("├───────────────────────────────────────────────┤");
            Console.WriteLine("│ 1 - Get the terrorist with the most intel.    │");
            Console.WriteLine("│ 2 - Show strike units availability & capacity.│");
            Console.WriteLine("│ 3 - Get the most dangerous terrorist.         │");
            Console.WriteLine("│ 4 - Execute a strike.                         │");
            Console.WriteLine("└───────────────────────────────────────────────┘\n");
            Console.Write("Enter your choice: ");
        }

        public static void HandleChoice()
        {
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("");
                    break;

                case "2":
                    StrikeUnitsInfo.ShowAvailableUnitsInfo();
                    break;

                case "3":
                    Console.WriteLine("");
                    break;

            }
        }
    }
}
