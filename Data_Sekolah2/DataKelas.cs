using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Sekolah2
{
    public partial class DataKelas : Form
    {
        private string level;
        private int selectedRowIndex = -1;

        public static object Rows { get; private set; }
        public DataKelas(string level)
        {
            InitializeComponent();
            this.level = level;
        }

        private void TextNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                PerformKelas();
            }
        }

        private void PerformKelas()
        {
            string nama = TextNama.Text;

            if (string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("Nama kelas tidak boleh kosong", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Connect.conn.Open();
            using (SqlCommand cmd = Connect.conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO tb_kelas (nama_kelas) values (@nama_kelas)";
                cmd.Parameters.AddWithValue("@nama_kelas", nama);
                cmd.ExecuteNonQuery();
            }
            Connect.conn.Close();

            MessageBox.Show("Data berhasil di input!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TextNama.Clear();

            BtnSimpan.Enabled = false;

            LoadDataToDataGridView();
        }

        private void DataKelas_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();

            // Tambahkan logika kondisional untuk menyembunyikan kontrol input berdasarkan level
            if (level != "kepsek")
            {
                DisableInputControls();
            }
            else
            {
                // Sembunyikan 
            }
            DisableInputControls();
        }

        private void LoadDataToDataGridView()
        {
            Data_Kelas.Rows.Clear();

            Connect.conn.Open();
            using (SqlCommand cmd = Connect.conn.CreateCommand())
            {
                cmd.CommandText = "SELECT id_kelas, nama_kelas FROM tb_kelas";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string kelas = reader["id_kelas"].ToString();
                        string nama = reader["nama_kelas"].ToString();
                        Data_Kelas.Rows.Add(kelas, nama);
                    }
                }
            }
            Connect.conn.Close();
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            EnableInputControls();
        }

        private void Data_Kelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;

                // Periksa apakah sel yang diklik tidak null sebelum mengambil nilai
                if (Data_Kelas.Rows[selectedRowIndex].Cells[0].Value != null)
                {
                    TextKelas.Text = Data_Kelas.Rows[selectedRowIndex].Cells[0].Value.ToString();
                }
                else
                {
                    TextKelas.Text = string.Empty;
                }

                if (Data_Kelas.Rows[selectedRowIndex].Cells[1].Value != null)
                {
                    TextNama.Text = Data_Kelas.Rows[selectedRowIndex].Cells[1].Value.ToString();
                }
                else
                {
                    TextNama.Text = string.Empty;
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

            string kelas = TextKelas.Text;
            string nama = TextNama.Text;

            if (string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("Nama kelas tidak boleh kosong", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Connect.conn.Open();
            using (SqlCommand cmd = Connect.conn.CreateCommand())
            {
                cmd.CommandText = "UPDATE tb_kelas SET nama_kelas = @nama_kelas WHERE id_kelas = @id_kelas";
                cmd.Parameters.AddWithValue("@id_kelas", kelas);
                cmd.Parameters.AddWithValue("@nama_kelas", nama);
                cmd.ExecuteNonQuery();
            }
            Connect.conn.Close();

            MessageBox.Show("Data berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TextKelas.Clear();
            TextNama.Clear();

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
                //Lakukan penghapusan data jika pengguna menekan tombol yes
                string kelas = TextKelas.Text;

                Connect.conn.Open();
                using (SqlCommand cmd = Connect.conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM tb_kelas WHERE id_kelas = @id_kelas";
                    cmd.Parameters.AddWithValue("@id_kelas", kelas);
                    cmd.ExecuteNonQuery();
                }
                Connect.conn.Close();

                MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TextKelas.Clear();
                TextNama.Clear();

                selectedRowIndex = -1;

                LoadDataToDataGridView();
            }
            else
            {
                // Pengguna memmilih No, tidak melakukan apa-apa
            }
        }

        private void Data_Kelas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Data_Kelas.Columns["Hapus"].Index && e.RowIndex >= 0)
            {
                // Pastikan kolom yang diklik adalah kolom Hapus Data dan bukan header
                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    // Periksa apakah nilai di kolom "kelas" tidak null sebelum mengakses propertinya
                    string kelas = Data_Kelas.Rows[e.RowIndex].Cells["Kelas"]?.Value?.ToString();

                    if (kelas != null)
                    {
                        Connect.conn.Open();
                        using (SqlCommand cmd = Connect.conn.CreateCommand())
                        {
                            cmd.CommandText = "DELETE FROM tb_kelas WHERE id_kelas = @id_kelas";
                            cmd.Parameters.AddWithValue("@id_kelas", kelas);
                            cmd.ExecuteNonQuery();
                        }
                        Connect.conn.Close();

                        MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDataToDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Nilai id kelas null atau tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            TextKelas.Clear();
            TextNama.Clear();

            TextNama.Enabled = true;

            BtnSimpan.Enabled = true;
            BtnUbah.Enabled = true;
            BtnHapus.Enabled = true;
        }

        private void DisableInputControls()
        {
            TextKelas.Enabled = false;
            TextNama.Enabled = false;

            BtnSimpan.Enabled = false;
            BtnUbah.Enabled = false;
            BtnHapus.Enabled = false;
        }
    }
}
