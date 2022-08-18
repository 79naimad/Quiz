namespace QuizBSWinForms.View
{
    partial class QuestionViewModel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblQuestionId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(47, 62);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(71, 15);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "{{Question}}";
            // 
            // lblQuestionId
            // 
            this.lblQuestionId.AutoSize = true;
            this.lblQuestionId.Location = new System.Drawing.Point(3, 62);
            this.lblQuestionId.Name = "lblQuestionId";
            this.lblQuestionId.Size = new System.Drawing.Size(33, 15);
            this.lblQuestionId.TabIndex = 1;
            this.lblQuestionId.Text = "{{Id}}";
            // 
            // QuestionViewModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblQuestionId);
            this.Controls.Add(this.lblQuestion);
            this.Name = "QuestionViewModel";
            this.Size = new System.Drawing.Size(390, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblQuestion;
        private Label lblQuestionId;
    }
}
