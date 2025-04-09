namespace NumberTheory
{
    partial class Exercise1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            richTextBox2 = new RichTextBox();
            button3 = new Button();
            button2 = new Button();
            label3 = new Label();
            tabPage3 = new TabPage();
            label6 = new Label();
            label5 = new Label();
            richTextBox4 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            button5 = new Button();
            button4 = new Button();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1064, 907);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1048, 853);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Yêu cầu 1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(833, 160);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 4;
            button1.Text = "Tạo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(52, 248);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(931, 319);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "8", "16", "64" });
            comboBox1.Location = new Point(300, 160);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(149, 40);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 163);
            label2.Name = "label2";
            label2.Size = new Size(227, 32);
            label2.TabIndex = 1;
            label2.Text = "Số bit cần generate:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 128);
            label1.Location = new Point(167, 39);
            label1.Name = "label1";
            label1.Size = new Size(704, 71);
            label1.TabIndex = 0;
            label1.Text = "Generate Random Number";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(richTextBox2);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1048, 853);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Yêu cầu 2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(32, 201);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(982, 622);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            // 
            // button3
            // 
            button3.Location = new Point(812, 143);
            button3.Name = "button3";
            button3.Size = new Size(37, 46);
            button3.TabIndex = 3;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(864, 143);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 2;
            button2.Text = "Thực hiện";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 128, 128);
            label3.Location = new Point(21, 70);
            label3.Name = "label3";
            label3.Size = new Size(1010, 40);
            label3.TabIndex = 1;
            label3.Text = "Tìm 10 số nguyên tố lớn nhất (dưới 10 số nguyên tố Mersenne đầu tiên)";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(richTextBox4);
            tabPage3.Controls.Add(richTextBox3);
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(label4);
            tabPage3.Location = new Point(8, 46);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1048, 853);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Yêu cầu 3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 646);
            label6.Name = "label6";
            label6.Size = new Size(269, 32);
            label6.TabIndex = 8;
            label6.Text = "Có phải là số nguyên tố";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 177);
            label5.Name = "label5";
            label5.Size = new Size(158, 32);
            label5.TabIndex = 7;
            label5.Text = "Số nguyên tố";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(328, 622);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(689, 189);
            richTextBox4.TabIndex = 6;
            richTextBox4.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(38, 242);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(979, 362);
            richTextBox3.TabIndex = 5;
            richTextBox3.Text = "";
            // 
            // button5
            // 
            button5.Location = new Point(867, 170);
            button5.Name = "button5";
            button5.Size = new Size(150, 46);
            button5.TabIndex = 4;
            button5.Text = "Kiểm tra";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(775, 170);
            button4.Name = "button4";
            button4.Size = new Size(72, 46);
            button4.TabIndex = 3;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 128, 128);
            label4.Location = new Point(246, 59);
            label4.Name = "label4";
            label4.Size = new Size(582, 71);
            label4.TabIndex = 2;
            label4.Text = "Kiểm tra số nguyên tố";
            // 
            // Exercise1
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 940);
            Controls.Add(tabControl1);
            Name = "Exercise1";
            Text = "Exercise1";
            Load += Exercise1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RichTextBox richTextBox1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private TabPage tabPage3;
        private Button button1;
        private Label label3;
        private Button button2;
        private Button button3;
        private RichTextBox richTextBox2;
        private Label label4;
        private Label label6;
        private Label label5;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox3;
        private Button button5;
        private Button button4;
    }
}