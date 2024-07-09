namespace Aplikasi_Array
{
    partial class DataBuku
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TextKode = new TextBox();
            TextJudul = new TextBox();
            TextTahun = new TextBox();
            TextPenerbit = new TextBox();
            TextPenulis = new TextBox();
            TextStok = new TextBox();
            BtnSimpan = new Button();
            BtnTambah = new Button();
            label7 = new Label();
            Data_Buku = new DataGridView();
            BtnBack = new Button();
            Kode = new DataGridViewTextBoxColumn();
            Judul = new DataGridViewTextBoxColumn();
            Tahun = new DataGridViewTextBoxColumn();
            Penerbit = new DataGridViewTextBoxColumn();
            Penulis = new DataGridViewTextBoxColumn();
            Stok = new DataGridViewTextBoxColumn();
            Ubah = new DataGridViewButtonColumn();
            Hapus = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)Data_Buku).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(433, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Data Buku";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 51);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 1;
            label2.Text = "Kode Buku";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 85);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 2;
            label3.Text = "Judul Buku";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 119);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 3;
            label4.Text = "Tahun Terbit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 153);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 4;
            label5.Text = "Penerbit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 187);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 5;
            label6.Text = "Penulis";
            // 
            // TextKode
            // 
            TextKode.Location = new Point(127, 48);
            TextKode.Margin = new Padding(4, 3, 4, 3);
            TextKode.Name = "TextKode";
            TextKode.Size = new Size(155, 28);
            TextKode.TabIndex = 6;
            TextKode.KeyPress += TextKode_KeyPress;
            // 
            // TextJudul
            // 
            TextJudul.Location = new Point(127, 82);
            TextJudul.Margin = new Padding(4, 3, 4, 3);
            TextJudul.Name = "TextJudul";
            TextJudul.Size = new Size(155, 28);
            TextJudul.TabIndex = 7;
            TextJudul.KeyPress += TextJudul_KeyPress;
            // 
            // TextTahun
            // 
            TextTahun.Location = new Point(127, 116);
            TextTahun.Margin = new Padding(4, 3, 4, 3);
            TextTahun.Name = "TextTahun";
            TextTahun.Size = new Size(155, 28);
            TextTahun.TabIndex = 8;
            // 
            // TextPenerbit
            // 
            TextPenerbit.Location = new Point(127, 150);
            TextPenerbit.Margin = new Padding(4, 3, 4, 3);
            TextPenerbit.Name = "TextPenerbit";
            TextPenerbit.Size = new Size(155, 28);
            TextPenerbit.TabIndex = 9;
            TextPenerbit.KeyPress += TextPenerbit_KeyPress;
            // 
            // TextPenulis
            // 
            TextPenulis.Location = new Point(127, 184);
            TextPenulis.Margin = new Padding(4, 3, 4, 3);
            TextPenulis.Name = "TextPenulis";
            TextPenulis.Size = new Size(155, 28);
            TextPenulis.TabIndex = 10;
            TextPenulis.KeyPress += TextPenulis_KeyPress;
            // 
            // TextStok
            // 
            TextStok.Location = new Point(127, 218);
            TextStok.Margin = new Padding(4, 3, 4, 3);
            TextStok.Name = "TextStok";
            TextStok.Size = new Size(155, 28);
            TextStok.TabIndex = 11;
            TextStok.KeyPress += TextStok_KeyPress;
            // 
            // BtnSimpan
            // 
            BtnSimpan.Location = new Point(391, 81);
            BtnSimpan.Margin = new Padding(4, 3, 4, 3);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(100, 29);
            BtnSimpan.TabIndex = 12;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = true;
            BtnSimpan.Click += BtnSimpan_Click;
            // 
            // BtnTambah
            // 
            BtnTambah.Location = new Point(499, 81);
            BtnTambah.Margin = new Padding(4, 3, 4, 3);
            BtnTambah.Name = "BtnTambah";
            BtnTambah.Size = new Size(100, 29);
            BtnTambah.TabIndex = 14;
            BtnTambah.Text = "Tambah";
            BtnTambah.UseVisualStyleBackColor = true;
            BtnTambah.Click += BtnTambah_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 221);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 15;
            label7.Text = "Stok";
            // 
            // Data_Buku
            // 
            Data_Buku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data_Buku.Columns.AddRange(new DataGridViewColumn[] { Kode, Judul, Tahun, Penerbit, Penulis, Stok, Ubah, Hapus });
            Data_Buku.Location = new Point(25, 287);
            Data_Buku.Margin = new Padding(4, 3, 4, 3);
            Data_Buku.Name = "Data_Buku";
            Data_Buku.RowHeadersWidth = 51;
            Data_Buku.RowTemplate.Height = 29;
            Data_Buku.Size = new Size(1587, 488);
            Data_Buku.TabIndex = 16;
            Data_Buku.CellClick += Data_Buku_CellClick;
            Data_Buku.CellContentClick += Data_Buku_CellContentClick;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(391, 115);
            BtnBack.Margin = new Padding(4, 3, 4, 3);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(100, 29);
            BtnBack.TabIndex = 18;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // Kode
            // 
            Kode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kode.HeaderText = "Kode Buku";
            Kode.MinimumWidth = 6;
            Kode.Name = "Kode";
            // 
            // Judul
            // 
            Judul.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Judul.HeaderText = "Judul Buku";
            Judul.MinimumWidth = 6;
            Judul.Name = "Judul";
            // 
            // Tahun
            // 
            Tahun.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tahun.HeaderText = "Tahun Terbit";
            Tahun.MinimumWidth = 6;
            Tahun.Name = "Tahun";
            // 
            // Penerbit
            // 
            Penerbit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Penerbit.HeaderText = "Penerbit";
            Penerbit.MinimumWidth = 6;
            Penerbit.Name = "Penerbit";
            // 
            // Penulis
            // 
            Penulis.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Penulis.HeaderText = "Penulis";
            Penulis.MinimumWidth = 6;
            Penulis.Name = "Penulis";
            // 
            // Stok
            // 
            Stok.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Stok.HeaderText = "Stok";
            Stok.MinimumWidth = 6;
            Stok.Name = "Stok";
            // 
            // Ubah
            // 
            Ubah.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ubah.HeaderText = "Ubah Data";
            Ubah.MinimumWidth = 6;
            Ubah.Name = "Ubah";
            Ubah.Text = "Ubah";
            Ubah.UseColumnTextForButtonValue = true;
            // 
            // Hapus
            // 
            Hapus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Hapus.HeaderText = "Hapus Data";
            Hapus.MinimumWidth = 6;
            Hapus.Name = "Hapus";
            Hapus.Text = "Hapus";
            Hapus.UseColumnTextForButtonValue = true;
            // 
            // DataBuku
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1637, 810);
            Controls.Add(BtnBack);
            Controls.Add(Data_Buku);
            Controls.Add(label7);
            Controls.Add(BtnTambah);
            Controls.Add(BtnSimpan);
            Controls.Add(TextStok);
            Controls.Add(TextPenulis);
            Controls.Add(TextPenerbit);
            Controls.Add(TextTahun);
            Controls.Add(TextJudul);
            Controls.Add(TextKode);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DataBuku";
            Text = "DataBuku";
            Load += DataBuku_Load;
            ((System.ComponentModel.ISupportInitialize)Data_Buku).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TextKode;
        private TextBox TextJudul;
        private TextBox TextTahun;
        private TextBox TextPenerbit;
        private TextBox TextPenulis;
        private TextBox TextStok;
        private Button BtnSimpan;
        private Button BtnTambah;
        private Label label7;
        private DataGridView Data_Buku;
        private Button BtnBack;
        private DataGridViewTextBoxColumn Kode;
        private DataGridViewTextBoxColumn Judul;
        private DataGridViewTextBoxColumn Tahun;
        private DataGridViewTextBoxColumn Penerbit;
        private DataGridViewTextBoxColumn Penulis;
        private DataGridViewTextBoxColumn Stok;
        private DataGridViewButtonColumn Ubah;
        private DataGridViewButtonColumn Hapus;
    }
}