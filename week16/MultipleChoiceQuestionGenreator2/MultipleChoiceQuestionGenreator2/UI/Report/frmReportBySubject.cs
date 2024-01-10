using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultipleChoiceQuestionGenreator2.UI.Report
{
    public partial class frmReportBySubject : Form
    {
        public frmReportBySubject()
        {
            InitializeComponent();
        }

        private void ReadData(string keyword, int rowindex = 0)
        {
            int i = 1;
            string sql = "SELECT Question, AnswerA, AnswerB, AnswerC, CorrectAnswer, Name FROM vw_QuestionLists ORDER BY QuestionId DESC";
            if (keyword != "")
            {
                sql = "SELECT Question, AnswerA, AnswerB, AnswerC, CorrectAnswer, Name FROM vw_QuestionLists WHERE Name=@Name ORDER BY QuestionId DESC";
            }

            Dictionary<string, object> whereInfo = new Dictionary<string, object>();
            string value = keyword;
            whereInfo.Add("Name", value);

            var getData = MssqlHelper.GetData(sql, whereInfo);
            dgv.DataSource = getData;
            dgv.Rows[rowindex].Selected = true;
        }

        private void btnSerach_Click(object sender, EventArgs e)
        {
            ReadData(cboSubject.Text);
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            try
            {
                string result = ExportHelper.ExportCsv(dgv);
                MessageBox.Show(result, "Export CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Export CSV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
        }

        private void frmReportBySubject_Load(object sender, EventArgs e)
        {
            string selectSubjectSql = "SELECT SubjectId AS [ID], [Name] AS Display FROM mcq_Subjects";
            MssqlHelper.BindCombox(cboSubject, selectSubjectSql);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Form frm = new frmPrevieReport(cboSubject.Text);
            frm.ShowDialog();
        }
    }
}
