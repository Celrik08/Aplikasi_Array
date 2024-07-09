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
    public partial class DataAnggota : Form
    {
        private string userLevel;
        public List<string[]> dataAnggotaList; // Array untuk menyimpan data anggota
        private int selectedRowIndex = -1;
        public DataAnggota(string userLevel)
        {
            InitializeComponent();
            InitializeDataGrid(); // Panggil metode untuk menganisialisasi array dan menampilkan di DataGridView
            this.userLevel = userLevel;
        }

        public void InitializeDataGrid()
        {
            // Inisialisasi array dengan data anggota
            dataAnggotaList = new List<string[]>
            {
                new string[] {"1", "Fajar", "Jl. Kemakmuran", "085654102199"},
                new string[] {"2", "Fathur", "Jl. Pelita", "0856"},
                new string[] {"3", "Safwan", "Jl. Lambung", "0856"}
            };

            // Tambahkan event handler CellClick
            Data_Anggota.CellClick += Data_Anggota_CellClick;

            // Menampilkan data array di DataGridView
            LoadDataToDataGridView();
        }

        private void TextNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                TextAlamat.Focus();
            }
        }

        private void TextAlamat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                TextHp.Focus();
            }
        }

        private void TextHp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                PerformAnggota();
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            PerformAnggota();
        }

        private void PerformAnggota()
        {
            // Menyimpan data diri dataAnggota ke DataGridView
            LoadDataToDataGridView();

            // Menambahkan data baru dari TextBox ke array
            string id = (dataAnggotaList.Count + 1).ToString(); // ID baru
            string nama = TextNama.Text;
            string alamat = TextAlamat.Text;
            string no = TextHp.Text;

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(alamat) || string.IsNullOrWhiteSpace(no))
            {
                MessageBox.Show("Semua kolom harus diisi", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Menambahkan data baru ke array
            string[] newData = new string[] { id, nama, alamat, no };
            dataAnggotaList.Add(newData);

            //Menampilkan data array yang diperbarui di DataGridView
            LoadDataToDataGridView();

            // Bersihkan TextBox setelah menyimpan
            TextKode.Clear();
            TextNama.Clear();
            TextAlamat.Clear();
            TextHp.Clear();
        }

        private void DataAnggota_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            DisableInputControls();
        }
        private void LoadDataToDataGridView()
        {
            Data_Anggota.Rows.Clear();

            if (dataAnggotaList != null)
            {
                foreach (var rowData in dataAnggotaList)
                {
                    Data_Anggota.Rows.Add(rowData[0], rowData[1], rowData[2], rowData[3]);
                }
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            EnableInputControls();
        }

        private void Data_Anggota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < Data_Anggota.Rows.Count)
            {
                selectedRowIndex = e.RowIndex;

                // Periksa apakah sel yang dikklik tidak null sebelum mengambil nilai
                if (Data_Anggota.Rows[selectedRowIndex].Cells[0].Value != null)
                {
                    TextKode.Text = Data_Anggota.Rows[selectedRowIndex].Cells[0].Value.ToString();
                }
                else
                {
                    TextKode.Text = string.Empty;
                }

                if (Data_Anggota.Rows[selectedRowIndex].Cells[1].Value != null)
                {
                    TextNama.Text = Data_Anggota.Rows[selectedRowIndex].Cells[1].Value.ToString();
                }
                else
                {
                    TextNama.Text = string.Empty;
                }

                if (Data_Anggota.Rows[selectedRowIndex].Cells[2].Value != null)
                {
                    TextAlamat.Text = Data_Anggota.Rows[selectedRowIndex].Cells[2].Value.ToString();
                }
                else
                {
                    TextAlamat.Text = string.Empty;
                }

                if (Data_Anggota.Rows[selectedRowIndex].Cells[3].Value != null)
                {
                    TextHp.Text = Data_Anggota.Rows[selectedRowIndex].Cells[3].Value.ToString();
                }
                else
                {
                    TextHp.Text = string.Empty;
                }

                BtnSimpan.Enabled = false;
            }
        }

        private void Data_Anggota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Data_Anggota.Columns["Ubah"].Index && e.RowIndex >= 0)
            {
                // Ambil indeks baris yang dipilih
                int rowIndex = e.RowIndex;

                // Tampilkan data yang dipilih di TextBox
                TextNama.Text = dataAnggotaList[rowIndex][1];
                TextAlamat.Text = dataAnggotaList[rowIndex][2];
                TextHp.Text = dataAnggotaList[rowIndex][3];

                // Matikan fungsi BtnSimpan untuk menghindari duplikasi data
                BtnSimpan.Enabled = false;
            }
            else if (e.ColumnIndex == Data_Anggota.Columns["Hapus"].Index && e.RowIndex >= 0)
            {
                // Pastikan kolom yang diklik adalah kolom Hapus Data dan bukan header
                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Hapus item dari array
                    dataAnggotaList.RemoveAt(selectedRowIndex);

                    // Reload tampilan DataGridView
                    LoadDataToDataGridView();

                    // Bersihkan TextBox setelah menghapus
                    TextNama.Clear();
                    TextAlamat.Clear();
                    TextHp.Clear();

                    // Kembalikan fungsi BtnSimpan dan nonaktifkan BtnUpdate
                    BtnSimpan.Enabled = true;
                }
                else
                {
                    // Pengguna memilih No, tidak melakukan apa-apa
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MenuUtama MU = new MenuUtama(userLevel);
            MU.Show();
            Hide();
        }

        private void EnableInputControls()
        {
            TextKode.Clear();
            TextNama.Clear();
            TextAlamat.Clear();
            TextHp.Clear();

            TextNama.Enabled = true;
            TextAlamat.Enabled = true;
            TextHp.Enabled = true;

            BtnSimpan.Enabled = true;
        }

        private void DisableInputControls()
        {
            TextKode.Enabled = false;
            TextNama.Enabled = false;
            TextAlamat.Enabled = false;
            TextHp.Enabled = false;

            BtnSimpan.Enabled = false;
        }
    }
}