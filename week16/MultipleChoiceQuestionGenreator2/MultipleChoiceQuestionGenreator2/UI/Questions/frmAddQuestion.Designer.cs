namespace MultipleChoiceQuestionGenreator2.Questions
{
    partial class frmAddQuestion
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboCorrectAnswer = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboDifficultLevel = new System.Windows.Forms.ComboBox();
            this.cboSubject = new System.Windows.Forms.ComboBox();
            this.txtAnswerC = new System.Windows.Forms.TextBox();
            this.txtAnswerB = new System.Windows.Forms.TextBox();
            this.txtAnswerA = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(107, 391);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 33);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboCorrectAnswer
            // 
            this.cboCorrectAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCorrectAnswer.FormattingEnabled = true;
            this.cboCorrectAnswer.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cboCorrectAnswer.Location = new System.Drawing.Point(107, 349);
            this.cboCorrectAnswer.Name = "cboCorrectAnswer";
            this.cboCorrectAnswer.Size = new System.Drawing.Size(271, 21);
            this.cboCorrectAnswer.TabIndex = 24;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(922, 16);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(271, 21);
            this.cboStatus.TabIndex = 19;
            // 
            // cboDifficultLevel
            // 
            this.cboDifficultLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDifficultLevel.FormattingEnabled = true;
            this.cboDifficultLevel.Location = new System.Drawing.Point(528, 16);
            this.cboDifficultLevel.Name = "cboDifficultLevel";
            this.cboDifficultLevel.Size = new System.Drawing.Size(271, 21);
            this.cboDifficultLevel.TabIndex = 17;
            // 
            // cboSubject
            // 
            this.cboSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubject.FormattingEnabled = true;
            this.cboSubject.Location = new System.Drawing.Point(107, 16);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Size = new System.Drawing.Size(271, 21);
            this.cboSubject.TabIndex = 9;
            // 
            // txtAnswerC
            // 
            this.txtAnswerC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAnswerC.Location = new System.Drawing.Point(106, 267);
            this.txtAnswerC.Multiline = true;
            this.txtAnswerC.Name = "txtAnswerC";
            this.txtAnswerC.Size = new System.Drawing.Size(1087, 54);
            this.txtAnswerC.TabIndex = 23;
            // 
            // txtAnswerB
            // 
            this.txtAnswerB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAnswerB.Location = new System.Drawing.Point(106, 198);
            this.txtAnswerB.Multiline = true;
            this.txtAnswerB.Name = "txtAnswerB";
            this.txtAnswerB.Size = new System.Drawing.Size(1087, 54);
            this.txtAnswerB.TabIndex = 22;
            // 
            // txtAnswerA
            // 
            this.txtAnswerA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAnswerA.Location = new System.Drawing.Point(106, 127);
            this.txtAnswerA.Multiline = true;
            this.txtAnswerA.Name = "txtAnswerA";
            this.txtAnswerA.Size = new System.Drawing.Size(1087, 54);
            this.txtAnswerA.TabIndex = 21;
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtQuestion.Location = new System.Drawing.Point(106, 57);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(1087, 54);
            this.txtQuestion.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(853, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Difficult Level:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Subject:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Correct Answer: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "C:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "B:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "A: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Question:";
            // 
            // frmAddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 446);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboCorrectAnswer);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.cboDifficultLevel);
            this.Controls.Add(this.cboSubject);
            this.Controls.Add(this.txtAnswerC);
            this.Controls.Add(this.txtAnswerB);
            this.Controls.Add(this.txtAnswerA);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Question";
            this.Load += new System.EventHandler(this.frmAddQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboCorrectAnswer;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboDifficultLevel;
        private System.Windows.Forms.ComboBox cboSubject;
        private System.Windows.Forms.TextBox txtAnswerC;
        private System.Windows.Forms.TextBox txtAnswerB;
        private System.Windows.Forms.TextBox txtAnswerA;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}