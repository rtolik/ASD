using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UILabs.Interfaces;

namespace UILabs.Classes.Sorters
{
    class QuickSort<T> : AbstractPrinter<T>, ISortable<T>
    {

        public QuickSort()
        {
        }

        private int _step = 0;

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
            RecursiveSort(ref array, 0, array.Length-1, comparator, textBox,dir,enableOutput);
            return array;
        }


        private void RecursiveSort(ref T[] array, int start, int end, IComparableLab<T> comparator,RichTextBox textBox,Direction direction,bool enableOutput)
        { 
            if (start == end||start<0) 
            {
                return;
            }

            if (start<end)
            {
                T pivot = array[end];
                T tmp;
                int currentInd=start;
                for (int i = start; i <end ; i++)
                {
                    if (direction(array[i],pivot))  
                    {
                        tmp = array[currentInd];
                        array[currentInd] = array[i];
                        array[i] = tmp;
                        currentInd++;
                    }   

                }
                _step++;
                if (enableOutput)
                {
                    string info = "Step: " + _step + "=";
                    Print(array, textBox, info);
                }

                tmp = array[end];
                array[end] = array[currentInd];
                array[currentInd] = tmp;
                if (currentInd-1>start)
                {
                    RecursiveSort(ref array,start,currentInd-1,comparator,textBox,direction,enableOutput);

                }

                if (currentInd!=end && currentInd<end)
                {
                    RecursiveSort(ref array, currentInd+1, end, comparator, textBox,direction,enableOutput);
                }
            }
        }

        public delegate bool Direction(T left, T right);
    }
}