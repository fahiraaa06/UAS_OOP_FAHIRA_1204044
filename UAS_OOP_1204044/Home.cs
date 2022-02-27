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
            
        }

        private void ProdiMenuItem_Click(object sender, EventArgs e)
        {
            Prodi InputProdi = new Prodi();
            InputProdi.MdiParent = this;
            InputProdi.Show();
        }
    }
}
