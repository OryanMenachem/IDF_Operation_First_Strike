using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal class IDF
    {
        public string DateOfEstablish { get; private set; } = "26/05/1948";
        string CurrentCommander = "Eyal zamir";
        List<StrikeOption> strikeOptionsList = new List<StrikeOption>();

        public IDF() { }
        public void AddToStrikeList(StrikeOption option)
        {
            strikeOptionsList.Add(option);
        }
    }
}
