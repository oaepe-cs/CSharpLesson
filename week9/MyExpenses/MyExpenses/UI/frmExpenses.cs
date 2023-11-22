using System;
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
    public partial class frmExpenses : Form, ISqlCrud
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
            string createdDate = dtpCreatedDate.Value.ToString("yyyy-MM-dd");
            string sql = "SELECT ID, Type, Category, Amount, Note FROM tbl_IncomesExpenses WHERE CreatedDate='" + createdDate + "';";
            DataTable dt = ReadAllData(sql);

            dgvIncomeExpense.Rows.Clear();
            int _no = 1;
            foreach (DataRow rd in dt.Rows)
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

            //dgvIncomeExpense.Rows.Clear();
            //string connectionString = MssqlDBHelper.ConnectionString;
            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    int _no = 1;
            //    conn.Open();
            //    string createdDate = dtpCreatedDate.Value.ToString("yyyy-MM-dd");
            //    string sql = "SELECT ID, Type, Category, Amount, Note FROM tbl_IncomesExpenses WHERE CreatedDate='" + createdDate + "';";
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    SqlDataReader rd = cmd.ExecuteReader();
                
            //    while (rd.Read())
            //    {
            //        string id = rd["ID"].ToString();
            //        string type = rd["Type"].ToString();
            //        string category = rd["Category"].ToString();
            //        string amount = rd["Amount"].ToString();
            //        string note = rd["Note"].ToString();

            //        string[] rowData = { id, _no.ToString(), type, category, amount, note };
            //        dgvIncomeExpense.Rows.Add(rowData);
            //        _no++;
            //    }
            //}
        }
        
        private void DeleteData(int id, string value)
        {
            DialogResult result = MessageBox.Show(string.Format("Do you want to delete {0}?", value), "Income/Expense", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string deleteQuery = string.Format("DELETE FROM tbl_IncomesExpenses WHERE ID={0}", id);
                Delete(deleteQuery);

                //using (SqlConnection conn = new SqlConnection(MssqlDBHelper.ConnectionString))
                //{
                //    conn.Open();
                //    SqlTransaction sqlTrx = conn.BeginTransaction();
                //    try
                //    {
                //        SqlCommand command = new SqlCommand(string.Format("DELETE FROM tbl_IncomesExpenses WHERE ID={0}", id), conn, sqlTrx);
                //        command.ExecuteNonQuery();
                //        sqlTrx.Commit();
                //    }
                //    catch (Exception ex)
                //    {
                //        sqlTrx.Rollback();
                //    }
                //}

                ReadData();
            }
        }
        #endregion

        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            string createdDate = dtpCreatedDate.Value.ToString("yyyy-MM-dd");//2023-11-20
            string type = "";
            if (rdbIncome.Checked == true)
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
            string insertQuey = string.Format("INSERT INTO tbl_IncomesExpenses VALUES('{0}', '{1}', '{2}', {3}, '{4}');", createdDate, type, category, amount, note);
            Add(insertQuey);
            ReadData();

            //string connectionString = MssqlDBHelper.ConnectionString;
            //SqlConnection conn = new SqlConnection(connectionString);
            //conn.Open();
            //SqlTransaction sqlTrx = conn.BeginTransaction();
            //try
            //{                
                

            //    //SqlCommand command = new SqlCommand(insertQuey, conn);
            //    SqlCommand command = new SqlCommand(insertQuey, conn, sqlTrx);
            //    command.ExecuteNonQuery();

            //    sqlTrx.Commit();
            //    ReadData();
            //}
            //catch (Exception ex)
            //{
            //    sqlTrx.Rollback();
            //    //MessageBox.Show(ex.ToString());
            //}
            //finally
            //{
            //    conn.Close();
            //}            
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
                int id = int.Parse(rowData.Cells[0].Value.ToString());
                string value = rowData.Cells[2].Value.ToString() + " - " + rowData.Cells[3].Value.ToString();
                DeleteData(id, value);
            }
        }

        public DataTable ReadAllData(string SelectSql)
        {
            return CommonCrudService.ReadAllData(SelectSql);
        }

        public void Add(string InsertSql)
        {
            List<string> lstTrxsSql = new List<string>();
            lstTrxsSql.Add(InsertSql);
            string msg = CommonCrudService.MakeTransaction(lstTrxsSql);
            MessageBox.Show(msg, "Income & Expense", MessageBoxButtons.OK, MessageBoxIcon.Information);            
        }

        public void Delete(string DeleteSql)
        {
            List<string> lstTrxsSql = new List<string>();
            lstTrxsSql.Add(DeleteSql);
            string msg = CommonCrudService.MakeTransaction(lstTrxsSql);
            MessageBox.Show(msg, "Income & Expense", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Update(string UpdateSql)
        {
            throw new NotImplementedException();
        }
    }
}

