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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CreatedGrid();
            BindLstSummary(DateTime.Now);
            
            string type = lstSummary.Text;
            if (type != "")
            {
                type = type.Split('-')[1].Trim().Split(' ')[0];
                ReadDataGrid(type);
            }
        }

        #region Event
        private void btnCategory_Click(object sender, EventArgs e)
        {
            Form frm = new frmCategory();
            frm.ShowDialog();
        }

        private void btnIncomeExpense_Click(object sender, EventArgs e)
        {
            Form frm = new frmExpenses();
            frm.ShowDialog();
            BindLstSummary(DateTime.Now);
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            Form frm = new frmReportsByDates();
            //Form frm = new frmType();
            frm.ShowDialog();
        }

        private void lstSummary_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = lstSummary.Text;
            if (type != "")
            {
                type = type.Split('-')[1].Trim().Split(' ')[0];
                ReadDataGrid(type);
            }
        }

        private void cdmType_Click(object sender, EventArgs e)
        {
            Form frm = new frmType();
            frm.ShowDialog();
        }
        #endregion

        #region Method
        private void BindLstSummary(DateTime dateTime)
        {
            lstSummary.Items.Clear();
            using(SqlConnection conn = new SqlConnection(MssqlDBHelper.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(string.Format("SELECT [Type], Sum(Amount) AS TotalAmount FROM tbl_IncomesExpenses WHERE CreatedDate='{0}' GROUP BY [Type];", dateTime.ToString("yyyy-MM-dd")), conn);
                SqlDataReader rd = cmd.ExecuteReader();
                int no = 1;
                while (rd.Read())
                {
                    string item = string.Format("{0} - {1}  ({2})", no, rd[0].ToString(), rd[1].ToString());
                    lstSummary.Items.Add(item);
                    no++;
                }
            }
            if (lstSummary.Items.Count > 0)
            {
                lstSummary.SelectedIndex = 0;
            }
        }

        private void CreatedGrid()
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;           
            //dgv.Location = new System.Drawing.Point(298, 25);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.ColumnCount = 5;
            // 
            // ID
            // 
            var ID = dgv.Columns[0];
            ID.Frozen = true;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // No
            // 
            var No = dgv.Columns[1];
            No.Frozen = true;
            No.HeaderText = "No.";
            No.Name = "No";
            No.Width = 50;
            No.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight; ;
            // 
            // Category
            // 
            var Category = dgv.Columns[2];
            Category.HeaderText = "Category";
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // Amount
            // 
            var Amount = dgv.Columns[3];
            Amount.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // Note
            // 
            var Note = dgv.Columns[4];
            Note.HeaderText = "Note";
            Note.Name = "Note";
            Note.ReadOnly = true;
            Note.Width = 200;
        }

        private void ReadDataGrid(string type)
        {
            dgv.Rows.Clear();
            string connectionString = MssqlDBHelper.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                int _no = 1;
                conn.Open();
                string createdDate = DateTime.Now.ToString("yyyy-MM-dd");
                string sql = "SELECT ID, Type, Category, Amount, Note FROM tbl_IncomesExpenses WHERE Type= '"+ type +"' AND CreatedDate='" + createdDate + "';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    string id = rd["ID"].ToString();
                    string category = rd["Category"].ToString();
                    string amount = rd["Amount"].ToString();
                    string note = rd["Note"].ToString();

                    string[] rowData = { id, _no.ToString(), category, amount, note };
                    dgv.Rows.Add(rowData);
                    _no++;
                }
            }
        }
        #endregion

        
    }
}
