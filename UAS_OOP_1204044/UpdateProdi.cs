﻿using System;
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
    public partial class UpdateProdi : Form
    {
        public UpdateProdi()
        {
            InitializeComponent();
        }
        private DataSet dsProdi;

        public DataSet CreateProdiDataSet()
        {
            DataSet myDataSet = new DataSet();
            {
                try
                {
                    SqlConnection myConnection = new SqlConnection(@"data source=desktop-l726lra; initial catalog = UAS; integrated security=true;");

                    SqlCommand myCommand = new SqlCommand();

                    myCommand.Connection = myConnection;

                    myCommand.CommandText = "SELECT * FROM ms_prodi";
                    myCommand.CommandType = CommandType.Text;

                    SqlDataAdapter myDataAdapter = new SqlDataAdapter();
                    myDataAdapter.SelectCommand = myCommand;
                    myDataAdapter.TableMappings.Add("Table", "Prodi");

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
            dsProdi = CreateProdiDataSet();

            dgProdi.DataSource = dsProdi.Tables["Prodi"];
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataset();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(@"data source=desktop-l726lra; initial catalog = UAS; integrated security=true;");

            myConnection.Open();

            SqlDataAdapter myAdapter = new SqlDataAdapter("select * from ms_prodi", myConnection);
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
                int rowsUpdated = myAdapter.Update(dsProdi, "Prodi");

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