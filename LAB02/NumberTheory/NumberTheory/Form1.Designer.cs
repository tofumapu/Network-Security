namespace NumberTheory
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_MenuTitle = new Label();
            btn_BaiTap1 = new Button();
            btn_BaiTap2 = new Button();
            btn_BaiTap3 = new Button();
            btn_Exit = new Button();
            SuspendLayout();
            // 
            // lbl_MenuTitle
            // 
            lbl_MenuTitle.AutoSize = true;
            lbl_MenuTitle.Font = new Font("Segoe UI", 21.85714F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_MenuTitle.ForeColor = Color.IndianRed;
            lbl_MenuTitle.Location = new Point(211, 130);
            lbl_MenuTitle.Name = "lbl_MenuTitle";
            lbl_MenuTitle.Size = new Size(684, 78);
            lbl_MenuTitle.TabIndex = 0;
            lbl_MenuTitle.Text = "LAB02: Number Theory";
            // 
            // btn_BaiTap1
            // 
            btn_BaiTap1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_BaiTap1.Location = new Point(211, 262);
            btn_BaiTap1.Name = "btn_BaiTap1";
            btn_BaiTap1.Size = new Size(220, 99);
            btn_BaiTap1.TabIndex = 1;
            btn_BaiTap1.Text = "Bài tập 1";
            btn_BaiTap1.UseVisualStyleBackColor = true;
            btn_BaiTap1.Click += btn_BaiTap1_Click;
            // 
            // btn_BaiTap2
            // 
            btn_BaiTap2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_BaiTap2.Location = new Point(677, 262);
            btn_BaiTap2.Name = "btn_BaiTap2";
            btn_BaiTap2.Size = new Size(220, 99);
            btn_BaiTap2.TabIndex = 2;
            btn_BaiTap2.Text = "Bài tập 2";
            btn_BaiTap2.UseVisualStyleBackColor = true;
            btn_BaiTap2.Click += btn_BaiTap2_Click;
            // 
            // btn_BaiTap3
            // 
            btn_BaiTap3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_BaiTap3.Location = new Point(211, 431);
            btn_BaiTap3.Name = "btn_BaiTap3";
            btn_BaiTap3.Size = new Size(220, 99);
            btn_BaiTap3.TabIndex = 3;
            btn_BaiTap3.Text = "Bài tập 3";
            btn_BaiTap3.UseVisualStyleBackColor = true;
            btn_BaiTap3.Click += btn_BaiTap3_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(677, 431);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(220, 99);
            btn_Exit.TabIndex = 6;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 700);
            Controls.Add(btn_Exit);
            Controls.Add(btn_BaiTap3);
            Controls.Add(btn_BaiTap2);
            Controls.Add(btn_BaiTap1);
            Controls.Add(lbl_MenuTitle);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab2_MenuForm";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label lbl_MenuTitle;
        private Button btn_BaiTap1;
        private Button btn_BaiTap2;
        private Button btn_BaiTap3;
        private Button btn_Exit;
    }
}
