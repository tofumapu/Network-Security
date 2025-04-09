namespace NumberTheory
{
    partial class Exercise3
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
            button5 = new Button();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            richTextBox5 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 128, 128);
            label4.Location = new Point(367, 76);
            label4.Name = "label4";
            label4.Size = new Size(391, 71);
            label4.TabIndex = 3;
            label4.Text = "Modulo số mũ";
            // 
            // button4
            // 
            button4.Location = new Point(866, 186);
            button4.Name = "button4";
            button4.Size = new Size(72, 46);
            button4.TabIndex = 4;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(971, 186);
            button5.Name = "button5";
            button5.Size = new Size(150, 46);
            button5.TabIndex = 5;
            button5.Text = "Kiểm tra";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 241);
            label5.Name = "label5";
            label5.Size = new Size(210, 32);
            label5.TabIndex = 8;
            label5.Text = "Nhập số nguyên a";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 393);
            label1.Name = "label1";
            label1.Size = new Size(163, 32);
            label1.TabIndex = 9;
            label1.Text = "Nhập số mũ x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 540);
            label2.Name = "label2";
            label2.Size = new Size(214, 32);
            label2.TabIndex = 10;
            label2.Text = "Nhập số modulo p";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 679);
            label3.Name = "label3";
            label3.Size = new Size(96, 32);
            label3.TabIndex = 11;
            label3.Text = "Kết quả";
            // 
            // richTextBox5
            // 
            richTextBox5.Location = new Point(298, 256);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(823, 100);
            richTextBox5.TabIndex = 12;
            richTextBox5.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(298, 390);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(823, 100);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(298, 537);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(823, 100);
            richTextBox2.TabIndex = 14;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(298, 676);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(823, 100);
            richTextBox3.TabIndex = 15;
            richTextBox3.Text = "";
            // 
            // Exercise3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 931);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(richTextBox5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label4);
            Name = "Exercise3";
            Text = "Exercise3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button button4;
        private Button button5;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBox5;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
    }
}