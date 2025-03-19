using System.Drawing;
using System.Windows.Forms;

namespace LAB01
{
    partial class CaesarCipher
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(32, 223);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(617, 571);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(675, 223);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(629, 571);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(999, 56);
            button1.Name = "button1";
            button1.Size = new Size(305, 96);
            button1.TabIndex = 2;
            button1.Text = "Decrypt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(527, 74);
            label1.Name = "label1";
            label1.Size = new Size(260, 50);
            label1.TabIndex = 3;
            label1.Text = "CaesarCipher";
            // 
            // button2
            // 
            button2.Location = new Point(32, 56);
            button2.Name = "button2";
            button2.Size = new Size(305, 96);
            button2.TabIndex = 4;
            button2.Text = "Encrypt";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 171);
            label2.Name = "label2";
            label2.Size = new Size(268, 32);
            label2.TabIndex = 5;
            label2.Text = "Key (Input is a number):";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(306, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1017, 168);
            label3.Name = "label3";
            label3.Size = new Size(272, 32);
            label3.TabIndex = 7;
            label3.Text = "Brute-force (use no key)";
            // 
            // CaesarCipher
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 834);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Name = "CaesarCipher";
            Text = "Task2_1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button button1;
        private Label label1;
        private Button button2;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
    }
}