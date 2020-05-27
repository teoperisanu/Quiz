using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Quiz : Form
    {
		private Controller.Controller controller;
		private int minutes;
		private int seconds;

        public Quiz(Controller.Controller controller)
        {
			this.controller = controller;
			this.controller.ReadData();
			this.controller.Get26Questions();
			this.minutes = 0;
			this.seconds = 3;
            InitializeComponent();
		}

		private void Load_Question()
		{
			this.labelQuestion.Text = this.controller.GetQuestions().ElementAt(this.controller.GetCurrentQuestion()).GetQuestion();
			this.checkBoxA.Text = this.controller.GetQuestions().ElementAt(this.controller.GetCurrentQuestion()).GetAnswerA().GetAnswerText();
			this.checkBoxB.Text = this.controller.GetQuestions().ElementAt(this.controller.GetCurrentQuestion()).GetAnswerB().GetAnswerText();
			this.checkBoxC.Text = this.controller.GetQuestions().ElementAt(this.controller.GetCurrentQuestion()).GetAnswerC().GetAnswerText();
			this.controller.SetCurrentQuestion(this.controller.GetCurrentQuestion() + 1);
		}

        private void Form1_Load(object sender, EventArgs e)
        {
			Load_Question();
		}

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

		private void timer1_Tick_1(object sender, EventArgs e)
		{
			if(this.minutes >= 0 && this.seconds > 0)
			{
				this.seconds -= 1;
				this.time.Text = this.minutes.ToString() + ":" + this.seconds.ToString();
				this.time.Refresh();
			}
			else if(this.minutes > 0 && this.seconds == 0)
			{
				this.minutes -= 1;
				this.seconds = 59;
				this.time.Text = this.minutes.ToString() + ":" + this.seconds.ToString();
				this.time.Refresh();
			}
			else
			{
				if(this.controller.GetCorrectQuestions() >= 22)
				{
					MessageBox.Show("Congratulations, you passed!");
				}
				this.timer1.Stop();
				MessageBox.Show("Time is up!");
				Hide();
				Start start = new Start(this.controller);
				start.ShowDialog();
			}
		}

		private void End_Quiz()
		{
			if(this.controller.GetWrongQuestions() == 5)
			{
				Hide();
				MessageBox.Show("You Failed.");
				Start start = new Start(this.controller);
				start.ShowDialog();
			}
			if (this.controller.GetCurrentQuestion() == 26)
			{
				Hide();
				MessageBox.Show("You Passed.");
				Start start = new Start(this.controller);
				start.ShowDialog();
			}
		}

		private void buttonNext_Click(object sender, EventArgs e)
		{
			String answers = "";
			if (checkBoxA.Checked)
			{
				answers += 'A';
				checkBoxA.Checked = false;
			}
			if (checkBoxB.Checked)
			{
				answers += 'B';
				checkBoxB.Checked = false;
			}
			if (checkBoxC.Checked)
			{
				answers += 'C';
				checkBoxC.Checked = false;
			}
			numberOfQuestionLeft.Text = (26 - this.controller.GetCurrentQuestion()).ToString();
			if(this.controller.CheckQuestion(this.controller.GetQuestions().ElementAt(this.controller.GetCurrentQuestion() - 1), answers))
			{
				this.controller.SetCorrectQuestions(this.controller.GetCorrectQuestions() + 1);
				numberOfCorrectQuestions.Text = this.controller.GetCorrectQuestions().ToString();
			}
			else
			{
				this.controller.SetWrongQuestions(this.controller.GetWrongQuestions() + 1);
				numberOfWrongQuestions.Text = this.controller.GetWrongQuestions().ToString();
			}
			End_Quiz();
			Load_Question();
		}
	}
}
