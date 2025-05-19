namespace HashCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            richTextBox5 = new RichTextBox();
            checkBox4 = new CheckBox();
            richTextBox6 = new RichTextBox();
            checkBox5 = new CheckBox();
            richTextBox7 = new RichTextBox();
            checkBox6 = new CheckBox();
            richTextBox8 = new RichTextBox();
            checkBox7 = new CheckBox();
            richTextBox9 = new RichTextBox();
            checkBox8 = new CheckBox();
            richTextBox10 = new RichTextBox();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            richTextBox11 = new RichTextBox();
            richTextBox12 = new RichTextBox();
            checkBox11 = new CheckBox();
            richTextBox13 = new RichTextBox();
            checkBox12 = new CheckBox();
            richTextBox14 = new RichTextBox();
            checkBox13 = new CheckBox();
            richTextBox15 = new RichTextBox();
            checkBox14 = new CheckBox();
            richTextBox16 = new RichTextBox();
            checkBox15 = new CheckBox();
            richTextBox17 = new RichTextBox();
            checkBox16 = new CheckBox();
            richTextBox18 = new RichTextBox();
            checkBox17 = new CheckBox();
            richTextBox19 = new RichTextBox();
            checkBox18 = new CheckBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Text string", "Hex string", "File" });
            comboBox1.Location = new Point(32, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 40);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 19);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 1;
            label1.Text = "Data Format:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 19);
            label2.Name = "label2";
            label2.Size = new Size(68, 32);
            label2.TabIndex = 2;
            label2.Text = "Data:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(274, 65);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(972, 122);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(25, 276);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(98, 36);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "MD5";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(25, 332);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(114, 36);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "SHA-1";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(25, 392);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(140, 36);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "SHA-256";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(183, 276);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(1018, 36);
            richTextBox2.TabIndex = 7;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(183, 332);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new Size(1018, 36);
            richTextBox3.TabIndex = 8;
            richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(183, 390);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.ReadOnly = true;
            richTextBox4.Size = new Size(1018, 36);
            richTextBox4.TabIndex = 9;
            richTextBox4.Text = "";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(915, 1273);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 10;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1089, 1273);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 11;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 1273);
            label3.Name = "label3";
            label3.Size = new Size(337, 32);
            label3.TabIndex = 12;
            label3.Text = "23520231 - 23520266 - LAB04";
            // 
            // richTextBox5
            // 
            richTextBox5.Location = new Point(183, 454);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.ReadOnly = true;
            richTextBox5.Size = new Size(1018, 36);
            richTextBox5.TabIndex = 14;
            richTextBox5.Text = "";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(25, 456);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(140, 36);
            checkBox4.TabIndex = 13;
            checkBox4.Text = "SHA-384";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // richTextBox6
            // 
            richTextBox6.Location = new Point(183, 510);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.ReadOnly = true;
            richTextBox6.Size = new Size(1018, 36);
            richTextBox6.TabIndex = 16;
            richTextBox6.Text = "";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(25, 512);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(140, 36);
            checkBox5.TabIndex = 15;
            checkBox5.Text = "SHA-512";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // richTextBox7
            // 
            richTextBox7.Location = new Point(183, 567);
            richTextBox7.Name = "richTextBox7";
            richTextBox7.ReadOnly = true;
            richTextBox7.Size = new Size(1018, 36);
            richTextBox7.TabIndex = 18;
            richTextBox7.Text = "";
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(25, 569);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(140, 36);
            checkBox6.TabIndex = 17;
            checkBox6.Text = "SHA-224";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // richTextBox8
            // 
            richTextBox8.Location = new Point(249, 626);
            richTextBox8.Name = "richTextBox8";
            richTextBox8.ReadOnly = true;
            richTextBox8.Size = new Size(952, 36);
            richTextBox8.TabIndex = 20;
            richTextBox8.Text = "";
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(25, 626);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(225, 36);
            checkBox7.TabIndex = 19;
            checkBox7.Text = "Double SHA-256";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // richTextBox9
            // 
            richTextBox9.Location = new Point(129, 689);
            richTextBox9.Name = "richTextBox9";
            richTextBox9.ReadOnly = true;
            richTextBox9.Size = new Size(1072, 36);
            richTextBox9.TabIndex = 22;
            richTextBox9.Text = "";
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(25, 689);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(98, 36);
            checkBox8.TabIndex = 21;
            checkBox8.Text = "MD2";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // richTextBox10
            // 
            richTextBox10.Location = new Point(129, 751);
            richTextBox10.Name = "richTextBox10";
            richTextBox10.ReadOnly = true;
            richTextBox10.Size = new Size(1072, 36);
            richTextBox10.TabIndex = 24;
            richTextBox10.Text = "";
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(25, 751);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(98, 36);
            checkBox9.TabIndex = 23;
            checkBox9.Text = "MD4";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(25, 811);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(179, 36);
            checkBox10.TabIndex = 25;
            checkBox10.Text = "RIPEMD-128";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // richTextBox11
            // 
            richTextBox11.Location = new Point(210, 811);
            richTextBox11.Name = "richTextBox11";
            richTextBox11.ReadOnly = true;
            richTextBox11.Size = new Size(991, 36);
            richTextBox11.TabIndex = 26;
            richTextBox11.Text = "";
            // 
            // richTextBox12
            // 
            richTextBox12.Location = new Point(210, 867);
            richTextBox12.Name = "richTextBox12";
            richTextBox12.ReadOnly = true;
            richTextBox12.Size = new Size(991, 36);
            richTextBox12.TabIndex = 28;
            richTextBox12.Text = "";
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(25, 867);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(179, 36);
            checkBox11.TabIndex = 27;
            checkBox11.Text = "RIPEMD-160";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // richTextBox13
            // 
            richTextBox13.Location = new Point(210, 925);
            richTextBox13.Name = "richTextBox13";
            richTextBox13.ReadOnly = true;
            richTextBox13.Size = new Size(991, 36);
            richTextBox13.TabIndex = 30;
            richTextBox13.Text = "";
            // 
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.Location = new Point(25, 925);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(179, 36);
            checkBox12.TabIndex = 29;
            checkBox12.Text = "RIPEMD-256";
            checkBox12.UseVisualStyleBackColor = true;
            // 
            // richTextBox14
            // 
            richTextBox14.Location = new Point(210, 982);
            richTextBox14.Name = "richTextBox14";
            richTextBox14.ReadOnly = true;
            richTextBox14.Size = new Size(991, 36);
            richTextBox14.TabIndex = 32;
            richTextBox14.Text = "";
            // 
            // checkBox13
            // 
            checkBox13.AutoSize = true;
            checkBox13.Location = new Point(25, 982);
            checkBox13.Name = "checkBox13";
            checkBox13.Size = new Size(179, 36);
            checkBox13.TabIndex = 31;
            checkBox13.Text = "RIPEMD-320";
            checkBox13.UseVisualStyleBackColor = true;
            // 
            // richTextBox15
            // 
            richTextBox15.Location = new Point(157, 1037);
            richTextBox15.Name = "richTextBox15";
            richTextBox15.ReadOnly = true;
            richTextBox15.Size = new Size(1044, 36);
            richTextBox15.TabIndex = 34;
            richTextBox15.Text = "";
            // 
            // checkBox14
            // 
            checkBox14.AutoSize = true;
            checkBox14.Location = new Point(25, 1037);
            checkBox14.Name = "checkBox14";
            checkBox14.Size = new Size(126, 36);
            checkBox14.TabIndex = 33;
            checkBox14.Text = "CRC-32";
            checkBox14.UseVisualStyleBackColor = true;
            // 
            // richTextBox16
            // 
            richTextBox16.Location = new Point(157, 1090);
            richTextBox16.Name = "richTextBox16";
            richTextBox16.ReadOnly = true;
            richTextBox16.Size = new Size(1044, 36);
            richTextBox16.TabIndex = 36;
            richTextBox16.Text = "";
            // 
            // checkBox15
            // 
            checkBox15.AutoSize = true;
            checkBox15.Location = new Point(25, 1090);
            checkBox15.Name = "checkBox15";
            checkBox15.Size = new Size(126, 36);
            checkBox15.TabIndex = 35;
            checkBox15.Text = "CRC-64";
            checkBox15.UseVisualStyleBackColor = true;
            // 
            // richTextBox17
            // 
            richTextBox17.Location = new Point(197, 1145);
            richTextBox17.Name = "richTextBox17";
            richTextBox17.ReadOnly = true;
            richTextBox17.Size = new Size(1004, 36);
            richTextBox17.TabIndex = 38;
            richTextBox17.Text = "";
            // 
            // checkBox16
            // 
            checkBox16.AutoSize = true;
            checkBox16.Location = new Point(25, 1145);
            checkBox16.Name = "checkBox16";
            checkBox16.Size = new Size(166, 36);
            checkBox16.TabIndex = 37;
            checkBox16.Text = "SHAKE-128";
            checkBox16.UseVisualStyleBackColor = true;
            // 
            // richTextBox18
            // 
            richTextBox18.Location = new Point(197, 1201);
            richTextBox18.Name = "richTextBox18";
            richTextBox18.ReadOnly = true;
            richTextBox18.Size = new Size(1004, 36);
            richTextBox18.TabIndex = 40;
            richTextBox18.Text = "";
            // 
            // checkBox17
            // 
            checkBox17.AutoSize = true;
            checkBox17.Location = new Point(25, 1201);
            checkBox17.Name = "checkBox17";
            checkBox17.Size = new Size(166, 36);
            checkBox17.TabIndex = 39;
            checkBox17.Text = "SHAKE-256";
            checkBox17.UseVisualStyleBackColor = true;
            // 
            // richTextBox19
            // 
            richTextBox19.Location = new Point(183, 215);
            richTextBox19.Name = "richTextBox19";
            richTextBox19.Size = new Size(1018, 36);
            richTextBox19.TabIndex = 42;
            richTextBox19.Text = "";
            // 
            // checkBox18
            // 
            checkBox18.AutoSize = true;
            checkBox18.Location = new Point(25, 215);
            checkBox18.Name = "checkBox18";
            checkBox18.Size = new Size(115, 36);
            checkBox18.TabIndex = 41;
            checkBox18.Text = "HMAC";
            checkBox18.UseVisualStyleBackColor = true;
            checkBox18.CheckedChanged += checkBox18_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(181, 165);
            label4.Name = "label4";
            label4.Size = new Size(58, 32);
            label4.TabIndex = 43;
            label4.Text = "Key:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 1332);
            Controls.Add(label4);
            Controls.Add(richTextBox19);
            Controls.Add(checkBox18);
            Controls.Add(richTextBox18);
            Controls.Add(checkBox17);
            Controls.Add(richTextBox17);
            Controls.Add(checkBox16);
            Controls.Add(richTextBox16);
            Controls.Add(checkBox15);
            Controls.Add(richTextBox15);
            Controls.Add(checkBox14);
            Controls.Add(richTextBox14);
            Controls.Add(checkBox13);
            Controls.Add(richTextBox13);
            Controls.Add(checkBox12);
            Controls.Add(richTextBox12);
            Controls.Add(checkBox11);
            Controls.Add(richTextBox11);
            Controls.Add(checkBox10);
            Controls.Add(richTextBox10);
            Controls.Add(checkBox9);
            Controls.Add(richTextBox9);
            Controls.Add(checkBox8);
            Controls.Add(richTextBox8);
            Controls.Add(checkBox7);
            Controls.Add(richTextBox7);
            Controls.Add(checkBox6);
            Controls.Add(richTextBox6);
            Controls.Add(checkBox5);
            Controls.Add(richTextBox5);
            Controls.Add(checkBox4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox4);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "HashCalc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private Button button1;
        private Button button2;
        private Label label3;
        private RichTextBox richTextBox5;
        private CheckBox checkBox4;
        private RichTextBox richTextBox6;
        private CheckBox checkBox5;
        private RichTextBox richTextBox7;
        private CheckBox checkBox6;
        private RichTextBox richTextBox8;
        private CheckBox checkBox7;
        private RichTextBox richTextBox9;
        private CheckBox checkBox8;
        private RichTextBox richTextBox10;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private RichTextBox richTextBox11;
        private RichTextBox richTextBox12;
        private CheckBox checkBox11;
        private RichTextBox richTextBox13;
        private CheckBox checkBox12;
        private RichTextBox richTextBox14;
        private CheckBox checkBox13;
        private RichTextBox richTextBox15;
        private CheckBox checkBox14;
        private RichTextBox richTextBox16;
        private CheckBox checkBox15;
        private RichTextBox richTextBox17;
        private CheckBox checkBox16;
        private RichTextBox richTextBox18;
        private CheckBox checkBox17;
        private RichTextBox richTextBox19;
        private CheckBox checkBox18;
        private Label label4;
    }
}
