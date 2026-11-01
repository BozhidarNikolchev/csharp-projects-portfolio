using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public class DateCalculator
    {
        public static int GetDaysBetween(DateTime firstDate, DateTime secondDate)
        {
            return Math.Abs((firstDate - secondDate).Days);
        }
    }
}
