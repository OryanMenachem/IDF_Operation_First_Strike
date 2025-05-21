using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal class Terrorist
    {
        string Name { get; }
        int Rank { get; }
        bool IsALive { get; set; } = true;

        List<string> Weapons = new List<string>();

        public Terrorist(string name, int rank, List<string> weapons)
        {
            name = name.ToLower();
            Rank = rank;
            Weapons = weapons;
        }

        

    }
}
