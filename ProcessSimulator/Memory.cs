using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessSimulator
{
    class Memory
    {
        public Memory Save(long size)
        {
            FreeSize = size;
            OccupiedSize = 0;
            return this;
        }
        public Memory Clear()
        {
            FreeSize += OccupiedSize;
            OccupiedSize = 0;
            return this;
        }
        public long FreeSize
        {
            get { return freeSize; }
            set { freeSize = value; }
        }
        public long OccupiedSize
        {
            get { return occupiedSize; }
            set { occupiedSize = value; }
        }

        private long freeSize;
        private long occupiedSize;
    }
}
