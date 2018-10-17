using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UILabs.Interfaces
{
    interface ISortable<T>
    {

        bool ArrayCheck(T[] array,IComparableLab<T> comparator);

        T[] Sort(T[] array, RichTextBox textBox, IComparableLab<T> comparator, bool direction,bool enableOutput);/// direction is true than sort is growing up

        void Print(T[] array, RichTextBox textBox,string info);
    
    }
}
