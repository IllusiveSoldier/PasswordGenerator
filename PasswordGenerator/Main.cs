using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace PasswordGenerator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void GeneratePassButton_Click(object sender, EventArgs e)
        {
            GeneratingPassword();
        }

        private void GeneratingPassword()
        {
            string resourceCharString = "`1234567890-=qwertyuiop[]asdfghjkl;'\\zxcvbnm,./~!@#$%^&*()_+QWERTYUIOP{}ASDFGHJKL:\"|ZXCVBNM<>?";

            StringBuilder currentPass = new StringBuilder();
            Random rand = new Random();

            for (int i = 0; i <= 24; i++)
            {
                currentPass.Append(resourceCharString[rand.Next(resourceCharString.Length)]);
            }

            string generatedPassword = currentPass.ToString();

            ShowingPasswordTextBox.Text = generatedPassword;
            ListOfPasswordsRichTextBox.AppendText($"{generatedPassword}\n");
            currentPass.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ReadOnlyCheckBox.Checked) ShowingPasswordTextBox.ReadOnly = true;
            else ShowingPasswordTextBox.ReadOnly = false;
        }

        private void GetMDFiveSumButton_Click(object sender, EventArgs e)
        {
            if (ShowingPasswordTextBox.Text == "") GeneratingPassword();
            string source = ShowingPasswordTextBox.Text;

            using (MD5 md5Hash = MD5.Create())
            {
                string hash = GetMd5Hash(md5Hash, source);

                MDFive.Text = hash;
            }
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        private void ShowingPasswordTextBox_DoubleClick(object sender, EventArgs e)
        {
            if (ShowingPasswordTextBox.Text == "") ShowingPasswordTextBox.Text = "Поле пустое!";
            Clipboard.SetText(ShowingPasswordTextBox.Text);
        }

        private void MDFive_DoubleClick(object sender, EventArgs e)
        {
            if (MDFive.Text == "") MDFive.Text = "Поле пустое!";
            else Clipboard.SetText(MDFive.Text);
        }
    }
}
