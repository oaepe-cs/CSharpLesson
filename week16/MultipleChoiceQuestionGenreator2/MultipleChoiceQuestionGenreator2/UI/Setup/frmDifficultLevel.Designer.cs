namespace MultipleChoiceQuestionGenreator2.Setup
{
    partial class frmDifficultLevel
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDifficultLevel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(15, 142);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(386, 342);
            this.dgv.TabIndex = 5;
            this.dgv.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgv_KeyUp);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(95, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 22);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(95, 71);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(306, 20);
            this.txtRemark.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDescription.Location = new System.Drawing.Point(95, 11);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(306, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Remark:";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(12, 15);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(63, 13);
            this.Description.TabIndex = 12;
            this.Description.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Difficult Level:";
            // 
            // txtDifficultLevel
            // 
            this.txtDifficultLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDifficultLevel.Location = new System.Drawing.Point(95, 41);
            this.txtDifficultLevel.MaxLength = 5;
            this.txtDifficultLevel.Name = "txtDifficultLevel";
            this.txtDifficultLevel.Size = new System.Drawing.Size(306, 20);
            this.txtDifficultLevel.TabIndex = 2;
            this.txtDifficultLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDifficultLevel_KeyPress);
            // 
            // frmDifficultLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 491);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtDifficultLevel);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Description);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDifficultLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Difficult Level";
            this.Load += new System.EventHandler(this.frmDifficultLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDifficultLevel;
    }
}