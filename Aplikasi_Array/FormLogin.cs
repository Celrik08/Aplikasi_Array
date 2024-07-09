 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Array
{
    public partial class FormLogin : Form
    {
        // Array untuk menyimpan inromasi pengguna (username, password, level)
        public string[,] userCreadentials =
        {
            {"1", "Admin", "Admin123", "Admin" },
            {"2", "Anggota", "Anggota123", "Anggota"}
        };
        public FormLogin()
        {
            InitializeComponent();
        }

        private void TextUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                TextPass.Focus();
                e.Handled = true;
            }
        }

        private void TextPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                PerformLogin();
            }
        }

        private void PerformLogin()
        {
            string username = TextUser.Text;
            string password = TextPass.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan password tidak boleh kosong", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Memeriksa kecocokan username dan password
            string userLevel = CheckCredentials(username, password);

            if (userLevel != null)
            {
                MessageBox.Show($"Login berhasil Level: {userLevel}", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Pindah ke form lain jika login berhasil
                MenuUtama MU = new MenuUtama(userLevel);
                MU.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Login gagal. Periksa kembali username dan password.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextUser.Text = "";
                TextPass.Text = "";
            }
        }

        private string CheckCredentials(string username, string password)
        {
            // Iterasi melalui array untuk mencari kecocokan
            for (int i = 0; i < userCreadentials.GetLength(0); i++)
            {
                // Memeriksa apakah username dan password cocok
                if (userCreadentials[i, 1] == username && userCreadentials[i, 2] == password)
                {
                    return userCreadentials[i, 3]; // Kembalikan level jika ada kecocokan
                }
            }

            return null; // Kembalikan null jika tidak ada kecocokan
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            TextPass.PasswordChar = '*';
        }

        private void CheckPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPass.Checked)
            {
                TextPass.PasswordChar = '\0';
            }
            else
            {
                TextPass.PasswordChar = '*';
            }
        }
    }
}
