namespace Data_Sekolah2
{
    partial class DataMapel
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
            Data_Mapel = new DataGridView();
            Mapel = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            Hapus = new DataGridViewButtonColumn();
            TextNama = new TextBox();
            Label3 = new Label();
            label1 = new Label();
            TextMapel = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Data_Mapel).BeginInit();
            SuspendLayout();
            // 
            // BtnHapus
            // 
            BtnHapus.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnHapus.Location = new Point(542, 155);
            BtnHapus.Margin = new Padding(4, 3, 4, 3);
            BtnHapus.Name = "BtnHapus";
            BtnHapus.Size = new Size(104, 29);
            BtnHapus.TabIndex = 55;
            BtnHapus.Text = "Hapus";
            BtnHapus.UseVisualStyleBackColor = true;
            BtnHapus.Click += BtnHapus_Click;
            // 
            // BtnUbah
            // 
            BtnUbah.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnUbah.Location = new Point(747, 85);
            BtnUbah.Margin = new Padding(4, 3, 4, 3);
            BtnUbah.Name = "BtnUbah";
            BtnUbah.Size = new Size(104, 29);
            BtnUbah.TabIndex = 54;
            BtnUbah.Text = "Ubah";
            BtnUbah.UseVisualStyleBackColor = true;
            BtnUbah.Click += BtnUbah_Click;
            // 
            // BtnBack
            // 
            BtnBack.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBack.Location = new Point(747, 155);
            BtnBack.Margin = new Padding(4, 3, 4, 3);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(104, 29);
            BtnBack.TabIndex = 53;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnSimpan
            // 
            BtnSimpan.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSimpan.Location = new Point(542, 85);
            BtnSimpan.Margin = new Padding(4, 3, 4, 3);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(104, 29);
            BtnSimpan.TabIndex = 52;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = true;
            BtnSimpan.Click += BtnSimpan_Click;
            // 
            // BtnTambah
            // 
            BtnTambah.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnTambah.Location = new Point(644, 120);
            BtnTambah.Margin = new Padding(4, 3, 4, 3);
            BtnTambah.Name = "BtnTambah";
            BtnTambah.Size = new Size(104, 29);
            BtnTambah.TabIndex = 51;
            BtnTambah.Text = "Tambah";
            BtnTambah.UseVisualStyleBackColor = true;
            BtnTambah.Click += BtnTambah_Click;
            // 
            // Data_Mapel
            // 
            Data_Mapel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data_Mapel.Columns.AddRange(new DataGridViewColumn[] { Mapel, Nama, Hapus });
            Data_Mapel.Location = new Point(49, 229);
            Data_Mapel.Margin = new Padding(4, 3, 4, 3);
            Data_Mapel.Name = "Data_Mapel";
            Data_Mapel.RowHeadersWidth = 51;
            Data_Mapel.RowTemplate.Height = 29;
            Data_Mapel.Size = new Size(886, 417);
            Data_Mapel.TabIndex = 50;
            Data_Mapel.CellClick += Data_Mapel_CellClick;
            Data_Mapel.CellContentClick += Data_Mapel_CellContentClick;
            // 
            // Mapel
            // 
            Mapel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Mapel.HeaderText = "Id_Mapel";
            Mapel.MinimumWidth = 6;
            Mapel.Name = "Mapel";
            // 
            // Nama
            // 
            Nama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nama.HeaderText = "Nama Mapel";
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
            TextNama.Location = new Point(224, 156);
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
            Label3.Location = new Point(50, 163);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(102, 20);
            Label3.TabIndex = 47;
            Label3.Text = "Nama Mapel";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(433, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 45;
            label1.Text = "Data Mapel";
            // 
            // TextMapel
            // 
            TextMapel.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextMapel.Location = new Point(224, 122);
            TextMapel.Margin = new Padding(4, 3, 4, 3);
            TextMapel.Name = "TextMapel";
            TextMapel.Size = new Size(155, 28);
            TextMapel.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 129);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 56;
            label2.Text = "Id Mapel";
            // 
            // DataMapel
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 686);
            Controls.Add(TextMapel);
            Controls.Add(label2);
            Controls.Add(BtnHapus);
            Controls.Add(BtnUbah);
            Controls.Add(BtnBack);
            Controls.Add(BtnSimpan);
            Controls.Add(BtnTambah);
            Controls.Add(Data_Mapel);
            Controls.Add(TextNama);
            Controls.Add(Label3);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DataMapel";
            Text = "DataMapel";
            Load += DataMapel_Load;
            ((System.ComponentModel.ISupportInitialize)Data_Mapel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnHapus;
        private Button BtnUbah;
        private Button BtnBack;
        private Button BtnSimpan;
        private Button BtnTambah;
        private DataGridView Data_Mapel;
        private TextBox TextNama;
        private Label Label3;
        private Label label1;
        private TextBox TextMapel;
        private Label label2;
        private DataGridViewTextBoxColumn Mapel;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewButtonColumn Hapus;
    }
}