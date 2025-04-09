namespace NumberTheory
{
    partial class GenerateRandomPrimeNumber
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            richTextBox5 = new RichTextBox();
            richTextBox6 = new RichTextBox();
            richTextBox7 = new RichTextBox();
            richTextBox8 = new RichTextBox();
            richTextBox9 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Miller-Rabin Test", "Solovay-Strassen Test", "Fermat Test" });
            comboBox1.Location = new Point(420, 132);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(393, 40);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 132);
            label1.Name = "label1";
            label1.Size = new Size(360, 32);
            label1.TabIndex = 1;
            label1.Text = "Algorithm to test prime number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 128);
            label2.Location = new Point(393, 18);
            label2.Name = "label2";
            label2.Size = new Size(420, 71);
            label2.TabIndex = 5;
            label2.Text = "Generate Prime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 209);
            label3.Name = "label3";
            label3.Size = new Size(292, 32);
            label3.TabIndex = 6;
            label3.Text = "Type of generate number:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "To be entered independently of each other", "Both are equal (you just need to enter one)" });
            comboBox2.Location = new Point(352, 209);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(586, 40);
            comboBox2.TabIndex = 7;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 304);
            label4.Name = "label4";
            label4.Size = new Size(192, 32);
            label4.TabIndex = 8;
            label4.Text = "Prime number p:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(420, 304);
            label5.Name = "label5";
            label5.Size = new Size(192, 32);
            label5.TabIndex = 9;
            label5.Text = "Prime number q:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(790, 306);
            label6.Name = "label6";
            label6.Size = new Size(147, 32);
            label6.TabIndex = 10;
            label6.Text = "Public key e:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 396);
            label7.Name = "label7";
            label7.Size = new Size(74, 32);
            label7.TabIndex = 11;
            label7.Text = "From:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(54, 491);
            label8.Name = "label8";
            label8.Size = new Size(44, 32);
            label8.TabIndex = 12;
            label8.Text = "To:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(420, 396);
            label9.Name = "label9";
            label9.Size = new Size(74, 32);
            label9.TabIndex = 13;
            label9.Text = "From:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(790, 396);
            label10.Name = "label10";
            label10.Size = new Size(74, 32);
            label10.TabIndex = 14;
            label10.Text = "From:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(420, 491);
            label11.Name = "label11";
            label11.Size = new Size(44, 32);
            label11.TabIndex = 15;
            label11.Text = "To:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(790, 491);
            label12.Name = "label12";
            label12.Size = new Size(44, 32);
            label12.TabIndex = 16;
            label12.Text = "To:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(54, 588);
            label13.Name = "label13";
            label13.Size = new Size(83, 32);
            label13.TabIndex = 17;
            label13.Text = "Result:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(420, 588);
            label14.Name = "label14";
            label14.Size = new Size(83, 32);
            label14.TabIndex = 18;
            label14.Text = "Result:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(790, 588);
            label15.Name = "label15";
            label15.Size = new Size(83, 32);
            label15.TabIndex = 19;
            label15.Text = "Result:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(134, 376);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(266, 72);
            richTextBox1.TabIndex = 20;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(500, 376);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(266, 72);
            richTextBox2.TabIndex = 21;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(880, 376);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(266, 72);
            richTextBox3.TabIndex = 22;
            richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(134, 488);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(266, 72);
            richTextBox4.TabIndex = 23;
            richTextBox4.Text = "";
            richTextBox4.TextChanged += richTextBox4_TextChanged;
            // 
            // richTextBox5
            // 
            richTextBox5.Location = new Point(500, 488);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(266, 72);
            richTextBox5.TabIndex = 24;
            richTextBox5.Text = "";
            // 
            // richTextBox6
            // 
            richTextBox6.Location = new Point(880, 488);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.Size = new Size(266, 72);
            richTextBox6.TabIndex = 25;
            richTextBox6.Text = "";
            // 
            // richTextBox7
            // 
            richTextBox7.Location = new Point(134, 585);
            richTextBox7.Name = "richTextBox7";
            richTextBox7.Size = new Size(266, 72);
            richTextBox7.TabIndex = 26;
            richTextBox7.Text = "";
            // 
            // richTextBox8
            // 
            richTextBox8.Location = new Point(500, 588);
            richTextBox8.Name = "richTextBox8";
            richTextBox8.Size = new Size(266, 72);
            richTextBox8.TabIndex = 27;
            richTextBox8.Text = "";
            // 
            // richTextBox9
            // 
            richTextBox9.Location = new Point(880, 585);
            richTextBox9.Name = "richTextBox9";
            richTextBox9.Size = new Size(266, 72);
            richTextBox9.TabIndex = 28;
            richTextBox9.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(675, 702);
            button1.Name = "button1";
            button1.Size = new Size(251, 84);
            button1.TabIndex = 29;
            button1.Text = "Generate/Regenerate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(955, 702);
            button2.Name = "button2";
            button2.Size = new Size(178, 84);
            button2.TabIndex = 30;
            button2.Text = "Apply";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // GenerateRandomPrimeNumber
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 812);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox9);
            Controls.Add(richTextBox8);
            Controls.Add(richTextBox7);
            Controls.Add(richTextBox6);
            Controls.Add(richTextBox5);
            Controls.Add(richTextBox4);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "GenerateRandomPrimeNumber";
            Text = "GenerateRandomPrimeNumber";
            FormClosed += GenerateRandomPrimeNumber_FormClosed;
            Load += GenerateRandomPrimeNumber_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox5;
        private RichTextBox richTextBox6;
        public RichTextBox richTextBox7;
        public RichTextBox richTextBox8;
        public RichTextBox richTextBox9;
        private Button button1;
        private Button button2;
    }
}