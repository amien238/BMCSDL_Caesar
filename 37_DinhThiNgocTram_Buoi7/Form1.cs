using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _37_DinhThiNgocTram_Buoi7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            radioButtonEncrypt.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            buttonEncrypt.Text = "Encrypt Message";
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            buttonEncrypt.Text = "Encrypt Message";
        }
        private char encrypt(char c, int k)
        {
            if (Char.IsLetter(c))
                return (char)('A' + (c - 'A' + k) % 26);
            else
                return c;
        }

        private void encryptMess(string m, int k)
        {
            string result = "";
            entryResult.Text = "";
            int len = m.Length;
            for (int i = 0; i < len; i++)
                result += encrypt(m[i], k);
            entryResult.Text = result;
        }
        private void buttonEncryptClick(object sender, EventArgs e)
        {
            string m = entryMess.Text;
            if (m == "")
            {
                MessageBox.Show("Vui lòng nhập thông điệp cần mã hóa!");
            }
            m = m.ToUpper();
            int k = (int)entryKey.Value;
            if (radioButtonEncrypt.Checked)
            {

            }
            else
            {
                k = 26 - k;
            }

            encryptMess(m, k);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }
    }
}
