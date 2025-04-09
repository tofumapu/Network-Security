using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberTheory
{
    public partial class Exercise2 : Form
    {
        public Exercise2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tìm ước số chung lớn nhất - khoảng số lớn nhất có thể xử lý được là một số có 2^31 - 1 bit ở .NET9", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        static BigInteger GCD(BigInteger a, BigInteger b)
        {
            a = BigInteger.Abs(a);
            b = BigInteger.Abs(b);
            while (b != 0)
            {
                BigInteger temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (BigInteger.TryParse(richTextBox3.Text, out BigInteger number) && BigInteger.TryParse(richTextBox1.Text, out BigInteger number1))
            {
                if (number == 0 && number1 == 0)
                {
                    MessageBox.Show("Không thể tính GCD của hai số 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                BigInteger gcd = GCD(number, number1);
                richTextBox2.Text = $"Ước chung lớn nhất (GCD) của {number} và {number1}: {gcd}";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
