using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal static class AmanTerroristsReports
    {
        public static Dictionary<DateTime, Dictionary<Terrorist, string>> TerroristsReports = new Dictionary<DateTime, Dictionary<Terrorist, string>>();                                                                               
        public static Dictionary<Terrorist, string> RawTerroristsReports = new Dictionary<Terrorist, string>();

        public static void AddToTerroristsReports(DateTime creationDate , Terrorist terrorist, string lastLocation)
        {
            TerroristsReports[creationDate] = new Dictionary<Terrorist, string>();
            TerroristsReports[creationDate].Add(terrorist, lastLocation);

            RawTerroristsReports.Add(terrorist , lastLocation);
        }
    }
}
