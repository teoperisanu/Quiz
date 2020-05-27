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
    public partial class Start : Form
    {
		private Controller.Controller controller;

		public Start(Controller.Controller controller)
        {
			this.controller = controller;
			InitializeComponent();
        }

		private void Start_Load(object sender, EventArgs e)
		{

		}

		private void addQuestion_Click(object sender, EventArgs e)
		{
			Hide();
			AddQuestion addQuestion = new AddQuestion(this.controller);
			addQuestion.ShowDialog();
		}

		private void takeQuiz_Click(object sender, EventArgs e)
		{
			Hide();
			Quiz quiz = new Quiz(this.controller);
			quiz.ShowDialog();
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
