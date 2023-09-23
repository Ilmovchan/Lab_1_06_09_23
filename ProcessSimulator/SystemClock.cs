using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessSimulator
{
    public class SystemClock
    {

        public void Clear()
        {
            Clock = 0;
        }

        public void WorkingCycle()
        {
            Clock++;
        }


        private long clock;
        public long Clock
        {
            get { return clock; }
            private set { clock = value; }
        }   
    }
}
