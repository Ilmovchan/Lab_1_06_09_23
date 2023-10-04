using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessSimulator
{
    public class Memory
    {

        public void Save(long size)
        {
            FreeSize = size;
            OccupiedSize = 0;
            return this;
        }

        public void Clear()
        {
            FreeSize += OccupiedSize;
            occupiedSize = 0;
            return this;
        }

        private long occupiedSize;
        private long freeSize;

        public long OccupiedSize
        {
            get { return occupiedSize; }
            set { occupiedSize = value; }
        }

        public long FreeSize
        {
            get { return freeSize; }
            set { freeSize = value; }
        }

    }
}
