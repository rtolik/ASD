using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UILabs.Classes.Comparators;
using UILabs.Classes.Sorters;
using UILabs.Classes.Utils;
using UILabs.Interfaces;

namespace UILabs
{
    public partial class Form1 : Form
    {
        public CustomDoubleArray[] CustomDoubleArray;

        public double[] array = new double[0],tmp=new double[0];

        private IComparableLab<double> _comparator;

        private ISortable<double> _sortable;

        private readonly List<RadioButton> _radioButtonList = new List<RadioButton>();

        private int _size, _arrayEnterIterator;
        private bool _direction = true,_formChanged;

        public Form1()
        {
            InitializeComponent();  
            _radioButtonList.Add(radioButton1);
            _radioButtonList.Add(radioButton2);
            _radioButtonList.Add(radioButton3);
            _radioButtonList.Add(radioButton4);
            _radioButtonList.Add(radioButton5);
            _radioButtonList.Add(radioButton6);
            _radioButtonList.Add(radioButton7);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            array = new double[_size];
            _arrayEnterIterator = 0;
            PrintArray();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _size = ValidateTextBox(textBox1, true);
        }

        private void arrInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter && _arrayEnterIterator < array.Length)
            {
                array[_arrayEnterIterator] = ValidateTextBox(arrInput, false);
                arrInput.Text = "";
                _arrayEnterIterator++;
                PrintArray();
            }

            if (_arrayEnterIterator==array.Length)
            {
                tmp= new double[array.Length];
                array.CopyTo(tmp, 0);
            }
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

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            _arrayEnterIterator--;
            array[_arrayEnterIterator] = 0;
            PrintArray();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            this.tmp.CopyTo(array, 0);
            int tmp = _radioButtonList.FindIndex(button => button.Checked);
            switch (tmp)
            {
                case 0:
                {
                    _comparator = new NumberComparator();
                    _sortable = new BubbleSorter<double>();
                }
                    break;

                case 1:
                {
                    _comparator = new NumberComparator();
                    _sortable = new FlagBubble<double>();
                }
                    break;

                case 2:
                {
                    _comparator=new NumberComparator();
                    _sortable=new SimpleSelection<double>();
                }
                    break;

                case 3:
                {
                    _comparator=new NumberComparator();
                    _sortable= new QuickSort<double>();
                }
                    break;

                case 4:
                {
                    IComparableLab<CustomDoubleArray> comparator=new CustomDoubleArrayComparator();
                    ISortable<CustomDoubleArray> sortable=new ShellSort<CustomDoubleArray>();
                    if (sortable.ArrayCheck(CustomDoubleArray, comparator))
                    {
                        tmpArrayHolder.Text = "";
                        sortedArrayHolder.Text = "";
                        
                        CustomDoubleArray = sortable.Sort(CustomDoubleArray, tmpArrayHolder, comparator, true, true);
                        sortable.Print(CustomDoubleArray, sortedArrayHolder, "");
                    }
                    else
                    {
                        tmpLabel.Text = "Please reenter array, because it does not fit the condition!!";
                    }
                }
                    return;

                case 5:
                {
                    _comparator=new NumberComparator();
                    _sortable=new MergeSort<double>();
                    _direction = false;

                }
                    break;

                case 6:
                {
                    int [] intArray = new int[array.Length];
                    for (int i = 0; i < intArray.Length; i++)
                    {
                        intArray[i] = (int)array[i];
                    }

                    intArray = Lab6ArrayHandler.Execute(intArray);
                    IComparableLab<int> comparable=new NumberComparator();
                    ISortable<int> sortable=new CountSort<int>();
                    _direction = false;
                    if (sortable.ArrayCheck(intArray, comparable))
                    {
                        tmpArrayHolder.Text = "";
                        sortedArrayHolder.Text = "";
                        sortable.Print(intArray,tmpArrayHolder,"Масив після виконання індивідуального завдання: \n");
                        intArray = sortable.Sort(intArray, tmpArrayHolder, comparable, _direction, true);
                        sortable.Print(intArray, sortedArrayHolder, "");
                    }
                    else
                    {
                        tmpLabel.Text = "Please reenter array, because it does not fit the condition!!";
                    }
                }
                    return;

                default:
                {
                    throw new IndexOutOfRangeException();
                }
            }

            if (_sortable.ArrayCheck(array,_comparator))
            { 
            tmpArrayHolder.Text = "";
            sortedArrayHolder.Text = "";
            
            array= _sortable.Sort(array, tmpArrayHolder, _comparator, _direction, true);
            _sortable.Print(array, sortedArrayHolder, "");
            }
            else
            {
                tmpLabel.Text = "Please reenter array, because it does not fit the condition!!";
            }
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            Lab3_ArraysInput formInput=new Lab3_ArraysInput(this);
            formInput.Show();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Lab4Input lab4Input= new Lab4Input(this);
            lab4Input.Show();
        }

        private void buttonRandomize_Click(object sender, EventArgs e)
        {
            Random rand= new Random();
            if (_size == 0)
            {
                _size = rand.Next(2, 10);
                array = new double[_size];
                _arrayEnterIterator = _size;
            }

            double val;
            for (int i = 0; i < array.Length; i++)
            {
                val = rand.Next(-4000, 4000);
                array[i] = val/100;
                array[i] = rand.Next(0, 10);
            }
            tmp = new double[array.Length];
            array.CopyTo(tmp,0);
            PrintArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab7 formLab7= new Lab7();
            formLab7.Show();
        }

        public void PrintArray()
        {
            string line = "";
            foreach (double el in array) line += el + " ";

            arrayHolder.Text = line;
        }

        public void PrintCustomDoubleArray()
        {
            string line = "";
            foreach (CustomDoubleArray el in CustomDoubleArray) line += el;
            arrayHolder.Text = line;
            ChangeDimencions();
        }

        private void ChangeDimencions()
        {
            if (!_formChanged)
            {


                Height = 800;
                arrayHolder.Height += 100;

                Point location = tmpArrayHolder.Location;
                location.Y += 100;
                tmpArrayHolder.Location = location;

                location = sortedArrayHolder.Location;
                location.Y += 100;
                sortedArrayHolder.Location = location;

                sortedArrayHolder.Height += 100;

                location = label5.Location;
                location.Y += 100;
                label5.Location = location;

                location = label6.Location;
                location.Y += 100;
                label6.Location = location;
                _formChanged = true;
            }
        }
    }
}