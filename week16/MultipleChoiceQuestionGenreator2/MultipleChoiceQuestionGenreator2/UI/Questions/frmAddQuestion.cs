using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultipleChoiceQuestionGenreator2.Questions
{
    public partial class frmAddQuestion : Form
    {
        public frmAddQuestion()
        {
            InitializeComponent();
        }

        int questionId = 0;
        public frmAddQuestion(string questionId)
        {
            InitializeComponent();
            int.TryParse(questionId, out this.questionId);
        }

        private void BindData(int questionId)
        {
            string sql = "SELECT * FROM mcq_Questions WHERE QuestionId=" + questionId;
            DataTable dt = MssqlHelper.GetData(sql);
            if (dt.Rows.Count == 1)
            {
                string questionName = dt.Rows[0]["Question"].ToString();
                txtQuestion.Text = questionName;

                txtAnswerA.Text = dt.Rows[0]["AnswerA"].ToString();
                txtAnswerB.Text = dt.Rows[0]["AnswerB"].ToString();
                txtAnswerC.Text = dt.Rows[0]["AnswerC"].ToString();

                
                cboCorrectAnswer.Text = dt.Rows[0]["CorrectAnswer"].ToString();
                cboDifficultLevel.SelectedValue = dt.Rows[0]["DifficultLevelId"].ToString();
                cboStatus.SelectedValue = dt.Rows[0]["StatusId"].ToString();
                cboSubject.SelectedValue = dt.Rows[0]["SubjectId"].ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string message = "";
            try
            {
                if (txtQuestion.Text == "")
                {
                    MessageBox.Show("Question is not blank!", "Wanning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQuestion.Focus();
                }
                else if (txtAnswerA.Text == "")
                {
                    MessageBox.Show("Answer A is not blank!", "Wanning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAnswerA.Focus();
                }
                else if (txtAnswerB.Text == "")
                {
                    MessageBox.Show("Answer B is not blank!", "Wanning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAnswerB.Focus();
                }
                else if (txtAnswerC.Text == "")
                {
                    MessageBox.Show("Answer C is not blank!", "Wanning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAnswerC.Focus();
                }
                else
                {
                    int subjectId = int.Parse(cboSubject.SelectedValue.ToString());
                    int difficultLevelId = int.Parse(cboDifficultLevel.SelectedValue.ToString());
                    int statusId = int.Parse(cboStatus.SelectedValue.ToString());
                    ////2) Insert Query
                    //string insertQuery = "INSERT INTO mcq_Questions (Question, AnswerA, AnswerB, AnswerC, CorrectAnswer, SubjectId, DifficultLevelId, StatusId) ";
                    //insertQuery += string.Format("VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6}, {7})", 
                    //    txtQuestion.Text.Replace("'","'"),
                    //    txtAnswerA.Text.Replace("'", "'"),
                    //    txtAnswerB.Text.Replace("'", "'"),
                    //    txtAnswerC.Text.Replace("'", "'"),
                    //    cboCorrectAnswer.Text.Replace("'", "'"), 
                    //    subjectId, difficultLevelId, statusId);

                    Dictionary<string, Object> columnInformation = new Dictionary<string,object>();
                    columnInformation.Add("Question", txtQuestion.Text);
                    columnInformation.Add("AnswerA", txtAnswerA.Text);
                    columnInformation.Add("AnswerB", txtAnswerB.Text);
                    columnInformation.Add("AnswerC", txtAnswerC.Text);
                    columnInformation.Add("CorrectAnswer", cboCorrectAnswer.Text);
                    columnInformation.Add("DifficultLevelId", difficultLevelId);
                    columnInformation.Add("SubjectId", subjectId);
                    columnInformation.Add("StatusId", statusId);

                    if (questionId >0)
                    {
                        message = MssqlHelper.UpdateData("mcq_Questions", columnInformation, "QuestionId=" + questionId);
                    }
                    else
                    {
                        message = MssqlHelper.AddData("mcq_Questions", columnInformation);                        
                    }
                    
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
                    string selectSubjectSql = "SELECT SubjectId AS [ID], [Name] AS Display FROM mcq_Subjects";
                    MssqlHelper.BindCombox(cboSubject, selectSubjectSql);

                    string selectStatusSql = "SELECT StatusId AS [ID], Description AS Display FROM mcq_Status";
                    MssqlHelper.BindCombox(cboStatus, selectStatusSql);

                    string selectDifficultLevelSql = "SELECT DifficultLevelId AS [ID], [Description] AS Display FROM mcq_DifficultLevels;";
                    MssqlHelper.BindCombox(cboDifficultLevel, selectDifficultLevelSql);

                    txtQuestion.Text = "";
                    txtAnswerA.Text = "";
                    txtAnswerB.Text = "";
                    txtAnswerC.Text = "";
                    
                }
            }
        }

        private void frmAddQuestion_Load(object sender, EventArgs e)
        {
            string selectSubjectSql = "SELECT SubjectId AS [ID], [Name] AS Display FROM mcq_Subjects";
            MssqlHelper.BindCombox(cboSubject, selectSubjectSql);

            string selectStatusSql = "SELECT StatusId AS [ID], Description AS Display FROM mcq_Status";
            MssqlHelper.BindCombox(cboStatus, selectStatusSql);

            string selectDifficultLevelSql = "SELECT DifficultLevelId AS [ID], [Description] AS Display FROM mcq_DifficultLevels;";
            MssqlHelper.BindCombox(cboDifficultLevel, selectDifficultLevelSql);

            BindData(questionId);
        }
    }
}
