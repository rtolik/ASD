using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UILabs.Interfaces;

namespace UILabs.Classes.Sorters
{
    class SimpleSelection<T>:AbstractPrinter<T>, ISortable<T>
    {
        public bool ArrayCheck(int[] array, IComparableLab<int> comparator)
        {
            int negCount = 0;
            foreach (int el in array)
            {
                if (el<0)
                    negCount++;
            }

            if (negCount>=2)
            {
                return true;
            }

            return false;
        }

        public bool ArrayCheck(T[] array, IComparableLab<T> comparator)
        {
            return true;
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

            FindNeg(array,out int first,out int last,comparator);
            for (int i = first; i < last; i++)
            {
                int foundValId = FindElByDir(array, i, dir);
                if (foundValId != i)
                {
                    T tmp = array[i];
                    array[i] = array[foundValId];
                    array[foundValId] = tmp;
                }
                if (enableOutput)
                    Print(array,textBox,("Step "+(i+1)+":"));
            }


            return array;
        }


        public void Print(double[] array, RichTextBox textBox, string info)
        {
            string resultStr = info + " ";
            foreach (double el in array)
            {
                resultStr += el + " ";
            }

            textBox.Text = textBox.Text + resultStr + "\n";
        }

        private T[] PreAction(T[] array,IComparableLab<T> comparable )
        {
            FindNeg(array,out int first,out int last, comparable);
            T[] result = new T[last - first];
            int iterator =0;
            for (int i = first; i < last; i++)
            {
                result[iterator] = array[i];
                iterator++;
            }

            return result;
        }

        private T[] AfterAction(T[] old, T[] sortedPart,IComparableLab<T> comparable)
        {
            FindNeg(old, out  int first,out int last,comparable);
            int iterator = 0;
            for (int i = first; i < last; i++)
            {
                old[i] = sortedPart[iterator];
                iterator++;
            }

            return old;
        }

        private void FindNeg(T[] array, out int first, out int last, IComparableLab<T> comparable)
        {
            first = 0;
            last = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (comparable.Less(array[i],0))
                {
                    if (first == -1)
                    {
                        first = i;
                    }

                    last = i;
                }
            }
        
        }

        private int FindElByDir(T[] array, int startInd,Direction direction)  
        {
            T val = array[startInd];
            int id=startInd;
            for (int i = startInd+1; i < array.Length; i++)
            {
                if (direction(val,array[i]))
                {
                    val = array[i];
                    id = i;
                }
            }

            return id;
        }

        private delegate bool Direction(T left, T right);
    }
}
