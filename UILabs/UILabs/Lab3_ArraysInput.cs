using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UILabs.Classes;

namespace UILabs
{
    public partial class Lab3_ArraysInput : Form
    {
        private Form1 form;

        private int _size1, _arrayEnterIterator1;
        private int _size2, _arrayEnterIterator2;

        private int[] arr1, arr2;
        List<int> result= new List<int>();

        public Lab3_ArraysInput( Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Randomize(ref arr1,_size1,ref _arrayEnterIterator1,Array1Holder);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Randomize(ref arr2,_size2,ref _arrayEnterIterator2,Array2Holder);
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

        private void arrInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            arrInput_KeyPress(ref arr1,ref _arrayEnterIterator1,e, Array1Holder);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            arrInput_KeyPress(ref arr2,ref  _arrayEnterIterator2, e, Array2Holder);

        }


        private void arrInput_KeyPress(ref int[] array,ref int _arrayEnterIterator, KeyPressEventArgs e,RichTextBox textBox)
        {
            if (e.KeyChar == (char)Keys.Enter && _arrayEnterIterator < array.Length)
            {
                array[_arrayEnterIterator] = ValidateTextBox(arrInput, false);
                arrInput.Text = "";
                _arrayEnterIterator++;
                Print(array,textBox,"");
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Submit(ref arr1,_size1,ref _arrayEnterIterator1,Array1Holder);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Submit(ref arr2, _size2, ref _arrayEnterIterator2, Array2Holder);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _size1 = ValidateTextBox(textBox1, true);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            _size2 = ValidateTextBox(textBox3, true);
        }

        private void Submit(ref int [] array,int _size,ref int _arrayEnterIterator,RichTextBox textBox)
        {
            array = new int[_size];
            _arrayEnterIterator = 0;
            Print(array,textBox,"");
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            Undo(ref arr1,ref _arrayEnterIterator1,Array1Holder);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Undo(ref arr2, ref _arrayEnterIterator2, Array2Holder);
        }

        private void Arrayhandler(object sender, EventArgs e)
        {
            bool isNeed = false;    
            foreach (int el in arr1)
            {
                if (isNeed)
                {
                    result.Add(el);
                }

                isNeed = !isNeed;
            }
            isNeed=true;
            foreach (int el in arr2)
            {
                if (isNeed)
                {
                    result.Add(el);
                }

                isNeed = !isNeed;
            }

            double[] tmp = new double[result.Count];
            int i = 0;
            result.ForEach(x =>
            {
                tmp[i] = (double)x;
                i++;
            });
            form.array = tmp;
            form.tmp = tmp;
            form.PrintArray();
            Print(result.ToArray(),ResultHolder,"");
        }

        private void Randomize(ref int [] array,int _size,ref int _arrayEnterIterator,RichTextBox textBox)
        {
            Random rand = new Random();
            if (_size == 0)
            {
                _size = rand.Next(2, 10);
                array = new int[_size];
                _arrayEnterIterator = _size;
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-40, 40);
                
            }
            Print(array,textBox,"");
        }

        public void Print(int[] array, RichTextBox textBox, string info)
        {
            string resultStr = info + " ";
            foreach (int el in array)
            {
                resultStr += el + " ";
            }

            textBox.Text =  resultStr;
        }

        private void Undo(ref int [] array, ref int _arrayEnterIterator,RichTextBox textBox)
        {
            _arrayEnterIterator--;
            array[_arrayEnterIterator] = 0;
            Print(array,textBox,"");
        }

    }
}
