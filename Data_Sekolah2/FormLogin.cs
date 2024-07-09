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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void TextUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                TextPass.Focus();
                e.Handled = true;
            }
        }

        private void TextPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                PerfromLogin();
            }
        }

        private void BtnKlik_Click(object sender, EventArgs e)
        {
            PerfromLogin();
        }

        private void PerfromLogin()
        {
            string username = TextUser.Text;
            string password = TextPass.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan password tidak boleh kosong", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "SELECT * FROM tb_user WHERE username = @username AND password = @password";

            using (SqlCommand cmd = new SqlCommand(query, Connect.conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                Connect.conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string level = reader["level"].ToString();

                        MenuUtama menuUtama = new MenuUtama(level);
                        menuUtama.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username atau password salah", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextUser.Text = "";
                        TextPass.Text = "";
                    }
                }

                Connect.conn.Close();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            TextPass.PasswordChar = '*';
        }

        private void CheckPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPass.Checked)
            {
                TextPass.PasswordChar = '\0'; // Menampilkan teks biasa (tanpa karakter tersembunyi)
            }
            else
            {
                TextPass.PasswordChar = '*'; // Menggunakan karakter tersembunyi (bintang)
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
