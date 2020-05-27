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
    public partial class AddQuestion : Form
    {
		private Controller.Controller controller;

        public AddQuestion(Controller.Controller controller)
        {
			this.controller = controller;
            InitializeComponent();
        }

		private void AddQuestion_Load(object sender, EventArgs e)
		{

		}

		private void close_Form()
		{
			Hide();
			Start start = new Start(this.controller);
			start.ShowDialog();
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			close_Form();
		}

		private void textBoxQuestion_Enter(object sender, EventArgs e)
		{
			if(textBoxQuestion.Text == "Please enter your question here")
			{
				textBoxQuestion.Text = "";
				textBoxQuestion.ForeColor = System.Drawing.Color.Black;
			}
		}

		private void textBoxA_Enter(object sender, EventArgs e)
		{
			if (textBoxA.Text == "Please enter answer A here")
			{
				textBoxA.Text = "";
				textBoxA.ForeColor = System.Drawing.Color.Black;
			}
		}

		private void textBoxB_Enter(object sender, EventArgs e)
		{
			if (textBoxB.Text == "Please enter answer B here")
			{
				textBoxB.Text = "";
				textBoxB.ForeColor = System.Drawing.Color.Black;
			}
		}

		private void textBoxC_Enter(object sender, EventArgs e)
		{
			if (textBoxC.Text == "Please enter answer C here")
			{
				textBoxC.Text = "";
				textBoxC.ForeColor = System.Drawing.Color.Black;
			}
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			this.controller.ReadData();
			string answers = "";
			if (checkBoxA.Checked)
				answers += 'A';
			if (checkBoxB.Checked)
				answers += 'B';
			if (checkBoxC.Checked)
				answers += 'C';
			if (textBoxA.Text != "" && textBoxB.Text != "" && textBoxC.Text != ""
				&& textBoxQuestion.Text != "" && answers != "") {
				Model.Question question = new Model.Question(this.controller.GetRepository().GetQuestions().Count + 1
					, textBoxQuestion.Text, new Model.Answer("A", textBoxA.Text),
					new Model.Answer("B", textBoxB.Text), new Model.Answer("C", textBoxC.Text), answers);
				this.controller.AddData(question);
			}
			else
			{
				MessageBox.Show("Invalid Quiz.");
			}
			close_Form();
		}
	}
}
