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
    public partial class XOR : Form
    {
        public XOR()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputText = richTextBox1.Text;
            string key = textBox1.Text;
            richTextBox2.Text = XOREncryptDecrypt(inputText, key);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = richTextBox1.Text;
            string key = textBox1.Text;
            richTextBox2.Text = XOREncryptDecrypt(inputText, key);
        }
        private string XOREncryptDecrypt(string text, string hexKey)
        {
            string hexa = "";
            if (!IsValidHex(hexKey))
            {
                MessageBox.Show("Khóa phải ở dạng thập lục phân (0-9, A-F)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
            byte[] keyBytes = HexStringToBytes(hexKey);
            StringBuilder result = new StringBuilder();
            result.Append("Result: ");
            for (int i = 0; i < text.Length; i++)
            {
                result.Append((char)(text[i] ^ keyBytes[i % keyBytes.Length]));
            }
            return result.ToString();
        }
        private bool IsValidHex(string hex)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(hex, @"\A\b[0-9A-Fa-f]+\b\Z");
        }
        private byte[] HexStringToBytes(string hex)
        {
            int length = hex.Length;
            byte[] bytes = new byte[length / 2];

            for (int i = 0; i < length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }

            return bytes;
        }
    }
}
