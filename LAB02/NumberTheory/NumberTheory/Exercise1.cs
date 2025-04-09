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
    public partial class Exercise1 : Form
    {
        public Exercise1()
        {
            InitializeComponent();
        }

        static BigInteger GenerateRandomPrime(int bitLength)
        {
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            byte[] bytes = new byte[bitLength / 8];
            BigInteger number;
            do
            {
                rng.GetBytes(bytes);
                bytes[bytes.Length - 1] |= 0x01; // Odd number at the end
                number = new BigInteger(bytes);
                number = BigInteger.Abs(number);
            } while (!IsPrime(number));
            return number;
        }

        // Check if a number is prime using Miller-Rabin test
        static bool IsPrime(BigInteger number, int k = 5)
        {
            if (number < 2) return false;
            if (number == 2 || number == 3) return true;
            if (number % 2 == 0) return false;

            BigInteger d = number - 1;
            int s = 0;
            while (d % 2 == 0)
            {
                d /= 2;
                s++;
            }

            Random rng = new Random();
            for (int i = 0; i < k; i++)
            {
                BigInteger a = GenerateRandomBigInteger(2, number - 2);
                BigInteger x = ModularExponentiation(a, d, number);
                if (x == 1 || x == number - 1) continue;

                for (int r = 0; r < s - 1; r++)
                {
                    x = ModularExponentiation(x, 2, number);
                    if (x == number - 1) break;
                }

                if (x != number - 1) return false;
            }
            return true;
        }

        static BigInteger GenerateRandomBigInteger(BigInteger minValue, BigInteger maxValue)
        {
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            byte[] bytes = maxValue.ToByteArray();
            BigInteger result;

            do
            {
                rng.GetBytes(bytes);
                result = new BigInteger(bytes);
            } while (result < minValue || result >= maxValue);

            return result;
        }

        // Compute the modular exponentiation (base^exp % mod)
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy bitlength từ combobox
            int bitLength = int.Parse(comboBox1.SelectedItem.ToString());
            BigInteger primeNumber = GenerateRandomPrime(bitLength);
            richTextBox1.Text = "Số nguyên tố đã tạo: " + primeNumber.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tìm 10 số nguyên tố lớn nhất (dưới 10 số nguyên tố Mersenne đầu tiên)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // Get 10 largest prime numbers under first 10 Mersenne primes
        static List<BigInteger> FindLargestPrimesBelow(BigInteger limit, int count)
        {
            List<BigInteger> primes = new List<BigInteger>();
            for (BigInteger i = limit - 1; i > 2; i--)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                    if (primes.Count == count) break;
                }
            }
            return primes;
        }

        // Get first 'count' Mersenne primes
        static BigInteger FindNthMersennePrime(int n)
        {
            int count = 0;
            int p = 2;
            while (true)
            {
                BigInteger mersenne = (BigInteger.One << p) - 1; // 2^p - 1
                if (IsPrime(mersenne))
                {
                    count++;
                    if (count == n) return mersenne;
                }
                p++;
            }
        }
        private void Exercise1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BigInteger mersennePrime10 = FindNthMersennePrime(10);
            richTextBox2.AppendText("Số nguyên tố Mersenne thứ 10: " + mersennePrime10.ToString() + "\n");
            List<BigInteger> largestPrimes = FindLargestPrimesBelow(mersennePrime10, 10);
            richTextBox2.AppendText("\n\n10 số nguyên tố lớn nhất dưới 10 số nguyên tố Mersenne đầu tiên:\n");
            foreach (BigInteger prime in largestPrimes)
            {
                richTextBox2.AppendText(prime.ToString() + "\n");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kiểm tra số nguyên tố dưới 2^89 - 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {  
            if (BigInteger.TryParse(richTextBox3.Text, out BigInteger number) && number > 0 && number < (BigInteger.One << 89) - 1)
            {
                if (IsPrime(number))
                {
                    richTextBox4.AppendText(number.ToString() + " là số nguyên tố.\n");
                }
                else
                {
                    richTextBox4.AppendText(number.ToString() + " không phải là số nguyên tố.\n");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên dương nhỏ hơn 2^89 - 1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
