using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessSimulator
{
    public enum ProcessStatus { ready, running, waiting, terminated }

    public class Process
    {

        public Process(long pId, long addrSpace)
        {
            id = pId;
            name = "P" + pId.ToString();
            Status = ProcessStatus.ready;
            AddrSpace = addrSpace;
        }

        public void IncreaseWorkTime()
        {
            if (workTime == BurstTime)
            {
                if (Status == ProcessStatus.running)
                {
                    Status = procRand.Next(0, 2) == 0 ? ProcessStatus.terminated : ProcessStatus.waiting;
                }
                else
                {
                    Status = ProcessStatus.ready;
                }
            }
            else
            {
                workTime++;
            }
        }

        public void ResetWorkTime()
        {
            workTime = 0;
        }
        
        public override string ToString()
        {
            return "id: " + id + "\n" + "name: " + name + "\n" + "burst time: " + BurstTime + "\n" + "status: " + Status + "\n" + "work time: " + workTime + "\n" + "address space: " + AddrSpace;
        }

        Random procRand = new Random();

        private long id;
        private string name;
        private long workTime;

        public long BurstTime 
        {
            get;
            set;
        }

        public ProcessStatus Status
        {
            get;
            set;
        }

        public long AddrSpace 
        {
            get;
            private set;
        }
    }
}
