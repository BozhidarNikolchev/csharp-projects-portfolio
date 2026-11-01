using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public class Date
    {
        private DateTime firstDate;
        private DateTime secondDate;

        public DateTime FirstDate
        {
            get { return firstDate; }
            set { firstDate = value; }
        }

        public DateTime SecondDate
        {
            get { return secondDate; }
            set { secondDate = value; }
        }
    }
}
