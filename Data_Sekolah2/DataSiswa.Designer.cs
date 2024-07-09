namespace Data_Sekolah2
{
    partial class DataSiswa
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
            BtnHapus = new Button();
            BtnUbah = new Button();
            BtnBack = new Button();
            BtnSimpan = new Button();
            BtnTambah = new Button();
            Data_Siswa = new DataGridView();
            NISN = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            Nomor = new DataGridViewTextBoxColumn();
            Alamat = new DataGridViewTextBoxColumn();
            Hapus = new DataGridViewButtonColumn();
            TextNama = new TextBox();
            TextNISN = new TextBox();
            Label3 = new Label();
            Label2 = new Label();
            label1 = new Label();
            TextNomor = new TextBox();
            label4 = new Label();
            TextAlamat = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)Data_Siswa).BeginInit();
            SuspendLayout();
            // 
            // BtnHapus
            // 
            BtnHapus.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnHapus.Location = new Point(521, 151);
            BtnHapus.Margin = new Padding(4, 3, 4, 3);
            BtnHapus.Name = "BtnHapus";
            BtnHapus.Size = new Size(118, 29);
            BtnHapus.TabIndex = 40;
            BtnHapus.Text = "Hapus";
            BtnHapus.UseVisualStyleBackColor = true;
            BtnHapus.Click += BtnHapus_Click;
            // 
            // BtnUbah
            // 
            BtnUbah.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnUbah.Location = new Point(752, 81);
            BtnUbah.Margin = new Padding(4, 3, 4, 3);
            BtnUbah.Name = "BtnUbah";
            BtnUbah.Size = new Size(118, 29);
            BtnUbah.TabIndex = 39;
            BtnUbah.Text = "Ubah";
            BtnUbah.UseVisualStyleBackColor = true;
            BtnUbah.Click += BtnUbah_Click;
            // 
            // BtnBack
            // 
            BtnBack.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBack.Location = new Point(752, 151);
            BtnBack.Margin = new Padding(4, 3, 4, 3);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(118, 29);
            BtnBack.TabIndex = 38;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnSimpan
            // 
            BtnSimpan.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSimpan.Location = new Point(521, 81);
            BtnSimpan.Margin = new Padding(4, 3, 4, 3);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(118, 29);
            BtnSimpan.TabIndex = 37;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = true;
            BtnSimpan.Click += BtnSimpan_Click;
            // 
            // BtnTambah
            // 
            BtnTambah.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnTambah.Location = new Point(638, 116);
            BtnTambah.Margin = new Padding(4, 3, 4, 3);
            BtnTambah.Name = "BtnTambah";
            BtnTambah.Size = new Size(118, 29);
            BtnTambah.TabIndex = 36;
            BtnTambah.Text = "Tambah";
            BtnTambah.UseVisualStyleBackColor = true;
            BtnTambah.Click += BtnTambah_Click;
            // 
            // Data_Siswa
            // 
            Data_Siswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data_Siswa.Columns.AddRange(new DataGridViewColumn[] { NISN, Nama, Nomor, Alamat, Hapus });
            Data_Siswa.Location = new Point(48, 254);
            Data_Siswa.Margin = new Padding(4, 3, 4, 3);
            Data_Siswa.Name = "Data_Siswa";
            Data_Siswa.RowHeadersWidth = 51;
            Data_Siswa.RowTemplate.Height = 29;
            Data_Siswa.Size = new Size(1041, 417);
            Data_Siswa.TabIndex = 35;
            Data_Siswa.CellClick += Data_Siswa_CellClick;
            Data_Siswa.CellContentClick += Data_Siswa_CellContentClick;
            // 
            // NISN
            // 
            NISN.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NISN.HeaderText = "NISN";
            NISN.MinimumWidth = 6;
            NISN.Name = "NISN";
            // 
            // Nama
            // 
            Nama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nama.HeaderText = "Nama Siswa";
            Nama.MinimumWidth = 6;
            Nama.Name = "Nama";
            // 
            // Nomor
            // 
            Nomor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nomor.HeaderText = "Nomor Hp";
            Nomor.MinimumWidth = 6;
            Nomor.Name = "Nomor";
            // 
            // Alamat
            // 
            Alamat.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Alamat.HeaderText = "Alamat";
            Alamat.MinimumWidth = 6;
            Alamat.Name = "Alamat";
            // 
            // Hapus
            // 
            Hapus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Hapus.HeaderText = "Hapus Data";
            Hapus.MinimumWidth = 6;
            Hapus.Name = "Hapus";
            Hapus.Text = "delete";
            Hapus.UseColumnTextForButtonValue = true;
            // 
            // TextNama
            // 
            TextNama.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNama.Location = new Point(221, 123);
            TextNama.Margin = new Padding(4, 3, 4, 3);
            TextNama.Name = "TextNama";
            TextNama.Size = new Size(155, 28);
            TextNama.TabIndex = 34;
            TextNama.KeyPress += TextNama_KeyPress;
            // 
            // TextNISN
            // 
            TextNISN.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNISN.Location = new Point(221, 90);
            TextNISN.Margin = new Padding(4, 3, 4, 3);
            TextNISN.Name = "TextNISN";
            TextNISN.Size = new Size(155, 28);
            TextNISN.TabIndex = 33;
            TextNISN.KeyPress += TextNISN_KeyPress;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Label3.Location = new Point(48, 130);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(99, 20);
            Label3.TabIndex = 32;
            Label3.Text = "Nama Siswa";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.Location = new Point(48, 97);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(51, 20);
            Label2.TabIndex = 31;
            Label2.Text = "NISN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(445, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 23);
            label1.TabIndex = 30;
            label1.Text = "Data Siswa";
            // 
            // TextNomor
            // 
            TextNomor.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNomor.Location = new Point(221, 157);
            TextNomor.Margin = new Padding(4, 3, 4, 3);
            TextNomor.Name = "TextNomor";
            TextNomor.Size = new Size(155, 28);
            TextNomor.TabIndex = 42;
            TextNomor.KeyPress += TextNomor_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(48, 164);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 41;
            label4.Text = "Nomor Hp";
            // 
            // TextAlamat
            // 
            TextAlamat.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextAlamat.Location = new Point(221, 191);
            TextAlamat.Margin = new Padding(4, 3, 4, 3);
            TextAlamat.Name = "TextAlamat";
            TextAlamat.Size = new Size(155, 28);
            TextAlamat.TabIndex = 44;
            TextAlamat.KeyPress += TextAlamat_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(48, 198);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 43;
            label5.Text = "Alamat";
            // 
            // DataSiswa
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 714);
            Controls.Add(TextAlamat);
            Controls.Add(label5);
            Controls.Add(TextNomor);
            Controls.Add(label4);
            Controls.Add(BtnHapus);
            Controls.Add(BtnUbah);
            Controls.Add(BtnBack);
            Controls.Add(BtnSimpan);
            Controls.Add(BtnTambah);
            Controls.Add(Data_Siswa);
            Controls.Add(TextNama);
            Controls.Add(TextNISN);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DataSiswa";
            Text = "DataSiswa";
            Load += DataSiswa_Load;
            ((System.ComponentModel.ISupportInitialize)Data_Siswa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnHapus;
        private Button BtnUbah;
        private Button BtnBack;
        private Button BtnSimpan;
        private Button BtnTambah;
        private DataGridView Data_Siswa;
        private TextBox TextNama;
        private TextBox TextNISN;
        private Label Label3;
        private Label Label2;
        private Label label1;
        private TextBox TextNomor;
        private Label label4;
        private TextBox TextAlamat;
        private Label label5;
        private DataGridViewTextBoxColumn NISN;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Nomor;
        private DataGridViewTextBoxColumn Alamat;
        private DataGridViewButtonColumn Hapus;
    }
}