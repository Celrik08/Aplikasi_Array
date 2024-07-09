namespace Aplikasi_Array
{
    partial class MenuUtama
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
            menuStrip1 = new MenuStrip();
            DataMaster = new ToolStripMenuItem();
            DataAnggota = new ToolStripMenuItem();
            DataBuku = new ToolStripMenuItem();
            DataTransaksi = new ToolStripMenuItem();
            DataPeminjaman = new ToolStripMenuItem();
            DataPengembalian = new ToolStripMenuItem();
            Back = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            TextUser = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { DataMaster, DataTransaksi, Back });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(522, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // DataMaster
            // 
            DataMaster.DropDownItems.AddRange(new ToolStripItem[] { DataAnggota, DataBuku });
            DataMaster.Name = "DataMaster";
            DataMaster.Size = new Size(112, 24);
            DataMaster.Text = "Data Master";
            // 
            // DataAnggota
            // 
            DataAnggota.Name = "DataAnggota";
            DataAnggota.Size = new Size(224, 26);
            DataAnggota.Text = "Data Anggota";
            DataAnggota.Click += DataAnggota_Click;
            // 
            // DataBuku
            // 
            DataBuku.Name = "DataBuku";
            DataBuku.Size = new Size(224, 26);
            DataBuku.Text = "Data Buku";
            DataBuku.Click += DataBuku_Click;
            // 
            // DataTransaksi
            // 
            DataTransaksi.DropDownItems.AddRange(new ToolStripItem[] { DataPeminjaman, DataPengembalian });
            DataTransaksi.Name = "DataTransaksi";
            DataTransaksi.Size = new Size(131, 24);
            DataTransaksi.Text = "Data Transaksi";
            // 
            // DataPeminjaman
            // 
            DataPeminjaman.Name = "DataPeminjaman";
            DataPeminjaman.Size = new Size(231, 26);
            DataPeminjaman.Text = "Data Peminjaman";
            DataPeminjaman.Click += DataPeminjaman_Click;
            // 
            // DataPengembalian
            // 
            DataPengembalian.Name = "DataPengembalian";
            DataPengembalian.Size = new Size(231, 26);
            DataPengembalian.Text = "Data Pengembalian";
            DataPengembalian.Click += DataPengembalian_Click;
            // 
            // Back
            // 
            Back.Name = "Back";
            Back.Size = new Size(60, 24);
            Back.Text = "Back";
            Back.Click += Back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(195, 65);
            label1.Name = "label1";
            label1.Size = new Size(119, 23);
            label1.TabIndex = 1;
            label1.Text = "Menu Utama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(192, 179);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 2;
            label2.Text = "Selamat Datang";
            // 
            // TextUser
            // 
            TextUser.AutoSize = true;
            TextUser.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextUser.Location = new Point(195, 239);
            TextUser.Name = "TextUser";
            TextUser.Size = new Size(99, 20);
            TextUser.TabIndex = 3;
            TextUser.Text = "__________";
            // 
            // MenuUtama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 361);
            Controls.Add(TextUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuUtama";
            Text = "MenuUtama";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem DataMaster;
        private ToolStripMenuItem DataBuku;
        private ToolStripMenuItem DataAnggota;
        private ToolStripMenuItem DataTransaksi;
        private ToolStripMenuItem DataPeminjaman;
        private ToolStripMenuItem Back;
        private Label label1;
        private Label label2;
        private Label TextUser;
        private ToolStripMenuItem DataPengembalian;
    }
}