using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{

    internal class StrikeExecution
    {
        static string OperatorName = "officer Benjy and officer oryan";

        // Based on the terrorist's location and type, choose an appropriate strike unit

        public StrikeOption GetRelevantStrikeUnit(string lastLocation)
        {
            StrikeOption strikeOption = null;

            switch (lastLocation)
            {
                case "at home":
                    strikeOption = new F16();
                    break;
                case "in a car":
                    strikeOption = new Hermes460();
                    break;
                case "outside":
                    strikeOption = new M109();
                    break;
                default:
                    Console.WriteLine("ERROR! no location given, Strike option is null.");
                    break;
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
                              $"last seen {Locations.GetTerroristLocation(terrorist)} \n" +
                              $"using {strikeOption.Name} strike unit, \n" +
                              $"which has {strikeOption.RemainingBombs} strikes left. \n" +
                              $"operators: {OperatorName}.");
        }
    }
}
