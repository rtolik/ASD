using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UILabs.Classes
{
    abstract class AbstractPrinter<T>
    {
        public void Print(T[] array, RichTextBox textBox, string info)
        {
            string resultStr = info + " ";
            foreach (T el in array)
            {
                resultStr += el + " ";
            }

            List<string> lines = textBox.Lines.ToList();
            lines.Add(resultStr + "\n");
            textBox.Lines = lines.ToArray();
        }

    }
}
