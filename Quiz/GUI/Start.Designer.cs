namespace Quiz
{
    partial class Start
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
			this.addQuestion = new System.Windows.Forms.Button();
			this.takeQuiz = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// addQuestion
			// 
			this.addQuestion.Location = new System.Drawing.Point(100, 25);
			this.addQuestion.Name = "addQuestion";
			this.addQuestion.Size = new System.Drawing.Size(75, 23);
			this.addQuestion.TabIndex = 0;
			this.addQuestion.Text = "Add Question";
			this.addQuestion.UseVisualStyleBackColor = true;
			this.addQuestion.Click += new System.EventHandler(this.addQuestion_Click);
			// 
			// takeQuiz
			// 
			this.takeQuiz.Location = new System.Drawing.Point(100, 75);
			this.takeQuiz.Name = "takeQuiz";
			this.takeQuiz.Size = new System.Drawing.Size(75, 23);
			this.takeQuiz.TabIndex = 1;
			this.takeQuiz.Text = "Take Quiz";
			this.takeQuiz.UseVisualStyleBackColor = true;
			this.takeQuiz.Click += new System.EventHandler(this.takeQuiz_Click);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(100, 125);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 2;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// Start
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 150);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.takeQuiz);
			this.Controls.Add(this.addQuestion);
			this.Name = "Start";
			this.Text = "Start";
			this.Load += new System.EventHandler(this.Start_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addQuestion;
        private System.Windows.Forms.Button takeQuiz;
		private System.Windows.Forms.Button exitButton;
	}
}