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
    public partial class DataPeminjaman : Form
    {
        private string userLevel;
        public List<string[]> dataPeminjamanList; // Array untuk menyimpan data peminjaman
        private int selectedRowIndex = -1;
        public DataPeminjaman(string userLevel)
        {
            InitializeComponent();
            InitializeDataGrid(); // Panggil metode untuk menganisialisasi array dan menampilkan di DataGridView
            this.userLevel = userLevel;
        }

        public void InitializeDataGrid()
        {
            // Inisialisasi array dengan data peminjaman
            dataPeminjamanList = new List<string[]>
            {
                new string[] {"1", DateTime.Now.ToString("dd/MM/yyyy"), "Farid", "KIMIA"},
            };

            // Tambahkan event handler CellClick
            Data_Peminjaman.CellClick += Data_Peminjaman_CellClick;

            // Menampilkan data array di DataGridView
            LoadDataToDataGridView();
        }

        private void TextNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                TextBuku.Focus();
            }
        }

        private void TextJudul_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                PerformPeminjaman();
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            PerformPeminjaman();
        }

        private void PerformPeminjaman()
        {
            // Menyimpan data diri dataPeminjaman ke DataGridView
            LoadDataToDataGridView();

            // Menambahkan data baru dari TextBox ke array
            string id = (dataPeminjamanList.Count + 1).ToString(); // ID baru
            string tanggal = TextTanggal.Text;
            string nama = TextAnggota.Text;
            string judul = TextBuku.Text;

            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(judul))
            {
                MessageBox.Show("Semua kolom harus diisi", "Kesalahan", MessageBoxBuutons.OK, MessageBoxIcon.Error);
                return;
            }

            // Menambahkan data baru ke array
            string[] newData = new string[] { id, tanggal, nama, judul };
            dataPeminjamanList.Add(newData);

            // Menampilkan data array yang diperbarui di DataGridView
            LoadDataToDataGridView();

            // Bersihkan TextBox setelah menyimpan
            TextKode.Clear();
            TextTanggal.Clear();
            ComboAnggota.SelectedIndex = -1;
            TextAnggota.Clear();
            ComboBuku.SelectedIndex = -1;
            TextBuku.Clear();
        }

        private void DataPeminjaman_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            DisableInputControls();
        }

        private void LoadDataToDataGridView()
        {
            Data_Peminjaman.Rows.Clear();

            if (dataPeminjamanList != null)
            {
                foreach (var rowData in dataPeminjamanList)
                {
                    Data_Peminjaman.Rows.Add(rowData[0], rowData[1], rowData[2], rowData[3]);
                }
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            EnableInputControls();

            // Mengisi TextTanggal dengan tanggal hari ini
            TextTanggal.Text = DateTime.Now.ToString("dd/MM/yyyy");

            // Membuat instance dari kelas DataAnggota
            DataAnggota dataAnggotaForm = new DataAnggota(userLevel);

            // Mengisi ComboAnggota dengan data Id Anggota
            ComboAnggota.Items.Clear();
            foreach (var anggota in dataAnggotaForm.dataAnggotaList)
            {
                ComboAnggota.Items.Add(anggota[0]);
            }

            // Membuat instance dari kelas DataBuku
            DataBuku dataBukuForm = new DataBuku(userLevel);

            // Mengisi ComboBuku dengan data Id Buku
            ComboBuku.Items.Clear();
            foreach (var buku in dataBukuForm.dataBukuList)
            {
                ComboBuku.Items.Add(buku[0]);
            }
        }

        private void Data_Peminjaman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < Data_Peminjaman.Rows.Count)
            {
                selectedRowIndex = e.RowIndex;

                // Periksa apakah sel yang diklik tidak null sebelum mengambil nilai
                if (Data_Peminjaman.Rows[selectedRowIndex].Cells[0].Value != null)
                {
                    TextKode.Text = Data_Peminjaman.Rows[selectedRowIndex].Cells[0].Value.ToString();
                }
                else
                {
                    TextKode.Text = string.Empty;
                }

                if (Data_Peminjaman.Rows[selectedRowIndex].Cells[1].Value != null)
                {
                    TextTanggal.Text = Data_Peminjaman.Rows[selectedRowIndex].Cells[1].Value.ToString();
                }
                else
                {
                    TextTanggal.Text = string.Empty;
                }

                if (Data_Peminjaman.Rows[selectedRowIndex].Cells[2].Value != null)
                {
                    TextAnggota.Text = Data_Peminjaman.Rows[selectedRowIndex].Cells[2].Value.ToString();
                }
                else
                {
                    TextAnggota.Text = string.Empty;
                }

                if (Data_Peminjaman.Rows[selectedRowIndex].Cells[3].Value != null)
                {
                    TextBuku.Text = Data_Peminjaman.Rows[selectedRowIndex].Cells[3].Value.ToString();
                }
                else
                {
                    TextBuku.Text = string.Empty;
                }
            }
        }

        private void ComboAnggota_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Menampilkan nama anggota sesuai dengan id yang dipilih
            if (ComboAnggota.SelectedIndex != null)
            {
                string selectedId = ComboAnggota.SelectedItem.ToString();

                DataAnggota dataAnggota = new DataAnggota(userLevel);

                string selectedNama = dataAnggota.dataAnggotaList
                    .FirstOrDefault(ComboAnggota => ComboAnggota[0] == selectedId)?
                    .ElementAtOrDefault(1);

                TextAnggota.Text = selectedNama ?? string.Empty;
            }
        }

        private void ComboBuku_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Menampilkan judul buku sesuai dengan id yang dipilih
            if (ComboBuku.SelectedIndex != null)
            {
                string selectedId = ComboBuku.SelectedItem.ToString();

                DataBuku dataBuku = new DataBuku(userLevel);

                string selectedJudul = dataBuku.dataBukuList
                    .FirstOrDefault(ComboBuku => ComboBuku[0] == selectedId)?
                    .ElementAtOrDefault(1);

                TextBuku.Text = selectedJudul ?? string.Empty;
            }
        }
    }
}
