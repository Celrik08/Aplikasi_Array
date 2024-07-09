namespace Aplikasi_Array
{
    partial class DataAnggota
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
            TextKode = new TextBox();
            TextNama = new TextBox();
            TextAlamat = new TextBox();
            TextHp = new TextBox();
            Data_Anggota = new DataGridView();
            Kode = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            Alamat = new DataGridViewTextBoxColumn();
            No = new DataGridViewTextBoxColumn();
            Ubah = new DataGridViewButtonColumn();
            Hapus = new DataGridViewButtonColumn();
            BtnSimpan = new Button();
            BtnTambah = new Button();
            BtnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)Data_Anggota).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(307, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 23);
            label1.TabIndex = 0;
            label1.Text = "Data Anggota";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 82);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 1;
            label2.Text = "Kode Anggota";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 116);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 2;
            label3.Text = "Nama Anggota";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 150);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 3;
            label4.Text = "Alamat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 184);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 4;
            label5.Text = "No. Hp";
            // 
            // TextKode
            // 
            TextKode.Location = new Point(132, 79);
            TextKode.Margin = new Padding(4, 3, 4, 3);
            TextKode.Name = "TextKode";
            TextKode.Size = new Size(155, 28);
            TextKode.TabIndex = 5;
            // 
            // TextNama
            // 
            TextNama.Location = new Point(134, 113);
            TextNama.Margin = new Padding(4, 3, 4, 3);
            TextNama.Name = "TextNama";
            TextNama.Size = new Size(155, 28);
            TextNama.TabIndex = 6;
            TextNama.KeyPress += TextNama_KeyPress;
            // 
            // TextAlamat
            // 
            TextAlamat.Location = new Point(134, 147);
            TextAlamat.Margin = new Padding(4, 3, 4, 3);
            TextAlamat.Name = "TextAlamat";
            TextAlamat.Size = new Size(155, 28);
            TextAlamat.TabIndex = 7;
            TextAlamat.KeyPress += TextAlamat_KeyPress;
            // 
            // TextHp
            // 
            TextHp.Location = new Point(134, 181);
            TextHp.Margin = new Padding(4, 3, 4, 3);
            TextHp.Name = "TextHp";
            TextHp.Size = new Size(155, 28);
            TextHp.TabIndex = 8;
            TextHp.KeyPress += TextHp_KeyPress;
            // 
            // Data_Anggota
            // 
            Data_Anggota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data_Anggota.Columns.AddRange(new DataGridViewColumn[] { Kode, Nama, Alamat, No, Ubah, Hapus });
            Data_Anggota.Location = new Point(13, 231);
            Data_Anggota.Margin = new Padding(4, 3, 4, 3);
            Data_Anggota.Name = "Data_Anggota";
            Data_Anggota.RowHeadersWidth = 51;
            Data_Anggota.RowTemplate.Height = 29;
            Data_Anggota.Size = new Size(1085, 544);
            Data_Anggota.TabIndex = 9;
            Data_Anggota.CellClick += Data_Anggota_CellClick;
            Data_Anggota.CellContentClick += Data_Anggota_CellContentClick;
            // 
            // Kode
            // 
            Kode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kode.HeaderText = "Kode Anggota";
            Kode.MinimumWidth = 6;
            Kode.Name = "Kode";
            // 
            // Nama
            // 
            Nama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nama.HeaderText = "Nama Anggota";
            Nama.MinimumWidth = 6;
            Nama.Name = "Nama";
            // 
            // Alamat
            // 
            Alamat.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Alamat.HeaderText = "Alamat";
            Alamat.MinimumWidth = 6;
            Alamat.Name = "Alamat";
            // 
            // No
            // 
            No.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            No.HeaderText = "No. Hp";
            No.MinimumWidth = 6;
            No.Name = "No";
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
            // BtnSimpan
            // 
            BtnSimpan.Location = new Point(387, 78);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(94, 29);
            BtnSimpan.TabIndex = 10;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = true;
            BtnSimpan.Click += BtnSimpan_Click;
            // 
            // BtnTambah
            // 
            BtnTambah.Location = new Point(487, 78);
            BtnTambah.Name = "BtnTambah";
            BtnTambah.Size = new Size(94, 29);
            BtnTambah.TabIndex = 12;
            BtnTambah.Text = "Tambah";
            BtnTambah.UseVisualStyleBackColor = true;
            BtnTambah.Click += BtnTambah_Click;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(387, 116);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(94, 29);
            BtnBack.TabIndex = 14;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // DataAnggota
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 787);
            Controls.Add(BtnBack);
            Controls.Add(BtnTambah);
            Controls.Add(BtnSimpan);
            Controls.Add(Data_Anggota);
            Controls.Add(TextHp);
            Controls.Add(TextAlamat);
            Controls.Add(TextNama);
            Controls.Add(TextKode);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DataAnggota";
            Text = "DataAnggota";
            Load += DataAnggota_Load;
            ((System.ComponentModel.ISupportInitialize)Data_Anggota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TextKode;
        private TextBox TextNama;
        private TextBox TextAlamat;
        private TextBox TextHp;
        private DataGridView Data_Anggota;
        private Button BtnSimpan;
        private Button BtnTambah;
        private Button BtnBack;
        private Button BtnUpdate;
        private DataGridViewTextBoxColumn Kode;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Alamat;
        private DataGridViewTextBoxColumn No;
        private DataGridViewButtonColumn Ubah;
        private DataGridViewButtonColumn Hapus;
    }
}