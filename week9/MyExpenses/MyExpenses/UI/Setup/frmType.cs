﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyExpenses.Data;
using MyExpenses.Service;

namespace MyExpenses
{
    public partial class frmType : Form, ISqlCrud
    {
        public frmType()
        {
            InitializeComponent();
            ReadDataAndBindToListType();

        }

        private void BindToGrid(string sql)
        {
            DataTable dt = ReadAllData(sql);
            dgvCategory.DataSource = dt;
        }

        private void ReadDataAndBindToListType()
        {
            lstType.Items.Clear();
            using (SqlConnection conn = new SqlConnection(MssqlDBHelper.ConnectionString))
            {
                conn.Open();
                string selectQuery = "SELECT Type FROM tbl_Types;";

                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string item = rd["Type"].ToString();

                    lstType.Items.Add(item);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string insertSQL = string.Format("INSERT INTO tbl_Types (Type) VALUES ('{0}')",txtType.Text);
            Add(insertSQL);
            //using (SqlConnection conn = new SqlConnection(MssqlDBHelper.ConnectionString))
            //{
            //    conn.Open();
            //    string insertSQL = string.Format(
            //                                    "INSERT INTO tbl_Types (Type) VALUES ('{0}')",
            //                                    txtType.Text
            //                                    );
            //    SqlCommand command = new SqlCommand(insertSQL, conn);
            //    command.ExecuteNonQuery();
            //}

            ReadDataAndBindToListType();
            BindToGrid("SELECT Type FROM tbl_Types;");
        }

        private void lstType_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && lstType.SelectedItem.ToString() != "")
            {
                string message = string.Format("Do you want to delete {0}?", lstType.SelectedItem.ToString());
                DialogResult result = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result.Equals(DialogResult.Yes))
                {
                    string deleteSql = string.Format("DELETE FROM tbl_Types WHERE Type='{0}';", lstType.SelectedItem.ToString());
                    Delete(deleteSql);
                    ReadDataAndBindToListType();
                    BindToGrid("SELECT Type FROM tbl_Types;");
                    //using (SqlConnection conn = new SqlConnection(MssqlDBHelper.ConnectionString))
                    //{
                    //    conn.Open();
                    //    string deleteSql = string.Format("DELETE FROM tbl_Types WHERE Type='{0}';", lstType.SelectedItem.ToString());
                    //    SqlCommand cmd = new SqlCommand(deleteSql, conn);
                    //    cmd.ExecuteNonQuery();

                    //    ReadDataAndBindToListType();
                    //}
                }
            }
        }

        private void frmType_Load(object sender, EventArgs e)
        {
            BindToGrid("SELECT Type FROM tbl_Types;");
        }

        private DataTable GetData()
        {
            using (SqlConnection connection = new SqlConnection(MssqlDBHelper.ConnectionString))
            {
                // Create a new SqlDataAdapter with the SELECT query and connection
                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From tbl_Categories", connection))
                {
                    // Create a new DataSet
                    DataSet dataSet = new DataSet();

                    // Open the connection
                    connection.Open();

                    // Fill the DataSet with data from the database
                    adapter.Fill(dataSet, "YourTable");

                    // Do something with the data in the DataSet

                    // For example, display the data in a console
                    return dataSet.Tables["YourTable"];
                }
            }
        }



        public DataTable ReadAllData(string SelectSql)
        {
            return CommonCrudService.ReadAllData(SelectSql);
        }

        public void Add(string InsertSql)
        {
            List<string> lstTrxSqls = new List<string>();
            lstTrxSqls.Add(InsertSql);
            string msg = CommonCrudService.MakeTransaction(lstTrxSqls);
            MessageBox.Show(msg);

        }

        public void Delete(string DeleteSql)
        {
            List<string> lstTrxSqls = new List<string>();
            lstTrxSqls.Add(DeleteSql);
            string msg = CommonCrudService.MakeTransaction(lstTrxSqls);
            MessageBox.Show(msg);
        }

        public void Update(string UpdateSql)
        {
            throw new NotImplementedException();
        }
    }
}
