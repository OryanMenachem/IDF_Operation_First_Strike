using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal static class AmanTerroristsReports
    {
        public static Dictionary<DateTime, Dictionary<Terrorist, string>> TerroristsReports;                                                                               

        public static void AddToTerroristsReports(DateTime creationDate , Terrorist terrorist, string lastLocation)
        {
            TerroristsReports[creationDate] = new Dictionary<Terrorist, string>();
            TerroristsReports[creationDate].Add(terrorist, lastLocation);
        }
    }
}
