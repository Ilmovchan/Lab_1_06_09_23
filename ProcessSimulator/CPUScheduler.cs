using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessSimulator
{
    public class CPUScheduler
    {

        public CPUScheduler(Resource resource, Queue<Process, long> queue)
        {
            this.resource = resource;
            this.queue = queue;
        }

        public Queue<Process, long> Session()
        {
            resource.ActiveProcess = queue.Dequeue();
            resource.ActiveProcess = ProcessStatus.running;
            return queue;

        }

        private Resource resource;
        private PriorityQueue<Process, long> queue;
    }
}
