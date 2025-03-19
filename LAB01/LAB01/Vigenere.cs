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
    public partial class Vigenere : Form
    {
        public Vigenere()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // Encrypt
        {
            string plaintext = richTextBox1.Text.ToUpper();
            string key = textBox1.Text.ToUpper();
            richTextBox2.Text = VigenereEncrypt(plaintext, key);
        }

        private void button1_Click(object sender, EventArgs e) // Decrypt
        {
            string ciphertext = richTextBox1.Text.ToUpper();
            string key = textBox1.Text.ToUpper();
            richTextBox2.Text = VigenereDecrypt(ciphertext, key);
        }

        private string VigenereEncrypt(string text, string key)
        {
            string result = "";
            int keyIndex = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                if (char.IsLetter(letter))
                {
                    int shift = key[keyIndex % key.Length] - 'A';
                    char encryptedChar = (char)('A' + (letter - 'A' + shift) % 26);
                    result += encryptedChar;
                    keyIndex++;
                }
                else
                {
                    result += letter; // Giữ nguyên ký tự không phải chữ cái
                }
            }
            return result;
        }

        private string VigenereDecrypt(string text, string key)
        {
            string result = "";
            int keyIndex = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                if (char.IsLetter(letter))
                {
                    int shift = key[keyIndex % key.Length] - 'A';
                    char decryptedChar = (char)('A' + (letter - 'A' - shift + 26) % 26);
                    result += decryptedChar;
                    keyIndex++;
                }
                else
                {
                    result += letter;
                }
            }
            return result;
        }
    }
}
