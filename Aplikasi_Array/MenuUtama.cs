using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Array
{
    public partial class MenuUtama : Form
    {
        private string userLevel;
        public MenuUtama(string userLevel)
        {
            InitializeComponent();
            this.userLevel = userLevel;

            InitializeMenuVisibility();
        }

        private void InitializeMenuVisibility()
        {
            // Set visiblitas menu berdasarkan level pengguna
            DataMaster.Visible = (userLevel == "Admin");
            DataTransaksi.Visible = (userLevel == "Admin" || userLevel == "Anggota");

            TextUser.Text = userLevel;
        }

        private void DataAnggota_Click(object sender, EventArgs e)
        {
            DataAnggota dataanggota = new DataAnggota(userLevel);
            dataanggota.Show();
            Hide();
        }

        private void DataBuku_Click(object sender, EventArgs e)
        {
            DataBuku databuku = new DataBuku(userLevel);
            databuku.Show();
            Hide();
        }

        private void DataPeminjaman_Click(object sender, EventArgs e)
        {
            DataPeminjaman datapeminjaman = new DataPeminjaman(userLevel);
            datapeminjaman.Show();
            Hide();
        }

        private void DataPengembalian_Click(object sender, EventArgs e)
        {
            DataPengembalian datapengembalian = new DataPengembalian();
            datapengembalian.Show();
            Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormLogin FL = new FormLogin();
            FL.Show();
            Hide();
        }
    }
}
