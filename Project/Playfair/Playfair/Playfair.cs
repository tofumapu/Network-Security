using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playfair
{
    public partial class Playfair : Form
    {
        private char[,] keyMatrix = new char[5, 5];
        public Playfair()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GenerateKeyMatrix(textBox1.Text);
            richTextBox2.Text = Encrypt(richTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerateKeyMatrix(textBox1.Text);
            richTextBox2.Text = Decrypt(richTextBox1.Text);
        }

        private void GenerateKeyMatrix(string key)
        {
            string keyString = new string((key + "ABCDEFGHIKLMNOPQRSTUVWXYZ").ToUpper().Where(c => c >= 'A' && c <= 'Z' && c != 'J').Distinct().ToArray());
            int index = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    keyMatrix[i, j] = keyString[index++];
                }
            }
            DisplayKeyMatrix();
        }

        private void DisplayKeyMatrix()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 5;
            int cellSize = 30;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Height = cellSize;
                for (int j = 0; j < 5; j++)
                {
                    dataGridView1.Columns[j].Width = cellSize;
                    dataGridView1.Rows[i].Cells[j].Value = keyMatrix[i, j];
                    dataGridView1.Rows[i].Cells[j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }


        private string Encrypt(string input)
        {
            return ProcessText(input, true);
        }

        private string Decrypt(string input)
        {
            return ProcessText(input, false);
        }

        private string ProcessText(string input, bool encrypt)
        {
            string text = input.ToUpper().Replace("J", "I").Where(c => c >= 'A' && c <= 'Z').Aggregate("", (current, c) => current + c);
            string result = "";
            if (text.Length % 2 != 0) text += "X";

            for (int i = 0; i < text.Length; i += 2)
            {
                char a = text[i], b = text[i + 1];
                (int row1, int col1) = FindPosition(a);
                (int row2, int col2) = FindPosition(b);

                if (row1 == row2)
                {
                    col1 = (col1 + (encrypt ? 1 : 4)) % 5;
                    col2 = (col2 + (encrypt ? 1 : 4)) % 5;
                }
                else if (col1 == col2)
                {
                    row1 = (row1 + (encrypt ? 1 : 4)) % 5;
                    row2 = (row2 + (encrypt ? 1 : 4)) % 5;
                }
                else
                {
                    (col1, col2) = (col2, col1);
                }

                result += keyMatrix[row1, col1].ToString() + keyMatrix[row2, col2].ToString() + " ";
            }
            return result.ToString().Trim();
        }

        private (int, int) FindPosition(char letter)
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    if (keyMatrix[i, j] == letter)
                        return (i, j);
            return (-1, -1);
        }
    }
}
