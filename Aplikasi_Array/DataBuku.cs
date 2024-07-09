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
    public partial class DataBuku : Form
    {
        private string userLevel;
        public List<string[]> dataBukuList; // Array untuk menyimpan data anggota
        private int selectedRowIndex = -1;
        public DataBuku(string userLevel)
        {
            InitializeComponent();
            InitializeDataGrid(); // Panggil metode untuk menganisialisasi array dan menampilkan di DataGridView
            this.userLevel = userLevel;
        }

        public void InitializeDataGrid()
        {
            // Inisialisasi array dengan data anggota
            dataBukuList = new List<string[]>
            {
                new string [] {"1", "IPA", "2005", "ERLANGGA", "Fajar", "4"},
                new string [] {"2", "IPS", "2000", "ERLANGGA", "Safwan", "2"},
                new string [] {"3", "Matematika", "2001", "ERLANGGA", "Fathur", "3"}
            };

            // Tambahkan event handler CellClik
            Data_Buku.CellClick += Data_Buku_CellClick;

            // Menampilkan data array di DataGridView
            LoadDataToDataGridView();
        }

        private void TextKode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                TextJudul.Focus();
            }
        }

        private void TextJudul_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                TextPenerbit.Focus();
            }
        }

        private void TextPenerbit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                TextPenulis.Focus();
            }
        }

        private void TextPenulis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                TextStok.Focus();
            }
        }

        private void TextStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                PerformBuku();
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            PerformBuku();
        }

        private void PerformBuku()
        {
            // Menyimpan data buku dataBuku ke DataGridView
            LoadDataToDataGridView();

            // Menambahkan data baru dari TextBox ke array
            string id = (dataBukuList.Count + 1).ToString(); // ID baru
            string judul = TextJudul.Text;
            string tahun = TextTahun.Text;
            string penerbit = TextPenerbit.Text;
            string penulis = TextPenulis.Text;
            string stok = TextStok.Text;

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(judul) || string.IsNullOrWhiteSpace(tahun) || string.IsNullOrWhiteSpace(penerbit) || string.IsNullOrWhiteSpace(penulis) || string.IsNullOrWhiteSpace(penulis) || string.IsNullOrWhiteSpace(stok))
            {
                MessageBox.Show("Semua kolom harus diisi", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Menambahkan data baru ke array
            string[] newData = new string[] { id, judul, tahun, penerbit, penulis, stok };
            dataBukuList.Add(newData);

            // Menampilkan data array yang diperbarui di DataGridView
            LoadDataToDataGridView();

            // Bersihkan TextBox setelah menyimpan
            TextKode.Clear();
            TextJudul.Clear();
            TextTahun.Clear();
            TextPenerbit.Clear();
            TextPenulis.Clear();
            TextStok.Clear();
        }

        private void DataBuku_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            DisableInputControls();
        }

        private void LoadDataToDataGridView()
        {
            Data_Buku.Rows.Clear();

            if (dataBukuList != null)
            {
                foreach (var rowData in dataBukuList)
                {
                    Data_Buku.Rows.Add(rowData[0], rowData[1], rowData[2], rowData[3], rowData[4], rowData[5]);
                }
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            EnableInputControls();

            // Menghasilkan tahun secara otomatis antara 2001 ke 2010
            Random random = new Random();
            int randomYear = random.Next(2001, 2011);
            TextTahun.Text = randomYear.ToString();
        }

        private void Data_Buku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < Data_Buku.Rows.Count)
            {
                selectedRowIndex = e.RowIndex;

                // Periksa apakah sel yang diklik tidak null sebelum mengambil nilai
                if (Data_Buku.Rows[selectedRowIndex].Cells[0].Value != null)
                {
                    TextKode.Text = Data_Buku.Rows[selectedRowIndex].Cells[0].Value.ToString();
                }
                else
                {
                    TextKode.Text = string.Empty;
                }

                if (Data_Buku.Rows[selectedRowIndex].Cells[1].Value != null)
                {
                    TextJudul.Text = Data_Buku.Rows[selectedRowIndex].Cells[1].Value.ToString();
                }
                else
                {
                    TextJudul.Text = string.Empty;
                }

                if (Data_Buku.Rows[selectedRowIndex].Cells[2].Value != null)
                {
                    TextTahun.Text = Data_Buku.Rows[selectedRowIndex].Cells[2].Value.ToString();
                }
                else
                {
                    TextTahun.Text = string.Empty;
                }

                if (Data_Buku.Rows[selectedRowIndex].Cells[3].Value != null)
                {
                    TextPenerbit.Text = Data_Buku.Rows[selectedRowIndex].Cells[3].Value.ToString();
                }
                else
                {
                    TextPenerbit.Text = string.Empty;
                }

                if (Data_Buku.Rows[selectedRowIndex].Cells[4].Value != null)
                {
                    TextPenulis.Text = Data_Buku.Rows[selectedRowIndex].Cells[4].Value.ToString();
                }
                else
                {
                    TextPenulis.Text = string.Empty;
                }

                if (Data_Buku.Rows[selectedRowIndex].Cells[5].Value != null)
                {
                    TextStok.Text = Data_Buku.Rows[selectedRowIndex].Cells[5].Value.ToString();
                }
                else
                {
                    TextStok.Text = string.Empty;
                }

                BtnSimpan.Enabled = false;
            }
        }

        private void Data_Buku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Data_Buku.Columns["Ubah"].Index && e.RowIndex >= 0)
            {
                // Ambil indeks baris yang dipilih
                int rowIndex = e.RowIndex;

                // Tampilkan data yang dipilih di TextBox
                TextJudul.Text = dataBukuList[rowIndex][1];
                TextTahun.Text = dataBukuList[rowIndex][2];
                TextPenerbit.Text = dataBukuList[rowIndex][3];
                TextPenulis.Text = dataBukuList[rowIndex][4];
                TextStok.Text = dataBukuList[rowIndex][5];

                // Matikan fungsi BtnSimpan untuk menghindari duplikasi data
                BtnSimpan.Enabled = false;
            }
            else if (e.ColumnIndex == Data_Buku.Columns["Hapus"].Index && e.RowIndex >= 0)
            {
                // Pastikan kolom yang diklik adalah kolom Hapus Data dan bukan header
                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Hapus item dari array
                    dataBukuList.RemoveAt(selectedRowIndex);

                    // Reload tampilan DataGridView
                    LoadDataToDataGridView();

                    // Bersihkan TextBox setelah menghapus
                    TextKode.Clear();
                    TextJudul.Clear();
                    TextTahun.Clear();
                    TextPenerbit.Clear();
                    TextPenulis.Clear();
                    TextStok.Clear();

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
            TextJudul.Clear();
            TextTahun.Clear();
            TextPenerbit.Clear();
            TextPenulis.Clear();
            TextStok.Clear();

            TextJudul.Enabled = true;
            TextPenerbit.Enabled = true;
            TextPenulis.Enabled = true;
            TextStok.Enabled = true;

            BtnSimpan.Enabled = true;
        }

        private void DisableInputControls()
        {
            TextKode.Enabled = false;
            TextJudul.Enabled = false;
            TextTahun.Enabled = false;
            TextPenerbit.Enabled = false;
            TextPenulis.Enabled = false;
            TextStok.Enabled = false;

            BtnSimpan.Enabled = false;
        }
    }
}