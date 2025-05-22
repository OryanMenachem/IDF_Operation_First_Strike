using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                Hamas.AddTerrorostToHamas(new Terrorist(TerroristGenerator.GetRandomName(), TerroristGenerator.GetRandomRank(), TerroristGenerator.GetWeaponsList()));
            }
                foreach (var item in Hamas.TerroristsList)
                {
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.Rank);
                    foreach (var weapon in item.Weapons)
                    {
                        Console.WriteLine(weapon);
                    }
                }
            
        }
    }
}
