using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UILabs.Interfaces;

namespace UILabs.Classes.Sorters
{
    class MergeSort<T> : AbstractPrinter<T>, ISortable<T>
    {
        private int step = 1;

        public bool ArrayCheck(T[] array, IComparableLab<T> comparator)
        {
            FindMax(array, comparator, out int ind);
            if (ind<array.Length-1)
            {
                return true;
            }

            return false;
        }

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

            FindMax(array, comparator, out int ind);
            T[] tmp= new T[array.Length-ind];
            for (int i = ind; i < array.Length; i++)
            {
                tmp[i - ind] = array[i];
            }

            return RecMerge(tmp, dir, textBox,enableOutput); //TODO: Change here before 7 Lab return RecMerge(array, dir, textBox)
        }

        private T[] RecMerge(T[] array, Direction dir,RichTextBox textBox,bool enableOutput)
        {
            if (array.Length == 1)
                return array;
            int middle = array.Length / 2;
            return Merge(
                RecMerge(array.Take(middle).ToArray(),dir,textBox,enableOutput),
                RecMerge(array.Skip(middle).ToArray(),dir,textBox,enableOutput),
                dir,textBox,enableOutput);
        }

        private T[] Merge(T[] left, T[] right,Direction dir,RichTextBox textBox,bool enableOutput)
        {   
            int leftInd = 0, rightInd = 0;
            T[] result = new T[left.Length+right.Length];
            for (int i = 0; i < left.Length + right.Length; i++)
            {
                if (leftInd<left.Length && rightInd<right.Length)
                {
                    if (dir(left[leftInd],right[rightInd]))
                    {
                        result[i] = right[rightInd];
                        rightInd++;
                    }
                    else
                    {
                        result[i] = left[leftInd];
                        leftInd++;
                    }
                }
                else
                {
                    if (leftInd<left.Length)
                    {
                        result[i] = left[leftInd];
                        leftInd++;
                    }
                    else
                    {
                        result[i] = right[rightInd];
                        rightInd++;
                    }
                }
            }

            if (enableOutput)
                Print(result,textBox,("Step: "+ step+"= "));
            step++;
            return result;
        }

        private T FindMax(T[] array, IComparableLab<T> comparator, out int ind)
        {
            T max = array[0];
            ind = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (comparator.Less(max,array[i]))
                {
                    max = array[i];
                    ind = i;
                }   
            }

            return max;
        }

        private delegate bool Direction(T left, T right);
    }
}
