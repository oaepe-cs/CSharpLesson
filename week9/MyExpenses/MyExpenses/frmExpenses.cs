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
    public partial class frmExpenses : Form
    {
        public frmExpenses()
        {
            InitializeComponent();
        }

        private void frmExpenses_Load(object sender, EventArgs e)
        {
            ReadData();
            var _cratedDateTime = dtpCreatedDate.Text;
            string createdDate = dtpCreatedDate.Value.ToString("yyyy-MM-dd");
        }

        private void ReadData()
        {
            lstIncomeExpense.Items.Clear();
            dgvIncomeExpense.Rows.Clear();
            string connectionString = MssqlDBHelper.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string createdDate = dtpCreatedDate.Value.ToString("yyyy-MM-dd");
                string sql = "SELECT ID, Type, Category, Amount, Note FROM tbl_IncomesExpenses WHERE CreatedDate='" + createdDate + "';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string id = rd["ID"].ToString();
                    string type = rd["Type"].ToString();
                    string category = rd["Category"].ToString();
                    string amount = rd["Amount"].ToString();
                    string note = rd["Note"].ToString();

                    var item = id + ") " + type + " - " + category + "(" + amount + ")";
                    lstIncomeExpense.Items.Add(item);
                                        
                    string[] rowData = { id, type, category, amount, note };
                    dgvIncomeExpense.Rows.Add(rowData);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = MssqlDBHelper.ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string createdDate = dtpCreatedDate.Value.ToString("yyyy-MM-dd");
            string type = "";
            if (rdbIncome.Checked)
            {
                type = "Income";
            }
            if (rdbExpense.Checked)
            {
                type = "Expense";
            }
            string category = cboCategory.Text;
            string amount = ntxtAmount.Text;
            string note = txtNote.Text;
            string insertQueyr = string.Format("INSERT INTO tbl_IncomesExpenses VALUES('{0}', '{1}', '{2}', {3}, '{4}');", createdDate, type, category, amount, note);
            
            SqlCommand command = new SqlCommand(insertQueyr, conn);
            command.ExecuteNonQuery();

            conn.Close();

            ReadData();
        }

        private void dtpCreatedDate_ValueChanged(object sender, EventArgs e)
        {
            ReadData();
        }

        private void lstIncomeExpense_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstIncomeExpense_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show(lstIncomeExpense.SelectedItem.ToString());
        }

        private void lstIncomeExpense_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var selectedItem = lstIncomeExpense.SelectedItem.ToString();
                int id = Convert.ToInt32(selectedItem.Split(')')[0]);
                string value = lstIncomeExpense.SelectedItem.ToString();
                DeleteData(id, value);
            }
        }

        private void DeleteData(int id, string value)
        {
            string message = string.Format("Do you want to delete {0}?", value);
            DialogResult result = MessageBox.Show(message, "Income/Expense", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string connectionString = MssqlDBHelper.ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string deleteQuery = string.Format("DELETE FROM tbl_IncomesExpenses WHERE ID={0}", id);
                SqlCommand command = new SqlCommand(deleteQuery, conn);
                command.ExecuteNonQuery();

                conn.Close();

                ReadData();
            }
        }

        private void dgvIncomeExpense_KeyUp(object sender, KeyEventArgs e)
        {
            if (dgvIncomeExpense.SelectedRows.Count > 0)
            {
                var rowData = dgvIncomeExpense.SelectedRows[0];
                if (rowData.Cells[0].Value != null)
                {
                    int id = int.Parse(rowData.Cells[0].Value.ToString());
                    string value = rowData.Cells[1].Value.ToString();
                    DeleteData(id, value);
                }
            }
        }
    }
}
