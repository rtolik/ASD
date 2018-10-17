using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UILabs.Interfaces
{
    internal interface IComparableLab<T>
    {
        bool More(T left, T right);

        bool More(T left, int right);

        bool Less (T left, T right);

        bool Less(T left, int right);

        bool Equal(T left, T right);

        bool MoreEqual(T left, T right);

        bool LessEqual(T left, T right);

    }
}
