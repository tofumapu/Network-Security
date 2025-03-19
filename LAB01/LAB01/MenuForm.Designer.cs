using System.Drawing;
using System.Windows.Forms;

namespace LAB01
{
    partial class MenuForm
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
            this.lbl_MenuTitle = new System.Windows.Forms.Label();
            this.btn_BaiTap1 = new System.Windows.Forms.Button();
            this.btn_BaiTap2 = new System.Windows.Forms.Button();
            this.btn_BaiTap3 = new System.Windows.Forms.Button();
            this.btn_BaiTap4 = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_MenuTitle
            // 
            this.lbl_MenuTitle.AutoSize = true;
            this.lbl_MenuTitle.Font = new System.Drawing.Font("Segoe UI", 21.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MenuTitle.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_MenuTitle.Location = new System.Drawing.Point(89, 37);
            this.lbl_MenuTitle.Name = "lbl_MenuTitle";
            this.lbl_MenuTitle.Size = new System.Drawing.Size(878, 78);
            this.lbl_MenuTitle.TabIndex = 0;
            this.lbl_MenuTitle.Text = "LAB01: Classical Cryptography";
            // 
            // btn_BaiTap1
            // 
            this.btn_BaiTap1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BaiTap1.Location = new System.Drawing.Point(183, 149);
            this.btn_BaiTap1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BaiTap1.Name = "btn_BaiTap1";
            this.btn_BaiTap1.Size = new System.Drawing.Size(203, 77);
            this.btn_BaiTap1.TabIndex = 1;
            this.btn_BaiTap1.Text = "Caesar";
            this.btn_BaiTap1.UseVisualStyleBackColor = true;
            this.btn_BaiTap1.Click += new System.EventHandler(this.btn_BaiTap1_Click);
            // 
            // btn_BaiTap2
            // 
            this.btn_BaiTap2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BaiTap2.Location = new System.Drawing.Point(613, 149);
            this.btn_BaiTap2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BaiTap2.Name = "btn_BaiTap2";
            this.btn_BaiTap2.Size = new System.Drawing.Size(203, 77);
            this.btn_BaiTap2.TabIndex = 2;
            this.btn_BaiTap2.Text = "Playfair";
            this.btn_BaiTap2.UseVisualStyleBackColor = true;
            this.btn_BaiTap2.Click += new System.EventHandler(this.btn_BaiTap2_Click);
            // 
            // btn_BaiTap3
            // 
            this.btn_BaiTap3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BaiTap3.Location = new System.Drawing.Point(183, 281);
            this.btn_BaiTap3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BaiTap3.Name = "btn_BaiTap3";
            this.btn_BaiTap3.Size = new System.Drawing.Size(203, 77);
            this.btn_BaiTap3.TabIndex = 3;
            this.btn_BaiTap3.Text = "Vigenere";
            this.btn_BaiTap3.UseVisualStyleBackColor = true;
            this.btn_BaiTap3.Click += new System.EventHandler(this.btn_BaiTap3_Click);
            // 
            // btn_BaiTap4
            // 
            this.btn_BaiTap4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BaiTap4.Location = new System.Drawing.Point(613, 281);
            this.btn_BaiTap4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BaiTap4.Name = "btn_BaiTap4";
            this.btn_BaiTap4.Size = new System.Drawing.Size(203, 77);
            this.btn_BaiTap4.TabIndex = 4;
            this.btn_BaiTap4.Text = "XOR";
            this.btn_BaiTap4.UseVisualStyleBackColor = true;
            this.btn_BaiTap4.Click += new System.EventHandler(this.btn_BaiTap4_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(392, 409);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(203, 77);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 547);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_BaiTap4);
            this.Controls.Add(this.btn_BaiTap3);
            this.Controls.Add(this.btn_BaiTap2);
            this.Controls.Add(this.btn_BaiTap1);
            this.Controls.Add(this.lbl_MenuTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab1_MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_MenuTitle;
        private Button btn_BaiTap1;
        private Button btn_BaiTap2;
        private Button btn_BaiTap3;
        private Button btn_BaiTap4;
        private Button btn_Exit;
    }
}