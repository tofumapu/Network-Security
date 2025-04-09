using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberTheory
{
    public partial class RSA : Form
    {
        public RSA()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RSA (Rivest–Shamir–Adleman) cryptosystem is a public-key cryptosystem, one of the oldest widely used for secure data transmission.\n Follow this to read more information about RSA: https://en.wikipedia.org/wiki/RSA_cryptosystem", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You need to input the prime number p, prime number q, public key e (also a prime number) or generate random number on 'Generate' button", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            GenerateRandomPrimeNumber generateRandomPrimeNumber = new GenerateRandomPrimeNumber();
            generateRandomPrimeNumber.ShowDialog();
            // Nếu form GenerateRandomPrimeNumber đã đóng
            if (generateRandomPrimeNumber.DialogResult == DialogResult.OK)
            {
                richTextBox1.Text = generateRandomPrimeNumber.richTextBox7.Text;
                richTextBox2.Text = generateRandomPrimeNumber.richTextBox8.Text;
                richTextBox3.Text = generateRandomPrimeNumber.richTextBox9.Text;
            }
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private bool isUpdating = false; // Ngăn vòng lặp vô hạn khi thay đổi text

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!BigInteger.TryParse(richTextBox1.Text, out BigInteger e1) && richTextBox1.Text != "")
            {
                MessageBox.Show("You need to input a prime number for p", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox1.Text = "";
            }
            else
            {
                CalculateRSAValues();
            }
            CalculateRSAValues();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (!BigInteger.TryParse(richTextBox2.Text, out BigInteger e2) && richTextBox2.Text != "")
            {
                MessageBox.Show("You need to input a prime number for q", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox2.Text = "";
            }
            else
            {
                CalculateRSAValues();
            }
            CalculateRSAValues();
        }

        private void CalculateRSAValues()
        {
            if (isUpdating) return;
            isUpdating = true;

            BigInteger p, q;
            if (BigInteger.TryParse(richTextBox1.Text, out p) &&
                BigInteger.TryParse(richTextBox2.Text, out q))
            {
                BigInteger n = p * q;
                richTextBox4.Text = n.ToString();

                BigInteger phi = (p - 1) * (q - 1);
                richTextBox5.Text = phi.ToString();

                BigInteger e = richTextBox3.Text == "" ? 0 : BigInteger.Parse(richTextBox3.Text);
                BigInteger d = 0;
                if (e != 0)
                {
                    d = CalculatePrivateKeyD(e, phi);
                }
                if (d != -1)
                    richTextBox6.Text = d.ToString(); // Gán d vào richTextBox6 chẳng hạn
                else
                    richTextBox6.Text = "Không tìm được d";
            }

            isUpdating = false;
        }

        private BigInteger CalculatePrivateKeyD(BigInteger e, BigInteger phi)
        {
            // Tìm x sao cho (x * phi + 1) % e == 0
            // => d = (x * phi + 1) / e
            for (BigInteger x = 1; x < 10000; x++) // giới hạn 10000 lần để tránh vô hạn
            {
                BigInteger numerator = x * phi + 1;
                if (numerator % e == 0)
                {
                    return numerator / e;
                }
            }
            return -1; // Không tìm thấy d hợp lệ
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (!BigInteger.TryParse(richTextBox3.Text, out BigInteger e3) && richTextBox3.Text != "")
            {
                MessageBox.Show("You need to input a prime number for e", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox3.Text = "";
            }
            else
            {
                CalculateRSAValues();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You need to type the message to encrypt/decrypt first, then you click the button encrypt/decrypt.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private bool IsNumeric(string input)
        {
            return BigInteger.TryParse(input, out _);
        }
        private BigInteger StringToBigInteger(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            return new BigInteger(bytes, isUnsigned: true, isBigEndian: true);
        }
        private string BigIntegerToString(BigInteger number)
        {
            byte[] bytes = number.ToByteArray(isUnsigned: true, isBigEndian: true);
            return Encoding.UTF8.GetString(bytes);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (!BigInteger.TryParse(richTextBox3.Text, out BigInteger ePublic) ||
                    !BigInteger.TryParse(richTextBox4.Text, out BigInteger n))
                {
                    MessageBox.Show("Invalid public key (e) or modulus (n).");
                    return;
                }

                string message = richTextBox7.Text;
                BigInteger m;

                if (IsNumeric(message)) // Dữ liệu là số
                {
                    m = BigInteger.Parse(message);
                }
                else // Dữ liệu là chuỗi
                {
                    m = StringToBigInteger(message);
                }

                if (m >= n)
                {
                    MessageBox.Show("Message too large. Use shorter text or larger keys.");
                    return;
                }

                BigInteger c = ModularExponentiation(m, ePublic, n);
                richTextBox8.Text = c.ToString(); // luôn lưu ciphertext dạng số
            }
            catch (Exception ex)
            {
                MessageBox.Show("Encryption failed: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (!BigInteger.TryParse(richTextBox6.Text, out BigInteger dPrivate) ||
                    !BigInteger.TryParse(richTextBox4.Text, out BigInteger n) ||
                    !BigInteger.TryParse(richTextBox7.Text, out BigInteger c))
                {
                    MessageBox.Show("Invalid private key (d), modulus (n), or ciphertext.");
                    return;
                }

                BigInteger m = ModularExponentiation(c, dPrivate, n);

                // Hiển thị kết quả dạng số
                richTextBox8.Text = m.ToString();

                // Thử chuyển sang chuỗi
                try
                {
                    string decryptedString = BigIntegerToString(m);

                    // Nếu chuỗi có nội dung hợp lệ, hiển thị
                    if (!string.IsNullOrWhiteSpace(decryptedString))
                    {
                        richTextBox8.Text += '\n' + "String data: " + decryptedString;
                    }
                    else
                    {
                        richTextBox8.Text += '\n' + "String data: " + "(Không thể giải mã thành chuỗi)";

                    }
                }
                catch
                {
                    richTextBox8.Text += '\n' + "String data: " + "(Giải mã chuỗi thất bại)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Decryption failed: " + ex.Message);
            }
        }
    }
}
