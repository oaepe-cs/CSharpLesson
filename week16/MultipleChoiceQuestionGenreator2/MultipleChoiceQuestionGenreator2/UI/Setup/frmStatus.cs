using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MultipleChoiceQuestionGenreator2.Service;

namespace MultipleChoiceQuestionGenreator2.Setup
{
    public partial class frmStatus : Form
    {
        public frmStatus()
        {
            InitializeComponent();
        }

        private void frmStatus_Load(object sender, EventArgs e)
        {
            MssqlHelper.ReadData(dgv, "Select * From mcq_Status;");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string message = "";
            try
            {
                if (txtDescription.Text != "")
                {
                    //string insertQuery = string.Format("INSERT INTO mcq_Status (Description, Remarks) VALUES ('{0}', '{1}')",
                    //    txtDescription.Text.Replace("'", "''"), txtRemark.Text.Replace("'", "'"));
                    //message = MssqlHelper.InsertDataToDb(insertQuery);

                    message = StatusService.AddData(txtDescription.Text, txtRemark.Text);
                    MessageBox.Show(message);
                    MssqlHelper.ReadData(dgv, "Select * From mcq_Status;");
                }
                else
                {
                    MessageBox.Show("Description is not blank!", "Wanning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescription.Focus();
                }
            }
            catch (Exception ex)
            {
                message = ex.ToString();
                MessageBox.Show(message);
            }
            finally
            {                
                
            }
        }        

        private void dgv_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgv.SelectedRows.Count == 1)
            {
                var rowData = dgv.SelectedRows[0];
                var result = MessageBox.Show("Do you want to delete " + rowData.Cells[1].Value.ToString() + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string message = "";
                    try
                    {
                        string deleteQuery = "DELETE FROM mcq_Status WHERE StatusId=" + dgv.SelectedRows[0].Cells[0].Value.ToString();
                        message = MssqlHelper.DeleteDataFromDb(deleteQuery);
                    }
                    catch (Exception ex)
                    {
                        message = ex.ToString();
                    }
                    finally
                    {
                        MessageBox.Show(message);
                        MssqlHelper.ReadData(dgv, "Select * From mcq_Status;");
                    }

                }
            }
        }
    }
}
