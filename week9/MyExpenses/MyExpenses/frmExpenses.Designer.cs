namespace MyExpenses
{
    partial class frmExpenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbExpense = new System.Windows.Forms.RadioButton();
            this.rdbIncome = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.ntxtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvIncomeExpense = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomeExpense)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpCreatedDate
            // 
            this.dtpCreatedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCreatedDate.Location = new System.Drawing.Point(96, 25);
            this.dtpCreatedDate.Name = "dtpCreatedDate";
            this.dtpCreatedDate.Size = new System.Drawing.Size(184, 20);
            this.dtpCreatedDate.TabIndex = 0;
            this.dtpCreatedDate.ValueChanged += new System.EventHandler(this.dtpCreatedDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date :";
            // 
            // rdbExpense
            // 
            this.rdbExpense.AutoSize = true;
            this.rdbExpense.Checked = true;
            this.rdbExpense.Location = new System.Drawing.Point(96, 61);
            this.rdbExpense.Name = "rdbExpense";
            this.rdbExpense.Size = new System.Drawing.Size(66, 17);
            this.rdbExpense.TabIndex = 1;
            this.rdbExpense.TabStop = true;
            this.rdbExpense.Text = "Expense";
            this.rdbExpense.UseVisualStyleBackColor = true;
            // 
            // rdbIncome
            // 
            this.rdbIncome.AutoSize = true;
            this.rdbIncome.Location = new System.Drawing.Point(175, 61);
            this.rdbIncome.Name = "rdbIncome";
            this.rdbIncome.Size = new System.Drawing.Size(60, 17);
            this.rdbIncome.TabIndex = 2;
            this.rdbIncome.Text = "Income";
            this.rdbIncome.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type :";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "ABC"});
            this.cboCategory.Location = new System.Drawing.Point(96, 94);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(179, 21);
            this.cboCategory.TabIndex = 3;
            // 
            // ntxtAmount
            // 
            this.ntxtAmount.Location = new System.Drawing.Point(96, 131);
            this.ntxtAmount.Name = "ntxtAmount";
            this.ntxtAmount.Size = new System.Drawing.Size(184, 20);
            this.ntxtAmount.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Amount :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Note : ";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(96, 167);
            this.txtNote.MaxLength = 100;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(184, 78);
            this.txtNote.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(96, 261);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(184, 24);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvIncomeExpense
            // 
            this.dgvIncomeExpense.AllowUserToAddRows = false;
            this.dgvIncomeExpense.AllowUserToDeleteRows = false;
            this.dgvIncomeExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncomeExpense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.No,
            this.Type,
            this.Category,
            this.Amount,
            this.Note});
            this.dgvIncomeExpense.Location = new System.Drawing.Point(298, 25);
            this.dgvIncomeExpense.MultiSelect = false;
            this.dgvIncomeExpense.Name = "dgvIncomeExpense";
            this.dgvIncomeExpense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncomeExpense.Size = new System.Drawing.Size(668, 264);
            this.dgvIncomeExpense.TabIndex = 12;
            this.dgvIncomeExpense.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvIncomeExpense_KeyDown);
            // 
            // ID
            // 
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // No
            // 
            this.No.Frozen = true;
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.Width = 50;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Amount
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle2;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 200;
            // 
            // frmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 295);
            this.Controls.Add(this.dgvIncomeExpense);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ntxtAmount);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbIncome);
            this.Controls.Add(this.rdbExpense);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpCreatedDate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income/Expenses";
            this.Load += new System.EventHandler(this.frmExpenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomeExpense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpCreatedDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbExpense;
        private System.Windows.Forms.RadioButton rdbIncome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.TextBox ntxtAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvIncomeExpense;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}