using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal static class TerroristGenerator
    {
        private static readonly Random random = new Random();  // Reuse one Random instance

        public static string GetRandomName() => TerroristsNames.GetRandomName();

        public static int GetRandomRank() => random.Next(1, 6);  // Always 1 to 5 inclusive

        public static List<string> GetWeaponsList() => Weapons.GetWeapons();
    }



}
