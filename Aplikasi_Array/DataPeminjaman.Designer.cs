namespace Aplikasi_Array
{
    partial class DataPeminjaman
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
            label5 = new Label();
            TextKode = new TextBox();
            TextTanggal = new TextBox();
            BtnSimpan = new Button();
            BtnTambah = new Button();
            BtnBack = new Button();
            Data_Peminjaman = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Tanggal = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            Judul = new DataGridViewTextBoxColumn();
            Hapus = new DataGridViewButtonColumn();
            label4 = new Label();
            TextBuku = new TextBox();
            TextAnggota = new TextBox();
            ComboBuku = new ComboBox();
            ComboAnggota = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)Data_Peminjaman).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(346, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 23);
            label1.TabIndex = 0;
            label1.Text = "Data Peminjaman";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 45);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 1;
            label2.Text = "Id Peminjaman";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 79);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 2;
            label3.Text = "Tanggal Peminjam";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 215);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 4;
            label5.Text = "Judul Buku";
            // 
            // TextKode
            // 
            TextKode.Location = new Point(165, 42);
            TextKode.Name = "TextKode";
            TextKode.Size = new Size(151, 28);
            TextKode.TabIndex = 5;
            // 
            // TextTanggal
            // 
            TextTanggal.Location = new Point(165, 76);
            TextTanggal.Name = "TextTanggal";
            TextTanggal.Size = new Size(151, 28);
            TextTanggal.TabIndex = 6;
            // 
            // BtnSimpan
            // 
            BtnSimpan.Location = new Point(415, 58);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(94, 29);
            BtnSimpan.TabIndex = 9;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = true;
            BtnSimpan.Click += BtnSimpan_Click;
            // 
            // BtnTambah
            // 
            BtnTambah.Location = new Point(515, 58);
            BtnTambah.Name = "BtnTambah";
            BtnTambah.Size = new Size(94, 29);
            BtnTambah.TabIndex = 10;
            BtnTambah.Text = "Tambah";
            BtnTambah.UseVisualStyleBackColor = true;
            BtnTambah.Click += BtnTambah_Click;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(515, 93);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(94, 29);
            BtnBack.TabIndex = 11;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            // 
            // Data_Peminjaman
            // 
            Data_Peminjaman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data_Peminjaman.Columns.AddRange(new DataGridViewColumn[] { Id, Tanggal, Nama, Judul, Hapus });
            Data_Peminjaman.Location = new Point(16, 289);
            Data_Peminjaman.Name = "Data_Peminjaman";
            Data_Peminjaman.RowHeadersWidth = 51;
            Data_Peminjaman.RowTemplate.Height = 29;
            Data_Peminjaman.Size = new Size(1266, 610);
            Data_Peminjaman.TabIndex = 12;
            Data_Peminjaman.CellClick += Data_Peminjaman_CellClick;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.HeaderText = "Id Peminjaman";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            // 
            // Tanggal
            // 
            Tanggal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tanggal.HeaderText = "Tanggal Peminjam";
            Tanggal.MinimumWidth = 6;
            Tanggal.Name = "Tanggal";
            // 
            // Nama
            // 
            Nama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nama.HeaderText = "Nama Peminjam";
            Nama.MinimumWidth = 6;
            Nama.Name = "Nama";
            // 
            // Judul
            // 
            Judul.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Judul.HeaderText = "Judul Buku";
            Judul.MinimumWidth = 6;
            Judul.Name = "Judul";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 147);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 3;
            label4.Text = "Nama Anggota";
            // 
            // TextBuku
            // 
            TextBuku.Location = new Point(165, 212);
            TextBuku.Name = "TextBuku";
            TextBuku.Size = new Size(151, 28);
            TextBuku.TabIndex = 8;
            TextBuku.KeyPress += TextJudul_KeyPress;
            // 
            // TextAnggota
            // 
            TextAnggota.Location = new Point(165, 144);
            TextAnggota.Name = "TextAnggota";
            TextAnggota.Size = new Size(151, 28);
            TextAnggota.TabIndex = 7;
            TextAnggota.KeyPress += TextNama_KeyPress;
            // 
            // ComboBuku
            // 
            ComboBuku.FormattingEnabled = true;
            ComboBuku.Location = new Point(165, 178);
            ComboBuku.Name = "ComboBuku";
            ComboBuku.Size = new Size(151, 28);
            ComboBuku.TabIndex = 13;
            ComboBuku.SelectedIndexChanged += ComboBuku_SelectedIndexChanged;
            // 
            // ComboAnggota
            // 
            ComboAnggota.FormattingEnabled = true;
            ComboAnggota.Location = new Point(165, 110);
            ComboAnggota.Name = "ComboAnggota";
            ComboAnggota.Size = new Size(151, 28);
            ComboAnggota.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 113);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 15;
            label6.Text = "Id Anggota";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 181);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 16;
            label7.Text = "Id Buku";
            // 
            // button1
            // 
            button1.Location = new Point(415, 93);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 17;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            // 
            // DataPeminjaman
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 911);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(ComboAnggota);
            Controls.Add(ComboBuku);
            Controls.Add(Data_Peminjaman);
            Controls.Add(BtnBack);
            Controls.Add(BtnTambah);
            Controls.Add(BtnSimpan);
            Controls.Add(TextBuku);
            Controls.Add(TextAnggota);
            Controls.Add(TextTanggal);
            Controls.Add(TextKode);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DataPeminjaman";
            Text = "DataPeminjaman";
            Load += DataPeminjaman_Load;
            ((System.ComponentModel.ISupportInitialize)Data_Peminjaman).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox TextKode;
        private TextBox TextTanggal;
        private Button BtnSimpan;
        private Button BtnTambah;
        private Button BtnBack;
        private DataGridView Data_Peminjaman;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Tanggal;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Judul;
        private DataGridViewButtonColumn Hapus;
        private Label label4;
        private TextBox TextBuku;
        private TextBox TextAnggota;
        private ComboBox ComboBuku;
        private ComboBox ComboAnggota;
        private Label label6;
        private Label label7;
        private Button button1;
    }
}