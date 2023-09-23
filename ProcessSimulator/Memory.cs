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
        }

        public void Clear()
        {
            occupiedSize = 0;
        }

        private long occupiedSize;

        public long Size
        {
            get;
            private set;
        }

        public long OccupiedSize
        {
            get;
            set;
        }

        public long FreeSize
        {
            get {return Size - occupiedSize; }
            private set;
        }

    }
}
