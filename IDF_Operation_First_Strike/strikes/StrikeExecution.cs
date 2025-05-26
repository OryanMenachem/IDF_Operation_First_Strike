using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    // Based on the terrorist's location and type, choose an appropriate strike unit

    internal class StrikeExecution
    {
        static string OperatorName = "turaiy Benjy and turaiy oryan";
        public StrikeOption GetRelevantStrikeUnit(string lastLocation)
        {
            // deffult strike is F16
            StrikeOption strikeOption = new F16();
            if (string.IsNullOrEmpty(lastLocation))
            { Console.WriteLine("no location givin "); }

            else if (lastLocation == "at home")
            {
                strikeOption = new F16();
            }
            else if (lastLocation == "in a car")
            {
                strikeOption = new Hermes460();
            }
            else if (lastLocation == "outside")
            {
                strikeOption = new M109();
            }

            return strikeOption;
        }

        public void Attack(Terrorist terrorist, StrikeOption strikeOption)
        {
            if (!terrorist.IsALive)
            {
                Console.WriteLine($"oops, the terrorist {terrorist.Name} is already dead.");
            }
            else
            {
                Console.WriteLine("Attack commited succefully! \n");
                terrorist.IsALive = false;
                strikeOption.RemainingBombs -= 1;
                ShowAttackInfo(terrorist, strikeOption);
            }
        }

        public void ShowAttackInfo(Terrorist terrorist, StrikeOption strikeOption)
        {
            Console.WriteLine($"Attack commited at {DateTime.Now}, \n" +
                              $"on the terrorist {terrorist.Name}, \n" +
                              $"last seen {Locations.GetTerroristLocation(terrorist)}" +
                              $"using {strikeOption.Name} strike unit, \n" +
                              $"which has {strikeOption.RemainingBombs} strikes left. \n" +
                              $"operators: {OperatorName}.");
        }
    }
}
