using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal class TerroristsPoints
    {
        public static Dictionary<Terrorist, int> terroristsPoints = new Dictionary<Terrorist, int>();


        public static void AddToTerroristsPoints(Dictionary<Terrorist, string> RawterroristsList)
        {


            foreach (var kvp in RawterroristsList)
            {
                terroristsPoints.Add(kvp.Key, kvp.Key.Rank * WeaponsPoints.GetWeaponsPoints(kvp.Key));
            }
        }


    }
}
