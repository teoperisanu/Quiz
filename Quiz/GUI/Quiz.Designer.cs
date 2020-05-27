namespace Quiz
{
    partial class Quiz
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
			this.components = new System.ComponentModel.Container();
			this.labelA = new System.Windows.Forms.Label();
			this.labelB = new System.Windows.Forms.Label();
			this.labelC = new System.Windows.Forms.Label();
			this.buttonNext = new System.Windows.Forms.Button();
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			this.checkBoxA = new System.Windows.Forms.CheckBox();
			this.checkBoxB = new System.Windows.Forms.CheckBox();
			this.checkBoxC = new System.Windows.Forms.CheckBox();
			this.labelQuestion = new System.Windows.Forms.Label();
			this.numberOfQuestionLeft = new System.Windows.Forms.Label();
			this.questionLeft = new System.Windows.Forms.Label();
			this.numberOfCorrectQuestions = new System.Windows.Forms.Label();
			this.correctQuestions = new System.Windows.Forms.Label();
			this.numberOfWrongQuestions = new System.Windows.Forms.Label();
			this.wrongQuestions = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.time = new System.Windows.Forms.Label();
			this.timer = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.SuspendLayout();
			// 
			// labelA
			// 
			this.labelA.AutoSize = true;
			this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.labelA.Location = new System.Drawing.Point(100, 225);
			this.labelA.Name = "labelA";
			this.labelA.Size = new System.Drawing.Size(26, 25);
			this.labelA.TabIndex = 0;
			this.labelA.Text = "A";
			// 
			// labelB
			// 
			this.labelB.AutoSize = true;
			this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.labelB.Location = new System.Drawing.Point(100, 275);
			this.labelB.Name = "labelB";
			this.labelB.Size = new System.Drawing.Size(25, 25);
			this.labelB.TabIndex = 1;
			this.labelB.Text = "B";
			// 
			// labelC
			// 
			this.labelC.AutoSize = true;
			this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.labelC.Location = new System.Drawing.Point(100, 325);
			this.labelC.Name = "labelC";
			this.labelC.Size = new System.Drawing.Size(27, 25);
			this.labelC.TabIndex = 2;
			this.labelC.Text = "C";
			// 
			// buttonNext
			// 
			this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.buttonNext.Location = new System.Drawing.Point(375, 425);
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.Size = new System.Drawing.Size(100, 50);
			this.buttonNext.TabIndex = 8;
			this.buttonNext.Text = "Next";
			this.buttonNext.UseVisualStyleBackColor = true;
			this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			// 
			// checkBoxA
			// 
			this.checkBoxA.MaximumSize = new System.Drawing.Size(600, 125);
			this.checkBoxA.AutoSize = true;
			this.checkBoxA.Location = new System.Drawing.Point(150, 230);
			this.checkBoxA.Name = "checkBoxA";
			this.checkBoxA.Size = new System.Drawing.Size(15, 14);
			this.checkBoxA.TabIndex = 9;
			this.checkBoxA.UseVisualStyleBackColor = true;
			// 
			// checkBoxB
			// 
			this.checkBoxB.MaximumSize = new System.Drawing.Size(600, 125);
			this.checkBoxB.AutoSize = true;
			this.checkBoxB.Location = new System.Drawing.Point(150, 280);
			this.checkBoxB.Name = "checkBoxB";
			this.checkBoxB.Size = new System.Drawing.Size(15, 14);
			this.checkBoxB.TabIndex = 10;
			this.checkBoxB.UseVisualStyleBackColor = true;
			// 
			// checkBoxC
			// 
			this.checkBoxC.MaximumSize = new System.Drawing.Size(600, 125);
			this.checkBoxC.AutoSize = true;
			this.checkBoxC.Location = new System.Drawing.Point(150, 330);
			this.checkBoxC.Name = "checkBoxC";
			this.checkBoxC.Size = new System.Drawing.Size(15, 14);
			this.checkBoxC.TabIndex = 11;
			this.checkBoxC.UseVisualStyleBackColor = true;
			// 
			// labelQuestion
			// 
			this.labelQuestion.MaximumSize = new System.Drawing.Size(600, 100);
			this.labelQuestion.AutoSize = true;
			this.labelQuestion.Location = new System.Drawing.Point(100, 125);
			this.labelQuestion.Name = "labelQuestion";
			this.labelQuestion.Size = new System.Drawing.Size(49, 13);
			this.labelQuestion.TabIndex = 13;
			this.labelQuestion.Text = "Question";
			// 
			// numberOfQuestionLeft
			// 
			this.numberOfQuestionLeft.AutoSize = true;
			this.numberOfQuestionLeft.ForeColor = System.Drawing.Color.Blue;
			this.numberOfQuestionLeft.Location = new System.Drawing.Point(100, 50);
			this.numberOfQuestionLeft.Name = "numberOfQuestionLeft";
			this.numberOfQuestionLeft.Size = new System.Drawing.Size(19, 13);
			this.numberOfQuestionLeft.TabIndex = 14;
			this.numberOfQuestionLeft.Text = "26";
			// 
			// questionLeft
			// 
			this.questionLeft.AutoSize = true;
			this.questionLeft.Location = new System.Drawing.Point(120, 50);
			this.questionLeft.Name = "questionLeft";
			this.questionLeft.Size = new System.Drawing.Size(75, 13);
			this.questionLeft.TabIndex = 15;
			this.questionLeft.Text = "Questions Left";
			// 
			// numberOfCorrectQuestions
			// 
			this.numberOfCorrectQuestions.AutoSize = true;
			this.numberOfCorrectQuestions.ForeColor = System.Drawing.Color.Green;
			this.numberOfCorrectQuestions.Location = new System.Drawing.Point(250, 50);
			this.numberOfCorrectQuestions.Name = "numberOfCorrectQuestions";
			this.numberOfCorrectQuestions.Size = new System.Drawing.Size(13, 13);
			this.numberOfCorrectQuestions.TabIndex = 16;
			this.numberOfCorrectQuestions.Text = "0";
			// 
			// correctQuestions
			// 
			this.correctQuestions.AutoSize = true;
			this.correctQuestions.Location = new System.Drawing.Point(265, 50);
			this.correctQuestions.Name = "correctQuestions";
			this.correctQuestions.Size = new System.Drawing.Size(91, 13);
			this.correctQuestions.TabIndex = 17;
			this.correctQuestions.Text = "Correct Questions";
			// 
			// numberOfWrongQuestions
			// 
			this.numberOfWrongQuestions.AutoSize = true;
			this.numberOfWrongQuestions.ForeColor = System.Drawing.Color.Red;
			this.numberOfWrongQuestions.Location = new System.Drawing.Point(400, 50);
			this.numberOfWrongQuestions.Name = "numberOfWrongQuestions";
			this.numberOfWrongQuestions.Size = new System.Drawing.Size(13, 13);
			this.numberOfWrongQuestions.TabIndex = 18;
			this.numberOfWrongQuestions.Text = "0";
			// 
			// wrongQuestions
			// 
			this.wrongQuestions.AutoSize = true;
			this.wrongQuestions.Location = new System.Drawing.Point(415, 50);
			this.wrongQuestions.Name = "wrongQuestions";
			this.wrongQuestions.Size = new System.Drawing.Size(89, 13);
			this.wrongQuestions.TabIndex = 19;
			this.wrongQuestions.Text = "Wrong Questions";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
			// 
			// time
			// 
			this.time.AutoSize = true;
			this.time.Location = new System.Drawing.Point(650, 50);
			this.time.Name = "time";
			this.time.Size = new System.Drawing.Size(34, 13);
			this.time.TabIndex = 20;
			this.time.Text = "30:00";
			// 
			// timer
			// 
			this.timer.AutoSize = true;
			this.timer.Location = new System.Drawing.Point(600, 50);
			this.timer.Name = "timer";
			this.timer.Size = new System.Drawing.Size(33, 13);
			this.timer.TabIndex = 21;
			this.timer.Text = "Time:";
			// 
			// Quiz
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 500);
			this.Controls.Add(this.timer);
			this.Controls.Add(this.time);
			this.Controls.Add(this.wrongQuestions);
			this.Controls.Add(this.numberOfWrongQuestions);
			this.Controls.Add(this.correctQuestions);
			this.Controls.Add(this.numberOfCorrectQuestions);
			this.Controls.Add(this.questionLeft);
			this.Controls.Add(this.numberOfQuestionLeft);
			this.Controls.Add(this.labelQuestion);
			this.Controls.Add(this.checkBoxC);
			this.Controls.Add(this.checkBoxB);
			this.Controls.Add(this.checkBoxA);
			this.Controls.Add(this.buttonNext);
			this.Controls.Add(this.labelC);
			this.Controls.Add(this.labelB);
			this.Controls.Add(this.labelA);
			this.Name = "Quiz";
			this.Text = "Quiz";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Button buttonNext;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.CheckBox checkBoxC;
        private System.Windows.Forms.CheckBox checkBoxB;
        private System.Windows.Forms.CheckBox checkBoxA;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label wrongQuestions;
        private System.Windows.Forms.Label numberOfWrongQuestions;
        private System.Windows.Forms.Label correctQuestions;
        private System.Windows.Forms.Label numberOfCorrectQuestions;
        private System.Windows.Forms.Label questionLeft;
        private System.Windows.Forms.Label numberOfQuestionLeft;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label timer;
		private System.Windows.Forms.Label time;
	}
}

