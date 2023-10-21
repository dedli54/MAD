namespace WinFormsApp1
{
    partial class Register
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
            button3 = new Button();
            button1 = new Button();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(94, 447);
            button3.Name = "button3";
            button3.Size = new Size(117, 23);
            button3.TabIndex = 41;
            button3.Text = "Go back";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(94, 398);
            button1.Name = "button1";
            button1.Size = new Size(117, 23);
            button1.TabIndex = 39;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(39, 317);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 38;
            label6.Text = "Gender";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(39, 266);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(243, 23);
            dateTimePicker1.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(39, 248);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 36;
            label5.Text = "Birth date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(39, 176);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 35;
            label4.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(39, 111);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 34;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(39, 45);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 33;
            label2.Text = "E-mail:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(350, -32);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 32;
            label1.Text = "Edit your data";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(39, 335);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(243, 23);
            textBox5.TabIndex = 31;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(39, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(243, 23);
            textBox3.TabIndex = 30;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(39, 194);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 23);
            textBox2.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 23);
            textBox1.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(86, 9);
            label7.Name = "label7";
            label7.Size = new Size(125, 15);
            label7.TabIndex = 42;
            label7.Text = "Please insert your data";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(309, 515);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button1;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
    }
}