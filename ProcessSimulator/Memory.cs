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
            Size = size;
            occupiedSize = 0;
            FreeSize = Size - OccupiedSize;
        }

        public void Clear()
        {
            occupiedSize = 0;
            FreeSize = Size;
        }

        private long occupiedSize;

        public long Size
        {
            get;
            private set;
        }

        public long OccupiedSize
        {
            get { return occupiedSize; }
            set { occupiedSize = value; }
        }

        public long FreeSize
        {
            get;
            private set;
        }

    }
}
