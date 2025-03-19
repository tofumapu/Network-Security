using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB01
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        private void btn_BaiTap1_Click(object sender, EventArgs e)
        {
            CaesarCipher lab1_BaiTap1 = new CaesarCipher();
            lab1_BaiTap1.ShowDialog();
        }

        private void btn_BaiTap2_Click(object sender, EventArgs e)
        {
            Playfair lab1_BaiTap2 = new Playfair();
            lab1_BaiTap2.ShowDialog();
        }
        private void btn_BaiTap3_Click(object sender, EventArgs e)
        {
            Vigenere lab1_BaiTap3 = new Vigenere();
            lab1_BaiTap3.ShowDialog();
        }
        private void btn_BaiTap4_Click(object sender, EventArgs e)
        {
            XOR lab1_BaiTap4 = new XOR();
            lab1_BaiTap4.ShowDialog();
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_BaiTap5_Click(object sender, EventArgs e)
        {
            //Lab2_BaiTap5 BaiTap5 = new Lab2_BaiTap5();
            //BaiTap5.ShowDialog();
        }
    }
}
