namespace NumberTheory
{
    partial class Exercise2
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
            richTextBox3 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 128, 128);
            label4.Location = new Point(364, 56);
            label4.Name = "label4";
            label4.Size = new Size(593, 71);
            label4.TabIndex = 3;
            label4.Text = "Ước số chung lớn nhất";
            // 
            // button4
            // 
            button4.Location = new Point(1028, 186);
            button4.Name = "button4";
            button4.Size = new Size(72, 46);
            button4.TabIndex = 4;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1119, 186);
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
            label5.Location = new Point(47, 235);
            label5.Name = "label5";
            label5.Size = new Size(256, 32);
            label5.TabIndex = 8;
            label5.Text = "Số nguyên tố thứ nhất";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 471);
            label1.Name = "label1";
            label1.Size = new Size(240, 32);
            label1.TabIndex = 9;
            label1.Text = "Số nguyên tố thứ hai";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 693);
            label2.Name = "label2";
            label2.Size = new Size(257, 32);
            label2.TabIndex = 10;
            label2.Text = "Ước số chung lớn nhất";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(47, 291);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(1222, 151);
            richTextBox3.TabIndex = 11;
            richTextBox3.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(47, 517);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1222, 159);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(47, 749);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(1222, 160);
            richTextBox2.TabIndex = 13;
            richTextBox2.Text = "";
            // 
            // Exercise2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 946);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(richTextBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label4);
            Name = "Exercise2";
            Text = "Exercise2";
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
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
    }
}