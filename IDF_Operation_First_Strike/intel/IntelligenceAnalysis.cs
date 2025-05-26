using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal class IntelligenceAnalysis
    {
        //Terrorist MostCommonTerrorist = 

        //AvailableWeaponsAndCapacity =




        public void CreateAReport()
        {
            Terrorist = GenerateIntel.terrorist;
            LastLocation = GenerateIntel.Location;
            TimeCollected = GenerateIntel.TimeCollected;

            AmanTerroristsReports.AddToTerroristsReports(TimeCollected, Terrorist, LastLocation);
        }

    }
}
