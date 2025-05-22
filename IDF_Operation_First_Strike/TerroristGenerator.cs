using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal static class TerroristGenerator
    {
      public static  string Name = TerroristsNames.GetRandomName();

      public static int  Rank = GetRandomNumber.Rand.Next(1,6);

      public static List<string> WeaponsList = Weapons.GetWeapons();
    }


}
