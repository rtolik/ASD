using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UILabs.Classes.Utils;
using UILabs.Interfaces;

namespace UILabs.Classes.Comparators
{
    class CustomDoubleArrayComparator:IComparableLab<CustomDoubleArray>
    {
        public bool Equal(CustomDoubleArray left, CustomDoubleArray right)
        {
            return left.ArrEl.Equals(right.ArrEl);
        }

        public bool Less(CustomDoubleArray left, CustomDoubleArray right)
        {
            return left.ArrEl < right.ArrEl;
        }

        public bool Less(CustomDoubleArray left, int right)
        {
            return left.ArrEl < right;
        }

        public bool LessEqual(CustomDoubleArray left, CustomDoubleArray right)
        {
            return left.ArrEl <= right.ArrEl;
        }

        public bool More(CustomDoubleArray left, CustomDoubleArray right)
        {
            return left.ArrEl > right.ArrEl;
        }

        public bool More(CustomDoubleArray left, int right)
        {
            return left.ArrEl > right;
        }

        public bool MoreEqual(CustomDoubleArray left, CustomDoubleArray right)
        {
            return left.ArrEl >= right.ArrEl;
        }
    }
}
