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

            using (SqlConnection conn = new SqlConnection(MssqlDBHelper.ConnectionString))
            {
                cboCategory.Items.Clear();
                conn.Open();
                string selectSql = "SELECT Category FROM tbl_Categories ORDER BY Category;";
                SqlCommand cmd = new SqlCommand(selectSql, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while(rd.Read())
                {
                    string item = rd["Category"].ToString();

                    cboCategory.Items.Add(item);
                }
            }

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
            string connectionString = MssqlDBHelper.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string createdDate = dtpCreatedDate.Value.ToString("yyyy-MM-dd");
                string sql = "SELECT Type, Category, Amount FROM tbl_IncomesExpenses WHERE CreatedDate='" + createdDate + "';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    var item = rd[0].ToString() + ") " + rd[1] + "(" + rd[2].ToString() + ")";
                    lstIncomeExpense.Items.Add(item);
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

        private void lstIncomeExpense_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selectedItem = lstIncomeExpense.SelectedItem.ToString();

            string connectionString = MssqlDBHelper.ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string createdDate = dtpCreatedDate.Value.ToString("yyyy-MM-dd");
            string type = selectedItem.Split(')')[0].Trim();

            string category = selectedItem.Split('(')[0].Split(')')[1].Trim();

            string amount = selectedItem.Split('(')[1].Split(')')[0].Trim();
            string insertQueyr = string.Format("DELETE FROM tbl_IncomesExpenses WHERE CreatedDate='{0}' AND Type='{1}' AND Category='{2}' AND Amount={3}", createdDate, type, category, amount);

            SqlCommand command = new SqlCommand(insertQueyr, conn);
            command.ExecuteNonQuery();

            conn.Close();

            ReadData();
        }
    }
}
