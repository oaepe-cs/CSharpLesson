using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MultipleChoicesQuestionsGenerator.Main
{
    public partial class frmAddQuestion : Form
    {
        string ConnectionString = "Server=.; Database=MultipleChoicesQuestionGenerator; User Id=sa; Password=123456789cs";
        string questionID = "";

        public frmAddQuestion()
        {
            InitializeComponent();
        }

        public frmAddQuestion(string questionId)
        {
            InitializeComponent();
            this.questionID = questionId;
        }

        private void BindCombox(ComboBox cbo, string sql)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    cbo.DataSource = dt;
                    cbo.DisplayMember = "Display";
                    cbo.ValueMember = "ID";

                    //var columnHeaders = dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName).ToArray();
                    //cbo.DisplayMember = columnHeaders[1];
                    //cbo.ValueMember = columnHeaders[0];
                }
            }
        }

        private void ReadData(string questionId)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string sql = "SELECT top(1) * FROM mcq_Questions WHERE QuestionId=" + questionId;
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        txtQuestion.Text = rd[1].ToString();
                        txtAnswerA.Text = rd["AnswerA"].ToString();
                        txtAnswerB.Text = rd["AnswerB"].ToString();
                        txtAnswerC.Text = rd["AnswerC"].ToString();
                        cboCorrectAnswer.Text = rd[5].ToString();
                        cboSubject.SelectedValue = rd[6].ToString();
                        cboDifficultLevel.SelectedValue = rd[7].ToString();
                        cboStatus.SelectedValue = rd[8].ToString();
                    }
                }
            }
        }

        private void frmAddQuestion_Load(object sender, EventArgs e)
        {
            string selectSubjectSql = "SELECT SubjectId AS [ID], [Name] AS Display FROM mcq_Subjects";
            BindCombox(cboSubject, selectSubjectSql);

            string selectStatusSql = "SELECT StatusId AS [ID], Description AS Display FROM mcq_Status";
            BindCombox(cboStatus, selectStatusSql);

            string selectDifficultLevelSql = "SELECT DifficultLevelId AS [ID], [Description] AS Display FROM mcq_DifficultLevels;";
            BindCombox(cboDifficultLevel, selectDifficultLevelSql);

            if (questionID != "")
            {
                ReadData(questionID);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (questionID == "")
            {
                InsertDatToDatabase();
            }
            else
            {
                UpdateDataToDatabase(questionID);
            }
        }

        private void UpdateDataToDatabase(string questionId)
        {
            //1) Connection
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                //Update Sql Query
                string updateSql = "UPDATE mcq_Questions SET " +
                                    "Question='" + txtQuestion.Text + "', " +
                                    "AnswerA='" + txtAnswerA.Text + "', " +
                                    "AnswerB='" + txtAnswerB.Text + "', " +
                                    "AnswerC='" + txtAnswerC.Text + "', " +
                                    "CorrectAnswer='" + cboCorrectAnswer.Text + "', " +
                                    "SubjectId=" + cboSubject.SelectedValue.ToString() + ", " +
                                    "DifficultLevelId=" + cboDifficultLevel.SelectedValue.ToString() + ", " +
                                    "StatusId=" + cboStatus.SelectedValue.ToString() + 
                                    " WHERE QuestionID=" + questionId;

                //3) Command(Insert Query, Connection)
                using (SqlCommand cmd = new SqlCommand(updateSql, conn))
                {
                    //4) Execute
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Successfully Updated.");
        }

        private void InsertDatToDatabase()
        {
            //1) Connection
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                int subjectId = int.Parse(cboSubject.SelectedValue.ToString());
                int difficultLevelId = int.Parse(cboDifficultLevel.SelectedValue.ToString());
                int statusId = int.Parse(cboStatus.SelectedValue.ToString());
                //2) Insert Query
                string insertQuery = "INSERT INTO mcq_Questions (Question, AnswerA, AnswerB, AnswerC, CorrectAnswer, SubjectId, DifficultLevelId, StatusId) ";
                insertQuery += string.Format("VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6}, {7})", txtQuestion.Text, txtAnswerA.Text, txtAnswerB.Text, txtAnswerC.Text, cboCorrectAnswer.Text, subjectId, difficultLevelId, statusId);

                //3) Command(Insert Query, Connection)
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    //4) Execute
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Successfully Added.");

            string selectSubjectSql = "SELECT SubjectId AS [ID], [Name] AS Display FROM mcq_Subjects";
            BindCombox(cboSubject, selectSubjectSql);

            string selectStatusSql = "SELECT StatusId AS [ID], Description AS Display FROM mcq_Status";
            BindCombox(cboStatus, selectStatusSql);

            string selectDifficultLevelSql = "SELECT DifficultLevelId AS [ID], [Description] AS Display FROM mcq_DifficultLevels;";
            BindCombox(cboDifficultLevel, selectDifficultLevelSql);

            txtQuestion.Text = "";
            txtAnswerA.Text = "";
            txtAnswerB.Text = "";
            txtAnswerC.Text = "";
        }
    }
}
