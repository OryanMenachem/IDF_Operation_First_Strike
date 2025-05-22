using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal static class Locations
    {
        public static string[] LocationList = { "at home", "in a car", "at a meeting", "outside" };

        public static string GetRandomLocation()
        {
            Random rand = new Random();
            return LocationList[rand.Next(LocationList.Length)];
        }
    }
}
