using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal static class TerroristGenerator
    {

        public static string GetRandomName() => TerroristsNames.GetRandomName();

        public static int GetRandomRank() => GetRandomNumber.Rand.Next(1, 6); // דרגה רנדומלית 1 - 5

        public static List<string> GetWeaponsList() => Weapons.GetWeapons();

        public static Terrorist GetTerrorist()
        {
            return new Terrorist(GetRandomName(), GetRandomRank(), GetWeaponsList());
        }
    }



}
