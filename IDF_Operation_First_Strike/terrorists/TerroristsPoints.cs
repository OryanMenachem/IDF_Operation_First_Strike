using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal class TerroristsPoints
    {

        public static Dictionary<Terrorist,int> terroristsPoints = new Dictionary<Terrorist,int>();

        public static void GetTerroristsPoints(List<Terrorist> terroristsList)
        {
            foreach (Terrorist terrorist in terroristsList)
            {
                terroristsPoints.Add(terrorist, terrorist.Rank * WeaponsPoints.GetWeaponsPoints(terrorist));
            }
        }


    }
}
