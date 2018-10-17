using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UILabs.Interfaces;

namespace UILabs.Classes.Sorters
{
    class BubbleSorter<T> : AbstractPrinter<T>, ISortable<T>
    {
        
        public T[] Sort(T[] array, RichTextBox textBox, IComparableLab<T> comparator, bool direction, bool enableOutput)
        {
            Direction dir;

            if (direction)
            {
                dir = comparator.More;
            }
            else
            {
                dir = comparator.Less;
            }

            for (int j = 0; j < array.Length; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (dir(array[i], array[i + 1]))
                    {
                        T tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                    }
                }

                if (enableOutput)
                    Print(array, textBox, ("Step " + (j + 1) + ":") );
            }

            return array;
        }
        
        public bool ArrayCheck(T[] array,IComparableLab<T> comparator)
        {
            return true;
        }

        private delegate bool Direction(T left, T right);
    }
}
