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
    public partial class UpdateMahasiswa : Form
    {
        public UpdateMahasiswa()
        {
            InitializeComponent();
        }
        private DataSet dsMhs;

        public DataSet CreateProdiDataSet()
        {
            DataSet myDataSet = new DataSet();
            {
                try
                {
                    SqlConnection myConnection = new SqlConnection(@"data source=desktop-l726lra; initial catalog = UAS; integrated security=true;");

                    SqlCommand myCommand = new SqlCommand();

                    myCommand.Connection = myConnection;

                    myCommand.CommandText = "SELECT * FROM ms_mhs";
                    myCommand.CommandType = CommandType.Text;

                    SqlDataAdapter myDataAdapter = new SqlDataAdapter();
                    myDataAdapter.SelectCommand = myCommand;
                    myDataAdapter.TableMappings.Add("Table", "Mahasiswa");

                    myDataAdapter.Fill(myDataSet);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                return myDataSet;
            }
        }

        private void RefreshDataset()
        {
            dsMhs = CreateProdiDataSet();

            dgMahasiswa.DataSource = dsMhs.Tables["Mahasiswa"];
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataset();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SqlConnection myConnection = new SqlConnection(@"data source=desktop-l726lra; initial catalog = UAS; integrated security=true;");

            myConnection.Open();

            SqlDataAdapter myAdapter = new SqlDataAdapter("select * from ms_mhs", myConnection);
            SqlCommandBuilder myCmdBuilder = new SqlCommandBuilder(myAdapter);

            myAdapter.InsertCommand = myCmdBuilder.GetInsertCommand();
            myAdapter.UpdateCommand = myCmdBuilder.GetUpdateCommand();
            myAdapter.DeleteCommand = myCmdBuilder.GetDeleteCommand();

            SqlTransaction myTransaction;
            myTransaction = myConnection.BeginTransaction();
            myAdapter.DeleteCommand.Transaction = myTransaction;
            myAdapter.UpdateCommand.Transaction = myTransaction;
            myAdapter.InsertCommand.Transaction = myTransaction;

            try
            {
                int rowsUpdated = myAdapter.Update(dsMhs, "Mahasiswa");

                myTransaction.Commit();

                MessageBox.Show(rowsUpdated.ToString() + " baris diperbarui", "informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshDataset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update: " + ex.Message);

                myTransaction.Rollback();
            }
        }
    }
}
