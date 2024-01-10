using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using StoreProcedure.Helper;

namespace StoreProcedure.Setup
{
    public partial class frmType : Form
    {
        public frmType()
        {
            InitializeComponent();
        }

        private void frmType_Load(object sender, EventArgs e)
        {
            dgv.DataSource = ReadData("select * from tbl_Types;");
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            //AddToDBBySql();
            AddToDBByDynamicSql();
            dgv.DataSource = ReadData("select * from tbl_Types;");
        }

        private void AddToDBByDynamicSql()
        {
            using (SqlConnection conn = new SqlConnection(MSSQLHelper.ConnectionString))
            {
                conn.Open();
                SqlTransaction trx = conn.BeginTransaction();
                try
                {
                    using (SqlCommand cmd = new SqlCommand("InsertType", conn, trx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@type", txtType.Text);

                        cmd.ExecuteNonQuery();
                        trx.Commit();
                    }
                }
                catch (Exception ex)
                {
                    trx.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AddToDBBySql()
        {
            using (SqlConnection conn = new SqlConnection(MSSQLHelper.ConnectionString))
            {
                conn.Open();
                SqlTransaction trx = conn.BeginTransaction();
                try
                {
                    string sqlInsertQuery = string.Format("INSERT INTO tbl_Types (Type) VALUES ('{0}')", txtType.Text.Replace("'", "''"));
                    using (SqlCommand cmd = new SqlCommand(sqlInsertQuery, conn, trx))
                    {
                        cmd.ExecuteNonQuery();
                        trx.Commit();
                    }
                }
                catch (Exception ex)
                {
                    trx.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private DataTable ReadData(string selectQuery)
        {
            using (SqlConnection conn = new SqlConnection(MSSQLHelper.ConnectionString))
            {
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    DataTable dt = ds.Tables[0];

                    return dt;
                }
            }
        }
    }
}
