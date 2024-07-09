using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Sekolah2
{
    public partial class DataSiswa : Form
    {
        private string level;
        private int selectedRowIndex = -1;

        public static object Rows { get; private set; }

        public DataSiswa(string level)
        {
            InitializeComponent();
            this.level = level;
        }

        private void TextNISN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                TextNama.Focus();
            }
        }

        private void TextNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                TextNomor.Focus();
            }
        }

        private void TextNomor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                TextAlamat.Focus();
            }
        }

        private void TextAlamat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                PerformSiswa();
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            PerformSiswa();
        }

        private void PerformSiswa()
        {
            string nis = TextNISN.Text;
            string nama = TextNama.Text;
            string nomor = TextNomor.Text;
            string alamat = TextAlamat.Text;

            if (string.IsNullOrWhiteSpace(nis) || string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(nomor) || string.IsNullOrWhiteSpace(alamat))
            {
                MessageBox.Show("Semua kolom harus diisi", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Connect.conn.Open();
            using (SqlCommand cmd = Connect.conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO tb_siswa (nis, nama_siswa, phone, alamat) values (@nis, @nama_siswa, @phone, @alamat)";
                cmd.Parameters.AddWithValue("@nis", nis);
                cmd.Parameters.AddWithValue("@nama_siswa", nama);
                cmd.Parameters.AddWithValue("@phone", nomor);
                cmd.Parameters.AddWithValue("@alamat", alamat);
                cmd.ExecuteNonQuery();
            }
            Connect.conn.Close();

            MessageBox.Show("Data berhasil di input!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TextNISN.Clear();
            TextNama.Clear();
            TextNomor.Clear();
            TextAlamat.Clear();

            BtnSimpan.Enabled = false;

            LoadDataToDataGridView();
        }

        private void DataSiswa_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            DisableInputControls();
        }

        private void LoadDataToDataGridView()
        {
            Data_Siswa.Rows.Clear();

            Connect.conn.Open();
            using (SqlCommand cmd = Connect.conn.CreateCommand())
            {
                cmd.CommandText = "SELECT nis, nama_siswa, phone, alamat FROM tb_siswa";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nis = reader["nis"].ToString();
                        string nama = reader["nama_siswa"].ToString();
                        string nomor = reader["phone"].ToString();
                        string alamat = reader["alamat"].ToString();
                        Data_Siswa.Rows.Add(nis, nama, nomor, alamat);
                    }
                }
            }
            Connect.conn.Close();
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            EnableInputControls();
        }

        private void Data_Siswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;

                // Periksa apakah sel yang diklik tidak null sebelum mengambil nilai
                if (Data_Siswa.Rows[selectedRowIndex].Cells[0].Value != null)
                {
                    TextNISN.Text = Data_Siswa.Rows[selectedRowIndex].Cells[0].Value.ToString();
                }
                else
                {
                    TextNISN.Text = string.Empty;
                }

                if (Data_Siswa.Rows[selectedRowIndex].Cells[1].Value != null)
                {
                    TextNama.Text = Data_Siswa.Rows[selectedRowIndex].Cells[1].Value.ToString();
                }
                else
                {
                    TextNama.Text = string.Empty;
                }

                if (Data_Siswa.Rows[selectedRowIndex].Cells[2].Value != null)
                {
                    TextNomor.Text = Data_Siswa.Rows[selectedRowIndex].Cells[2].Value.ToString();
                }
                else
                {
                    TextNomor.Text = string.Empty;
                }

                if (Data_Siswa.Rows[selectedRowIndex].Cells[3].Value != null)
                {
                    TextAlamat.Text = Data_Siswa.Rows[selectedRowIndex].Cells[3].Value.ToString();
                }
                else
                {
                    TextAlamat.Text = string.Empty;
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

            string nis = TextNISN.Text;
            string nama = TextNama.Text;
            string nomor = TextNomor.Text;
            string alamat = TextAlamat.Text;

            if (string.IsNullOrWhiteSpace(nis) || string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(nomor) || string.IsNullOrWhiteSpace(alamat))
            {
                MessageBox.Show("Semua kolom harus diisi", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Connect.conn.Open();
            using (SqlCommand cmd = Connect.conn.CreateCommand())
            {
                cmd.CommandText = "UPDATE tb_siswa SET nis = @nis, nama_siswa = @nama_siswa, phone = @phone, alamat = @alamat WHERE nis = @nis";
                cmd.Parameters.AddWithValue("@nis", nis);
                cmd.Parameters.AddWithValue("@nama_siswa", nama);
                cmd.Parameters.AddWithValue("@phone", nomor);
                cmd.Parameters.AddWithValue("@alamat", alamat);
                cmd.ExecuteNonQuery();
            }
            Connect.conn.Close();

            MessageBox.Show("Data berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TextNISN.Clear();
            TextNama.Clear();
            TextNomor.Clear();
            TextAlamat.Clear();

            selectedRowIndex = -1;
            BtnSimpan.Enabled = true;
            BtnUbah.Enabled = false;
            BtnHapus.Enabled = false;

            LoadDataToDataGridView();
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
                string nis = TextNISN.Text;

                Connect.conn.Open();
                using (SqlCommand cmd = Connect.conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM tb_siswa WHERE nis = @nis";
                    cmd.Parameters.AddWithValue("@nis", nis);
                    cmd.ExecuteNonQuery();
                }
                Connect.conn.Close();

                MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TextNISN.Clear();
                TextNama.Clear();
                TextNomor.Clear();
                TextAlamat.Clear();

                selectedRowIndex = -1;

                LoadDataToDataGridView();
            }
            else
            {
                // Pengguna memilih No, tidak melakukan apa-apa
            }
        }

        private void Data_Siswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Data_Siswa.Columns["Hapus"].Index && e.RowIndex >= 0)
            {
                // Pastikan kolom yang diklik adalah kolom Hapus Data dan bukan header
                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    // Periksa apakah nilai di kolom "nis" tidak null sebelum mengakses propertinya
                    string nis = Data_Siswa.Rows[e.RowIndex].Cells["NISN"]?.Value?.ToString();

                    if (nis != null)
                    {
                        Connect.conn.Open();
                        using (SqlCommand cmd = Connect.conn.CreateCommand())
                        {
                            cmd.CommandText = "DELETE FROM tb_siswa WHERE nis = @nis";
                            cmd.Parameters.AddWithValue("@nis", nis);
                            cmd.ExecuteNonQuery();
                        }
                        Connect.conn.Close();

                        MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        TextNISN.Clear();
                        TextNama.Clear();
                        TextNomor.Clear();
                        TextAlamat.Clear();

                        LoadDataToDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Nilai nis null atau tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            TextNISN.Clear();
            TextNama.Clear();
            TextNomor.Clear();
            TextAlamat.Clear();

            TextNISN.Enabled = true;
            TextNama.Enabled = true;
            TextNomor.Enabled = true;
            TextAlamat.Enabled = true;

            BtnSimpan.Enabled = true;
            BtnUbah.Enabled = true;
            BtnHapus.Enabled = true;
        }

        private void DisableInputControls()
        {
            TextNISN.Enabled = false;
            TextNama.Enabled = false;
            TextNomor.Enabled = false;
            TextAlamat.Enabled = false;

            BtnSimpan.Enabled = false;
            BtnUbah.Enabled = false;
            BtnHapus.Enabled = false;
        }
    }
}
