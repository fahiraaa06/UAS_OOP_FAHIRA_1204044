using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_OOP_1204044
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MahasiswaMenuItem_Click(object sender, EventArgs e)
        {
            Mahasiswa InputMahasiswa = new Mahasiswa();
            InputMahasiswa.MdiParent = this;
            InputMahasiswa.Show();
        }

        private void ProdiMenuItem_Click(object sender, EventArgs e)
        {
            Prodi InputProdi = new Prodi();
            InputProdi.MdiParent = this;
            InputProdi.Show();
        }

        private void viewProdiToolStripMenuItem_Click(object sender, EventArgs e)
        {
          ViewProdi TampilProdi = new ViewProdi();
            TampilProdi.MdiParent = this;
            TampilProdi.Show();
        }

        private void viewMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMahasiswa TampilMhs = new ViewMahasiswa();
            TampilMhs.MdiParent = this;
            TampilMhs.Show();
        }

        private void updateProdiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateProdi UbahProdi = new UpdateProdi();
            UbahProdi.MdiParent = this;
            UbahProdi.Show();
        }

        private void updateMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateMahasiswa UbahMahasiswa = new UpdateMahasiswa();
            UbahMahasiswa.MdiParent = this;
            UbahMahasiswa.Show();
        }

        private void TransaksiMenuItem_Click(object sender, EventArgs e)
        {
            Daftar_Ulang_Mahasiswa InputDaftarUlang = new Daftar_Ulang_Mahasiswa();
            InputDaftarUlang.MdiParent = this;
            InputDaftarUlang.Show();
        }
    }
}
