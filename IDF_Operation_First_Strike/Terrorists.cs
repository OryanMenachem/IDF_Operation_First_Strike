using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal class Terrorist
    {
        public string Name { get; } 
        public int Rank { get; }
        public bool IsALive { get; set; } = true;

        public List<string> Weapons = new List<string>();

        public  Terrorist(string name, int rank, List<string> weapons)
        {
            Name = name;
            Rank = rank;
            Weapons = weapons;
        }

        

    }
}
