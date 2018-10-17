using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using UILabs.Classes.Comparators;
using UILabs.Classes.Sorters;
using UILabs.Interfaces;

namespace UILabs
{
    public partial class Lab7 : Form
    {
        private Dictionary<string,ISortable<int>> sorters= new Dictionary<string, ISortable<int>>();

        private static  IComparableLab<int> comparator = new NumberComparator();

        private int [] array;

        private List<DataGridViewTextBoxColumn> datacol= new List<DataGridViewTextBoxColumn>();

        private OututForm form = new OututForm();

        public Lab7()
        {
            InitializeComponent();

            InitSorters();

            ClearFile();

            datacol.Add(Hundred);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;

            sortTable.Rows.Clear();
            consoleBox.Text = "";
            sortTable.RowCount = 7;
            for (int size = 100,cellIndex=1; size <= 10000; size*=10,cellIndex++)
            {
                int[] randomArr = RandomGeneratedArr(size);
                array=new int[size];
                if (checkBox1.Checked)
                {
                    form.arrays.Add("Згенерований масив на: "+size+ "елементів",randomArr);
                }
                for(int i=0;i<sorters.Count;i++)
                {
                    randomArr.CopyTo(array,0);

                    DateTime start = DateTime.Now;
                    WriteConsole(DateTime.Now.TimeOfDay + " Сортування " + sorters.ElementAt(i).Key + " для " + size + " елементів розпочато");

                    int[] sortedArr = sorters.ElementAt(i).Value.Sort(array, null, comparator, true, false);
                    if (checkBox2.Checked)
                    {
                        form.arrays.Add(sorters.ElementAt(i).Key + " на " + size + "елементів", sortedArr);
                    }


                    TimeSpan res = DateTime.Now - start;
                    WriteConsole(DateTime.Now.TimeOfDay + " Сортування " + sorters.ElementAt(i).Key+" для "+size + " елементів завершено за " + res);
                    
                    WriteTable(i, cellIndex, res);
                }
            }

            for (int i = 0; i < sorters.Count; i++)
            {
                for (int cellIndex = 1; cellIndex <= 3; cellIndex++)
                {
                
                    hundredChart.Series[i].Points.AddXY(cellIndex, TimeSpan.Parse(sortTable.Rows[i].Cells[cellIndex].Value.ToString()).TotalMilliseconds);
                }
            }

            button2.Enabled = true;
        }

        private void WriteTable(int i, int cellIndex, TimeSpan res)
        {
            sortTable.Rows[i].Cells[0].Value = sorters.ElementAt(i).Key;
            sortTable.Rows[i].Cells[cellIndex].Value = res;
        }

        private void WriteConsole(string message)
        {
            message += "\n";
            consoleBox.Text += message;
            consoleBox.SelectionStart = consoleBox.Text.Length;
            consoleBox.ScrollToCaret();
        }

        private int[] RandomGeneratedArr(int size)
        {
            Random random= new  Random();
            int[] result=new int[size];
            string strArray = "Розмір: "+size+" , Елементи: ";
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = random.Next(100);
                strArray += result[i] + " ";
            }

            WriteToFile(strArray);
            return result;
        }

        private static void WriteToFile(string strArray)
        {
            using (FileStream fs = new FileStream("Unsorted_Array.txt", FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(strArray);
                    sw.WriteLine("");
                    sw.WriteLine("");
                    sw.WriteLine("");
                    sw.Close();
                }
            }
        }

        private static void ClearFile()
        {
            using (FileStream fs = new FileStream("Unsorted_Array.txt", FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write("");
                    sw.Close();
                }
            }
        }

        private void InitSorters()
        {
            sorters.Add("Бульбашкою", new BubbleSorter<int>());
            sorters.Add("Бульбашкою з прапорцем", new FlagBubble<int>());
            sorters.Add("Простою вибіркою", new SimpleSelection<int>());
            sorters.Add("Швидким сортуванням", new QuickSort<int>());
            sorters.Add("Шеллом", new ShellSort<int>());
            sorters.Add("Злиттям", new MergeSort<int>());
            sorters.Add("Підрахунком", new CountSort<int>());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.Show();
        }
    }
}
