namespace UILabs
{
    partial class Lab4Input
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.GroupBox arrayInitBox;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label label2;
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Array2Holder = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            arrayInitBox = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            arrayInitBox.SuspendLayout();
            groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // arrayInitBox
            // 
            arrayInitBox.Controls.Add(this.buttonSubmit);
            arrayInitBox.Controls.Add(this.textBox1);
            arrayInitBox.Controls.Add(label1);
            arrayInitBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            arrayInitBox.Location = new System.Drawing.Point(14, 13);
            arrayInitBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            arrayInitBox.Name = "arrayInitBox";
            arrayInitBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            arrayInitBox.Size = new System.Drawing.Size(200, 100);
            arrayInitBox.TabIndex = 7;
            arrayInitBox.TabStop = false;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(106, 63);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(42, 4, 42, 4);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 29);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.Location = new System.Drawing.Point(31, 63);
            this.textBox1.Margin = new System.Windows.Forms.Padding(42, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(27, 26);
            label1.Margin = new System.Windows.Forms.Padding(42, 0, 42, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(150, 25);
            label1.TabIndex = 0;
            label1.Text = "Кількість Рядків";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.button1);
            groupBox1.Controls.Add(this.textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            groupBox1.Location = new System.Drawing.Point(224, 13);
            groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            groupBox1.Size = new System.Drawing.Size(200, 100);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(42, 4, 42, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGray;
            this.textBox2.Location = new System.Drawing.Point(31, 63);
            this.textBox2.Margin = new System.Windows.Forms.Padding(42, 4, 5, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 29);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(27, 26);
            label2.Margin = new System.Windows.Forms.Padding(42, 0, 42, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(150, 25);
            label2.TabIndex = 0;
            label2.Text = "Кількість стовбців";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Array2Holder
            // 
            this.Array2Holder.Location = new System.Drawing.Point(8, 29);
            this.Array2Holder.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Array2Holder.Name = "Array2Holder";
            this.Array2Holder.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.Array2Holder.Size = new System.Drawing.Size(334, 235);
            this.Array2Holder.TabIndex = 15;
            this.Array2Holder.Text = "";
            this.Array2Holder.WordWrap = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(321, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 29);
            this.button4.TabIndex = 16;
            this.button4.Text = "Random";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(321, 155);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 29);
            this.button6.TabIndex = 17;
            this.button6.Text = "Генерація";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Array2Holder);
            this.groupBox2.Location = new System.Drawing.Point(436, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 272);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Початкова матриця";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Location = new System.Drawing.Point(436, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 272);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Кінцева матриця";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 29);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox1.Size = new System.Drawing.Size(334, 235);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // Lab4Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(groupBox1);
            this.Controls.Add(arrayInitBox);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Lab4Input";
            this.Text = "Романюк АСД";
            arrayInitBox.ResumeLayout(false);
            arrayInitBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox Array2Holder;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}