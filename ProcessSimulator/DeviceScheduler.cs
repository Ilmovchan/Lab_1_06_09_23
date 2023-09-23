using System;
namespace ProcessSimulator
{
	public class DeviceScheduler
	{
		public DeviceScheduler(Resource resource, PriorityQueue<Process, long> queue)
		{
            this.resource = resource;
            this.queue = queue;
        }

        public PriorityQueue<Process, long> Session()
        {
            resource.ActiveProcess = queue.Peek;

        }

        private Resource resource;
        PriorityQueue<Process, long> queue;
    }
}

