using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace NumberTheory
{
    public partial class Exercise3 : Form
    {
        public Exercise3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Công thức modulo số mũ là a^x mod p, chương trình có thể chạy với số cực lớn!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        static BigInteger ModularExponentiation(BigInteger baseNum, BigInteger exponent, BigInteger modulus)
        {
            if (modulus == 1) return 0;
            BigInteger result = 1;
            baseNum %= modulus;
            while (exponent > 0)
            {
                if ((exponent & 1) == 1)
                    result = (result * baseNum) % modulus;
                exponent >>= 1;
                baseNum = (baseNum * baseNum) % modulus;
            }
            return result;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string input1 = richTextBox5.Text;
            string input2 = richTextBox1.Text;
            string input3 = richTextBox2.Text;
            string input4 = richTextBox3.Text;
            if (string.IsNullOrWhiteSpace(input1) || string.IsNullOrWhiteSpace(input2) || string.IsNullOrWhiteSpace(input3))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các số nguyên dương!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!BigInteger.TryParse(input1, out BigInteger a) || !BigInteger.TryParse(input2, out BigInteger x) || !BigInteger.TryParse(input3, out BigInteger p))
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                richTextBox3.AppendText("Kết quả của " + a.ToString() + "^" + x.ToString() + " mod " + p.ToString() + " là: ");
                BigInteger result = ModularExponentiation(a, x, p);
                richTextBox3.AppendText(result.ToString() + "\n");
            }

        }
    }
}
