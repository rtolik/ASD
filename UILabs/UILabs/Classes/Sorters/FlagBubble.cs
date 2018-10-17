using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UILabs.Interfaces;

namespace UILabs.Classes.Sorters
{
    class FlagBubble<T>:AbstractPrinter<T>, ISortable<T>
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

            bool flag;
            T tmp;
            for (int j = 0; j < array.Length; j++)
            {
                flag =false;
                for (int i = 0; i < array.Length-1; i++)
                {
                    if (dir(array[i],array[i+1]))
                    {
                        tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                        flag = true;
                    }
                }

                if (enableOutput)
                    Print(array, textBox, ("Step " + (j + 1) +"flag: "+flag.ToString() + ":"));
                if (!flag)
                {
                    break;
                }

            }

            return array;
        }
        
        public bool ArrayCheck(T[] array, IComparableLab<T> comparator)
        {
            return true;
        }

        private delegate bool Direction(T left, T right);
    }
}
