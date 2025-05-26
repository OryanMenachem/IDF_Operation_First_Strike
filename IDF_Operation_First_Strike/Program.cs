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
            Terrorist terrorist = TerroristGenerator.GetTerrorist();
            Hamas.AddTerrorostToHamas(terrorist);

            IDF.strikeOptionsList.Add(new F16());
            IDF.strikeOptionsList.Add(new Hermes460());
            IDF.strikeOptionsList.Add(new M109());

            Aman.CreateAReport();

            CommanderMenu.Show();
            

        }
    }
}
