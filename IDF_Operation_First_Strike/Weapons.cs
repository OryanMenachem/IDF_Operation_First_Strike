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
        
        
        public static List<string> GetWeapons()  // Returns a list of weapons according to the index of the weapons list, for example 0 will bring a knife, and 2 will bring a knife and a gun
        {
            for (int i = 0; i < GetRandomNumber.Rand.Next(0,weapons.Length); i++)
            { 
               weaponsList.Add(weapons[i]);
            }
            
            return weaponsList;
        }
    }
}
