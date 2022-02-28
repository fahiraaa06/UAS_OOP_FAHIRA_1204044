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
    public partial class Mahasiswa : Form
    {

        string prodi;
        public Mahasiswa()
        {
            InitializeComponent();

            SqlConnection myConnection = new SqlConnection(@"datasource=desktop-l726lra; initialcatalog=UAS; integratedsecurity=true;");

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand("SELECT * FROM ms_prodi", myConnection);
            SqlDataReader reader;

            reader = myCommand.ExecuteReader();
            DataTable myDataTable = new DataTable();
            myDataTable.Columns.Add("kode_prodi", typeof(string));
            myDataTable.Columns.Add("singkatan", typeof(string));
            myDataTable.Load(reader);

            cbProdi.ValueMember = "kode_prodi";
            cbProdi.DisplayMember = "singkatan";
            cbProdi.DataSource = myDataTable;

            myConnection.Close();
        }

        private void txtNPM_Leave(object sender, EventArgs e)
        {
            if (txtNPM.Text == "")
            {
                epWarning.SetError(txtNPM, "Textbox NPM tidak boleh kosong!");
                epWrong.SetError(txtNPM, "");
                epCorrect.SetError(txtNPM, "");
            }
            else
            {
                if ((txtNPM.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(txtNPM, "Betul!");
                    epWarning.SetError(txtNPM, "");
                    epWrong.SetError(txtNPM, "");
                }
                else
                {
                    epCorrect.SetError(txtNPM, "");
                    epWarning.SetError(txtNPM, "");
                    epWrong.SetError(txtNPM, "Inputan hanya boleh angka!");
                }
            }
        }

        private void txtNamaMhs_Leave(object sender, EventArgs e)
        {
            if (txtNamaMhs.Text == "")
            {
                epWarning.SetError(txtNamaMhs, "Textbox Nama Mahasiswa tidak boleh kosong!");
                epWrong.SetError(txtNamaMhs, "");
                epCorrect.SetError(txtNamaMhs, "");
            }
            else
            {
                if ((txtNamaMhs.Text).All(Char.IsLetter))
                {
                    epCorrect.SetError(txtNamaMhs, "Betul!");
                    epWarning.SetError(txtNamaMhs, "");
                    epWrong.SetError(txtNamaMhs, "");
                }
                else
                {
                    epCorrect.SetError(txtNamaMhs, "");
                    epWarning.SetError(txtNamaMhs, "");
                    epWrong.SetError(txtNamaMhs, "Inputan hanya boleh huruf!");
                }
            }
        }

        private void cbProdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.prodi = cbProdi.SelectedValue.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string npm = txtNPM.Text;
            string nama = txtNamaMhs.Text;
            string prodi = this.prodi;

            SqlConnection myConnection = new SqlConnection(@"data source=desktop-l726lra; initial catalog = UAS; integrated security=true;");
            string sql = "INSERT INTO ms_mhs ([npm],[nama_mhs],[kode_prodi]) VALUES(@npm,@nama_mhs,@kode_prodi)";

            using (SqlConnection Connection = new SqlConnection(@"data source=desktop-l726lra; initial catalog = UAS; integrated security=true"))
            {
                try
                {
                    Connection.Open();

                    using (SqlCommand Command = new SqlCommand(sql, Connection))
                    {
                        Command.Parameters.Add("@npm", SqlDbType.VarChar).Value = npm;
                        Command.Parameters.Add("@nama_mhs", SqlDbType.VarChar).Value = nama;
                        Command.Parameters.Add("@kode_prodi", SqlDbType.VarChar).Value = prodi;

                        int rowsAdded = Command.ExecuteNonQuery();
                        if (rowsAdded > 0)
                            MessageBox.Show("Data berhasil di simpan");
                        else
                            MessageBox.Show("Data tidak tersimpan");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.Message);

                }
            }
        }
        private void clear()
        {
            txtNPM.Text = "";
            txtNamaMhs.Text = "";
            cbProdi.Text = "";
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}

