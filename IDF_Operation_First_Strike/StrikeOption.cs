using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal interface IStrikeOption
    {
        string Name { get; }
        int RemainingStrikes { get; set; }
        int FuelSupply { get; }
        string TargetType { get; }
    }
}
