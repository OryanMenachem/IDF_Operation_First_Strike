using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal static class TerroristGenerator
    {
        private static readonly Random random = new Random();  

        public static string GetRandomName() => TerroristsNames.GetRandomName();

        public static int GetRandomRank() => random.Next(1, 6); 

        public static List<string> GetWeaponsList() => Weapons.GetWeapons();

        public static Terrorist GetTerrorist()
        {
            return new Terrorist(GetRandomName(), GetRandomRank(), GetWeaponsList());
        }
    }



}
