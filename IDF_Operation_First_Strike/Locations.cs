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
    }
}
