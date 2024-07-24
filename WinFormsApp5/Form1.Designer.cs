namespace WinFormsApp5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox_Month = new ComboBox();
            comboBox_Day = new ComboBox();
            comboBox_NameMonth = new ComboBox();
            comboBox_Year = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBox_Month
            // 
            comboBox_Month.FormattingEnabled = true;
            comboBox_Month.Location = new Point(494, 114);
            comboBox_Month.Name = "comboBox_Month";
            comboBox_Month.Size = new Size(103, 28);
            comboBox_Month.TabIndex = 0;
            // 
            // comboBox_Day
            // 
            comboBox_Day.FormattingEnabled = true;
            comboBox_Day.Location = new Point(646, 114);
            comboBox_Day.Name = "comboBox_Day";
            comboBox_Day.Size = new Size(101, 28);
            comboBox_Day.TabIndex = 1;
            comboBox_Day.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox_NameMonth
            // 
            comboBox_NameMonth.FormattingEnabled = true;
            comboBox_NameMonth.Location = new Point(344, 114);
            comboBox_NameMonth.Name = "comboBox_NameMonth";
            comboBox_NameMonth.Size = new Size(114, 28);
            comboBox_NameMonth.TabIndex = 2;
            // 
            // comboBox_Year
            // 
            comboBox_Year.FormattingEnabled = true;
            comboBox_Year.Location = new Point(195, 114);
            comboBox_Year.Name = "comboBox_Year";
            comboBox_Year.Size = new Size(119, 28);
            comboBox_Year.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(422, 26);
            label1.MinimumSize = new Size(110, 20);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 4;
            label1.Text = "תאריך";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 82);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 5;
            label2.Text = "שנה";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 82);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 6;
            label3.Text = "חודש";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(505, 82);
            label4.MinimumSize = new Size(110, 20);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 7;
            label4.Text = "היום בחודש";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(646, 82);
            label5.MinimumSize = new Size(110, 20);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 8;
            label5.Text = "היום בשבוע";
            // 
            // button1
            // 
            button1.Location = new Point(395, 253);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "הוסף";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox_Year);
            Controls.Add(comboBox_NameMonth);
            Controls.Add(comboBox_Day);
            Controls.Add(comboBox_Month);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_Month;
        private ComboBox comboBox_Day;
        private ComboBox comboBox_NameMonth;
        private ComboBox comboBox_Year;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}
