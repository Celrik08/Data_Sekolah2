using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Sekolah2
{
    public partial class DataJurusan : Form
    {
        private string level;
        private int selectedRowIndex = -1;

        public static object Rows { get; private set; }
        public DataJurusan(string level)
        {
            InitializeComponent();
            this.level = level;
        }

        private void TextNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                PerformJurusan();
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            PerformJurusan();
        }

        private void PerformJurusan()
        {
            string nama = TextNama.Text;

            if (string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("Nama Jurusan tidak boleh kosong", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Connect.conn.Open();
            using (SqlCommand cmd = Connect.conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO tb_jurusan (nama_jurusan) values (@nama_jurusan)";
                cmd.Parameters.AddWithValue("@nama_jurusan", nama);
                cmd.ExecuteNonQuery();
            }
            Connect.conn.Close();

            MessageBox.Show("Data berhasil di input!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TextNama.Clear();

            BtnSimpan.Enabled = false;

            LoadDataToDataGridView();

        }

        private void DataJurusan_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();

            // Tambahkan logika kondisional untuk menyembunyikan kontrol input berdasarkan level
            if (level != "kepsek")
            {
                DisableInputControls();
            }
            else
            {
                // Sembunyikan kontrol input jika level kepsek
                LabelId.Visible = false;
                LabelNama.Visible = false;
                TextJurusan.Visible = false;
                TextNama.Visible = false;
                BtnSimpan.Visible = false;
                BtnTambah.Visible = false;
                BtnUbah.Visible = false;
                BtnHapus.Visible = false;
            }
        }

        private void LoadDataToDataGridView()
        {
            Data_Jurusan.Rows.Clear();

            Connect.conn.Open();
            using (SqlCommand cmd = Connect.conn.CreateCommand())
            {
                cmd.CommandText = "SELECT id_jurusan, nama_jurusan FROM tb_jurusan";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string jurusan = reader["id_jurusan"].ToString();
                        string nama = reader["nama_jurusan"].ToString();
                        Data_Jurusan.Rows.Add(jurusan, nama);
                    }
                }
            }
            Connect.conn.Close();
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            EnableInputControls();
        }

        private void Data_Jurusan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;

                // Periksa apakah sel yang diklik tidak null sebelum mengambil nilai 
                if (Data_Jurusan.Rows[selectedRowIndex].Cells[0].Value != null)
                {
                    TextJurusan.Text = Data_Jurusan.Rows[selectedRowIndex].Cells[0].Value.ToString();
                }
                else
                {
                    TextJurusan.Text = string.Empty;
                }

                if (Data_Jurusan.Rows[selectedRowIndex].Cells[1].Value != null)
                {
                    TextNama.Text = Data_Jurusan.Rows[selectedRowIndex].Cells[1].Value.ToString();
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

            string jurusan = TextJurusan.Text;
            string nama = TextNama.Text;

            if (string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("Nama jurusan tidak boleh kosong", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Connect.conn.Open();
            using (SqlCommand cmd = Connect.conn.CreateCommand())
            {
                cmd.CommandText = "UPDATE tb_jurusan SET nama_jurusan = @nama_jurusan WHERE id_jurusan = @id_jurusan";
                cmd.Parameters.AddWithValue("@id_jurusan", jurusan);
                cmd.Parameters.AddWithValue("nama_jurusan", nama);
                cmd.ExecuteNonQuery();
            }
            Connect.conn.Close();

            MessageBox.Show("Data berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TextJurusan.Clear();
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
                // Lakukan penghapusan data jika pengguna menekan tombol yes
                string jurusan = TextJurusan.Text;

                Connect.conn.Open();
                using (SqlCommand cmd = Connect.conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM tb_jurusan WHERE id_jurusan = @id_jurusan";
                    cmd.Parameters.AddWithValue("@id_jurusan", jurusan);
                    cmd.ExecuteNonQuery();
                }
                Connect.conn.Close();

                MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TextJurusan.Clear();
                TextNama.Clear();

                selectedRowIndex = -1;

                LoadDataToDataGridView();
            }
            else
            {
                // Pengguna memilih No, tidak melakukan apa-apa
            }
        }

        private void Data_Jurusan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Data_Jurusan.Columns["Hapus"].Index && e.RowIndex >= 0)
            {
                // Pastikan kolom yang diklik adalah kolom Hapus Data dan bukan header
                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    // Periksa apakah nilai di kolom "jurusan" tidak null sebelum mengakses propertinya
                    string jurusan = Data_Jurusan.Rows[e.RowIndex].Cells["Jurusan"]?.Value?.ToString();

                    if (jurusan != null)
                    {
                        Connect.conn.Open();
                        using (SqlCommand cmd = Connect.conn.CreateCommand())
                        {
                            cmd.CommandText = "DELETE FROM tb_jurusan WHERE id_jurusan = @id_jurusan";
                            cmd.Parameters.AddWithValue("@id_jurusan", jurusan);
                            cmd.ExecuteNonQuery();
                        }
                        Connect.conn.Close();

                        MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDataToDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Nilai id jurusan null atau tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            TextJurusan.Clear();
            TextNama.Clear();

            TextNama.Enabled = true;

            BtnSimpan.Enabled = true;
            BtnUbah.Enabled = true;
            BtnHapus.Enabled = true;
        }

        private void DisableInputControls()
        {
            TextJurusan.Enabled = false;
            TextNama.Enabled = false;

            BtnSimpan.Enabled = false;
            BtnUbah.Enabled = false;
            BtnHapus.Enabled = false;
        }
    }
}