using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UILabs.Classes.Utils;

namespace UILabs
{
    public partial class Lab4Input : Form
    {
        private Form1 _form;

        private int _rowCount,_cellCount;

        private CustomDoubleArray[] array;

        public Lab4Input(Form1 form1)
        {
            InitializeComponent();
            _form = form1;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            array=new CustomDoubleArray[_rowCount];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new CustomDoubleArray();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < array.Length; i++)
                array[i].Arr= new double[_cellCount];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _rowCount= ValidateTextBox(textBox1, true);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _cellCount= ValidateTextBox(textBox2, true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (_rowCount<=0)
            {
                _rowCount = rand.Next(1, 10);
                array = new CustomDoubleArray[_rowCount];
            }

            if (_cellCount<=0)
            {
                _cellCount = rand.Next(1, 10);
                for (int i = 0; i < array.Length; i++)
                {
                    array[i]= new CustomDoubleArray();
                    array[i].Arr = new double[_cellCount];
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Arr.Length; j++)
                {
                    array[i].Arr[j] = (double)rand.Next(-4000, 4000) / 100;
                }
            }
            Print(array, Array2Holder,"");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].MaxArrEl > 0)
                {
                    array[i].MaxArrEl = Math.Round(Math.Pow(array[i].MaxArrEl, ((1 + 0.0) / 3)) * 100) / 100;
                }
            }

            _form.CustomDoubleArray = array;
            _form.PrintCustomDoubleArray();
            Print(array, richTextBox1,"");
        }

        public void Print(CustomDoubleArray[] array, RichTextBox textBox, string info)
        {
            string resultStr = info + " ";
            foreach (CustomDoubleArray el in array)
            {
                resultStr += el + " ";
            }

            textBox.Text = resultStr;
        }

        private int ValidateTextBox(TextBox textBox, bool isSize)
        {
            if ((!int.TryParse(textBox.Text, out int res) || isSize) && res == 0)
            {
                textBox.Text = "";
                res = 1;
            }

            return res;
        }
    }
}
