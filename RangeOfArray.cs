using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_collections
{
    public class RangeOfArray
    {
        private int[] array;
        private int startIndex;
        private int endIndex;

        public RangeOfArray(int[] array, int startIndex, int endIndex)
        {
            this.array = array;
            this.startIndex = startIndex;
            this.endIndex = endIndex;
        }

        public int this[int index]
        {
            get { return array[index + startIndex]; }
            set { array[index + startIndex] = value; }
        }

        public int Length
        {
            get { return endIndex - startIndex + 1; }
        }
    }
}
