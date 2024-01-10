namespace MultipleChoiceQuestionGenreator2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.questionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportBySubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.questionsToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(927, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // questionsToolStripMenuItem
            // 
            this.questionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addQuestionsToolStripMenuItem,
            this.questionListToolStripMenuItem});
            this.questionsToolStripMenuItem.Image = global::MultipleChoiceQuestionGenreator2.Properties.Resources.question;
            this.questionsToolStripMenuItem.Name = "questionsToolStripMenuItem";
            this.questionsToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.questionsToolStripMenuItem.Text = "Questions";
            // 
            // addQuestionsToolStripMenuItem
            // 
            this.addQuestionsToolStripMenuItem.Image = global::MultipleChoiceQuestionGenreator2.Properties.Resources.add_new;
            this.addQuestionsToolStripMenuItem.Name = "addQuestionsToolStripMenuItem";
            this.addQuestionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addQuestionsToolStripMenuItem.Text = "Add Questions";
            // 
            // questionListToolStripMenuItem
            // 
            this.questionListToolStripMenuItem.Name = "questionListToolStripMenuItem";
            this.questionListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.questionListToolStripMenuItem.Text = "Question List";
            this.questionListToolStripMenuItem.Click += new System.EventHandler(this.questionListToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subjectToolStripMenuItem,
            this.difficultLevelToolStripMenuItem,
            this.statusToolStripMenuItem});
            this.setupToolStripMenuItem.Image = global::MultipleChoiceQuestionGenreator2.Properties.Resources.setup;
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // subjectToolStripMenuItem
            // 
            this.subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            this.subjectToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.subjectToolStripMenuItem.Text = "Subject";
            this.subjectToolStripMenuItem.Click += new System.EventHandler(this.subjectToolStripMenuItem_Click);
            // 
            // difficultLevelToolStripMenuItem
            // 
            this.difficultLevelToolStripMenuItem.Name = "difficultLevelToolStripMenuItem";
            this.difficultLevelToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.difficultLevelToolStripMenuItem.Text = "Difficult Level";
            this.difficultLevelToolStripMenuItem.Click += new System.EventHandler(this.difficultLevelToolStripMenuItem_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateQuestionToolStripMenuItem,
            this.reportBySubjectToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // generateQuestionToolStripMenuItem
            // 
            this.generateQuestionToolStripMenuItem.Name = "generateQuestionToolStripMenuItem";
            this.generateQuestionToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.generateQuestionToolStripMenuItem.Text = "Generate Question";
            this.generateQuestionToolStripMenuItem.Click += new System.EventHandler(this.generateQuestionToolStripMenuItem_Click);
            // 
            // reportBySubjectToolStripMenuItem
            // 
            this.reportBySubjectToolStripMenuItem.Name = "reportBySubjectToolStripMenuItem";
            this.reportBySubjectToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.reportBySubjectToolStripMenuItem.Text = "Report By Subject";
            this.reportBySubjectToolStripMenuItem.Click += new System.EventHandler(this.reportBySubjectToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupDBToolStripMenuItem});
            this.helpToolStripMenuItem.Image = global::MultipleChoiceQuestionGenreator2.Properties.Resources.question;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // backupDBToolStripMenuItem
            // 
            this.backupDBToolStripMenuItem.Image = global::MultipleChoiceQuestionGenreator2.Properties.Resources.Db_Backup;
            this.backupDBToolStripMenuItem.Name = "backupDBToolStripMenuItem";
            this.backupDBToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.backupDBToolStripMenuItem.Text = "Backup DB";
            this.backupDBToolStripMenuItem.Click += new System.EventHandler(this.backupDBToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 601);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Multiple Choices Question";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem questionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficultLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questionListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportBySubjectToolStripMenuItem;
    }
}

