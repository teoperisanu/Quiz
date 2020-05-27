namespace Quiz
{
    partial class AddQuestion
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
			this.buttonAdd = new System.Windows.Forms.Button();
			this.textBoxQuestion = new System.Windows.Forms.TextBox();
			this.checkBoxC = new System.Windows.Forms.CheckBox();
			this.checkBoxA = new System.Windows.Forms.CheckBox();
			this.labelCorrectQuest = new System.Windows.Forms.Label();
			this.checkBoxB = new System.Windows.Forms.CheckBox();
			this.textBoxA = new System.Windows.Forms.TextBox();
			this.textBoxB = new System.Windows.Forms.TextBox();
			this.textBoxC = new System.Windows.Forms.TextBox();
			this.buttonBack = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(375, 365);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 25);
			this.buttonAdd.TabIndex = 0;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// textBoxQuestion
			// 
			this.textBoxQuestion.ForeColor = System.Drawing.Color.Gray;
			this.textBoxQuestion.Location = new System.Drawing.Point(50, 50);
			this.textBoxQuestion.Name = "textBoxQuestion";
			this.textBoxQuestion.Size = new System.Drawing.Size(675, 20);
			this.textBoxQuestion.TabIndex = 1;
			this.textBoxQuestion.Text = "Please enter your question here";
			this.textBoxQuestion.Enter += new System.EventHandler(this.textBoxQuestion_Enter);
			// 
			// checkBoxC
			// 
			this.checkBoxC.AutoSize = true;
			this.checkBoxC.Location = new System.Drawing.Point(625, 300);
			this.checkBoxC.Name = "checkBoxC";
			this.checkBoxC.Size = new System.Drawing.Size(33, 17);
			this.checkBoxC.TabIndex = 5;
			this.checkBoxC.Text = "C";
			this.checkBoxC.UseVisualStyleBackColor = true;
			// 
			// checkBoxA
			// 
			this.checkBoxA.AutoSize = true;
			this.checkBoxA.Location = new System.Drawing.Point(125, 300);
			this.checkBoxA.Name = "checkBoxA";
			this.checkBoxA.Size = new System.Drawing.Size(33, 17);
			this.checkBoxA.TabIndex = 3;
			this.checkBoxA.Text = "A";
			this.checkBoxA.UseVisualStyleBackColor = true;
			// 
			// labelCorrectQuest
			// 
			this.labelCorrectQuest.AutoSize = true;
			this.labelCorrectQuest.Location = new System.Drawing.Point(350, 250);
			this.labelCorrectQuest.Name = "labelCorrectQuest";
			this.labelCorrectQuest.Size = new System.Drawing.Size(124, 13);
			this.labelCorrectQuest.TabIndex = 6;
			this.labelCorrectQuest.Text = "Choose correct answers:";
			// 
			// checkBoxB
			// 
			this.checkBoxB.AutoSize = true;
			this.checkBoxB.Location = new System.Drawing.Point(375, 300);
			this.checkBoxB.Name = "checkBoxB";
			this.checkBoxB.Size = new System.Drawing.Size(33, 17);
			this.checkBoxB.TabIndex = 4;
			this.checkBoxB.Text = "B";
			this.checkBoxB.UseVisualStyleBackColor = true;
			// 
			// textBoxA
			// 
			this.textBoxA.ForeColor = System.Drawing.Color.Gray;
			this.textBoxA.Location = new System.Drawing.Point(50, 100);
			this.textBoxA.Name = "textBoxA";
			this.textBoxA.Size = new System.Drawing.Size(500, 20);
			this.textBoxA.TabIndex = 7;
			this.textBoxA.Text = "Please enter answer A here";
			this.textBoxA.Enter += new System.EventHandler(this.textBoxA_Enter);
			// 
			// textBoxB
			// 
			this.textBoxB.ForeColor = System.Drawing.Color.Gray;
			this.textBoxB.Location = new System.Drawing.Point(50, 150);
			this.textBoxB.Name = "textBoxB";
			this.textBoxB.Size = new System.Drawing.Size(500, 20);
			this.textBoxB.TabIndex = 8;
			this.textBoxB.Text = "Please enter answer B here";
			this.textBoxB.Enter += new System.EventHandler(this.textBoxB_Enter);
			// 
			// textBoxC
			// 
			this.textBoxC.ForeColor = System.Drawing.Color.Gray;
			this.textBoxC.Location = new System.Drawing.Point(50, 200);
			this.textBoxC.Name = "textBoxC";
			this.textBoxC.Size = new System.Drawing.Size(500, 20);
			this.textBoxC.TabIndex = 9;
			this.textBoxC.Text = "Please enter answer C here";
			this.textBoxC.Enter += new System.EventHandler(this.textBoxC_Enter);
			// 
			// buttonBack
			// 
			this.buttonBack.Location = new System.Drawing.Point(375, 415);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(75, 23);
			this.buttonBack.TabIndex = 10;
			this.buttonBack.Text = "Back";
			this.buttonBack.UseVisualStyleBackColor = true;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// AddQuestion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.textBoxC);
			this.Controls.Add(this.textBoxB);
			this.Controls.Add(this.textBoxA);
			this.Controls.Add(this.labelCorrectQuest);
			this.Controls.Add(this.checkBoxC);
			this.Controls.Add(this.checkBoxB);
			this.Controls.Add(this.checkBoxA);
			this.Controls.Add(this.textBoxQuestion);
			this.Controls.Add(this.buttonAdd);
			this.Name = "AddQuestion";
			this.Text = "AddQuestion";
			this.Load += new System.EventHandler(this.AddQuestion_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.TextBox textBoxQuestion;
		private System.Windows.Forms.CheckBox checkBoxC;
		private System.Windows.Forms.CheckBox checkBoxA;
		private System.Windows.Forms.Label labelCorrectQuest;
		private System.Windows.Forms.CheckBox checkBoxB;
		private System.Windows.Forms.TextBox textBoxA;
		private System.Windows.Forms.TextBox textBoxB;
		private System.Windows.Forms.TextBox textBoxC;
		private System.Windows.Forms.Button buttonBack;
	}
}