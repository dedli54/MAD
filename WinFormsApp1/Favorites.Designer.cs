namespace WinFormsApp1
{
    partial class Favorites
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(212, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(742, 598);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(24, 190);
            button1.Name = "button1";
            button1.Size = new Size(142, 25);
            button1.TabIndex = 1;
            button1.Text = "Delete selected favorite";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(24, 471);
            button2.Name = "button2";
            button2.Size = new Size(142, 23);
            button2.TabIndex = 2;
            button2.Text = "Go to word search";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(24, 379);
            button3.Name = "button3";
            button3.Size = new Size(142, 23);
            button3.TabIndex = 3;
            button3.Text = "Go to parameter search";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(54, 134);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 4;
            label1.Text = "Favorites";
            label1.Click += label1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(24, 422);
            button4.Name = "button4";
            button4.Size = new Size(142, 23);
            button4.TabIndex = 5;
            button4.Text = "Go to history";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(24, 245);
            button5.Name = "button5";
            button5.Size = new Size(142, 25);
            button5.TabIndex = 6;
            button5.Text = "Delete all";
            button5.UseVisualStyleBackColor = true;
            // 
            // Favorites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(991, 655);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Favorites";
            Text = "Favorites";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button4;
        private Button button5;
    }
}