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

namespace UAS_OOP_1204044
{
    public partial class Prodi : Form
    {
        public Prodi()
        {
            InitializeComponent();
        }

        private void tbKodePrd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKodePrd_Leave(object sender, EventArgs e)
        {
            if (txtKodePrd.Text == "")
            {
                epWarning.SetError(txtKodePrd, "Textbox kode prodi tidak boleh kosong!");
                epWrong.SetError(txtKodePrd, "");
                epCorrect.SetError(txtKodePrd, "");
            }
        }

        private void txtNamaProdi_Leave(object sender, EventArgs e)
        {
            if (txtNamaProdi.Text == "")
            {
                epWarning.SetError(txtNamaProdi, "Textbox nama prodi tidak boleh kosong!");
                epWrong.SetError(txtNamaProdi, "");
                epCorrect.SetError(txtNamaProdi, "");
            }
        }

        private void txtSingkatan_Leave(object sender, EventArgs e)
        {
            if (txtSingkatan.Text == "")
            {
                epWarning.SetError(txtSingkatan, "Textbox singkatan tidak boleh kosong!");
                epWrong.SetError(txtSingkatan, "");
                epCorrect.SetError(txtSingkatan, "");
            }
        }

        private void txtBiayaKuliah_Leave(object sender, EventArgs e)
        {
            if (txtBiayaKuliah.Text == "")
            {
                epWarning.SetError(txtBiayaKuliah, "Textbox Huruf tidak boleh kosong!");
                epWrong.SetError(txtBiayaKuliah, "");
                epCorrect.SetError(txtBiayaKuliah, "");
            }
            else
            {
                if ((txtBiayaKuliah.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(txtBiayaKuliah, "Betul!");
                    epWarning.SetError(txtBiayaKuliah, "");
                    epWrong.SetError(txtBiayaKuliah, "");
                }
                else
                {
                    epCorrect.SetError(txtBiayaKuliah, "");
                    epWarning.SetError(txtBiayaKuliah, "");
                    epWrong.SetError(txtBiayaKuliah, "Inputan hanya boleh angka!");
                }
            }
        }
        private void UpdateDB(string cmd)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection(@"data source=desktop-l726lra; initial catalog = UAS; integrated security=true;");

                myConnection.Open();

                SqlCommand myCommand = new SqlCommand();

                myCommand.Connection = myConnection;

                myCommand.CommandText = cmd;

                myCommand.ExecuteNonQuery();

                MessageBox.Show("Basisdata berhasil diperbaharui", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmi_Click(object sender, EventArgs e)
        {

            string myCmd = "INSERT INTO ms_prodi Values('"
                + txtKodePrd.Text + "','"
                + txtNamaProdi.Text + "','"
                + txtSingkatan.Text + "','"
                + txtBiayaKuliah.Text + "')";

            UpdateDB(myCmd);
        }
        private void clear()
        {
            txtKodePrd.Text = "";
            txtNamaProdi.Text = "";
            txtSingkatan.Text = "";
            txtBiayaKuliah.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
