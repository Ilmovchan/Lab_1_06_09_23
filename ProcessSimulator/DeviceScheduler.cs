using System;
namespace ProcessSimulator
{
	public class DeviceScheduler
	{
		public DeviceScheduler(Resource resource, Queue<Process, long> queue)
		{
            this.resource = resource;
            this.queue = queue;
        }

        public Queue<Process, long> Session()
        {
            resource.ActiveProcess = queue.Dequeue();
            resource.ActiveProcess = ProcessStatus.terminated;
            return queue;
        }

        private Resource resource;
        Queue<Process, long> queue;
    }
}

