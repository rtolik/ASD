using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UILabs.Classes.Comparators;
using UILabs.Interfaces;

namespace UILabs.Classes.Sorters
{
    class CountSort<T> : AbstractPrinter<T>, ISortable<T>
    {
        public bool ArrayCheck(T[] array, IComparableLab<T> comparator)
        {
            return true;
        }

        public T[] Sort(T[] array, RichTextBox textBox, IComparableLab<T> comparator, bool direction, bool enableOutput)
        {
            Dictionary<T, int> count= new Dictionary<T, int>();

            foreach (T el in array)
            {
                if (count.ContainsKey(el))
                    count[el]++;
                else
                    count.Add(el,0);
            }

            count = direction ? count.OrderBy((x) => x.Key).ToDictionary((x)=>x.Key,x=>x.Value) : count.OrderByDescending((x) => x.Key).ToDictionary((x)=>x.Key,x=>x.Value);

            
            int[] tmp = count.Values.ToArray();

            for (int j = 0; j < tmp.Length; j++)
                tmp[j]++;
            if (enableOutput)
            {
                Print(count.Keys.ToArray(), textBox, "Дані: ");
                AbstractPrinter<int> printer = new CountSort<int>();
                printer.Print(tmp, textBox, "Зустрічаються (разів): ");
            }

            int i = 0;
            foreach (KeyValuePair<T, int> el in count)
            {
                for (int j = 0; j <= count[el.Key]; j++)
                {
                    array[i] = el.Key;
                    i++;
                }
            }

            return array;
        }

        public void CurrentPrint(T[] array, RichTextBox textBox, string info, int [] elements)
        {
            string indStr = info + "\n";

            string resultStr ="";
            for(int i=0; i<array.Length;i++)
            {
                indStr += elements[i] + "\t";
                resultStr += array[i] + "\t";
            }

            List<string> lines = textBox.Lines.ToList();
            lines.Add(indStr);
            lines.Add(resultStr + "\n");
            textBox.Lines = lines.ToArray();
        }
    }
}
