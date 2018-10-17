namespace UILabs
{
    partial class Lab7
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sortTable = new System.Windows.Forms.DataGridView();
            this.AlgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hundred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thousand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThousand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consoleBox = new System.Windows.Forms.RichTextBox();
            this.hundredChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sortTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hundredChart)).BeginInit();
            this.SuspendLayout();
            // 
            // sortTable
            // 
            this.sortTable.AllowUserToOrderColumns = true;
            this.sortTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sortTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlgName,
            this.Hundred,
            this.Thousand,
            this.TenThousand});
            this.sortTable.Location = new System.Drawing.Point(12, 12);
            this.sortTable.Name = "sortTable";
            this.sortTable.Size = new System.Drawing.Size(835, 194);
            this.sortTable.TabIndex = 0;
            // 
            // AlgName
            // 
            this.AlgName.HeaderText = "Назва";
            this.AlgName.Name = "AlgName";
            this.AlgName.Width = 300;
            // 
            // Hundred
            // 
            this.Hundred.HeaderText = "100 ел";
            this.Hundred.Name = "Hundred";
            this.Hundred.Width = 150;
            // 
            // Thousand
            // 
            this.Thousand.HeaderText = "1000 ел";
            this.Thousand.Name = "Thousand";
            this.Thousand.Width = 150;
            // 
            // TenThousand
            // 
            this.TenThousand.HeaderText = "10000 ел";
            this.TenThousand.Name = "TenThousand";
            this.TenThousand.Width = 150;
            // 
            // consoleBox
            // 
            this.consoleBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.consoleBox.Location = new System.Drawing.Point(0, 528);
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ReadOnly = true;
            this.consoleBox.Size = new System.Drawing.Size(1087, 70);
            this.consoleBox.TabIndex = 2;
            this.consoleBox.Text = "";
            // 
            // hundredChart
            // 
            this.hundredChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea3.Name = "ChartArea1";
            this.hundredChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.hundredChart.Legends.Add(legend3);
            this.hundredChart.Location = new System.Drawing.Point(11, 231);
            this.hundredChart.Name = "hundredChart";
            this.hundredChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Legend = "Legend1";
            series15.Name = "Бульбашка";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Legend = "Legend1";
            series16.Name = "Бульбашка з прапорцем";
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series17.Legend = "Legend1";
            series17.Name = "Проста вибірка";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.Legend = "Legend1";
            series18.Name = "Швидке сортування";
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.Legend = "Legend1";
            series19.Name = "Сортування Шелла";
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Legend = "Legend1";
            series20.Name = "Сортування злиттям";
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series21.Legend = "Legend1";
            series21.Name = "Сортування підрахунком";
            this.hundredChart.Series.Add(series15);
            this.hundredChart.Series.Add(series16);
            this.hundredChart.Series.Add(series17);
            this.hundredChart.Series.Add(series18);
            this.hundredChart.Series.Add(series19);
            this.hundredChart.Series.Add(series20);
            this.hundredChart.Series.Add(series21);
            this.hundredChart.Size = new System.Drawing.Size(1063, 291);
            this.hundredChart.TabIndex = 3;
            this.hundredChart.Text = "100 елементів";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(895, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 53);
            this.button1.TabIndex = 9;
            this.button1.Text = "Аналіз";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(895, 72);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 48);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Згенеровані масиви";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(895, 126);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(149, 48);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Відсортовані масиви";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(895, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 45);
            this.button2.TabIndex = 12;
            this.button2.Text = "Вивід";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lab7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1087, 598);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.hundredChart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.sortTable);
            this.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Lab7";
            this.Text = "Lab7";
            ((System.ComponentModel.ISupportInitialize)(this.sortTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hundredChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sortTable;
        private System.Windows.Forms.RichTextBox consoleBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart hundredChart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hundred;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thousand;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThousand;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button2;
    }
}