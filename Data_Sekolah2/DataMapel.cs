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
    public partial class DataMapel : Form
    {
        private string level;
        private int selectedRowIndex = -1;

        public static object Rows { get; private set; }
        public DataMapel(string level)
        {
            InitializeComponent();
            this.level = level;
        }

        private void TextNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                PerformMapel();
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            PerformMapel();
        }

        private void PerformMapel()
        {
            string nama = TextNama.Text;

            if (string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("Nama Mapel tidak boleh kosong", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Connect.conn.Open();
            using (SqlCommand cmd = Connect.conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO tb_mapel (nama_mapel) values (@nama_mapel)";
                cmd.Parameters.AddWithValue("@nama_mapel", nama);
                cmd.ExecuteNonQuery();
            }
            Connect.conn.Close();

            MessageBox.Show("Data berhasil di input!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TextNama.Clear();

            BtnSimpan.Enabled = false;

            LoadDataToDataGridView();
        }

        private void DataMapel_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            DisableInputControls();
        }

        private void LoadDataToDataGridView()
        {
            Data_Mapel.Rows.Clear();

            Connect.conn.Open();
            using (SqlCommand cmd = Connect.conn.CreateCommand())
            {
                cmd.CommandText = "SELECT id_mapel, nama_mapel FROM tb_mapel";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string mapel = reader["id_mapel"].ToString();
                        string nama = reader["nama_mapel"].ToString();
                        Data_Mapel.Rows.Add(mapel, nama);
                    }
                }
            }
            Connect.conn.Close();
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            EnableInputControls();
        }

        private void Data_Mapel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;

                // Periksa apakah sel yang diklik tidak null sebelum mengambil nilai

                if (Data_Mapel.Rows[selectedRowIndex].Cells[0].Value != null)
                {
                    TextMapel.Text = Data_Mapel.Rows[selectedRowIndex].Cells[0].Value.ToString();
                }
                else
                {
                    TextMapel.Text = string.Empty;
                }

                if (Data_Mapel.Rows[selectedRowIndex].Cells[1].Value != null)
                {
                    TextNama.Text = Data_Mapel.Rows[selectedRowIndex].Cells[1].Value.ToString();
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

            string mapel = TextMapel.Text;
            string nama = TextNama.Text;

            if (string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("Nama mapel tidak boleh kosong", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Connect.conn.Open();
            using (SqlCommand cmd = Connect.conn.CreateCommand())
            {
                cmd.CommandText = "UPDATE tb_mapel SET nama_mapel = @nama_mapel WHERE id_mapel = @id_mapel";
                cmd.Parameters.AddWithValue("@id_mapel", mapel);
                cmd.Parameters.AddWithValue("nama_mapel", nama);
                cmd.ExecuteNonQuery();
            }
            Connect.conn.Close();

            MessageBox.Show("Data berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TextMapel.Clear();
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

            // Tampilkan Messagebox konfirmasi
            DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Lakukan penghapusan data jika pengguna menekan tombol yes
                string mapel = TextMapel.Text;

                Connect.conn.Open();
                using (SqlCommand cmd = Connect.conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM tb_mapel WHERE id_mapel = @id_mapel";
                    cmd.Parameters.AddWithValue("@id_mapel", mapel);
                    cmd.ExecuteNonQuery();
                }
                Connect.conn.Close();

                MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TextMapel.Clear();
                TextNama.Clear();

                selectedRowIndex = -1;

                LoadDataToDataGridView();
            }
            else
            {
                // Pengguna memilih No, tidak melakukan apa-apa
            }
        }

        private void Data_Mapel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Data_Mapel.Columns["Hapus"].Index && e.RowIndex >= 0)
            {
                // Pastikan kolom yang diklik adalah kolom Hapus Data dan bukan header
                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    // Periksa apakah nilai di kolom "kelas" tidak null sebelum mengakses propertinya
                    string mapel = Data_Mapel.Rows[e.RowIndex].Cells["Mapel"]?.Value?.ToString();

                    if (mapel != null)
                    {
                        Connect.conn.Open();
                        using (SqlCommand cmd = Connect.conn.CreateCommand())
                        {
                            cmd.CommandText = "DELETE FROM tb_mapel WHERE id_mapel = @id_mapel";
                            cmd.Parameters.AddWithValue("@id_mapel", mapel);
                            cmd.ExecuteNonQuery();
                        }
                        Connect.conn.Close();

                        MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDataToDataGridView();
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
            TextMapel.Clear();
            TextNama.Clear();

            TextNama.Enabled = true;

            BtnSimpan.Enabled = true;
            BtnUbah.Enabled = true;
            BtnHapus.Enabled = true;
        }

        private void DisableInputControls()
        {
            TextMapel.Enabled = false;
            TextNama.Enabled = false;

            BtnSimpan.Enabled = false;
            BtnUbah.Enabled = false;
            BtnHapus.Enabled = false;
        }
    }
}