using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal class TerroristsPoints
    {


        public static Dictionary<Terrorist, int> GetTerroristsPoints(List<Terrorist> terroristsList)
        {

            Dictionary<Terrorist, int> terroristsPoints = new Dictionary<Terrorist, int>();

            foreach (Terrorist terrorist in terroristsList)
            {
                terroristsPoints.Add(terrorist, terrorist.Rank * WeaponsPoints.GetWeaponsPoints(terrorist));
            }
            return terroristsPoints;
        }


    }
}
