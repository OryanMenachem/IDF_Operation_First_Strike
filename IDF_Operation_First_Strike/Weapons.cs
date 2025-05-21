using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal static class Weapons
    {
        public static string[] weapons = { "knife" , "gun", "AK47", "M16" };

        public static List<string> weaponsList = new List<string>();
        public static List<string> GetWeapons()
        {
            for (int i = 0; i < GetRandomNumber.Rand.Next(weapons.Length); i++)
            { 
               weaponsList.Add(weapons[i]);
            }
            
            return weaponsList;
        }
    }
}
