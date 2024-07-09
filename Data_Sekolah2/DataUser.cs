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
    public partial class DataUser : Form
    {
        private int selectedRowIndex = -1;
        private string level1;
        public DataUser(string level)
        {
            InitializeComponent();
            this.level1 = level;
        }

        private void TextNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true; // Menandakan bahwa event sudah ditangani
                TextPass.Focus(); // Alihkan fokus ke TextBox Password
            }

        }

        private void TextPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true; // Menandakan bahwa event sudah ditangani
                ComboLevel.Focus();
            }
        }

        private void ComboLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true; // Menandakan bahwa event sudah ditangani
                PerformUser();

            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            PerformUser();
        }

        private void PerformUser()
        {
            string username = TextNama.Text;
            string password = TextPass.Text;
            string level = ComboLevel.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(level))
            {
                MessageBox.Show("Semua kolom harus diisi", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Connect.conn.Open();
            using (SqlCommand cmd = Connect.conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO tb_user (username, password, level) values (@username, @password, @level)";
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("level", level);
                cmd.ExecuteNonQuery();
            }
            Connect.conn.Close();

            MessageBox.Show("Data berhasil di input!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TextNama.Clear();
            TextPass.Clear();
            ComboLevel.SelectedIndex = -1;

            BtnSimpan.Enabled = false;

            LoadDataToDataGridView();
        }

        private void DataUser_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            DisableInputControls();
        }

        private void LoadDataToDataGridView()
        {
            Data_User.Rows.Clear();

            Connect.conn.Open();
            using (SqlCommand cmd = Connect.conn.CreateCommand())
            {
                cmd.CommandText = "SELECT id_user, username, password, level FROM tb_user";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string user = reader["id_user"].ToString();
                        string nama = reader["username"].ToString();
                        string password = reader["password"].ToString();
                        string level = reader["level"].ToString();
                        Data_User.Rows.Add(user, nama, password, level);
                    }
                }
            }
            Connect.conn.Close();
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            EnableInputControls();
        }

        private void Data_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;

                // Periksa apakah sel yang diklik tidak null sebelum mengambil nilai
                if (Data_User.Rows[selectedRowIndex].Cells[0].Value != null)
                {
                    TextUser.Text = Data_User.Rows[selectedRowIndex].Cells[0].Value.ToString();
                }
                else
                {
                    TextUser.Text = string.Empty;
                }

                if (Data_User.Rows[selectedRowIndex].Cells[1].Value != null)
                {
                    TextNama.Text = Data_User.Rows[selectedRowIndex].Cells[1].Value.ToString();
                }
                else
                {
                    TextNama.Text = string.Empty;
                }

                if (Data_User.Rows[selectedRowIndex].Cells[2].Value != null)
                {
                    TextPass.Text = Data_User.Rows[selectedRowIndex].Cells[2].Value.ToString();
                }
                else
                {
                    TextPass.Text = string.Empty;
                }

                if (Data_User.Rows[selectedRowIndex].Cells[3].Value != null)
                {
                    ComboLevel.Text = Data_User.Rows[selectedRowIndex].Cells[3].Value.ToString();
                }
                else
                {
                    ComboLevel.Text = string.Empty;
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

            string user = TextUser.Text;
            string nama = TextNama.Text;
            string password = TextPass.Text;
            string level = ComboLevel.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(level))
            {
                MessageBox.Show("Semua kolom harus diisi", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Connect.conn.Open();
            using (SqlCommand cmd = Connect.conn.CreateCommand())
            {
                cmd.CommandText = "UPDATE tb_user SET id_user = @id_user, username = @username, password = @password, level = @level WHERE id_user = @id_user";
                cmd.Parameters.AddWithValue("@id_user", user);
                cmd.Parameters.AddWithValue("@username", nama);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@level", level);
                cmd.ExecuteNonQuery();
            }
            Connect.conn.Close();

            MessageBox.Show("Data berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TextUser.Clear();
            TextNama.Clear();
            TextPass.Clear();
            ComboLevel.SelectedIndex = -1;

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
                string user = TextUser.Text;

                Connect.conn.Open();
                using (SqlCommand cmd = Connect.conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM tb_user WHERE id_user = @id_user";
                    cmd.Parameters.AddWithValue("@id_user", user);
                    cmd.ExecuteNonQuery();
                }
                Connect.conn.Close();

                MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TextUser.Clear();
                TextNama.Clear();
                TextPass.Clear();
                ComboLevel.SelectedIndex = -1;

                selectedRowIndex = -1;

                LoadDataToDataGridView();
            }
            else
            {
                // Pengguna memilih No, tidak melakukan apa-apa
            }
        }

        private void Data_User_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Data_User.Columns["Hapus"].Index && e.RowIndex >= 0)
            {
                // Pastikan kolom yang diklik adalah kolom Hapus Data dan bukan header
                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    // Periksa apakah nilai di kolom "User" tidak null sebelum mengakses propertinya
                    string user = Data_User.Rows[e.RowIndex].Cells["User"]?.Value?.ToString();

                    if (user != null)
                    {
                        Connect.conn.Open();
                        using (SqlCommand cmd = Connect.conn.CreateCommand())
                        {
                            cmd.CommandText = "DELETE FROM tb_user WHERE id_user = @id_user";
                            cmd.Parameters.AddWithValue("@id_user", user);
                            cmd.ExecuteNonQuery();
                        }
                        Connect.conn.Close();

                        MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        TextUser.Clear();
                        TextNama.Clear();
                        TextPass.Clear();
                        ComboLevel.SelectedIndex = -1;

                        LoadDataToDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Nilai Id_User null atau tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            MenuUtama MU = new MenuUtama(level1);
            MU.Show();
            Hide();
        }

        private void EnableInputControls()
        {
            TextUser.Clear();
            TextNama.Clear();
            TextPass.Clear();
            ComboLevel.SelectedIndex = -1;

            TextNama.Enabled = true;
            TextPass.Enabled = true;
            ComboLevel.Enabled = true;

            BtnSimpan.Enabled = true;
            BtnUbah.Enabled = true;
            BtnHapus.Enabled = true;
        }

        private void DisableInputControls()
        {
            TextUser.Enabled = false;
            TextNama.Enabled = false;
            TextPass.Enabled = false;
            ComboLevel.Enabled = false;

            BtnSimpan.Enabled = false;
            BtnUbah.Enabled = false;
            BtnHapus.Enabled = false;
        }
    }
}
