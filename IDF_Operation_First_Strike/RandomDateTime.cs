using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal class RandomDateTime
    {
        DateTime Start;
        Random Gen;
        int Range;

        public  RandomDateTime()
        {
            Start = new DateTime(1995, 1, 1);
            Gen = new Random();
            Range = (DateTime.Today - Start).Days;
        }

        public  DateTime Next()
        {
            return Start.AddDays(Gen.Next(Range)).AddHours(Gen.Next(0, 24)).AddMinutes(Gen.Next(0, 60)).AddSeconds(Gen.Next(0, 60));
        }
    }
}
