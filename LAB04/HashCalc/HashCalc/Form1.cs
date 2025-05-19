using System.Security.Cryptography;
using System.Text;
using System.IO.Hashing;
using BouncyCastleCrypto = Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Digests;

namespace HashCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        // Event handler cho Button tính toán hash
        private void button1_Click(object sender, EventArgs e)
        {
            byte[] inputBytes;
            string? inputType = comboBox1.SelectedItem?.ToString();

            try
            {
                // Xử lý dữ liệu đầu vào dựa trên loại đã chọn
                if (inputType == "Text string")
                {
                    inputBytes = Encoding.UTF8.GetBytes(richTextBox1.Text);
                }
                else if (inputType == "Hex string")
                {
                    inputBytes = HexStringToByteArray(richTextBox1.Text);
                }
                else if (inputType == "File")
                {
                    inputBytes = Encoding.UTF8.GetBytes(richTextBox1.Text);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn loại dữ liệu đầu vào.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra xem có dữ liệu đầu vào không
                if (inputBytes == null || inputBytes.Length == 0)
                {
                    MessageBox.Show("Vui lòng cung cấp dữ liệu đầu vào.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (checkBox1.Checked)
                {
                    using (MD5 md5 = MD5.Create())
                    {
                        byte[] hashBytes = md5.ComputeHash(inputBytes);
                        richTextBox2.Text = ByteArrayToHexString(hashBytes);
                    }
                }
                else
                {
                    richTextBox2.Text = "";
                }

                if (checkBox2.Checked)
                {
                    using (SHA1 sha1 = SHA1.Create())
                    {
                        byte[] hashBytes = sha1.ComputeHash(inputBytes);
                        richTextBox3.Text = ByteArrayToHexString(hashBytes);
                    }
                }
                else
                {
                    richTextBox3.Text = "";
                }

                if (checkBox3.Checked)
                {
                    using (SHA256 sha256 = SHA256.Create())
                    {
                        byte[] hashBytes = sha256.ComputeHash(inputBytes);
                        richTextBox4.Text = ByteArrayToHexString(hashBytes);
                    }
                }
                else
                {
                    richTextBox4.Text = "";
                }

                if (checkBox4.Checked)
                {
                    using (SHA384 sha384 = SHA384.Create())
                    {
                        byte[] hashBytes = sha384.ComputeHash(inputBytes);
                        richTextBox5.Text = ByteArrayToHexString(hashBytes);
                    }
                }
                else
                {
                    richTextBox5.Text = "";
                }

                if (checkBox5.Checked)
                {
                    using (SHA512 sha512 = SHA512.Create())
                    {
                        byte[] hashBytes = sha512.ComputeHash(inputBytes);
                        richTextBox6.Text = ByteArrayToHexString(hashBytes);
                    }
                }
                else
                {
                    richTextBox6.Text = "";
                }

                if (checkBox6.Checked)
                {
                    BouncyCastleCrypto.Sha224Digest sha224Digest = new BouncyCastleCrypto.Sha224Digest();
                    sha224Digest.BlockUpdate(inputBytes, 0, inputBytes.Length);
                    byte[] hashBytes = new byte[sha224Digest.GetDigestSize()];
                    sha224Digest.DoFinal(hashBytes, 0);
                    richTextBox7.Text = ByteArrayToHexString(hashBytes);
                }
                else
                {
                    richTextBox7.Text = "";
                }

                if (checkBox7.Checked)
                {
                    using (SHA256 sha256 = SHA256.Create())
                    {
                        byte[] hashBytes = sha256.ComputeHash(inputBytes);
                        byte[] doubleHashBytes = sha256.ComputeHash(hashBytes);
                        richTextBox8.Text = ByteArrayToHexString(doubleHashBytes);
                    }
                }
                else
                {
                    richTextBox8.Text = "";
                }

                if (checkBox8.Checked)
                {
                    BouncyCastleCrypto.MD2Digest md2 = new BouncyCastleCrypto.MD2Digest();
                    md2.BlockUpdate(inputBytes, 0, inputBytes.Length);
                    byte[] hashBytes = new byte[md2.GetDigestSize()];
                    md2.DoFinal(hashBytes, 0);
                    richTextBox9.Text = ByteArrayToHexString(hashBytes);
                }
                else
                {
                    richTextBox9.Text = "";
                }

                if (checkBox9.Checked)
                {
                    BouncyCastleCrypto.MD4Digest md4 = new BouncyCastleCrypto.MD4Digest();
                    md4.BlockUpdate(inputBytes, 0, inputBytes.Length);
                    byte[] hashBytes = new byte[md4.GetDigestSize()];
                    md4.DoFinal(hashBytes, 0);
                    richTextBox10.Text = ByteArrayToHexString(hashBytes);
                }
                else
                {
                    richTextBox10.Text = "";
                }

                if (checkBox10.Checked)
                {
                    BouncyCastleCrypto.RipeMD128Digest ripemd128 = new BouncyCastleCrypto.RipeMD128Digest();
                    ripemd128.BlockUpdate(inputBytes, 0, inputBytes.Length);
                    byte[] hashBytes = new byte[ripemd128.GetDigestSize()];
                    ripemd128.DoFinal(hashBytes, 0);
                    richTextBox11.Text = ByteArrayToHexString(hashBytes);
                }
                else
                {
                    richTextBox11.Text = "";
                }

                if (checkBox11.Checked)
                {
                    BouncyCastleCrypto.RipeMD160Digest ripemd160 = new BouncyCastleCrypto.RipeMD160Digest();
                    ripemd160.BlockUpdate(inputBytes, 0, inputBytes.Length);
                    byte[] hashBytes = new byte[ripemd160.GetDigestSize()];
                    ripemd160.DoFinal(hashBytes, 0);
                    richTextBox12.Text = ByteArrayToHexString(hashBytes);
                }
                else
                {
                    richTextBox12.Text = "";
                }

                if (checkBox12.Checked)
                {
                    BouncyCastleCrypto.RipeMD256Digest ripemd256 = new BouncyCastleCrypto.RipeMD256Digest();
                    ripemd256.BlockUpdate(inputBytes, 0, inputBytes.Length);
                    byte[] hashBytes = new byte[ripemd256.GetDigestSize()];
                    ripemd256.DoFinal(hashBytes, 0);
                    richTextBox13.Text = ByteArrayToHexString(hashBytes);
                }
                else
                {
                    richTextBox13.Text = "";
                }

                if (checkBox13.Checked)
                {
                    BouncyCastleCrypto.RipeMD320Digest ripemd320 = new BouncyCastleCrypto.RipeMD320Digest();
                    ripemd320.BlockUpdate(inputBytes, 0, inputBytes.Length);
                    byte[] hashBytes = new byte[ripemd320.GetDigestSize()];
                    ripemd320.DoFinal(hashBytes, 0);
                    richTextBox14.Text = ByteArrayToHexString(hashBytes);
                }
                else
                {
                    richTextBox14.Text = "";
                }

                if (checkBox14.Checked)
                {
                    uint crc32Value = BitConverter.ToUInt32(Crc32.Hash(inputBytes), 0);
                    richTextBox15.Text = crc32Value.ToString("x8");
                }
                else
                {
                    richTextBox15.Text = "";
                }

                if (checkBox15.Checked)
                {
                    ulong crc64Value = BitConverter.ToUInt64(Crc64.Hash(inputBytes), 0);
                    richTextBox16.Text = crc64Value.ToString("x16");
                }
                else
                {
                    richTextBox16.Text = "";
                }

                if (checkBox16.Checked)
                {
                    BouncyCastleCrypto.ShakeDigest shake128 = new BouncyCastleCrypto.ShakeDigest(128);
                    shake128.BlockUpdate(inputBytes, 0, inputBytes.Length);
                    byte[] hashBytes = new byte[shake128.GetDigestSize()];
                    shake128.DoFinal(hashBytes, 0);
                    richTextBox17.Text = ByteArrayToHexString(hashBytes);
                }
                else
                {
                    richTextBox17.Text = "";
                }

                if (checkBox17.Checked)
                {
                    BouncyCastleCrypto.ShakeDigest shake256 = new BouncyCastleCrypto.ShakeDigest(256);
                    shake256.BlockUpdate(inputBytes, 0, inputBytes.Length);
                    byte[] hashBytes = new byte[shake256.GetDigestSize()];
                    shake256.DoFinal(hashBytes, 0);
                    richTextBox18.Text = ByteArrayToHexString(hashBytes);
                }
                else
                {
                    richTextBox18.Text = "";
                }

                if (checkBox18.Checked)
                {

                    string inputText = richTextBox1.Text;
                    string keyText = richTextBox19.Text;
                    var hmacInputBytes = new byte[0];
                    // Nếu input đang là hexstring -> Chuyển đổi
                    if (inputType == "Hex string")
                    {
                        hmacInputBytes = HexStringToByteArray(inputText);
                    }
                    else
                    {
                        hmacInputBytes = System.Text.Encoding.UTF8.GetBytes(inputText);
                    }
                    // Chuyển đổi thành byte
                    byte[] keyBytes = System.Text.Encoding.UTF8.GetBytes(keyText);

                    // Tính các HMAC theo lựa chọn
                    if (checkBox1.Checked)
                    {
                        using (HMACMD5 hmac = new HMACMD5(keyBytes))
                        {
                            byte[] hashBytes = hmac.ComputeHash(hmacInputBytes);
                            richTextBox2.Text = ByteArrayToHexString(hashBytes);
                        }
                    }
                    if (checkBox2.Checked)
                    {
                        using (HMACSHA1 hmac = new HMACSHA1(keyBytes))
                        {
                            byte[] hashBytes = hmac.ComputeHash(hmacInputBytes);
                            richTextBox3.Text = ByteArrayToHexString(hashBytes);
                        }
                    }
                    if (checkBox3.Checked)
                    {
                        using (HMACSHA256 hmac = new HMACSHA256(keyBytes))
                        {
                            byte[] hashBytes = hmac.ComputeHash(hmacInputBytes);
                            richTextBox4.Text = ByteArrayToHexString(hashBytes);
                        }
                    }
                    if (checkBox4.Checked)
                    {
                        using (HMACSHA384 hmac = new HMACSHA384(keyBytes))
                        {
                            byte[] hashBytes = hmac.ComputeHash(hmacInputBytes);
                            richTextBox5.Text = ByteArrayToHexString(hashBytes);
                        }
                    }
                    if (checkBox5.Checked)
                    {
                        using (HMACSHA512 hmac = new HMACSHA512(keyBytes))
                        {
                            byte[] hashBytes = hmac.ComputeHash(hmacInputBytes);
                            richTextBox6.Text = ByteArrayToHexString(hashBytes);
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Chuỗi Hex đầu vào không hợp lệ.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richTextBox2.Text = "";
                richTextBox3.Text = "";
                richTextBox4.Text = "";
                richTextBox5.Text = "";
                richTextBox6.Text = "";
                richTextBox7.Text = "";
                richTextBox8.Text = "";
                richTextBox9.Text = "";
                richTextBox10.Text = "";
                richTextBox11.Text = "";
                richTextBox12.Text = "";
                richTextBox13.Text = "";
                richTextBox14.Text = "";
                richTextBox15.Text = "";
                richTextBox16.Text = "";
                richTextBox17.Text = "";
                richTextBox18.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richTextBox2.Text = "";
                richTextBox3.Text = "";
                richTextBox4.Text = "";
                richTextBox5.Text = "";
                richTextBox6.Text = "";
                richTextBox7.Text = "";
                richTextBox8.Text = "";
                richTextBox9.Text = "";
                richTextBox10.Text = "";
                richTextBox11.Text = "";
                richTextBox12.Text = "";
                richTextBox13.Text = "";
                richTextBox14.Text = "";
                richTextBox15.Text = "";
                richTextBox16.Text = "";
                richTextBox17.Text = "";
                richTextBox18.Text = "";
            }
        }
        // Chuyển đổi chuỗi Hex thành mảng byte
        private byte[] HexStringToByteArray(string hex)
        {
            int length = hex.Length;
            byte[] bytes = new byte[length / 2];
            for (int i = 0; i < length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }

        // Hàm chuyển đổi mảng byte sang chuỗi Hex
        private string ByteArrayToHexString(byte[] byteArray)
        {
            StringBuilder hex = new StringBuilder(byteArray.Length * 2);
            foreach (byte b in byteArray)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedType = comboBox1.SelectedItem.ToString();
            if (selectedType == "File")
            {
                // Mở OpenFileDialog để chọn tệp
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Đọc nội dung tệp vào RichTextBox1
                    richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
                }
                else
                {
                    richTextBox1.Text = "";
                }
            }
            else
            {
                richTextBox1.Text = "";
                richTextBox1.Enabled = true;
            }
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            richTextBox4.Text = "";
            richTextBox5.Text = "";
            richTextBox6.Text = "";
            richTextBox7.Text = "";
            richTextBox8.Text = "";
            richTextBox9.Text = "";
            richTextBox10.Text = "";
            richTextBox11.Text = "";
            richTextBox12.Text = "";
            richTextBox13.Text = "";
            richTextBox14.Text = "";
            richTextBox15.Text = "";
            richTextBox16.Text = "";
            richTextBox17.Text = "";
            richTextBox18.Text = "";
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            bool enable = !checkBox18.Checked;

            checkBox6.Enabled = enable;
            checkBox7.Enabled = enable;
            checkBox8.Enabled = enable;
            checkBox9.Enabled = enable;
            checkBox10.Enabled = enable;
            checkBox11.Enabled = enable;
            checkBox12.Enabled = enable;
            checkBox13.Enabled = enable;
            checkBox14.Enabled = enable;
            checkBox15.Enabled = enable;
            checkBox16.Enabled = enable;
            checkBox17.Enabled = enable;
        }
    }
}
