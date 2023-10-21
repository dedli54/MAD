namespace WinFormsApp1
{
    partial class WordQuery
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
            label4 = new Label();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            label2 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            button3 = new Button();
            label6 = new Label();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Location = new Point(35, 493);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 25;
            label4.Text = "Favorites";
            // 
            // button4
            // 
            button4.Location = new Point(34, 594);
            button4.Name = "button4";
            button4.Size = new Size(117, 23);
            button4.TabIndex = 24;
            button4.Text = "See favorites";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(35, 521);
            button2.Name = "button2";
            button2.Size = new Size(117, 56);
            button2.TabIndex = 23;
            button2.Text = "Save displayed verse as favorite";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(35, 422);
            button1.Name = "button1";
            button1.Size = new Size(117, 23);
            button1.TabIndex = 22;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(265, 80);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1111, 747);
            richTextBox1.TabIndex = 21;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Location = new Point(34, 331);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 20;
            label3.Text = "Final verse";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(35, 259);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 19;
            label2.Text = "Initial verse";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(35, 361);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 18;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(35, 290);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 17;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(35, 130);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 16;
            comboBox1.Text = "Books";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(35, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 15;
            textBox2.Text = "Chapter";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(34, 96);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 14;
            label1.Text = "Optional search parameters";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(265, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(452, 23);
            textBox1.TabIndex = 26;
            textBox1.Text = "Word Search";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Location = new Point(265, 15);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 27;
            label5.Text = "Search by word";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            button3.FlatAppearance.BorderSize = 5;
            button3.FlatStyle = FlatStyle.System;
            button3.Location = new Point(60, 685);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 29;
            button3.Text = "Go to ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Location = new Point(36, 653);
            label6.Name = "label6";
            label6.Size = new Size(120, 15);
            label6.TabIndex = 28;
            label6.Text = "Search by parameters";
            label6.Click += label6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(60, 741);
            button5.Name = "button5";
            button5.Size = new Size(75, 52);
            button5.TabIndex = 30;
            button5.Text = "See search history";
            button5.UseVisualStyleBackColor = true;
            // 
            // WordQuery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1406, 866);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox1);
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
            Name = "WordQuery";
            Text = "WordQuery";
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button button4;
        private Button button2;
        private Button button1;
        private RichTextBox richTextBox1;
        private Label label3;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label label5;
        private Button button3;
        private Label label6;
        private Button button5;
    }
}