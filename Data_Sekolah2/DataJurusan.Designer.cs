namespace Data_Sekolah2
{
    partial class DataJurusan
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
            Data_Jurusan = new DataGridView();
            Jurusan = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            Hapus = new DataGridViewButtonColumn();
            TextNama = new TextBox();
            LabelNama = new Label();
            LabelJudul = new Label();
            TextJurusan = new TextBox();
            LabelId = new Label();
            ((System.ComponentModel.ISupportInitialize)Data_Jurusan).BeginInit();
            SuspendLayout();
            // 
            // BtnHapus
            // 
            BtnHapus.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnHapus.Location = new Point(468, 165);
            BtnHapus.Margin = new Padding(4, 3, 4, 3);
            BtnHapus.Name = "BtnHapus";
            BtnHapus.Size = new Size(101, 29);
            BtnHapus.TabIndex = 29;
            BtnHapus.Text = "Hapus";
            BtnHapus.UseVisualStyleBackColor = true;
            BtnHapus.Click += BtnHapus_Click;
            // 
            // BtnUbah
            // 
            BtnUbah.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnUbah.Location = new Point(669, 95);
            BtnUbah.Margin = new Padding(4, 3, 4, 3);
            BtnUbah.Name = "BtnUbah";
            BtnUbah.Size = new Size(101, 29);
            BtnUbah.TabIndex = 28;
            BtnUbah.Text = "Ubah";
            BtnUbah.UseVisualStyleBackColor = true;
            BtnUbah.Click += BtnUbah_Click;
            // 
            // BtnBack
            // 
            BtnBack.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBack.Location = new Point(669, 165);
            BtnBack.Margin = new Padding(4, 3, 4, 3);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(101, 29);
            BtnBack.TabIndex = 27;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnSimpan
            // 
            BtnSimpan.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSimpan.Location = new Point(468, 95);
            BtnSimpan.Margin = new Padding(4, 3, 4, 3);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(101, 29);
            BtnSimpan.TabIndex = 26;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = true;
            BtnSimpan.Click += BtnSimpan_Click;
            // 
            // BtnTambah
            // 
            BtnTambah.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnTambah.Location = new Point(568, 130);
            BtnTambah.Margin = new Padding(4, 3, 4, 3);
            BtnTambah.Name = "BtnTambah";
            BtnTambah.Size = new Size(101, 29);
            BtnTambah.TabIndex = 25;
            BtnTambah.Text = "Tambah";
            BtnTambah.UseVisualStyleBackColor = true;
            BtnTambah.Click += BtnTambah_Click;
            // 
            // Data_Jurusan
            // 
            Data_Jurusan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data_Jurusan.Columns.AddRange(new DataGridViewColumn[] { Jurusan, Nama, Hapus });
            Data_Jurusan.Location = new Point(49, 227);
            Data_Jurusan.Margin = new Padding(4, 3, 4, 3);
            Data_Jurusan.Name = "Data_Jurusan";
            Data_Jurusan.RowHeadersWidth = 51;
            Data_Jurusan.RowTemplate.Height = 29;
            Data_Jurusan.Size = new Size(944, 417);
            Data_Jurusan.TabIndex = 24;
            Data_Jurusan.CellClick += Data_Jurusan_CellClick;
            Data_Jurusan.CellContentClick += Data_Jurusan_CellContentClick;
            // 
            // Jurusan
            // 
            Jurusan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Jurusan.HeaderText = "Id Jurusan";
            Jurusan.MinimumWidth = 6;
            Jurusan.Name = "Jurusan";
            // 
            // Nama
            // 
            Nama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nama.HeaderText = "Nama Jurusan";
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
            TextNama.Location = new Point(232, 143);
            TextNama.Margin = new Padding(4, 3, 4, 3);
            TextNama.Name = "TextNama";
            TextNama.Size = new Size(155, 28);
            TextNama.TabIndex = 21;
            TextNama.KeyPress += TextNama_KeyPress;
            // 
            // LabelNama
            // 
            LabelNama.AutoSize = true;
            LabelNama.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNama.Location = new Point(59, 150);
            LabelNama.Margin = new Padding(4, 0, 4, 0);
            LabelNama.Name = "LabelNama";
            LabelNama.Size = new Size(112, 20);
            LabelNama.TabIndex = 17;
            LabelNama.Text = "Nama Jurusan";
            // 
            // LabelJudul
            // 
            LabelJudul.AutoSize = true;
            LabelJudul.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelJudul.Location = new Point(447, 27);
            LabelJudul.Margin = new Padding(4, 0, 4, 0);
            LabelJudul.Name = "LabelJudul";
            LabelJudul.Size = new Size(122, 23);
            LabelJudul.TabIndex = 15;
            LabelJudul.Text = "Data Jurusan";
            // 
            // TextJurusan
            // 
            TextJurusan.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextJurusan.Location = new Point(232, 109);
            TextJurusan.Margin = new Padding(4, 3, 4, 3);
            TextJurusan.Name = "TextJurusan";
            TextJurusan.Size = new Size(155, 28);
            TextJurusan.TabIndex = 31;
            // 
            // LabelId
            // 
            LabelId.AutoSize = true;
            LabelId.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelId.Location = new Point(59, 116);
            LabelId.Margin = new Padding(4, 0, 4, 0);
            LabelId.Name = "LabelId";
            LabelId.Size = new Size(84, 20);
            LabelId.TabIndex = 30;
            LabelId.Text = "Id Jurusan";
            // 
            // DataJurusan
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 679);
            Controls.Add(TextJurusan);
            Controls.Add(LabelId);
            Controls.Add(BtnHapus);
            Controls.Add(BtnUbah);
            Controls.Add(BtnBack);
            Controls.Add(BtnSimpan);
            Controls.Add(BtnTambah);
            Controls.Add(Data_Jurusan);
            Controls.Add(TextNama);
            Controls.Add(LabelNama);
            Controls.Add(LabelJudul);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DataJurusan";
            Text = "DataJurusan";
            Load += DataJurusan_Load;
            ((System.ComponentModel.ISupportInitialize)Data_Jurusan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnHapus;
        private Button BtnUbah;
        private Button BtnBack;
        private Button BtnSimpan;
        private Button BtnTambah;
        private DataGridView Data_Jurusan;
        private TextBox TextNama;
        private Label LabelNama;
        private Label LabelJudul;
        private TextBox TextJurusan;
        private Label LabelId;
        private DataGridViewTextBoxColumn Jurusan;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewButtonColumn Hapus;
    }
}