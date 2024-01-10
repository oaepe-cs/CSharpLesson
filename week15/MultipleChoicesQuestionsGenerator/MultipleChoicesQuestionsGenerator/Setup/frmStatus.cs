using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MultipleChoicesQuestionsGenerator.Setup
{
    public partial class frmStatus : Form
    {
        string ConnectionString = "Server=.; Database=MultipleChoicesQuestionGenerator; User Id=sa; Password=123456789cs";
        public frmStatus()
        {
            InitializeComponent();
        }

        private void frmStatus_Load(object sender, EventArgs e)
        {
            ReadData();

        }

        private void ReadData()
        {
            //1) DB Connection
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                //2) Select Query 
                string selectQuery = "Select * From mcq_Status";

                //3) DataAdapter(SelectQuery, DB Connection) 
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, conn))
                {
                    //3) DataSet
                    DataSet ds = new DataSet();

                    //4) DataAdapeter.Fill
                    adapter.Fill(ds);

                    //5) Bind to DataGrid View
                    DataTable table = ds.Tables[0];
                    dgv.DataSource = table;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //1) Connection
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                //2) Insert Query
                string insertQuery = string.Format("INSERT INTO mcq_Status (Description, Remarks) VALUES ('{0}', '{1}')", txtDescription.Text, txtRemark.Text);
                
                //3) Command(Insert Query, Connection)
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    //4) Execute
                    cmd.ExecuteNonQuery();
                }
            }

            ReadData();
        }

        private void dgv_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgv.SelectedRows.Count == 1)
            {
                DialogResult result = MessageBox.Show("Do you want to delete" +dgv.SelectedRows[0].Cells[1].Value.ToString()+ "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();

                        string deleteQuery = "DELETE FROM mcq_Status WHERE StatusId=" + dgv.SelectedRows[0].Cells[0].Value.ToString();

                        using(SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                    ReadData();
                }
            }
        }
    }
}
