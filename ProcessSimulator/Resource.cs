using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessSimulator
{
    public class Resource
    {

        public void WorkingCycle()
        {
            if (!IsFree())
            {
                activeProcess.IncreaseWorkTime();
            }
        }

        public bool IsFree()
        {
            return activeProcess == null ? true : false;
        }

        public void Clear()
        {
            ActiveProcess = null;
        }

        private Process activeProcess;
        public Process ActiveProcess
        {
            get { return activeProcess; }
            set { activeProcess = value; }
        }
    }
}
