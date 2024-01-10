namespace MultipleChoicesQuestionsGenerator
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnDifficultLevel = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diifficultLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStatus);
            this.panel1.Controls.Add(this.btnDifficultLevel);
            this.panel1.Controls.Add(this.btnSubject);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 48);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(205, 10);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(75, 23);
            this.btnStatus.TabIndex = 0;
            this.btnStatus.Text = "Add Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnDifficultLevel
            // 
            this.btnDifficultLevel.Location = new System.Drawing.Point(92, 10);
            this.btnDifficultLevel.Name = "btnDifficultLevel";
            this.btnDifficultLevel.Size = new System.Drawing.Size(107, 23);
            this.btnDifficultLevel.TabIndex = 0;
            this.btnDifficultLevel.Text = "Add Difficlut Level";
            this.btnDifficultLevel.UseVisualStyleBackColor = true;
            this.btnDifficultLevel.Click += new System.EventHandler(this.btnDifficultLevel_Click);
            // 
            // btnSubject
            // 
            this.btnSubject.Location = new System.Drawing.Point(11, 10);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(75, 23);
            this.btnSubject.TabIndex = 0;
            this.btnSubject.Text = "Add Subject";
            this.btnSubject.UseVisualStyleBackColor = true;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1089, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addQuestionToolStripMenuItem});
            this.mainToolStripMenuItem.Image = global::MultipleChoicesQuestionsGenerator.Properties.Resources.menu;
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // addQuestionToolStripMenuItem
            // 
            this.addQuestionToolStripMenuItem.Image = global::MultipleChoicesQuestionsGenerator.Properties.Resources.question;
            this.addQuestionToolStripMenuItem.Name = "addQuestionToolStripMenuItem";
            this.addQuestionToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.addQuestionToolStripMenuItem.Text = "Question";
            this.addQuestionToolStripMenuItem.Click += new System.EventHandler(this.addQuestionToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subjectToolStripMenuItem,
            this.diifficultLevelToolStripMenuItem,
            this.statusToolStripMenuItem});
            this.setupToolStripMenuItem.Image = global::MultipleChoicesQuestionsGenerator.Properties.Resources.setup;
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // subjectToolStripMenuItem
            // 
            this.subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            this.subjectToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.subjectToolStripMenuItem.Text = "Subject";
            this.subjectToolStripMenuItem.Click += new System.EventHandler(this.subjectToolStripMenuItem_Click);
            // 
            // diifficultLevelToolStripMenuItem
            // 
            this.diifficultLevelToolStripMenuItem.Name = "diifficultLevelToolStripMenuItem";
            this.diifficultLevelToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.diifficultLevelToolStripMenuItem.Text = "Diifficult Level";
            this.diifficultLevelToolStripMenuItem.Click += new System.EventHandler(this.diifficultLevelToolStripMenuItem_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseBackupToolStripMenuItem});
            this.helpToolStripMenuItem.Image = global::MultipleChoicesQuestionsGenerator.Properties.Resources.question;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // databaseBackupToolStripMenuItem
            // 
            this.databaseBackupToolStripMenuItem.Image = global::MultipleChoicesQuestionsGenerator.Properties.Resources.Db_Backup;
            this.databaseBackupToolStripMenuItem.Name = "databaseBackupToolStripMenuItem";
            this.databaseBackupToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.databaseBackupToolStripMenuItem.Text = "Database Backup";
            this.databaseBackupToolStripMenuItem.Click += new System.EventHandler(this.databaseBackupToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 618);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Multiple Choice Question Generators";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnDifficultLevel;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diifficultLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addQuestionToolStripMenuItem;
    }
}

