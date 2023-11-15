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
    public partial class frmReportsByDates : Form
    {
        public frmReportsByDates()
        {
            InitializeComponent();
        }

        private void frmReportsByDates_Load(object sender, EventArgs e)
        {
            //CreateGrid(dgv);
        }

        #region Method

        private void CreateGrid(DataGridView myGridName)
        {
            myGridName.AllowUserToAddRows = false;
            myGridName.AllowUserToDeleteRows = false;
            myGridName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            myGridName.Location = new System.Drawing.Point(298, 25);
            myGridName.MultiSelect = false;
            myGridName.Name = "dgv";
            myGridName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            myGridName.ColumnCount = 5;
            // 
            // ID
            // 
            var ID = myGridName.Columns[0];
            ID.Frozen = true;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // No
            // 
            var No = myGridName.Columns[1];
            No.Frozen = true;
            No.HeaderText = "No.";
            No.Name = "No";
            No.Width = 50;
            No.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            // 
            // Category
            // 
            var Category = myGridName.Columns[2];
            Category.HeaderText = "Category";
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // Amount
            // 
            var Amount = myGridName.Columns[3];
            Amount.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // Note
            // 
            var Note = myGridName.Columns[4];
            Note.HeaderText = "Note";
            Note.Name = "Note";
            Note.ReadOnly = true;
            Note.Width = 200;
        }

        private void BindSummaryData(DateTime dateFrom, DateTime dateTo)
        {
            lstSummary.Items.Clear();
            using (SqlConnection conn = new SqlConnection(MssqlDBHelper.ConnectionString))
            {
                conn.Open();
                try
                {
                    string sql = string.Format("SELECT [Type], Sum(Amount) AS TotalAmount FROM tbl_IncomesExpenses WHERE CreatedDate BETWEEN '{0}' AND '{1}' GROUP BY [Type];", dateFrom.ToString("yyyy-MM-dd"), dateTo.ToString("yyyy-MM-dd"));
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        string item = rd["Type"].ToString() + " (" + rd["TotalAmount"].ToString() + ")";
                        lstSummary.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    //Notified email to It Detps
                    //Write a log file.
                    //Write error to log table
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void BindDataGrid(DateTime dateFrom, DateTime dateTo, string type)
        {
            using(SqlConnection conn = new SqlConnection(MssqlDBHelper.ConnectionString))
            {
                conn.Open();
                string sql = "SELECT Type, Category, Amount, Note FROM tbl_IncomesExpenses WHERE Type= '" + type + "' AND CreatedDate BETWEEN '" + dateFrom.ToString("yyyy-MM-dd") + "' AND '" + dateTo.ToString("yyyy-MM-dd") + "';";
                SqlDataAdapter dt = new SqlDataAdapter(sql, conn);

                DataSet ds = new DataSet();
                dt.Fill(ds);

                //var dateTable = ds.Tables[0];

                dgv.DataSource = ds.Tables[0];

            }
        }
        #endregion

        #region Event

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindSummaryData(dtpFrom.Value, dtpTo.Value);
            if (lstSummary != null && lstSummary.Items.Count > 0)
            {
                lstSummary.SelectedIndex = 0;
                string type = lstSummary.Text;
                if (type != "")
                {
                    type = type.Split(' ')[0];
                    BindDataGrid(dtpFrom.Value, dtpTo.Value, type);
                }
            }
        }

        #endregion

        private void lstSummary_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = lstSummary.Text;
            if (type != "")
            {
                type = type.Split(' ')[0];
                BindDataGrid(dtpFrom.Value, dtpTo.Value, type);
            }
        }
    }
}
