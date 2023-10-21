namespace WinFormsApp1
{
    partial class Query
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
            label1 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            label4 = new Label();
            label5 = new Label();
            button3 = new Button();
            button5 = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(34, 40);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Search parameters";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(35, 130);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 2;
            textBox2.Text = "Chapter";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(35, 74);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "Books";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(35, 234);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(35, 305);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(35, 203);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 6;
            label2.Text = "Initial verse";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Location = new Point(34, 275);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 7;
            label3.Text = "Final verse";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(244, 16);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(865, 747);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(35, 366);
            button1.Name = "button1";
            button1.Size = new Size(117, 23);
            button1.TabIndex = 9;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(35, 465);
            button2.Name = "button2";
            button2.Size = new Size(117, 56);
            button2.TabIndex = 10;
            button2.Text = "Save displayed verse as favorite";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(34, 538);
            button4.Name = "button4";
            button4.Size = new Size(117, 23);
            button4.TabIndex = 12;
            button4.Text = "See favorites";
            button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Location = new Point(35, 437);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 13;
            label4.Text = "Favorites";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Location = new Point(42, 592);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 14;
            label5.Text = "Search by word(s)";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            button3.FlatAppearance.BorderSize = 5;
            button3.FlatStyle = FlatStyle.System;
            button3.Location = new Point(52, 610);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 15;
            button3.Text = "Go to ";
            button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Location = new Point(52, 698);
            button5.Name = "button5";
            button5.Size = new Size(75, 52);
            button5.TabIndex = 16;
            button5.Text = "See search history";
            button5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Location = new Point(66, 680);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 17;
            label6.Text = "History";
            // 
            // Query
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1144, 788);
            Controls.Add(label6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Name = "Query";
            Text = "Query";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Label label4;
        private Label label5;
        private Button button3;
        private Button button5;
        private Label label6;
    }
}