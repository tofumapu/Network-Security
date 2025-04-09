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
using static System.Net.Mime.MediaTypeNames;

namespace NumberTheory
{
    public partial class GenerateRandomPrimeNumber : Form
    {
        public GenerateRandomPrimeNumber()
        {
            InitializeComponent();
        }

        // Generate a random prime number within the inclusive range [min, max]
        static BigInteger GenerateRandomPrimeWithMillerRabin(BigInteger min, BigInteger max)
        {
            BigInteger candidate;
            do
            {
                // Generate a random BigInteger in the range [min, max]
                candidate = GenerateRandomBigInteger(min, max + 1);
                candidate = BigInteger.Abs(candidate);
            } while (!IsPrimeWithMillerRabin(candidate));
            return candidate;
        }

        // Check if a number is prime using Miller-Rabin test
        static bool IsPrimeWithMillerRabin(BigInteger number, int k = 5)
        {
            if (number < 2) return false;
            if (number == 2 || number == 3) return true;
            if (number % 2 == 0) return false;

            BigInteger d = number - 1;
            BigInteger s = 0;
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

                for (BigInteger r = 0; r < s - 1; r++)
                {
                    x = ModularExponentiation(x, 2, number);
                    if (x == number - 1) break;
                }

                if (x != number - 1) return false;
            }
            return true;
        }

        // Fermat prime
        public static bool IsFermatPrime(BigInteger n, int iterations = 5)
        {
            if (n <= 1) return false;
            if (n == 2 || n == 3) return true;
            if (n % 2 == 0) return false;

            for (int i = 0; i < iterations; i++)
            {
                BigInteger a = GenerateRandomBigInteger(2, n - 2);
                if (BigInteger.ModPow(a, n - 1, n) != 1)
                    return false;
            }
            return true;
        }
        public static BigInteger Jacobi(BigInteger a, BigInteger n)
        {
            if (n <= 0 || n % 2 == 0)
                throw new ArgumentException("n must be a positive odd number.");

            a %= n;
            BigInteger result = 1;

            while (a != 0)
            {
                while (a % 2 == 0)
                {
                    a /= 2;
                    BigInteger r = n % 8;
                    if (r == 3 || r == 5)
                        result = -result;
                }

                // Swap a and n
                (a, n) = (n, a);

                if (a % 4 == 3 && n % 4 == 3)
                    result = -result;

                a %= n;
            }

            return n == 1 ? result : 0;
        }


        public static bool IsSolovayStrassenPrime(BigInteger n, int iterations = 5)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int i = 0; i < iterations; i++)
            {
                BigInteger a = GenerateRandomBigInteger(2, n - 1);
                BigInteger jacobian = Jacobi(a, n);
                if (jacobian == 0 || BigInteger.ModPow(a, (n - 1) / 2, n) != (jacobian % n + n) % n)
                {
                    return false;
                }
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
                result = BigInteger.Abs(result);
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

        // Helper method for parsing expressions like "2^10"
        private BigInteger ParseExpression(string input)
        {
            input = input.Trim();
            if (input.Contains("^"))
            {
                var parts = input.Split('^');
                if (BigInteger.TryParse(parts[0].Trim(), out BigInteger baseNum) && BigInteger.TryParse(parts[1].Trim(), out BigInteger exp))
                {
                    return BigInteger.Pow(baseNum, (int)exp);
                }
                else
                {
                    throw new FormatException("Invalid expression format.");
                }
            }
            else
            {
                if (BigInteger.TryParse(input, out BigInteger value))
                    return value;
                else
                    throw new FormatException("Invalid number format.");
            }
        }

        private void button1_Click(object sender, EventArgs e) // Generate Primes for p, q and private key d
        {
            try
            {
                // Read range for prime p from RichTextBox1 (from) and RichTextBox4 (to)
                BigInteger pFrom = ParseExpression(richTextBox1.Text);
                BigInteger pTo = ParseExpression(richTextBox4.Text);
                if (pFrom > pTo)
                {
                    MessageBox.Show("For prime number p, the 'From' value must be less than or equal to the 'To' value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Read range for prime q from RichTextBox2 (from) and RichTextBox5 (to)
                BigInteger qFrom;
                BigInteger qTo;
                if (richTextBox2.Enabled == false)
                {
                    qFrom = ParseExpression(richTextBox1.Text);
                }
                else
                {
                    qFrom = ParseExpression(richTextBox2.Text);
                }
                if (richTextBox5.Enabled == false)
                {
                    qTo = ParseExpression(richTextBox4.Text);
                }
                else
                {
                    qTo = ParseExpression(richTextBox5.Text);
                }

                if (qFrom > qTo)
                {
                    MessageBox.Show("For prime number q, the 'From' value must be less than or equal to the 'To' value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Read range for private key d from RichTextBox3 (from) and RichTextBox6 (to)
                BigInteger dFrom = ParseExpression(richTextBox3.Text);
                BigInteger dTo = ParseExpression(richTextBox6.Text);
                if (dFrom > dTo)
                {
                    MessageBox.Show("For private key d, the 'From' value must be less than or equal to the 'To' value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                BigInteger p;
                BigInteger q;
                BigInteger d;
                if (comboBox1.SelectedIndex == 0)
                {
                    p = GenerateRandomPrimeWithMillerRabin(pFrom, pTo);
                    q = GenerateRandomPrimeWithMillerRabin(qFrom, qTo);
                    d = GenerateRandomPrimeWithMillerRabin(dFrom, dTo);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    p = GenerateRandomPrimeWithMillerRabin(pFrom, pTo);
                    q = GenerateRandomPrimeWithMillerRabin(qFrom, qTo);
                    d = GenerateRandomPrimeWithMillerRabin(dFrom, dTo);
                }
                else
                {
                    p = GenerateRandomPrimeWithMillerRabin(pFrom, pTo);
                    q = GenerateRandomPrimeWithMillerRabin(qFrom, qTo);
                    d = GenerateRandomPrimeWithMillerRabin(dFrom, dTo);
                }
                richTextBox7.Text = p.ToString();
                richTextBox8.Text = q.ToString();
                richTextBox9.Text = d.ToString();

            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid input: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e) // Apply
        {
            if (richTextBox7.Text == "" || richTextBox8.Text == "" || richTextBox9.Text == "")
            {
                MessageBox.Show("Please generate prime numbers first.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (richTextBox7.Text == "0" || richTextBox8.Text == "0" || richTextBox9.Text == "0")
            {
                MessageBox.Show("Prime numbers cannot be 0.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void GenerateRandomPrimeNumber_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "2^16"; // p from
            richTextBox4.Text = "2^32"; // p to

            richTextBox2.Text = "2^16"; // q from
            richTextBox5.Text = "2^32"; // q to

            richTextBox3.Text = "2^6"; // d from
            richTextBox6.Text = "2^7"; // d to

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 1)
            {
                richTextBox2.Enabled = false;
                richTextBox5.Enabled = false;
                richTextBox2.Text = richTextBox1.Text;
                richTextBox5.Text = richTextBox4.Text;
            }
            else
            {
                richTextBox2.Enabled = true;
                richTextBox5.Enabled = true;
                richTextBox2.Text = richTextBox1.Text;
                richTextBox5.Text = richTextBox4.Text;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 1)
            {
                richTextBox2.Text = richTextBox1.Text;
            }
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 1)
            {
                richTextBox5.Text = richTextBox4.Text;
            }
        }

        private void GenerateRandomPrimeNumber_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            RSA rsaForm = (RSA)this.Owner;
            if (rsaForm != null)
            {
                rsaForm.button1_Click(sender, e);
            }
        }
    }
}
