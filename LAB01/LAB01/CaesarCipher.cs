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
    public partial class CaesarCipher : Form
    {
        public CaesarCipher()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = richTextBox1.Text;
            StringBuilder result = new StringBuilder();

            for (int k = 1; k <= 26; k++)
            {
                result.AppendLine($"Key {k}: {DecodeCaesar(inputText, k)}");
            }

            richTextBox2.Text = result.ToString();
        }

        private string DecodeCaesar(string text, int key)
        {
            StringBuilder cipher = new StringBuilder();

            foreach (char c in text)
            {
                if (char.IsUpper(c))
                {
                    cipher.Append((char)(((c - 'A' - key + 26) % 26) + 'A'));
                }
                else if (char.IsLower(c))
                {
                    cipher.Append((char)(((c - 'a' - key + 26) % 26) + 'a'));
                }
                else
                {
                    cipher.Append(c);
                }
            }
            cipher.Append("\n");

            return cipher.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string inputText = richTextBox1.Text;
            StringBuilder result = new StringBuilder();


            result.AppendLine($"Cipher : {EncodeCaesar(inputText)}");
            richTextBox2.Text = result.ToString();
        }

        private string EncodeCaesar(string text)
        {
            StringBuilder cipher = new StringBuilder();
            int key = int.Parse(textBox1.Text);
            foreach (char c in text)
            {
                if (char.IsUpper(c))
                {
                    cipher.Append((char)(((c - 'A' + key + 26) % 26) + 'A'));
                }
                else if (char.IsLower(c))
                {
                    cipher.Append((char)(((c - 'a' + key + 26) % 26) + 'a'));
                }
                else
                {
                    cipher.Append(c);
                }
            }

            return cipher.ToString();
        }
    }
}
