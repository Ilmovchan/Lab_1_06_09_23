using System;
namespace ProcessSimulator
{
    class MemoryManager
    {
        private Memory memory;

        public void Save(Memory memory)
        {
            this.memory = memory;
        }

        public Memory Allocate(Process process)
        {
            if (memory.FreeSize >= process.AddrSpace)
            {
                memory.OccupiedSize += process.AddrSpace;
                return memory;
            }
            else
            {
                return null;
            }
        }

        public Memory Free(Process process)
        {
            memory.OccupiedSize -= process.AddrSpace;
            return memory;
        }
    }
}

