using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace MultipleChoiceQuestionGenreator2.UI.Report
{
    public partial class frmPrevieReport : Form
    {
        public frmPrevieReport()
        {
            InitializeComponent();
            this.reportViewer1.RefreshReport();
        }
        public string keyword { get; set; }
        public frmPrevieReport(string keyword)
        {
            InitializeComponent();
            this.reportViewer1.RefreshReport();
            this.keyword = keyword;
        }

        private void frmPrevieReport_Load(object sender, EventArgs e)
        {


            this.reportViewer1.RefreshReport();

            //QuestionId, Question, AnswerA, AnswerB, AnswerC,CorrectAnswer, Name, DifficultLevel, Status
            string sql = "SELECT Question, AnswerA, AnswerB, AnswerC, CorrectAnswer, Name,[Difficult level Discription] AS DifficultLevel, [Status Description] AS Status FROM vw_QuestionLists ORDER BY QuestionId DESC";
            if (keyword != "")
            {
                sql = "SELECT Question, AnswerA, AnswerB, AnswerC, CorrectAnswer, Name,[Difficult level Discription] AS DifficultLevel, [Status Description] AS Status FROM vw_QuestionLists WHERE Name=@Name ORDER BY QuestionId DESC";
            }
            Dictionary<string, object> whereInfo = new Dictionary<string, object>();
            string value = keyword;
            whereInfo.Add("Name", value);
            DataTable dt = MssqlHelper.GetData(sql, whereInfo);

            string rootdirctory = Environment.CurrentDirectory;
            string filePath = @"\UI\Report\Report1.rdlc";
            string reportPath = rootdirctory + filePath;
            this.reportViewer1.LocalReport.ReportPath = reportPath;
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ds", dt));
            this.reportViewer1.RefreshReport();
        }
    }
}
