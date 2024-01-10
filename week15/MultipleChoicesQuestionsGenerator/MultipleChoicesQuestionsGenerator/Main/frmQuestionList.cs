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
    public partial class frmQuestionList : Form
    {
        string ConnectionString = "Server=.; Database=MultipleChoicesQuestionGenerator; User Id=sa; Password=123456789cs";
        public frmQuestionList()
        {
            InitializeComponent();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddQuestion();
            frm.ShowDialog();
            ReadData();
        }

        private void CreatedGrid()
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.ColumnCount = 10;
            // 
            // ID
            // 
            var ID = dgv.Columns[0];
            ID.Frozen = true;
            ID.HeaderText = "QuestionId";
            ID.Name = "QuestionId";
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
            // Question
            // 
            var Category = dgv.Columns[2];
            Category.HeaderText = "Question";
            Category.Name = "Question";
            Category.ReadOnly = true;
            Category.Width = 250;
            // 
            // AnswerA
            // 
            var AnswerA = dgv.Columns[3];
            AnswerA.HeaderText = "AnswerA";
            AnswerA.Name = "AnswerA";
            AnswerA.Width = 250;
            AnswerA.ReadOnly = true;
            // 
            // AnswerB
            // 
            var AnswerB = dgv.Columns[4];
            AnswerB.HeaderText = "AnswerB";
            AnswerB.Name = "AnswerB";
            AnswerB.ReadOnly = true;
            AnswerB.Width = 250;

            var AnswerC = dgv.Columns[5];
            AnswerC.HeaderText = "AnswerC";
            AnswerC.Name = "AnswerC";
            AnswerC.ReadOnly = true;
            AnswerC.Width = 250;

            var CorrectAnswer = dgv.Columns[6];
            CorrectAnswer.HeaderText = "Correct Answer";
            CorrectAnswer.Name = "CorrectAnswer";
            CorrectAnswer.ReadOnly = true;
            CorrectAnswer.Width = 200;

            var Subject = dgv.Columns[7];
            Subject.HeaderText = "Subject";
            Subject.Name = "Subject";
            Subject.ReadOnly = true;

            var DifficultLevel = dgv.Columns[8];
            DifficultLevel.HeaderText = "DifficultLevel";
            DifficultLevel.Name = "DifficultLevel";
            DifficultLevel.ReadOnly = true;

            var Status = dgv.Columns[9];
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;

            DataGridViewButtonColumn btnDetails = new DataGridViewButtonColumn();
            btnDetails.Text = "Details";
            btnDetails.Name = "btnDetails";
            btnDetails.HeaderText = "";
            btnDetails.UseColumnTextForButtonValue = true;
            dgv.Columns.Add(btnDetails);

            dgv.CellContentClick += new DataGridViewCellEventHandler(dgvDetails_Click);
        }

        private void dgvDetails_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex== dgv.Columns["btnDetails"].Index && dgv.SelectedRows.Count == 1)
            {
                string questionID = dgv.SelectedRows[0].Cells[0].Value.ToString();
                Form frm = new frmAddQuestion(questionID);
                frm.ShowDialog();
                ReadData();
            }
        }

        private void frmQuestionList_Load(object sender, EventArgs e)
        {
            CreatedGrid();
            ReadData();
        }

        private void ReadData()
        {
            dgv.Rows.Clear();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                //string selectQuery = "SELECT que.QuestionId, que.Question, que.AnswerA, que.AnswerB, que.AnswerC, CorrectAnswer, " +
                //                    "sub.Name, dfl.Description AS [ ], stu.Description AS [Status Description] " +
                //                    "FROM mcq_Questions AS que " +
                //                    "INNER JOIN mcq_Subjects AS sub ON que.SubjectId = sub.SubjectId " +
                //                    "INNER JOIN mcq_DifficultLevels AS dfl ON que.DifficultLevelId = dfl.DifficultLevelId " +
                //                    "INNER JOIN mcq_Status AS stu ON que.StatusId = stu.StatusId " +
                //                    "WHERE stu.Description <> 'Delete' " +
                //                    "ORDER BY QuestionId DESC";

                string selectQuery = "SELECT * FROM [dbo].[vw_QuestionLists] ORDER BY QuestionId DESC";

                using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    int i = 1;
                    while (rd.Read())
                    {
                        string[] row = { rd[0].ToString(), i.ToString(), rd["Question"].ToString(), rd["AnswerA"].ToString(), rd["AnswerB"].ToString(), rd["AnswerC"].ToString(), rd["CorrectAnswer"].ToString(), rd[6].ToString(), rd[7].ToString(), rd[8].ToString() };
                        dgv.Rows.Add(row);
                        i = i + 1;
                    }
                }
            }
        }
    }
}
