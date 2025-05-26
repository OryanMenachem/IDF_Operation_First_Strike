using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal static class Locations
    {
        public static string[] LocationList = { "at home", "in a car", "outside" };

        static int RandomNum = GetRandomNumber.Rand.Next(LocationList.Length);
        public static string GetRandomLocation()
        {
            return LocationList[RandomNum];
        }

        public static string GetTerroristLocation(Terrorist terrorist)
        {
            foreach (var date in AmanTerroristsReports.TerroristsReports)
            {
                if (date.Value.ContainsKey(terrorist))
                {
                    return date.Value[terrorist];
                }
            }
            Console.WriteLine("no location found connected to this terrorist.");
            return null;
        }
    }
}
