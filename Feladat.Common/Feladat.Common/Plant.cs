using System;
using System.Collections.Generic;
using System.Text;

namespace Feladat.Common
{
    public class Plant
    {
        private int size;

        public int Size
        {
            get { return size; }
            internal set
            {
                if (value > 0)
                    value = size;
            }

        }
        private int maxsize;

        public int maxSize
        {
            get { return maxsize; }
            internal set
            {
                if (value > 0)
                    value = maxsize;
            }

        }
        public void Growing()
        {
            if (size > 0 && size < maxsize)
                size++;
        }
    }
}
