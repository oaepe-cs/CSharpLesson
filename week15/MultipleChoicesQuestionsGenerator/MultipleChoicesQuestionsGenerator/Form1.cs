using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MultipleChoicesQuestionsGenerator.Setup;
using MultipleChoicesQuestionsGenerator.Main;
using System.Data.SqlClient;

namespace MultipleChoicesQuestionsGenerator
{
    public partial class frmMain : Form
    {
        string ConnectionString = "Server=.; Database=MultipleChoicesQuestionGenerator; User Id=sa; Password=123456789cs";
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            Form _frmSubject = new frmSubject();
            _frmSubject.ShowDialog();
        }

        private void btnDifficultLevel_Click(object sender, EventArgs e)
        {
            Form _frmDifficlutLevel = new frmDifficultLevel();
            _frmDifficlutLevel.ShowDialog();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            Form _frmSataus = new frmStatus();
            _frmSataus.ShowDialog();
        }

        #region Menu
        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form _frmSubject = new frmSubject();
            _frmSubject.ShowDialog();
        }

        private void diifficultLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form _frmDifficlutLevel = new frmDifficultLevel();
            _frmDifficlutLevel.ShowDialog();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form _frmSataus = new frmStatus();
            _frmSataus.ShowDialog();
        }

        private void addQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form _frm = new frmQuestionList();
            _frm.ShowDialog();
        }
        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void databaseBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\DBBackup\MultipleChoicesQuestionGenerator.bak";
            string sql = "BACKUP DATABASE MultipleChoicesQuestionGenerator TO DISK = '" + filePath + "'";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }

        }
    }
}
