namespace QuizBSWinForms.View
{
    partial class AnswerViewModel
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
            this.cBoxA = new System.Windows.Forms.CheckBox();
            this.cBoxB = new System.Windows.Forms.CheckBox();
            this.cBoxC = new System.Windows.Forms.CheckBox();
            this.cBoxD = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cBoxA
            // 
            this.cBoxA.AutoSize = true;
            this.cBoxA.Location = new System.Drawing.Point(9, 0);
            this.cBoxA.Name = "cBoxA";
            this.cBoxA.Size = new System.Drawing.Size(50, 19);
            this.cBoxA.TabIndex = 0;
            this.cBoxA.Text = "{{A}}";
            this.cBoxA.UseVisualStyleBackColor = true;
            this.cBoxA.Click += new System.EventHandler(this.cBoxA_Click);
            // 
            // cBoxB
            // 
            this.cBoxB.AutoSize = true;
            this.cBoxB.Location = new System.Drawing.Point(9, 25);
            this.cBoxB.Name = "cBoxB";
            this.cBoxB.Size = new System.Drawing.Size(49, 19);
            this.cBoxB.TabIndex = 1;
            this.cBoxB.Text = "{{B}}";
            this.cBoxB.UseVisualStyleBackColor = true;
            // 
            // cBoxC
            // 
            this.cBoxC.AutoSize = true;
            this.cBoxC.Location = new System.Drawing.Point(9, 50);
            this.cBoxC.Name = "cBoxC";
            this.cBoxC.Size = new System.Drawing.Size(50, 19);
            this.cBoxC.TabIndex = 2;
            this.cBoxC.Text = "{{C}}";
            this.cBoxC.UseVisualStyleBackColor = true;
            // 
            // cBoxD
            // 
            this.cBoxD.AutoSize = true;
            this.cBoxD.Location = new System.Drawing.Point(9, 75);
            this.cBoxD.Name = "cBoxD";
            this.cBoxD.Size = new System.Drawing.Size(50, 19);
            this.cBoxD.TabIndex = 3;
            this.cBoxD.Text = "{{D}}";
            this.cBoxD.UseVisualStyleBackColor = true;
            // 
            // AnswerViewModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cBoxD);
            this.Controls.Add(this.cBoxC);
            this.Controls.Add(this.cBoxB);
            this.Controls.Add(this.cBoxA);
            this.Name = "AnswerViewModel";
            this.Size = new System.Drawing.Size(525, 98);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox cBoxA;
        private CheckBox cBoxB;
        private CheckBox cBoxC;
        private CheckBox cBoxD;
    }
}
