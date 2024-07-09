namespace Data_Sekolah2
{
    partial class DataUser
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
            label5 = new Label();
            BtnHapus = new Button();
            BtnUbah = new Button();
            BtnBack = new Button();
            BtnSimpan = new Button();
            BtnTambah = new Button();
            Data_User = new DataGridView();
            User = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Level = new DataGridViewTextBoxColumn();
            Hapus = new DataGridViewButtonColumn();
            TextPass = new TextBox();
            TextNama = new TextBox();
            Label4 = new Label();
            Label3 = new Label();
            label1 = new Label();
            ComboLevel = new ComboBox();
            TextUser = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Data_User).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(39, 190);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 55;
            label5.Text = "Level";
            // 
            // BtnHapus
            // 
            BtnHapus.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnHapus.Location = new Point(502, 149);
            BtnHapus.Margin = new Padding(4, 3, 4, 3);
            BtnHapus.Name = "BtnHapus";
            BtnHapus.Size = new Size(96, 29);
            BtnHapus.TabIndex = 54;
            BtnHapus.Text = "Hapus";
            BtnHapus.UseVisualStyleBackColor = true;
            BtnHapus.Click += BtnHapus_Click;
            // 
            // BtnUbah
            // 
            BtnUbah.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnUbah.Location = new Point(692, 79);
            BtnUbah.Margin = new Padding(4, 3, 4, 3);
            BtnUbah.Name = "BtnUbah";
            BtnUbah.Size = new Size(96, 29);
            BtnUbah.TabIndex = 53;
            BtnUbah.Text = "Ubah";
            BtnUbah.UseVisualStyleBackColor = true;
            BtnUbah.Click += BtnUbah_Click;
            // 
            // BtnBack
            // 
            BtnBack.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBack.Location = new Point(692, 147);
            BtnBack.Margin = new Padding(4, 3, 4, 3);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(96, 29);
            BtnBack.TabIndex = 52;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnSimpan
            // 
            BtnSimpan.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSimpan.Location = new Point(502, 79);
            BtnSimpan.Margin = new Padding(4, 3, 4, 3);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(96, 29);
            BtnSimpan.TabIndex = 51;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = true;
            BtnSimpan.Click += BtnSimpan_Click;
            // 
            // BtnTambah
            // 
            BtnTambah.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnTambah.Location = new Point(597, 114);
            BtnTambah.Margin = new Padding(4, 3, 4, 3);
            BtnTambah.Name = "BtnTambah";
            BtnTambah.Size = new Size(96, 29);
            BtnTambah.TabIndex = 50;
            BtnTambah.Text = "Tambah";
            BtnTambah.UseVisualStyleBackColor = true;
            BtnTambah.Click += BtnTambah_Click;
            // 
            // Data_User
            // 
            Data_User.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data_User.Columns.AddRange(new DataGridViewColumn[] { User, Nama, Password, Level, Hapus });
            Data_User.Location = new Point(39, 241);
            Data_User.Margin = new Padding(4, 3, 4, 3);
            Data_User.Name = "Data_User";
            Data_User.RowHeadersWidth = 51;
            Data_User.RowTemplate.Height = 29;
            Data_User.Size = new Size(1208, 417);
            Data_User.TabIndex = 49;
            Data_User.CellClick += Data_User_CellClick;
            Data_User.CellContentClick += Data_User_CellContentClick;
            // 
            // User
            // 
            User.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            User.HeaderText = "Id User";
            User.MinimumWidth = 6;
            User.Name = "User";
            // 
            // Nama
            // 
            Nama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nama.HeaderText = "User Name";
            Nama.MinimumWidth = 6;
            Nama.Name = "Nama";
            // 
            // Password
            // 
            Password.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            // 
            // Level
            // 
            Level.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Level.HeaderText = "Level";
            Level.MinimumWidth = 6;
            Level.Name = "Level";
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
            // TextPass
            // 
            TextPass.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextPass.Location = new Point(212, 149);
            TextPass.Margin = new Padding(4, 3, 4, 3);
            TextPass.Name = "TextPass";
            TextPass.Size = new Size(188, 28);
            TextPass.TabIndex = 48;
            TextPass.KeyPress += TextPass_KeyPress;
            // 
            // TextNama
            // 
            TextNama.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNama.Location = new Point(212, 116);
            TextNama.Margin = new Padding(4, 3, 4, 3);
            TextNama.Name = "TextNama";
            TextNama.Size = new Size(188, 28);
            TextNama.TabIndex = 47;
            TextNama.KeyPress += TextNama_KeyPress;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Label4.Location = new Point(39, 156);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(79, 20);
            Label4.TabIndex = 46;
            Label4.Text = "Password";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Label3.Location = new Point(39, 123);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(91, 20);
            Label3.TabIndex = 45;
            Label3.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(514, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 23);
            label1.TabIndex = 59;
            label1.Text = "Data User";
            // 
            // ComboLevel
            // 
            ComboLevel.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ComboLevel.FormattingEnabled = true;
            ComboLevel.Items.AddRange(new object[] { "siswa", "petugas", "kepsek", "guru" });
            ComboLevel.Location = new Point(212, 183);
            ComboLevel.Margin = new Padding(4, 3, 4, 3);
            ComboLevel.Name = "ComboLevel";
            ComboLevel.Size = new Size(188, 28);
            ComboLevel.TabIndex = 60;
            ComboLevel.KeyPress += ComboLevel_KeyPress;
            // 
            // TextUser
            // 
            TextUser.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextUser.Location = new Point(212, 82);
            TextUser.Margin = new Padding(4, 3, 4, 3);
            TextUser.Name = "TextUser";
            TextUser.Size = new Size(188, 28);
            TextUser.TabIndex = 62;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 89);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 61;
            label2.Text = "Id User";
            // 
            // DataUser
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 690);
            Controls.Add(TextUser);
            Controls.Add(label2);
            Controls.Add(ComboLevel);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(BtnHapus);
            Controls.Add(BtnUbah);
            Controls.Add(BtnBack);
            Controls.Add(BtnSimpan);
            Controls.Add(BtnTambah);
            Controls.Add(Data_User);
            Controls.Add(TextPass);
            Controls.Add(TextNama);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DataUser";
            Text = "DataUser";
            Load += DataUser_Load;
            ((System.ComponentModel.ISupportInitialize)Data_User).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Button BtnHapus;
        private Button BtnUbah;
        private Button BtnBack;
        private Button BtnSimpan;
        private Button BtnTambah;
        private DataGridView Data_User;
        private TextBox TextPass;
        private TextBox TextNama;
        private Label Label4;
        private Label Label3;
        private Label label1;
        private ComboBox ComboLevel;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Level;
        private DataGridViewButtonColumn Hapus;
        private TextBox TextUser;
        private Label label2;
    }
}