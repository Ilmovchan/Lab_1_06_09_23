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
            string info = "";

            info += $"ID: {id}\n";
            info += $"NAME: {name}\n";
            info += $"BURST TIME: {BurstTime}\n";
            info += $"STATUS: {Status}\n";
            info += $"WORK TIME: {workTime}\n";
            info += $"ADDRESS SPACE: {AddrSpace}\n";

            return info;
        }

        public int CompareTo(Process other)
        {
            if (other == null) return 1;

            return other.BurstTime.CompareTo(this.BurstTime);
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
