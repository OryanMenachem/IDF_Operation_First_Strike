using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal class PreferredTarget
    {

        
        static Dictionary<Terrorist, int> preferredTarget;

        static Terrorist terrorist;

        static int points = 0;


        public static Dictionary<Terrorist, int> GetpreferredTarget()
        {
            foreach (var member in TerroristsPoints.terroristsPoints)
            {
                if (member.Value > points)
                {
                    points = member.Value;
                    terrorist = member.Key;
                }
            }

            preferredTarget.Add(terrorist, points);

            return preferredTarget;
        }       
    }


    
    
}
