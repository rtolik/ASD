namespace UILabs
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.GroupBox sortTypeBox;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.GroupBox arrayInitBox;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.GroupBox groupBox1;
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.arrInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tmpLabel = new System.Windows.Forms.Label();
            this.arrayHolder = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSort = new System.Windows.Forms.Button();
            this.tmpArrayHolder = new System.Windows.Forms.RichTextBox();
            this.sortedArrayHolder = new System.Windows.Forms.RichTextBox();
            this.buttonRandomize = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            sortTypeBox = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            arrayInitBox = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            sortTypeBox.SuspendLayout();
            arrayInitBox.SuspendLayout();
            groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sortTypeBox
            // 
            sortTypeBox.Controls.Add(label3);
            sortTypeBox.Controls.Add(this.radioButton7);
            sortTypeBox.Controls.Add(this.radioButton6);
            sortTypeBox.Controls.Add(this.radioButton5);
            sortTypeBox.Controls.Add(this.radioButton4);
            sortTypeBox.Controls.Add(this.radioButton3);
            sortTypeBox.Controls.Add(this.radioButton2);
            sortTypeBox.Controls.Add(this.radioButton1);
            sortTypeBox.Location = new System.Drawing.Point(12, 12);
            sortTypeBox.Name = "sortTypeBox";
            sortTypeBox.Size = new System.Drawing.Size(190, 360);
            sortTypeBox.TabIndex = 3;
            sortTypeBox.TabStop = false;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(6, 14);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(178, 47);
            label3.TabIndex = 7;
            label3.Text = "Вибір методу сортування";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton7
            // 
            this.radioButton7.Location = new System.Drawing.Point(9, 314);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(175, 25);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Підрахунок";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.Location = new System.Drawing.Point(9, 283);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(175, 25);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Злиття";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.Location = new System.Drawing.Point(9, 252);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(175, 25);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Шелла";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Click += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.Location = new System.Drawing.Point(9, 196);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(175, 50);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Швидке сортування";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Click += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(9, 165);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(175, 25);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Проста вибірка";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(8, 107);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(175, 50);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Бульбашка з флагом";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 75);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(175, 25);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Бульбашка";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // arrayInitBox
            // 
            arrayInitBox.Controls.Add(this.buttonSubmit);
            arrayInitBox.Controls.Add(this.textBox1);
            arrayInitBox.Controls.Add(label1);
            arrayInitBox.Location = new System.Drawing.Point(208, 12);
            arrayInitBox.Name = "arrayInitBox";
            arrayInitBox.Size = new System.Drawing.Size(200, 100);
            arrayInitBox.TabIndex = 5;
            arrayInitBox.TabStop = false;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(97, 60);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(25, 3, 25, 3);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 29);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Submit";
            this.toolTip1.SetToolTip(this.buttonSubmit, "Creates a new array with a size written below");
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.Location = new System.Drawing.Point(28, 60);
            this.textBox1.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 29);
            this.textBox1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBox1, "Write here size of new array and click \"Submit\"");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(28, 25);
            label1.Margin = new System.Windows.Forms.Padding(25, 0, 25, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(150, 25);
            label1.TabIndex = 0;
            label1.Text = "Розмір Масиву";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(208, 119);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(416, 24);
            label2.TabIndex = 8;
            label2.Text = "Елементи масиву";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.buttonUndo);
            groupBox1.Controls.Add(this.arrInput);
            groupBox1.Controls.Add(this.label4);
            groupBox1.Location = new System.Drawing.Point(424, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(200, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(groupBox1, "Write number and press \"Enter\" to plase it in array");
            // 
            // buttonUndo
            // 
            this.buttonUndo.Location = new System.Drawing.Point(108, 60);
            this.buttonUndo.Margin = new System.Windows.Forms.Padding(11, 3, 22, 3);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(67, 29);
            this.buttonUndo.TabIndex = 2;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // arrInput
            // 
            this.arrInput.BackColor = System.Drawing.Color.LightGray;
            this.arrInput.Location = new System.Drawing.Point(25, 60);
            this.arrInput.Margin = new System.Windows.Forms.Padding(22, 3, 11, 3);
            this.arrInput.Name = "arrInput";
            this.arrInput.Size = new System.Drawing.Size(67, 29);
            this.arrInput.TabIndex = 1;
            this.toolTip1.SetToolTip(this.arrInput, "Write number and press \"Enter\" to plase it in array");
            this.arrInput.WordWrap = false;
            this.arrInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.arrInput_KeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Елементи масиву";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label4, "Write number and press \"Enter\" to plase it in array");
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(208, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(416, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Проміжні результати сортування";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(204, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(416, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Відсортованій масив";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmpLabel
            // 
            this.tmpLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tmpLabel.Location = new System.Drawing.Point(27, 489);
            this.tmpLabel.Name = "tmpLabel";
            this.tmpLabel.Size = new System.Drawing.Size(169, 41);
            this.tmpLabel.TabIndex = 6;
            this.tmpLabel.Visible = false;
            // 
            // arrayHolder
            // 
            this.arrayHolder.BackColor = System.Drawing.Color.LightGray;
            this.arrayHolder.Location = new System.Drawing.Point(208, 146);
            this.arrayHolder.Name = "arrayHolder";
            this.arrayHolder.ReadOnly = true;
            this.arrayHolder.Size = new System.Drawing.Size(416, 50);
            this.arrayHolder.TabIndex = 7;
            this.arrayHolder.Text = "";
            this.toolTip1.SetToolTip(this.arrayHolder, "Field with elements of array");
            this.arrayHolder.WordWrap = false;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Guide";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(638, 72);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(11, 3, 22, 3);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(115, 29);
            this.buttonSort.TabIndex = 7;
            this.buttonSort.Text = "Sort";
            this.toolTip1.SetToolTip(this.buttonSort, "Starts sorting array with choosen algorithm");
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // tmpArrayHolder
            // 
            this.tmpArrayHolder.BackColor = System.Drawing.Color.LightGray;
            this.tmpArrayHolder.Location = new System.Drawing.Point(208, 235);
            this.tmpArrayHolder.Name = "tmpArrayHolder";
            this.tmpArrayHolder.ReadOnly = true;
            this.tmpArrayHolder.Size = new System.Drawing.Size(416, 224);
            this.tmpArrayHolder.TabIndex = 9;
            this.tmpArrayHolder.Text = "";
            this.tmpArrayHolder.WordWrap = false;
            // 
            // sortedArrayHolder
            // 
            this.sortedArrayHolder.BackColor = System.Drawing.Color.LightGray;
            this.sortedArrayHolder.Location = new System.Drawing.Point(208, 489);
            this.sortedArrayHolder.Name = "sortedArrayHolder";
            this.sortedArrayHolder.ReadOnly = true;
            this.sortedArrayHolder.Size = new System.Drawing.Size(416, 50);
            this.sortedArrayHolder.TabIndex = 12;
            this.sortedArrayHolder.Text = "";
            this.sortedArrayHolder.WordWrap = false;
            // 
            // buttonRandomize
            // 
            this.buttonRandomize.Location = new System.Drawing.Point(638, 37);
            this.buttonRandomize.Margin = new System.Windows.Forms.Padding(11, 3, 22, 3);
            this.buttonRandomize.Name = "buttonRandomize";
            this.buttonRandomize.Size = new System.Drawing.Size(115, 29);
            this.buttonRandomize.TabIndex = 8;
            this.buttonRandomize.Text = "Randomize";
            this.buttonRandomize.UseVisualStyleBackColor = true;
            this.buttonRandomize.Click += new System.EventHandler(this.buttonRandomize_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 59);
            this.button1.TabIndex = 13;
            this.button1.Text = "Порівняння алгоритмів";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonRandomize);
            this.Controls.Add(this.sortedArrayHolder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tmpArrayHolder);
            this.Controls.Add(groupBox1);
            this.Controls.Add(label2);
            this.Controls.Add(this.arrayHolder);
            this.Controls.Add(this.tmpLabel);
            this.Controls.Add(arrayInitBox);
            this.Controls.Add(sortTypeBox);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Романюк АСД";
            sortTypeBox.ResumeLayout(false);
            arrayInitBox.ResumeLayout(false);
            arrayInitBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox arrInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.RichTextBox tmpArrayHolder;
        private System.Windows.Forms.RichTextBox sortedArrayHolder;
        private System.Windows.Forms.Button buttonRandomize;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.RichTextBox arrayHolder;
        public System.Windows.Forms.Label tmpLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

