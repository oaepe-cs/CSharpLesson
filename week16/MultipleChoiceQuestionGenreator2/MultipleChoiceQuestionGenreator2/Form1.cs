using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MultipleChoiceQuestionGenreator2.Setup;
using MultipleChoiceQuestionGenreator2.Questions;
using MultipleChoiceQuestionGenreator2.UI.Report;

namespace MultipleChoiceQuestionGenreator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmSubject();
            frm.ShowDialog();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmStatus();
            frm.ShowDialog();
        }

        private void difficultLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmDifficultLevel();
            frm.ShowDialog();
        }

        private void questionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmQuestionList();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void generateQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new MultipleChoiceQuestionGenreator2.UI.Report.Form1();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void reportBySubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmReportBySubject();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void backupDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string currentDirctory = Environment.CurrentDirectory;
                string fileName = "MultipleChoicesQuestionGenerator.bak";
                string filePath = currentDirctory + "\\" + fileName;
                MssqlHelper.BackupDatabase("MultipleChoicesQuestionGenerator", filePath);

                MessageBox.Show("Successfully run.", "Backup Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Backup Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


    }
}
