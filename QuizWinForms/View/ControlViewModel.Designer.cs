namespace QuizBSWinForms.View
{
    partial class ControlViewModel
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
            this.btnPrievQuestion = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnFinishTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrievQuestion
            // 
            this.btnPrievQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrievQuestion.AutoSize = true;
            this.btnPrievQuestion.Location = new System.Drawing.Point(3, 60);
            this.btnPrievQuestion.MinimumSize = new System.Drawing.Size(50, 15);
            this.btnPrievQuestion.Name = "btnPrievQuestion";
            this.btnPrievQuestion.Size = new System.Drawing.Size(75, 25);
            this.btnPrievQuestion.TabIndex = 0;
            this.btnPrievQuestion.Text = "{{<}}";
            this.btnPrievQuestion.UseVisualStyleBackColor = true;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextQuestion.Location = new System.Drawing.Point(514, 62);
            this.btnNextQuestion.MinimumSize = new System.Drawing.Size(50, 15);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnNextQuestion.TabIndex = 1;
            this.btnNextQuestion.Text = "{{>}}";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            // 
            // btnFinishTest
            // 
            this.btnFinishTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinishTest.Location = new System.Drawing.Point(254, 62);
            this.btnFinishTest.MinimumSize = new System.Drawing.Size(50, 15);
            this.btnFinishTest.Name = "btnFinishTest";
            this.btnFinishTest.Size = new System.Drawing.Size(75, 23);
            this.btnFinishTest.TabIndex = 2;
            this.btnFinishTest.Text = "{{Finish}}";
            this.btnFinishTest.UseVisualStyleBackColor = true;
            // 
            // ControlViewModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFinishTest);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.btnPrievQuestion);
            this.Name = "ControlViewModel";
            this.Size = new System.Drawing.Size(592, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPrievQuestion;
        private Button btnNextQuestion;
        private Button btnFinishTest;
    }
}
