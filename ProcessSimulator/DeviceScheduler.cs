using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessSimulator
{
    class DeviceScheduler
    {
        private Resource resource;
        private Queue<Process> queue;

        public DeviceScheduler(Resource resource, Queue<Process> queue)
        {
            this.resource = resource;
            this.queue = queue;
        }
        public Queue<Process> Session()
        {
            resource.ActiveProcess = queue.Dequeue();
            return queue;
        }
    }
}
