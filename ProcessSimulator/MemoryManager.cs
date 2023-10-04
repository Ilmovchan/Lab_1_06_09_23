using System;
namespace ProcessSimulator
{
	public class MemoryManager
	{

		public void Save(Memory memory)
		{
			this.memory = memory;
		}

		public Memory Allocate(Process process)
		{
			if (memory != null)
			{
                memory += process.AddrSpace;
            }

			else return null;
		}

		public Memory Free(Process process)
		{
			memory -= process.AddrSpace;
		}

		private Memory memory;
	}
}

