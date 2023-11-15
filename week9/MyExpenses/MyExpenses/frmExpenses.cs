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
            BindCategoryCombo();
            ReadData();
            var _cratedDateTime = dtpCreatedDate.Text;
            string createdDate = dtpCreatedDate.Value.ToString("yyyy-MM-dd");
        }
        
        #region Method

        private void BindCategoryCombo()
        {
            cboCategory.Items.Clear();
            using (SqlConnection connection = new SqlConnection(MssqlDBHelper.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT Category FROM tbl_Categories ORDER BY Category", connection);
                SqlDataReader rd = cmd.ExecuteReader();
                while(rd.Read()){
                    cboCategory.Items.Add(rd[0].ToString());
                }
            }
        }

        private void ReadData()
        {
            dgvIncomeExpense.Rows.Clear();
            string connectionString = MssqlDBHelper.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                int _no = 1;
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

                    string[] rowData = { id, _no.ToString(), type, category, amount, note };
                    dgvIncomeExpense.Rows.Add(rowData);
                    _no++;
                }
            }
        }
        
        private void DeleteData(int id, string value)
        {
            DialogResult result = MessageBox.Show(string.Format("Do you want to delete {0}?", value), "Income/Expense", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(MssqlDBHelper.ConnectionString);
                conn.Open();

                SqlCommand command = new SqlCommand(string.Format("DELETE FROM tbl_IncomesExpenses WHERE ID={0}", id), conn);
                command.ExecuteNonQuery();

                conn.Close();

                ReadData();
            }
        }
        #endregion

        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = MssqlDBHelper.ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlTransaction sqlTrx = conn.BeginTransaction();
            try
            {                
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

                sqlTrx.Commit();
                ReadData();
            }
            catch (Exception ex)
            {
                sqlTrx.Rollback();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }            
        }

        private void dtpCreatedDate_ValueChanged(object sender, EventArgs e)
        {
            ReadData();
        }

            

        #endregion

        private void dgvIncomeExpense_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Delete && dgvIncomeExpense.SelectedRows.Count > 0)
            {
                var rowData = dgvIncomeExpense.SelectedRows[0];
                if (rowData.Cells[0].Value != null)
                {
                    int id = int.Parse(rowData.Cells[0].Value.ToString());
                    string value = rowData.Cells[2].Value.ToString() + " - " + rowData.Cells[3].Value.ToString();
                    DeleteData(id, value);
                }
            }
        }
    }
}
