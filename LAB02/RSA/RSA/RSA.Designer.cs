namespace RSA
{
    partial class RSA
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            richTextBox4 = new RichTextBox();
            richTextBox5 = new RichTextBox();
            richTextBox6 = new RichTextBox();
            label8 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label9 = new Label();
            label10 = new Label();
            richTextBox7 = new RichTextBox();
            richTextBox8 = new RichTextBox();
            label11 = new Label();
            label12 = new Label();
            button6 = new Button();
            label13 = new Label();
            label14 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 128);
            label1.Location = new Point(621, 9);
            label1.Name = "label1";
            label1.Size = new Size(402, 71);
            label1.TabIndex = 4;
            label1.Text = "RSA Algorithm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 116);
            label2.Name = "label2";
            label2.Size = new Size(192, 32);
            label2.TabIndex = 5;
            label2.Text = "Prime number p:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 189);
            label3.Name = "label3";
            label3.Size = new Size(192, 32);
            label3.TabIndex = 6;
            label3.Text = "Prime number q:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 262);
            label4.Name = "label4";
            label4.Size = new Size(147, 32);
            label4.TabIndex = 7;
            label4.Text = "Public key e:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(268, 113);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1063, 54);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(268, 186);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(1063, 54);
            richTextBox2.TabIndex = 9;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(268, 259);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(1063, 54);
            richTextBox3.TabIndex = 10;
            richTextBox3.Text = "";
            richTextBox3.TextChanged += richTextBox3_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(1387, 109);
            button1.Name = "button1";
            button1.Size = new Size(192, 137);
            button1.TabIndex = 11;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 375);
            label5.Name = "label5";
            label5.Size = new Size(187, 32);
            label5.TabIndex = 12;
            label5.Text = "RSA Modulus N:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 438);
            label6.Name = "label6";
            label6.Size = new Size(217, 32);
            label6.TabIndex = 13;
            label6.Text = "phi(N) = (p-1)(q-1):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 507);
            label7.Name = "label7";
            label7.Size = new Size(156, 32);
            label7.TabIndex = 14;
            label7.Text = "Private key d:";
            // 
            // richTextBox4
            // 
            richTextBox4.Enabled = false;
            richTextBox4.Location = new Point(268, 372);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(1063, 54);
            richTextBox4.TabIndex = 15;
            richTextBox4.Text = "";
            richTextBox4.TextChanged += richTextBox4_TextChanged;
            // 
            // richTextBox5
            // 
            richTextBox5.Enabled = false;
            richTextBox5.Location = new Point(268, 438);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(1063, 54);
            richTextBox5.TabIndex = 16;
            richTextBox5.Text = "";
            // 
            // richTextBox6
            // 
            richTextBox6.Enabled = false;
            richTextBox6.Location = new Point(268, 504);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.Size = new Size(1063, 54);
            richTextBox6.TabIndex = 17;
            richTextBox6.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(52, 48);
            label8.Name = "label8";
            label8.Size = new Size(86, 32);
            label8.TabIndex = 18;
            label8.Text = "Step 1:";
            // 
            // button2
            // 
            button2.Location = new Point(1029, 21);
            button2.Name = "button2";
            button2.Size = new Size(53, 47);
            button2.TabIndex = 19;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1454, 262);
            button3.Name = "button3";
            button3.Size = new Size(53, 47);
            button3.TabIndex = 20;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(58, 641);
            button4.Name = "button4";
            button4.Size = new Size(199, 77);
            button4.TabIndex = 21;
            button4.Text = "Encrypt";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1387, 641);
            button5.Name = "button5";
            button5.Size = new Size(199, 77);
            button5.TabIndex = 22;
            button5.Text = "Decrypt";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(60, 731);
            label9.Name = "label9";
            label9.Size = new Size(75, 32);
            label9.TabIndex = 23;
            label9.Text = "Input:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(858, 731);
            label10.Name = "label10";
            label10.Size = new Size(95, 32);
            label10.TabIndex = 24;
            label10.Text = "Output:";
            // 
            // richTextBox7
            // 
            richTextBox7.Location = new Point(69, 789);
            richTextBox7.Name = "richTextBox7";
            richTextBox7.Size = new Size(728, 567);
            richTextBox7.TabIndex = 25;
            richTextBox7.Text = "";
            // 
            // richTextBox8
            // 
            richTextBox8.Location = new Point(858, 789);
            richTextBox8.Name = "richTextBox8";
            richTextBox8.Size = new Size(728, 567);
            richTextBox8.TabIndex = 26;
            richTextBox8.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(58, 589);
            label11.Name = "label11";
            label11.Size = new Size(86, 32);
            label11.TabIndex = 27;
            label11.Text = "Step 2:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(52, 332);
            label12.Name = "label12";
            label12.Size = new Size(278, 32);
            label12.TabIndex = 28;
            label12.Text = "Calculate Automatically...";
            // 
            // button6
            // 
            button6.Location = new Point(277, 656);
            button6.Name = "button6";
            button6.Size = new Size(53, 47);
            button6.TabIndex = 29;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(144, 48);
            label13.Name = "label13";
            label13.Size = new Size(142, 32);
            label13.TabIndex = 30;
            label13.Text = "Input p, q, e";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(150, 589);
            label14.Name = "label14";
            label14.Size = new Size(217, 32);
            label14.TabIndex = 31;
            label14.Text = "Input the message.";
            // 
            // RSA
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1650, 1403);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(button6);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(richTextBox8);
            Controls.Add(richTextBox7);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(richTextBox6);
            Controls.Add(richTextBox5);
            Controls.Add(richTextBox4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RSA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RSA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private Button button1;
        private Label label5;
        private Label label6;
        private Label label7;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox5;
        private RichTextBox richTextBox6;
        private Label label8;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label9;
        private Label label10;
        private RichTextBox richTextBox7;
        private RichTextBox richTextBox8;
        private Label label11;
        private Label label12;
        private Button button6;
        private Label label13;
        private Label label14;
    }
}