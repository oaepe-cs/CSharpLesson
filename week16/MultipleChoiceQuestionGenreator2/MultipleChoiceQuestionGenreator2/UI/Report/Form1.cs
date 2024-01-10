using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MultipleChoiceQuestionGenreator2.UI.Report
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            dgv.ReadOnly = true;
            // 
            // ID
            // 
            var ID = dgv.Columns[0];
            ID.Frozen = true;
            ID.HeaderText = "QuestionId";
            ID.Name = "QuestionId";
            //ID.ReadOnly = true;
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
            //Category.ReadOnly = true;
            Category.Width = 250;
            // 
            // AnswerA
            // 
            var AnswerA = dgv.Columns[3];
            AnswerA.HeaderText = "AnswerA";
            AnswerA.Name = "AnswerA";
            AnswerA.Width = 250;
            //AnswerA.ReadOnly = true;
            // 
            // AnswerB
            // 
            var AnswerB = dgv.Columns[4];
            AnswerB.HeaderText = "AnswerB";
            AnswerB.Name = "AnswerB";
            //AnswerB.ReadOnly = true;
            AnswerB.Width = 250;

            var AnswerC = dgv.Columns[5];
            AnswerC.HeaderText = "AnswerC";
            AnswerC.Name = "AnswerC";
            //AnswerC.ReadOnly = true;
            AnswerC.Width = 250;

            var CorrectAnswer = dgv.Columns[6];
            CorrectAnswer.HeaderText = "Correct Answer";
            CorrectAnswer.Name = "CorrectAnswer";
            //CorrectAnswer.ReadOnly = true;
            CorrectAnswer.Width = 200;

            var Subject = dgv.Columns[7];
            Subject.HeaderText = "Subject";
            Subject.Name = "Subject";
            //Subject.ReadOnly = true;

            var DifficultLevel = dgv.Columns[8];
            DifficultLevel.HeaderText = "DifficultLevel";
            DifficultLevel.Name = "DifficultLevel";
            //DifficultLevel.ReadOnly = true;

            var Status = dgv.Columns[9];
            Status.HeaderText = "Status";
            Status.Name = "Status";
            //Status.ReadOnly = true;
           
        }

        //private void ReadData(string keyword, int rowindex = 0)
        //{
        //    dgv.Rows.Clear();
        //    int i = 1;
        //    string sql = "SELECT * FROM vw_QuestionLists ORDER BY QuestionId DESC";
        //    if (keyword != "")
        //    {
        //        sql = "SELECT * FROM vw_QuestionLists WHERE Question LIKE '%"+ keyword + "%' ORDER BY QuestionId DESC";
        //    }
            
        //    var getData = MssqlHelper.GetData(sql);
        //    foreach (DataRow rd in getData.Rows)
        //    {
        //        string[] row = { rd["QuestionId"].ToString(), i.ToString(), rd["Question"].ToString(), rd["AnswerA"].ToString(), rd["AnswerB"].ToString(), rd["AnswerC"].ToString(), rd["CorrectAnswer"].ToString(), rd["Name"].ToString(), rd["Difficult level Discription"].ToString(), rd["Status Description"].ToString() };

        //        dgv.Rows.Add(row);
        //        i++;
        //    }
        //    dgv.Rows[rowindex].Selected = true;
        //}

        private void ReadData(string keyword, int rowindex = 0)
        {
            dgv.Rows.Clear();
            int i = 1;
            string sql = "SELECT * FROM vw_QuestionLists ORDER BY QuestionId DESC";
            if (keyword != "")
            {
                sql = "SELECT * FROM vw_QuestionLists WHERE (Question LIKE @Question) OR (AnswerA LIKE @AnswerA) ORDER BY QuestionId DESC";
            }

            Dictionary<string, object> whereInfo = new Dictionary<string, object>();
            string value = "%" + txtQuestion.Text + "%";
            whereInfo.Add("Question", value);
            whereInfo.Add("AnswerA", value);
            var getData = MssqlHelper.GetData(sql, whereInfo);
            foreach (DataRow rd in getData.Rows)
            {
                string[] row = { rd["QuestionId"].ToString(), i.ToString(), rd["Question"].ToString(), rd["AnswerA"].ToString(), rd["AnswerB"].ToString(), rd["AnswerC"].ToString(), rd["CorrectAnswer"].ToString(), rd["Name"].ToString(), rd["Difficult level Discription"].ToString(), rd["Status Description"].ToString() };

                dgv.Rows.Add(row);
                i++;
            }
            dgv.Rows[rowindex].Selected = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreatedGrid();
        }

        private void btnSerach_Click(object sender, EventArgs e)
        {
            ReadData(txtQuestion.Text);
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
                MessageBox.Show(ex.ToString(), "Export CSV", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
