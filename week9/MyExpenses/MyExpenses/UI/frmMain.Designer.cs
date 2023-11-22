namespace MyExpenses
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
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnIncomeExpense = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.pnlButtonGroup = new System.Windows.Forms.Panel();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.lstSummary = new System.Windows.Forms.ListBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.pnlButtonGroup.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(10, 11);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(127, 28);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "Add Category";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnIncomeExpense
            // 
            this.btnIncomeExpense.Location = new System.Drawing.Point(140, 11);
            this.btnIncomeExpense.Name = "btnIncomeExpense";
            this.btnIncomeExpense.Size = new System.Drawing.Size(127, 28);
            this.btnIncomeExpense.TabIndex = 1;
            this.btnIncomeExpense.Text = "Add Income/Expense";
            this.btnIncomeExpense.UseVisualStyleBackColor = true;
            this.btnIncomeExpense.Click += new System.EventHandler(this.btnIncomeExpense_Click);
            // 
            // btnType
            // 
            this.btnType.Location = new System.Drawing.Point(274, 11);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(127, 28);
            this.btnType.TabIndex = 2;
            this.btnType.Text = "Report By Dates";
            this.btnType.UseVisualStyleBackColor = true;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // pnlButtonGroup
            // 
            this.pnlButtonGroup.Controls.Add(this.btnType);
            this.pnlButtonGroup.Controls.Add(this.btnCategory);
            this.pnlButtonGroup.Controls.Add(this.btnIncomeExpense);
            this.pnlButtonGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtonGroup.Location = new System.Drawing.Point(0, 0);
            this.pnlButtonGroup.Name = "pnlButtonGroup";
            this.pnlButtonGroup.Size = new System.Drawing.Size(835, 50);
            this.pnlButtonGroup.TabIndex = 4;
            // 
            // pnlSummary
            // 
            this.pnlSummary.Controls.Add(this.lstSummary);
            this.pnlSummary.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSummary.Location = new System.Drawing.Point(0, 50);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(202, 604);
            this.pnlSummary.TabIndex = 5;
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.dgv);
            this.gbDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDetails.Location = new System.Drawing.Point(202, 50);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(633, 604);
            this.gbDetails.TabIndex = 6;
            this.gbDetails.TabStop = false;
            // 
            // lstSummary
            // 
            this.lstSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSummary.FormattingEnabled = true;
            this.lstSummary.Location = new System.Drawing.Point(0, 0);
            this.lstSummary.Name = "lstSummary";
            this.lstSummary.Size = new System.Drawing.Size(202, 604);
            this.lstSummary.TabIndex = 0;
            this.lstSummary.SelectedIndexChanged += new System.EventHandler(this.lstSummary_SelectedIndexChanged);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 16);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(627, 585);
            this.dgv.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 654);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlButtonGroup);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlButtonGroup.ResumeLayout(false);
            this.pnlSummary.ResumeLayout(false);
            this.gbDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnIncomeExpense;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.Panel pnlButtonGroup;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.ListBox lstSummary;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.DataGridView dgv;
    }
}