namespace Data_Sekolah2
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
            MenuUtama1 = new MenuStrip();
            DataMaster = new ToolStripMenuItem();
            DataSiswa = new ToolStripMenuItem();
            DataKelas = new ToolStripMenuItem();
            DataJurusan = new ToolStripMenuItem();
            DataMapel = new ToolStripMenuItem();
            DataUser = new ToolStripMenuItem();
            HasilData = new ToolStripMenuItem();
            DataNilai = new ToolStripMenuItem();
            Back = new ToolStripMenuItem();
            Judul = new Label();
            JudulUser = new Label();
            User = new Label();
            MenuUtama1.SuspendLayout();
            SuspendLayout();
            // 
            // MenuUtama1
            // 
            MenuUtama1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            MenuUtama1.ImageScalingSize = new Size(20, 20);
            MenuUtama1.Items.AddRange(new ToolStripItem[] { DataMaster, HasilData, Back });
            MenuUtama1.Location = new Point(0, 0);
            MenuUtama1.Name = "MenuUtama1";
            MenuUtama1.Padding = new Padding(8, 2, 0, 2);
            MenuUtama1.Size = new Size(632, 28);
            MenuUtama1.TabIndex = 0;
            MenuUtama1.Text = "Menu Utama 1";
            // 
            // DataMaster
            // 
            DataMaster.DropDownItems.AddRange(new ToolStripItem[] { DataSiswa, DataKelas, DataJurusan, DataMapel, DataUser });
            DataMaster.Name = "DataMaster";
            DataMaster.Size = new Size(112, 24);
            DataMaster.Text = "Data Master";
            // 
            // DataSiswa
            // 
            DataSiswa.Name = "DataSiswa";
            DataSiswa.Size = new Size(186, 26);
            DataSiswa.Text = "Data Siswa";
            DataSiswa.Click += DataSiswa_Click;
            // 
            // DataKelas
            // 
            DataKelas.Name = "DataKelas";
            DataKelas.Size = new Size(186, 26);
            DataKelas.Text = "Data Kelas";
            DataKelas.Click += DataKelas_Click;
            // 
            // DataJurusan
            // 
            DataJurusan.Name = "DataJurusan";
            DataJurusan.Size = new Size(186, 26);
            DataJurusan.Text = "Data Jurusan";
            DataJurusan.Click += DataJurusan_Click;
            // 
            // DataMapel
            // 
            DataMapel.Name = "DataMapel";
            DataMapel.Size = new Size(186, 26);
            DataMapel.Text = "Data Mapel";
            DataMapel.Click += DataMapel_Click;
            // 
            // DataUser
            // 
            DataUser.Name = "DataUser";
            DataUser.Size = new Size(186, 26);
            DataUser.Text = "Data User";
            DataUser.Click += DataUser_Click;
            // 
            // HasilData
            // 
            HasilData.DropDownItems.AddRange(new ToolStripItem[] { DataNilai });
            HasilData.Name = "HasilData";
            HasilData.Size = new Size(98, 24);
            HasilData.Text = "Hasil Data";
            // 
            // DataNilai
            // 
            DataNilai.Name = "DataNilai";
            DataNilai.Size = new Size(164, 26);
            DataNilai.Text = "Data Nilai";
            DataNilai.Click += DataNilai_Click;
            // 
            // Back
            // 
            Back.Name = "Back";
            Back.Size = new Size(60, 24);
            Back.Text = "Back";
            Back.Click += Back_Click;
            // 
            // Judul
            // 
            Judul.AutoSize = true;
            Judul.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Judul.Location = new Point(250, 71);
            Judul.Margin = new Padding(4, 0, 4, 0);
            Judul.Name = "Judul";
            Judul.Size = new Size(119, 23);
            Judul.TabIndex = 1;
            Judul.Text = "Menu Utama";
            // 
            // JudulUser
            // 
            JudulUser.AutoSize = true;
            JudulUser.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            JudulUser.Location = new Point(250, 181);
            JudulUser.Margin = new Padding(4, 0, 4, 0);
            JudulUser.Name = "JudulUser";
            JudulUser.Size = new Size(122, 20);
            JudulUser.TabIndex = 2;
            JudulUser.Text = "Selamat Datang";
            // 
            // User
            // 
            User.AutoSize = true;
            User.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            User.Location = new Point(271, 232);
            User.Margin = new Padding(4, 0, 4, 0);
            User.Name = "User";
            User.Size = new Size(81, 20);
            User.TabIndex = 3;
            User.Text = "________";
            // 
            // MenuUtama
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 387);
            Controls.Add(User);
            Controls.Add(JudulUser);
            Controls.Add(Judul);
            Controls.Add(MenuUtama1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = MenuUtama1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MenuUtama";
            Text = "MenuUtama";
            MenuUtama1.ResumeLayout(false);
            MenuUtama1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuUtama1;
        private ToolStripMenuItem DataMaster;
        private ToolStripMenuItem DataSiswa;
        private ToolStripMenuItem DataKelas;
        private ToolStripMenuItem DataJurusan;
        private ToolStripMenuItem DataMapel;
        private ToolStripMenuItem DataUser;
        private ToolStripMenuItem HasilData;
        private ToolStripMenuItem DataNilai;
        private ToolStripMenuItem Back;
        private Label Judul;
        private Label JudulUser;
        private Label User;
    }
}