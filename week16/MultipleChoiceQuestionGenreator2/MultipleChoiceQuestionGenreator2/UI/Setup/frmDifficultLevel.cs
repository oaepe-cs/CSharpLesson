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
    public partial class frmDifficultLevel : Form
    {
        public frmDifficultLevel()
        {
            InitializeComponent();
        }

        private void frmDifficultLevel_Load(object sender, EventArgs e)
        {
            MssqlHelper.ReadData(dgv, "Select * From mcq_DifficultLevels;");
        }

        private void txtDifficultLevel_KeyPress(object sender, KeyPressEventArgs e)
        {           
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string message = "";
            try
            {
                if (txtDescription.Text == "")
                {
                    MessageBox.Show("Description is not blank!", "Wanning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescription.Focus();
                }
                else if (txtDifficultLevel.Text == "")
                {
                    MessageBox.Show("DifficultLevel is not blank!", "Wanning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDifficultLevel.Focus();
                }
                else
                {
                    //string description = txtDescription.Text.Replace("'", "''");
                    //string difficultLevel = txtDifficultLevel.Text.Replace("'", "''");
                    //string remark = txtRemark.Text.Replace("'", "''");

                    //string insertQuery = string.Format("INSERT INTO mcq_DifficultLevels (Description, DifficultLevel, Remarks) VALUES ('{0}', {1}, '{2}');",
                    //    description, difficultLevel, remark);
                    //message = MssqlHelper.InsertDataToDb(insertQuery);
                    //message = DifficultLevelServices.AddData(int.Parse(txtDifficultLevel.Text), txtDescription.Text, txtRemark.Text);

                    Dictionary<string, Object> dictionary = new Dictionary<string, object>();
                    dictionary.Add("DifficultLevel", int.Parse(txtDifficultLevel.Text));
                    dictionary.Add("Remarks", txtRemark.Text);
                    dictionary.Add("Description", txtDescription.Text);

                     message = MssqlHelper.AddData("mcq_DifficultLevels", dictionary);
                }
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
                    MssqlHelper.ReadData(dgv, "Select * From mcq_DifficultLevels;");
                }
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
                        string deleteSql = "DELETE FROM mcq_DifficultLevels WHERE DifficultLevelId=" + dgv.SelectedRows[0].Cells[0].Value.ToString();
                        message = MssqlHelper.DeleteDataFromDb(deleteSql);
                    }
                    catch (Exception ex)
                    {
                        message = ex.ToString();
                    }
                    finally
                    {
                        MessageBox.Show(message);
                        MssqlHelper.ReadData(dgv, "Select * From mcq_DifficultLevels;");
                    }

                }
            }
        }

        
    }
}
