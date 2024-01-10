namespace MultipleChoiceQuestionGenreator2.Questions
{
    partial class frmQuestionList
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
            this.btnAddNewQuestion = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddNewQuestion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 39);
            this.panel1.TabIndex = 0;
            // 
            // btnAddNewQuestion
            // 
            this.btnAddNewQuestion.Location = new System.Drawing.Point(12, 5);
            this.btnAddNewQuestion.Name = "btnAddNewQuestion";
            this.btnAddNewQuestion.Size = new System.Drawing.Size(125, 28);
            this.btnAddNewQuestion.TabIndex = 0;
            this.btnAddNewQuestion.Text = "Add New Question";
            this.btnAddNewQuestion.UseVisualStyleBackColor = true;
            this.btnAddNewQuestion.Click += new System.EventHandler(this.btnAddNewQuestion_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 39);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(826, 536);
            this.dgv.TabIndex = 1;
            // 
            // frmQuestionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 575);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel1);
            this.Name = "frmQuestionList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmQuestionList";
            this.Load += new System.EventHandler(this.frmQuestionList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnAddNewQuestion;
    }
}