using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

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

        [Pure]
        public bool IsFree()
        {
            return activeProcess == null;
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
