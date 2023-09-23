using System;
namespace ProcessSimulator
{
	public class MemoryManager
	{

		public void Save(long size)
		{
			this.memory = size;
		}

		public Memory Allocate(Process process)
		{
			try
			{
				memory += process.AddrSpace;
			}
			catch
			{
				return null;
			}
		}

		public Memory Free(Process process)
		{
			memory -= process.AddrSpace;
		}

		private Memory memory;
	}
}

