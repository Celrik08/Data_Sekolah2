namespace Data_Sekolah2
{
    partial class DataKelas
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
            Data_Kelas = new DataGridView();
            Kelas = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            Hapus = new DataGridViewButtonColumn();
            TextNama = new TextBox();
            Label3 = new Label();
            label1 = new Label();
            TextKelas = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)Data_Kelas).BeginInit();
            SuspendLayout();
            // 
            // BtnHapus
            // 
            BtnHapus.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnHapus.Location = new Point(533, 159);
            BtnHapus.Margin = new Padding(4, 3, 4, 3);
            BtnHapus.Name = "BtnHapus";
            BtnHapus.Size = new Size(103, 29);
            BtnHapus.TabIndex = 55;
            BtnHapus.Text = "Hapus";
            BtnHapus.UseVisualStyleBackColor = true;
            BtnHapus.Click += BtnHapus_Click;
            // 
            // BtnUbah
            // 
            BtnUbah.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnUbah.Location = new Point(737, 89);
            BtnUbah.Margin = new Padding(4, 3, 4, 3);
            BtnUbah.Name = "BtnUbah";
            BtnUbah.Size = new Size(103, 29);
            BtnUbah.TabIndex = 54;
            BtnUbah.Text = "Ubah";
            BtnUbah.UseVisualStyleBackColor = true;
            BtnUbah.Click += BtnUbah_Click;
            // 
            // BtnBack
            // 
            BtnBack.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBack.Location = new Point(737, 155);
            BtnBack.Margin = new Padding(4, 3, 4, 3);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(103, 29);
            BtnBack.TabIndex = 53;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnSimpan
            // 
            BtnSimpan.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSimpan.Location = new Point(533, 89);
            BtnSimpan.Margin = new Padding(4, 3, 4, 3);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(103, 29);
            BtnSimpan.TabIndex = 52;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = true;
            // 
            // BtnTambah
            // 
            BtnTambah.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnTambah.Location = new Point(635, 124);
            BtnTambah.Margin = new Padding(4, 3, 4, 3);
            BtnTambah.Name = "BtnTambah";
            BtnTambah.Size = new Size(103, 29);
            BtnTambah.TabIndex = 51;
            BtnTambah.Text = "Tambah";
            BtnTambah.UseVisualStyleBackColor = true;
            BtnTambah.Click += BtnTambah_Click;
            // 
            // Data_Kelas
            // 
            Data_Kelas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data_Kelas.Columns.AddRange(new DataGridViewColumn[] { Kelas, Nama, Hapus });
            Data_Kelas.Location = new Point(32, 255);
            Data_Kelas.Margin = new Padding(4, 3, 4, 3);
            Data_Kelas.Name = "Data_Kelas";
            Data_Kelas.RowHeadersWidth = 51;
            Data_Kelas.RowTemplate.Height = 29;
            Data_Kelas.Size = new Size(885, 417);
            Data_Kelas.TabIndex = 50;
            Data_Kelas.CellClick += Data_Kelas_CellClick;
            Data_Kelas.CellContentClick += Data_Kelas_CellContentClick;
            // 
            // Kelas
            // 
            Kelas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kelas.HeaderText = "Id Kelas";
            Kelas.MinimumWidth = 6;
            Kelas.Name = "Kelas";
            // 
            // Nama
            // 
            Nama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nama.HeaderText = "Nama Kelas";
            Nama.MinimumWidth = 6;
            Nama.Name = "Nama";
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
            TextNama.Location = new Point(211, 152);
            TextNama.Margin = new Padding(4, 3, 4, 3);
            TextNama.Name = "TextNama";
            TextNama.Size = new Size(155, 28);
            TextNama.TabIndex = 49;
            TextNama.KeyPress += TextNama_KeyPress;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Label3.Location = new Point(38, 159);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(97, 20);
            Label3.TabIndex = 47;
            Label3.Text = "Nama Kelas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(415, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 23);
            label1.TabIndex = 45;
            label1.Text = "Data Kelas";
            // 
            // TextKelas
            // 
            TextKelas.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextKelas.Location = new Point(211, 117);
            TextKelas.Margin = new Padding(4, 3, 4, 3);
            TextKelas.Name = "TextKelas";
            TextKelas.Size = new Size(155, 28);
            TextKelas.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(38, 124);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 56;
            label6.Text = "Id Kelas";
            // 
            // DataKelas
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 713);
            Controls.Add(TextKelas);
            Controls.Add(label6);
            Controls.Add(BtnHapus);
            Controls.Add(BtnUbah);
            Controls.Add(BtnBack);
            Controls.Add(BtnSimpan);
            Controls.Add(BtnTambah);
            Controls.Add(Data_Kelas);
            Controls.Add(TextNama);
            Controls.Add(Label3);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DataKelas";
            Text = "DataKelas";
            Load += DataKelas_Load;
            ((System.ComponentModel.ISupportInitialize)Data_Kelas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextAlamat;
        private Label label5;
        private TextBox TextNomor;
        private Label label4;
        private Button BtnHapus;
        private Button BtnUbah;
        private Button BtnBack;
        private Button BtnSimpan;
        private Button BtnTambah;
        private DataGridView Data_Kelas;
        private DataGridViewTextBoxColumn nis;
        private DataGridViewTextBoxColumn Nomor;
        private DataGridViewTextBoxColumn Alamat;
        private TextBox TextNama;
        private TextBox TextNISN;
        private Label Label3;
        private Label Label2;
        private Label label1;
        private TextBox TextKelas;
        private Label label6;
        private DataGridViewTextBoxColumn Kelas;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewButtonColumn Hapus;
    }
}