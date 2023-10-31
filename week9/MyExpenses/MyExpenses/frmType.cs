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
    public partial class frmType : Form
    {
        public frmType()
        {
            InitializeComponent();
            ReadDataAndBindToListType();
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
            using (SqlConnection conn = new SqlConnection(MssqlDBHelper.ConnectionString))
            {
                conn.Open();
                string insertSQL = string.Format(
                                                "INSERT INTO tbl_Types (Type) VALUES ('{0}')",
                                                txtType.Text
                                                );
                SqlCommand command = new SqlCommand(insertSQL, conn);
                command.ExecuteNonQuery();
            }

            ReadDataAndBindToListType();
        }

        private void lstType_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && lstType.SelectedItem.ToString() != "")
            {
                string message = string.Format("Do you want to delete {0}?", lstType.SelectedItem.ToString());
                DialogResult result = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result.Equals(DialogResult.Yes))
                {
                    using (SqlConnection conn = new SqlConnection(MssqlDBHelper.ConnectionString))
                    {
                        conn.Open();
                        string deleteSql = string.Format("DELETE FROM tbl_Types WHERE Type='{0}';", lstType.SelectedItem.ToString());
                        SqlCommand cmd = new SqlCommand(deleteSql, conn);
                        cmd.ExecuteNonQuery();

                        ReadDataAndBindToListType();
                    }
                }
            }
        }
    }
}
