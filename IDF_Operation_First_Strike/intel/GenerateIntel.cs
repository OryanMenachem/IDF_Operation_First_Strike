using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    
    internal static class GenerateIntel 
    {

        public static Terrorist terrorist = Hamas.GetTerrorist();

        public static string Location = Locations.GetRandomLocation();

        public static DateTime TimeCollected = RandomDateTime.Next();

        
    }
}
