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
            this.SuspendLayout();
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(28, 16);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(87, 39);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "Add Category";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnIncomeExpense
            // 
            this.btnIncomeExpense.Location = new System.Drawing.Point(149, 16);
            this.btnIncomeExpense.Name = "btnIncomeExpense";
            this.btnIncomeExpense.Size = new System.Drawing.Size(123, 39);
            this.btnIncomeExpense.TabIndex = 1;
            this.btnIncomeExpense.Text = "Add Income/Expense";
            this.btnIncomeExpense.UseVisualStyleBackColor = true;
            this.btnIncomeExpense.Click += new System.EventHandler(this.btnIncomeExpense_Click);
            // 
            // btnType
            // 
            this.btnType.Location = new System.Drawing.Point(28, 80);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(87, 39);
            this.btnType.TabIndex = 2;
            this.btnType.Text = "Type";
            this.btnType.UseVisualStyleBackColor = true;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 261);
            this.Controls.Add(this.btnType);
            this.Controls.Add(this.btnIncomeExpense);
            this.Controls.Add(this.btnCategory);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnIncomeExpense;
        private System.Windows.Forms.Button btnType;
    }
}