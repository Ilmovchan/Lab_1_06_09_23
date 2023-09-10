using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessSimulator
{
    public class Process
    {
        public enum ProcessStatus { ready, running, waiting, terminated };

        Random random = new Random();
        int min = 1;
        int max = 2;

        public Process(long id, long addrSpace)
        {
            this.id = id;
            this.addrSpace = addrSpace;
            name = "test";
            status = ProcessStatus.ready;
        }

        public void IncreaseWorkTime()
        {
            if (workTime < burstTime) workTime++;
            else workTime = burstTime;

            if (status == ProcessStatus.running)
            {
                int randomInRange = random.Next(min, max + 1);
                if (randomInRange == 1) status = ProcessStatus.terminated;
                else status = ProcessStatus.waiting;
            }
            else if (status == ProcessStatus.waiting) status = ProcessStatus.ready;
        }

        public void ResetWorkTime()
        {
            workTime = 0;
        }

        public override string ToString()
        {
            string info = "id: " + id + "\n" + "name: " + name + "\n" + "burst time: " + burstTime + "\n" + "status: " + status + "\n" + "work time: " + workTime + "\n" +  "address space: " + addrSpace;
            return info;
        }

        private long id;
        private string name;
        private long burstTime;
        private ProcessStatus status;
        private long workTime;
        private long addrSpace;

        public long BurstTime 
        {
            get { return burstTime; }
            set { burstTime = value; }
        }

        public ProcessStatus Status
        {
            get { return status; }
            set { status = value; }
        }

        private long AddrSpace 
        {
            get { return addrSpace; }
            set { addrSpace = value; }
        }
    }
}
