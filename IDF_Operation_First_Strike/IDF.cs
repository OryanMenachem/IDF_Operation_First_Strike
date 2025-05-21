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
        List<IStrikeOption> strikeOptionsList = new List<IStrikeOption>();

        public IDF() { }
        public void AddToStrikeList(IStrikeOption option)
        {
            strikeOptionsList.Add(option);
        }
    }
}
