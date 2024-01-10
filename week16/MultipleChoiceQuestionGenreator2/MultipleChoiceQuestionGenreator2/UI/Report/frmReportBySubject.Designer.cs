namespace MultipleChoiceQuestionGenreator2.UI.Report
{
    partial class frmReportBySubject
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
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboSubject = new System.Windows.Forms.ComboBox();
            this.btnSerach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sfdExportCSV = new System.Windows.Forms.SaveFileDialog();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Location = new System.Drawing.Point(439, 9);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(99, 28);
            this.btnExportCSV.TabIndex = 2;
            this.btnExportCSV.Text = "Export (CSV)";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 54);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(852, 394);
            this.dgv.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.cboSubject);
            this.panel1.Controls.Add(this.btnExportCSV);
            this.panel1.Controls.Add(this.btnSerach);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 54);
            this.panel1.TabIndex = 6;
            // 
            // cboSubject
            // 
            this.cboSubject.FormattingEnabled = true;
            this.cboSubject.Location = new System.Drawing.Point(79, 11);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Size = new System.Drawing.Size(275, 21);
            this.cboSubject.TabIndex = 0;
            // 
            // btnSerach
            // 
            this.btnSerach.Location = new System.Drawing.Point(360, 9);
            this.btnSerach.Name = "btnSerach";
            this.btnSerach.Size = new System.Drawing.Size(73, 28);
            this.btnSerach.TabIndex = 1;
            this.btnSerach.Text = "Search";
            this.btnSerach.UseVisualStyleBackColor = true;
            this.btnSerach.Click += new System.EventHandler(this.btnSerach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Question: ";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(549, 8);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(99, 28);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmReportBySubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 448);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel1);
            this.Name = "frmReportBySubject";
            this.Text = "Report By Subject";
            this.Load += new System.EventHandler(this.frmReportBySubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSerach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog sfdExportCSV;
        private System.Windows.Forms.ComboBox cboSubject;
        private System.Windows.Forms.Button btnPrint;
    }
}