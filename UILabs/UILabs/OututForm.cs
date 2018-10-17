using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UILabs
{
    public partial class OututForm : Form
    {
        public Dictionary<string,int[]> arrays = new Dictionary<string, int[]>();

        public OututForm()
        {
            InitializeComponent();

            
        }

        private void OutPutForm_Load(object sender, EventArgs e)
        {
            string output = "";
            foreach (KeyValuePair<string, int[]> array in arrays)
            {
                output += array.Key + ":\n";
                foreach (int arraysValue in array.Value)
                {

                    output += arraysValue + "\t";
                }

                output+= "\n";
            }

            richTextBox2.Text = output;
        }
    }
}
