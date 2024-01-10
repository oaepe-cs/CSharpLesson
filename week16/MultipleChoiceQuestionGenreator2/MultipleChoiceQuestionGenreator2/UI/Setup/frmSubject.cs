using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MultipleChoiceQuestionGenreator2.Service;

namespace MultipleChoiceQuestionGenreator2.Setup
{
    public partial class frmSubject : Form
    {
        public frmSubject()
        {
            InitializeComponent();
        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
            MssqlHelper.ReadData(dgv, "Select * From mcq_Subjects;");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string message = "";
            if (txtName.Text != "")
            {
                try
                {
                    //string name = txtName.Text.Replace("'", "''");
                    //string description = txtDescription.Text.Replace("'", "''");
                    //string insertSql = string.Format("INSERT INTO mcq_Subjects (Name, Description) VALUES ('{0}', '{1}');", name, description);
                    //message = MssqlHelper.InsertDataToDb(insertSql);

                    //message = SubjectService.AddSubject(txtName.Text, txtDescription.Text);

                    Dictionary<string, Object> dictionary = new Dictionary<string, object>();
                    dictionary.Add("Name",txtName.Text);
                    dictionary.Add("Description", txtDescription.Text);

                    message = MssqlHelper.AddData("mcq_Subjects", dictionary);
                }
                catch (Exception ex)
                {
                    message = ex.ToString();
                }
                finally
                {
                    MessageBox.Show(message);
                    MssqlHelper.ReadData(dgv, "Select * From mcq_Subjects;");
                }
            }
            else
            {
                MessageBox.Show("Name is not blank!", "Wanning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
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
                        string deleteSql = "DELETE FROM mcq_Subjects WHERE SubjectId=" + rowData.Cells[0].Value.ToString();
                        message = MssqlHelper.DeleteDataFromDb(deleteSql);
                    }
                    catch (Exception ex)
                    {
                        message = ex.ToString();
                    }
                    finally
                    {
                        MessageBox.Show(message);
                        MssqlHelper.ReadData(dgv, "Select * From mcq_Subjects;");
                    }

                }
            }
        }
    }
}
