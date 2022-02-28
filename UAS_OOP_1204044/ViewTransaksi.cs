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
    public partial class ViewTransaksi : Form
    {
        private DataSet dsTr;

        public ViewTransaksi()
        {
            InitializeComponent();
        }
        public DataSet CreateTransaksiDataSet()
        {
            DataSet myDataSet = new DataSet();
            {
                try
                {
                    SqlConnection myConnection = new SqlConnection(@"data source=desktop-l726lra; initial catalog = UAS; integrated security=true;");

                    SqlCommand myCommand = new SqlCommand();

                    myCommand.Connection = myConnection;

                    myCommand.CommandText = "SELECT * FROM tr_daftar_ulang";
                    myCommand.CommandType = CommandType.Text;

                    SqlDataAdapter myDataAdapter = new SqlDataAdapter();
                    myDataAdapter.SelectCommand = myCommand;
                    myDataAdapter.TableMappings.Add("Table", "Daftar_ulang_Mahasiswa");

                    myDataAdapter.Fill(myDataSet);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                return myDataSet;
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dsTr = CreateTransaksiDataSet();

            dgTransaksi.DataSource = dsTr.Tables["Mahasiswa"];
        }
    }
}
