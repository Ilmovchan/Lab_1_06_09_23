using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessSimulator
{
    public class IdGenerator
    {
        public IdGenerator Clear()
        {
            if (this != null)
            {
                id = 0;
            }
            return this;
        }

        private long id;

        public long Id
        {
            get
            {
                return id == long.MaxValue ? 0 : ++id;
            }
        }

    }
}
