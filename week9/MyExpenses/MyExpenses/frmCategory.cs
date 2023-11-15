using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyExpenses
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            ReadDataAndBindToListCategory();
        }

        #region Method
        private void ReadDataAndBindToListCategory()
        {
            dgvCategory.Rows.Clear();
            using (SqlConnection conn = new SqlConnection(MssqlDBHelper.ConnectionString))
            {
                int _no = 1;
                conn.Open();
                string selectQuery = "SELECT Category FROM tbl_Categories;";

                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string item = rd["Category"].ToString();
                    string[] rowData = {_no.ToString(), item };
                    dgvCategory.Rows.Add(rowData);
                    _no++;
                }
            }
        }
        #endregion

        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            string message = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(MssqlDBHelper.ConnectionString))
                {
                    conn.Open();
                    string insertSQL = string.Format(
                                                    "INSERT INTO tbl_Categories (Category) VALUES ('{0}')",
                                                    txtCategory.Text
                                                    );
                    SqlCommand command = new SqlCommand(insertSQL, conn);
                    command.ExecuteNonQuery();
                }

                ReadDataAndBindToListCategory();
            }
            catch (Exception ex)
            {
                message = ex.ToString();
            }
            finally
            {
                if (message != "")
                {
                    MessageBox.Show(message);
                }
            }
            
        }
                
        private void DeleteCategory(string category)
        {
            string message = string.Format("Do you want to delete {0}?", category);
            DialogResult result = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes))
            {
                using (SqlConnection conn = new SqlConnection(MssqlDBHelper.ConnectionString))
                {
                    conn.Open();
                    string deleteSql = string.Format("DELETE FROM tbl_Categories WHERE Category='{0}';", category);
                    SqlCommand cmd = new SqlCommand(deleteSql, conn);
                    cmd.ExecuteNonQuery();

                    ReadDataAndBindToListCategory();
                }
            }
        }
        #endregion             

        private void dgvCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvCategory.SelectedRows.Count > 0)
            {
                var rowData = dgvCategory.SelectedRows[0];
                if (rowData.Cells[1].Value != null)
                {
                    string category = rowData.Cells[1].Value.ToString();
                    DeleteCategory(category);
                }
            }
        }
    }
}
