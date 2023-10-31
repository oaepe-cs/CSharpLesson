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

            ReadDataAndBindToListCategory();
        }

        private void ReadDataAndBindToListCategory()
        {
            lstCategory.Items.Clear();
            using (SqlConnection conn = new SqlConnection(MssqlDBHelper.ConnectionString))
            {
                conn.Open();
                string selectQuery = "SELECT Category FROM tbl_Categories;";

                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string item = rd["Category"].ToString();

                    lstCategory.Items.Add(item);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
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

        private void lstCategory_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && lstCategory.SelectedItem.ToString() != "")
            {
                string message = string.Format("Do you want to delete {0}?", lstCategory.SelectedItem.ToString());
                DialogResult result = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result.Equals(DialogResult.Yes))
                {
                    using (SqlConnection conn = new SqlConnection(MssqlDBHelper.ConnectionString))
                    {
                        conn.Open();
                        string deleteSql = string.Format("DELETE FROM tbl_Categories WHERE Category='{0}';", lstCategory.SelectedItem.ToString());
                        SqlCommand cmd = new SqlCommand(deleteSql, conn);
                        cmd.ExecuteNonQuery();

                        ReadDataAndBindToListCategory();
                    }
                }
            }
        }
    }
}
