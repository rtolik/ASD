using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UILabs.Classes.Utils;
using UILabs.Interfaces;

namespace UILabs.Classes.Sorters
{
    class ShellSort<T>:AbstractPrinter<T>,ISortable<T>
    {
        public bool ArrayCheck(T[] array, IComparableLab<T> comparator)
        {
            return true;
        }

        public T[] Sort(T[] array, RichTextBox textBox, IComparableLab<T> comparator, bool direction, bool enableOutput)
        {
           
            Direction dir;

            if (direction)
                dir = comparator.More;           
            else
                dir = comparator.Less;

            int step = array.Length / 2;
            int stepInfo = 1;
            while (step > 0)
            {
                for (int i = step; i < array.Length; i++)
                {
                    for (int j = i - step; j >= 0 && dir(array[j], array[j + step]); j -= step)
                    {
                        T tmp = array[j];
                        array[j] = array[j+step];
                        array[j + step] = tmp;
                    }
                }
                if (enableOutput)
                    Print(array, textBox, ("Step: " + stepInfo + "= "));
                stepInfo++;
                step /= 2;
            }

            return array;
        }

        private delegate bool Direction(T left, T right);
    }
}