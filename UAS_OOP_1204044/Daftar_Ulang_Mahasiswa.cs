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
    public partial class Daftar_Ulang_Mahasiswa : Form
    {
        public Daftar_Ulang_Mahasiswa()
        {
            InitializeComponent();
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

                MessageBox.Show("Data Berhasil Disubmit !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string getSql = "SELECT nama_mhs,nama_prodi,biaya_kuliah FROM ms_mhs " +
               "JOIN ms_prodi ON ms_mhs.kode_prodi=ms_prodi.kode_prodi WHERE npm='" + txtNpm.Text + "'";

            string connection = @"data source=desktop-l726lra; initial catalog = UAS; integrated security=true;";
            SqlConnection myConnection = new SqlConnection(connection);
            myConnection.Open();
            SqlCommand sc = new SqlCommand(getSql, myConnection);
            SqlDataReader Result;

            Result = sc.ExecuteReader();
            if (Result.HasRows)
            {
                while (Result.Read())
                {
                    txtNama.Text = Result["nama_mhs"].ToString();
                    txtProdi.Text = Result["nama_prodi"].ToString();
                    txtBiaya.Text = Result["biaya_kuliah"].ToString();
                }
            }
        }
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (txtNpm.Text != "")
            {
                if (rbA.Checked != false || rbB.Checked != false || rbC.Checked != false)
                {
                    string grade = "";
                    if (rbA.Checked)
                    {
                        grade = "A";
                    }
                    if (rbB.Checked)
                    {
                        grade = "B";
                    }
                    if (rbC.Checked)
                    {
                        grade = "C";
                    }

                    string cmd = "INSERT INTO tr_daftar_ulang VALUES ('"
                       + txtNpm.Text + "','"
                       + grade + "','"
                       + txtBiaya.Text + "')";
                    UpdateDB(cmd);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Grade Seleksi harus dipilih !", "Infromasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("NPM harus diisi !", "Infromasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void clear()
        {

            txtNpm.Text = "";
            txtNama.Text = "";
            txtProdi.Text = "";
            txtBiaya.Text = "";
            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false;
            txtPotBiaya.Text = "";
            txtBiaya.Text = "";

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void rbA_CheckedChanged(object sender, EventArgs e)
        {
            int potbiaya = (Int32.Parse(txtBiaya.Text.ToString()) * 50) / 100;
            txtPotBiaya.Text = potbiaya.ToString();
            int totalbiaya = Int32.Parse(txtBiaya.Text.ToString()) - potbiaya;
            txtBiaya.Text = totalbiaya.ToString();
        }

        private void rbB_CheckedChanged(object sender, EventArgs e)
        {
            int potbiaya = (Int32.Parse(txtBiaya.Text.ToString()) * 25) / 100;
            txtPotBiaya.Text = potbiaya.ToString();
            int totalbiaya = Int32.Parse(txtBiaya.Text.ToString()) - potbiaya;
            txtBiaya.Text = totalbiaya.ToString();
        }

        private void rbC_CheckedChanged(object sender, EventArgs e)
        {
            int potbiaya = (Int32.Parse(txtBiaya.Text.ToString()) * 10) / 100;
            txtPotBiaya.Text = potbiaya.ToString();
            int totalbiaya = Int32.Parse(txtBiaya.Text.ToString()) - potbiaya;
            txtBiaya.Text = totalbiaya.ToString();
        }

        private void txtBiaya_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtNpm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNpm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
