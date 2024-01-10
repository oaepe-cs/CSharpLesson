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
    public partial class frmSubject : Form
    {
        string ConnectionString = "Server=.; Database=MultipleChoicesQuestionGenerator; User Id=sa; Password=123456789cs";
        public frmSubject()
        {
            InitializeComponent();
        }

        private void ReadData()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from mcq_Subjects", conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable result = ds.Tables[0];
                dgv.DataSource = result;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                string insertSql = string.Format("INSERT INTO mcq_Subjects (Name, Description) VALUES ('{0}', '{1}');", txtName.Text, txtDescription.Text);
                
                SqlCommand cmd = new SqlCommand(insertSql, conn);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }

            ReadData();
        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
            ReadData();
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgv.SelectedRows.Count ==1)
            {
                var rowData = dgv.SelectedRows[0];
                //MessageBox.Show("Delete Key down Event." + rowData.Cells[0].Value.ToString() + " Name: " + rowData.Cells[1].Value.ToString());

                DialogResult result = MessageBox.Show("Do you want to delete " + rowData.Cells[1].Value.ToString() + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //1) Connection
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();

                        //2) Delete Sql
                        string deleteSql = "DELETE FROM mcq_Subjects WHERE SubjectId=" + rowData.Cells[0].Value.ToString();

                        //3) Command
                        using (SqlCommand cmd = new SqlCommand(deleteSql, conn))
                        {
                            //4) Execute
                            cmd.ExecuteNonQuery();
                        }
                    }

                    ReadData();
                }
            }
        }
    }
}
