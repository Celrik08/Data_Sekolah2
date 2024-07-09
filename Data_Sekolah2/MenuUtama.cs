using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Sekolah2
{
    public partial class MenuUtama : Form
    {
        private string level;
        public MenuUtama(string level)
        {
            InitializeComponent();
            this.level = level;

            if (level == "siswa")
            {
                DataMaster.Visible = false;
                HasilData.Visible = true;
            }

            else if (level == "petugas")
            {
                DataMaster.Visible = true;
                HasilData.Visible = false;
            }

            else if (level == "kepsek")
            {
                DataSiswa.Visible = true;
                DataKelas.Visible = true;
                DataMapel.Visible = true;
                DataJurusan.Visible = true;
                DataUser.Visible = false;
                HasilData.Visible = true;
            }

            else if (level == "guru")
            {
                DataMaster.Visible = false;
                HasilData.Visible = true;
            }

            User.Text = level;
        }

        private void DataSiswa_Click(object sender, EventArgs e)
        {
            DataSiswa DS = new DataSiswa(level);
            DS.Show();
            Hide();
        }

        private void DataKelas_Click(object sender, EventArgs e)
        {
            DataKelas DK = new DataKelas(level);
            DK.Show();
            Hide();
        }

        private void DataJurusan_Click(object sender, EventArgs e)
        {
            DataJurusan DJ = new DataJurusan(level);
            DJ.Show();
            Hide();
        }

        private void DataMapel_Click(object sender, EventArgs e)
        {
            DataMapel DM = new DataMapel(level);
            DM.Show();
            Hide();
        }

        private void DataUser_Click(object sender, EventArgs e)
        {
            DataUser DU = new DataUser(level);
            DU.Show();
            Hide();
        }

        private void DataNilai_Click(object sender, EventArgs e)
        {
            DataNilai DN = new DataNilai(level);
            DN.Show();
            Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormLogin FL = new FormLogin();
            FL.Show();
            Hide();
        }
    }
}
