using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessSimulator
{
    public class Resource
    {
        public void WorkingCycle()
        {

        }


        private Process activeProcess;

        public Process ActiveProcess
        {
            get { return activeProcess; }
            set { activeProcess = value; }
        }
    }
}
