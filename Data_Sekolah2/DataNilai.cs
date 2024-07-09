using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Data_Sekolah2
{
    public partial class DataNilai : Form
    {
        private string level;
        private int selectedRowIndex = -1;

        public static object Rows { get; private set; }
        public DataNilai(string level)
        {
            InitializeComponent();
            this.level = level;
        }

        private void ComboMapel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                ComboSiswa.Focus();
            }
        }

        private void ComboSiswa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                ComboJurusan.Focus();
            }
        }

        private void ComboJurusan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                ComboKelas.Focus();
            }
        }

        private void ComboKelas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                TextNilai.Focus();
            }
        }

        private void TextNilai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                ComboUser.Focus();
            }
        }

        private void ComboUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                PerformNilai();
            }
        }

        private void PerformMapel()
        {
            Connect.conn.Open();
            ComboMapel.Items.Clear();
            Connect.cmd = new SqlCommand("SELECT * FROM tb_mapel", Connect.conn);
            Connect.reader = Connect.cmd.ExecuteReader();
            while (Connect.reader.Read())
            {
                ComboMapel.Items.Add(Connect.reader[0]);
            }
            Connect.reader.Close();
            Connect.conn.Close();
        }

        private void PerformSiswa()
        {
            Connect.conn.Open();
            ComboSiswa.Items.Clear();
            Connect.cmd = new SqlCommand("SELECT * FROM tb_siswa", Connect.conn);
            Connect.reader = Connect.cmd.ExecuteReader();
            while (Connect.reader.Read())
            {
                ComboSiswa.Items.Add(Connect.reader[0]);
            }
            Connect.reader.Close();
            Connect.conn.Close();
        }

        private void PerformJurusan()
        {
            Connect.conn.Open();
            ComboJurusan.Items.Clear();
            Connect.cmd = new SqlCommand("SELECT * FROM tb_jurusan", Connect.conn);
            Connect.reader = Connect.cmd.ExecuteReader();
            while (Connect.reader.Read())
            {
                ComboJurusan.Items.Add(Connect.reader[0]);
            }
            Connect.reader.Close();
            Connect.conn.Close();
        }

        private void PerformKelas()
        {
            Connect.conn.Open();
            ComboKelas.Items.Clear();
            Connect.cmd = new SqlCommand("SELECT * FROM tb_kelas", Connect.conn);
            Connect.reader = Connect.cmd.ExecuteReader();
            while (Connect.reader.Read())
            {
                ComboKelas.Items.Add(Connect.reader[0]);
            }
            Connect.reader.Close();
            Connect.conn.Close();
        }

        private void PerformUser()
        {
            Connect.conn.Open();
            ComboUser.Items.Clear();
            Connect.cmd = new SqlCommand("SELECT * FROM tb_user WHERE id_user = 4", Connect.conn);
            Connect.reader = Connect.cmd.ExecuteReader();
            while (Connect.reader.Read())
            {
                ComboUser.Items.Add(Connect.reader[0]);
            }
            Connect.reader.Close();
            Connect.conn.Close();
        }

        private void ComboMapel_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Menampilkan data mapel
            Connect.conn.Open();
            Connect.cmd = new SqlCommand("SELECT * FROM tb_mapel WHERE id_mapel = @id_mapel", Connect.conn);
            Connect.cmd.Parameters.AddWithValue("@id_mapel", ComboMapel.Text);

            Connect.reader = Connect.cmd.ExecuteReader();
            if (Connect.reader.Read())
            {
                TextMapel.Text = Connect.reader["nama_mapel"].ToString();
            }
            Connect.reader.Close();
            Connect.conn.Close();
        }

        private void ComboSiswa_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Menampilkan data siswa
            Connect.conn.Open();
            Connect.cmd = new SqlCommand("SELECT * FROM tb_siswa WHERE id_siswa = @id_siswa", Connect.conn);
            Connect.cmd.Parameters.AddWithValue("@id_siswa", ComboSiswa.Text);

            Connect.reader = Connect.cmd.ExecuteReader();
            if (Connect.reader.Read())
            {
                TextSiswa.Text = Connect.reader["nama_siswa"].ToString();
            }
            Connect.reader.Close();
            Connect.conn.Close();
        }

        private void ComboJurusan_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Menampilkan data jurusan
            Connect.conn.Open();
            Connect.cmd = new SqlCommand("SELECT * FROM tb_jurusan WHERE id_jurusan = @id_jurusan", Connect.conn);
            Connect.cmd.Parameters.AddWithValue("@id_jurusan", ComboJurusan.Text);

            Connect.reader = Connect.cmd.ExecuteReader();
            if (Connect.reader.Read())
            {
                TextJurusan.Text = Connect.reader["nama_jurusan"].ToString();
            }
            Connect.reader.Close();
            Connect.conn.Close();
        }

        private void ComboKelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Menampilkan data kelas
            Connect.conn.Open();
            Connect.cmd = new SqlCommand("SELECT * FROM tb_kelas WHERE id_kelas = @id_kelas", Connect.conn);
            Connect.cmd.Parameters.AddWithValue("id_kelas", ComboKelas.Text);

            Connect.reader = Connect.cmd.ExecuteReader();
            if (Connect.reader.Read())
            {
                TextKelas.Text = Connect.reader["nama_kelas"].ToString();
            }
            Connect.reader.Close();
            Connect.conn.Close();
        }

        private void ComboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Menampilkan data user
            Connect.conn.Open();
            Connect.cmd = new SqlCommand("SELECT *FROM tb_user WHERE id_user = @id_user", Connect.conn);
            Connect.cmd.Parameters.AddWithValue("@id_user", ComboUser.Text);

            Connect.reader = Connect.cmd.ExecuteReader();
            if (Connect.reader.Read())
            {
                TextUser.Text = Connect.reader["level"].ToString();
            }
            Connect.reader.Close();
            Connect.conn.Close();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            PerformNilai();
        }

        private void PerformNilai()
        {
            string mapel = ComboMapel.Text;
            string siswa = ComboSiswa.Text;
            string jurusan = ComboJurusan.Text;
            string kelas = ComboKelas.Text;
            string nilai = TextNilai.Text;
            string user = ComboUser.Text;

            if (string.IsNullOrWhiteSpace(mapel) || string.IsNullOrWhiteSpace(siswa) || string.IsNullOrWhiteSpace(jurusan) || string.IsNullOrWhiteSpace(kelas) || string.IsNullOrWhiteSpace(nilai))
            {
                MessageBox.Show("Semua kolom harus diisi", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Connect.conn.Open();
            using (SqlCommand cmd = Connect.conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO tb_nilai (id_mapel, id_siswa, id_jurusan, id_kelas, nilai_siswa, id_user) values (@id_mapel, @id_siswa, @id_jurusan, @id_kelas, @nilai_siswa, @id_user)";
                cmd.Parameters.AddWithValue("@id_mapel", mapel);
                cmd.Parameters.AddWithValue("@id_siswa", siswa);
                cmd.Parameters.AddWithValue("@id_jurusan", jurusan);
                cmd.Parameters.AddWithValue("@id_kelas", kelas);
                cmd.Parameters.AddWithValue("@nilai_siswa", nilai);
                cmd.Parameters.AddWithValue("id_user", user);
                cmd.ExecuteNonQuery();
            }
            Connect.conn.Close();

            MessageBox.Show("Data berhasil di input!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ComboMapel.SelectedIndex = -1;
            TextMapel.Clear();
            ComboSiswa.SelectedIndex = -1;
            TextSiswa.Clear();
            ComboJurusan.SelectedIndex = -1;
            TextJurusan.Clear();
            ComboKelas.SelectedIndex = -1;
            TextKelas.Clear();
            TextNilai.Clear();
            ComboUser.SelectedIndex = -1;
            TextUser.Clear();

            BtnSimpan.Enabled = false;

            LoadDataToDataGridView();
        }

        private void DataNilai_Load(object sender, EventArgs e)
        {
            PerformMapel();
            PerformSiswa();
            PerformJurusan();
            PerformKelas();
            PerformUser();
            LoadDataToDataGridView();
            DisableInputControls();
        }

        private void LoadDataToDataGridView()
        {
            // Kosongkan DataGridView terlebih dahulu
            Data_Nilai.Rows.Clear();

            // Tulis kueri SQL Anda untuk mengambil data dari nilai
            string query = "SELECT tb_nilai.id_nilai, tb_mapel.nama_mapel, tb_siswa.nama_siswa, tb_jurusan.nama_jurusan, tb_kelas.nama_kelas, tb_nilai.nilai_siswa, tb_user.level " +
                            "FROM tb_nilai " +
                            "JOIN tb_mapel ON tb_nilai.id_mapel = tb_mapel.id_mapel " +
                            "JOIN tb_siswa ON tb_nilai.id_siswa = tb_siswa.id_siswa " +
                            "JOIN tb_jurusan ON tb_nilai.id_jurusan = tb_jurusan.id_jurusan " +
                            "JOIN tb_kelas ON tb_nilai.id_kelas = tb_kelas.id_kelas " +
                            "JOIN tb_user ON tb_nilai.id_user = tb_user.id_user ";

            // Buat SqlCommand untuk menjalankan kueri
            using (SqlCommand cmd = new SqlCommand(query, Connect.conn))
            {
                Connect.conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Menambahkan data ke DataGridView
                        string nilai = reader["id_nilai"].ToString();
                        string mapel = reader["nama_mapel"].ToString();
                        string siswa = reader["nama_siswa"].ToString();
                        string jurusan = reader["nama_jurusan"].ToString();
                        string kelas = reader["nama_kelas"].ToString();
                        string nilai_siswa = reader["nilai_siswa"].ToString();
                        string user = reader["level"].ToString();
                        Data_Nilai.Rows.Add(nilai, mapel, siswa, jurusan, kelas, nilai_siswa, user);
                    }
                }
                Connect.conn.Close();
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            EnableInputControls();
        }

        private void Data_Nilai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;

                // Periksan apakah sel yang diklik tidak null sebelum mengambil nilai
                if (Data_Nilai.Rows[selectedRowIndex].Cells[0].Value != null)
                {
                    TextId.Text = Data_Nilai.Rows[selectedRowIndex].Cells[0].Value.ToString();
                }
                else
                {
                    TextId.Text = string.Empty;
                }

                if (Data_Nilai.Rows[selectedRowIndex].Cells[1].Value != null)
                {
                    TextMapel.Text = Data_Nilai.Rows[selectedRowIndex].Cells[1].Value.ToString();
                }
                else
                {
                    TextMapel.Text = string.Empty;
                }

                if (Data_Nilai.Rows[selectedRowIndex].Cells[2].Value != null)
                {
                    TextSiswa.Text = Data_Nilai.Rows[selectedRowIndex].Cells[2].Value.ToString();
                }
                else
                {
                    TextSiswa.Text = string.Empty;
                }

                if (Data_Nilai.Rows[selectedRowIndex].Cells[3].Value != null)
                {
                    TextJurusan.Text = Data_Nilai.Rows[selectedRowIndex].Cells[3].Value.ToString();
                }
                else
                {
                    TextJurusan.Text = string.Empty;
                }

                if (Data_Nilai.Rows[selectedRowIndex].Cells[4].Value != null)
                {
                    TextKelas.Text = Data_Nilai.Rows[selectedRowIndex].Cells[4].Value.ToString();
                }
                else
                {
                    TextKelas.Text = string.Empty;
                }

                if (Data_Nilai.Rows[selectedRowIndex].Cells[5].Value != null)
                {
                    TextNilai.Text = Data_Nilai.Rows[selectedRowIndex].Cells[5].Value.ToString();
                }
                else
                {
                    TextNilai.Text = string.Empty;
                }

                if (Data_Nilai.Rows[selectedRowIndex].Cells[6].Value != null)
                {
                    TextUser.Text = Data_Nilai.Rows[selectedRowIndex].Cells[6].Value.ToString();
                }
                else
                {
                    TextUser.Text = string.Empty;
                }

                BtnSimpan.Enabled = false;
                BtnUbah.Enabled = true;
                BtnHapus.Enabled = true;
            }
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex < 0)
            {
                MessageBox.Show("Pilih baris yang ingin diubah", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string id = TextId.Text;
            string nilaiString = TextNilai.Text;

            if (string.IsNullOrWhiteSpace(nilaiString))
            {
                MessageBox.Show("Nilai tidak boleh kosong", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Koneverensi nilai string ke tipe data decimal
            if (decimal.TryParse(nilaiString, out decimal nilai))
            {
                Connect.conn.Open();
                using (SqlCommand cmd = Connect.conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE tb_nilai SET nilai_siswa = @nilai_siswa WHERE id_nilai = @id_nilai";
                    cmd.Parameters.AddWithValue("@id_nilai", id);
                    cmd.Parameters.AddWithValue("@nilai_siswa", nilai);
                    cmd.ExecuteNonQuery();
                }
                Connect.conn.Close();

                MessageBox.Show("Data berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Bersihkan kontrol input
                TextId.Clear();
                ComboMapel.SelectedIndex = -1;
                TextMapel.Clear();
                ComboSiswa.SelectedIndex = -1;
                TextSiswa.Clear();
                ComboJurusan.SelectedIndex = -1;
                TextJurusan.Clear();
                ComboKelas.SelectedIndex = -1;
                TextKelas.Clear();
                TextNilai.Clear();
                ComboUser.SelectedIndex = -1;
                TextUser.Clear();

                selectedRowIndex = -1;
                BtnSimpan.Enabled = true;
                BtnUbah.Enabled = false;
                BtnHapus.Enabled = false;

                LoadDataToDataGridView();
            }
            else
            {
                MessageBox.Show("Format nilai tidak valid", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex < 0)
            {
                MessageBox.Show("Pilih baris yang ingin dihapus", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tampilkan MessageBox konfirmasi
            DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Lakukan penghapusan data jika pengguna menekan tombol yes
                string id = TextId.Text;

                Connect.conn.Open();
                using (SqlCommand cmd = Connect.conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM tb_nilai WHERE id_nilai = @id_nilai";
                    cmd.Parameters.AddWithValue("@id_nilai", id);
                    cmd.ExecuteNonQuery();
                }
                Connect.conn.Close();

                MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TextId.Clear();
                ComboMapel.SelectedIndex = -1;
                TextMapel.Clear();
                ComboSiswa.SelectedIndex = -1;
                TextSiswa.Clear();
                ComboJurusan.SelectedIndex = -1;
                TextJurusan.Clear();
                ComboKelas.SelectedIndex = -1;
                TextKelas.Clear();
                TextNilai.Clear();
                ComboUser.SelectedIndex = -1;
                TextUser.Clear();

                selectedRowIndex = -1;

                LoadDataToDataGridView();
            }
            else
            {
                // Pengguna memilih No, tidak melakukan apa-apa
            }
        }

        private void Data_Nilai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Data_Nilai.Columns["Hapus"].Index && e.RowIndex >= 0)
            {
                // Pastikan kolom yang diklik adalah kolom Hapus Data dan buku header
                DialogResult result = MessageBox.Show("Anda yakin ingin mengahapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    // Periksa apakah nilai di kolom "nilai" tidak null sebelum mengakses propertinya
                    string id = Data_Nilai.Rows[e.RowIndex].Cells["Id"]?.Value?.ToString();

                    if (id != null)
                    {
                        Connect.conn.Open();
                        using (SqlCommand cmd = Connect.conn.CreateCommand())
                        {
                            cmd.CommandText = "DELETE FROM tb_nilai WHERE id_nilai = @id_nilai";
                            cmd.Parameters.AddWithValue("@id_nilai", id);
                            cmd.ExecuteNonQuery();
                        }
                        Connect.conn.Close();

                        MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDataToDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Nilai id nilai null atau tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Pengguna memilih No, tidak melakukan apa-apa
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MenuUtama MU = new MenuUtama(level);
            MU.Show();
            Hide();
        }

        private void EnableInputControls()
        {
            TextId.Clear();
            ComboMapel.SelectedIndex = -1;
            TextMapel.Clear();
            ComboSiswa.SelectedIndex = -1;
            TextSiswa.Clear();
            ComboJurusan.SelectedIndex = -1;
            TextJurusan.Clear();
            ComboKelas.SelectedIndex = -1;
            TextKelas.Clear();
            TextNilai.Clear();
            ComboUser.SelectedIndex = -1;
            TextUser.Clear();

            ComboMapel.Enabled = true;
            ComboSiswa.Enabled = true;
            ComboJurusan.Enabled = true;
            ComboKelas.Enabled = true;
            TextNilai.Enabled = true;
            ComboUser.Enabled = true;

            BtnSimpan.Enabled = true;
            BtnUbah.Enabled = true;
            BtnHapus.Enabled = true;
        }

        private void DisableInputControls()
        {
            TextId.Enabled = false;
            ComboMapel.Enabled = false;
            TextMapel.Enabled = false;
            ComboSiswa.Enabled = false;
            TextSiswa.Enabled = false;
            ComboJurusan.Enabled = false;
            TextJurusan.Enabled = false;
            ComboKelas.Enabled = false;
            TextKelas.Enabled = false;
            TextNilai.Enabled = false;
            ComboUser.Enabled = false;
            TextUser.Enabled = false;

            BtnSimpan.Enabled = false;
            BtnUbah.Enabled = false;
            BtnHapus.Enabled = false;
        }
    }
}
