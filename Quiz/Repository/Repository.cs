using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using Quiz.Model;

namespace Quiz.Repository
{
	public class Repository
	{
		/// <summary>
		/// The attribute of the class Repository
		/// </summary>
		private List<Question> questions = new List<Question>();

		public Repository()
		{
		} 

		public void ReadData()
		{
			SqlConnection myConnection = new SqlConnection("" +
				"Data Source=DESKTOP-Q5Q63H0;Initial Catalog=Quiz;Integrated Security=True");
			
			try
			{
				myConnection.Open();

			}
			catch (Exception exp)
			{
				MessageBox.Show("Could not connect to database! (" + exp.StackTrace.ToString() + ")");
			}
			this.questions.Clear();
			string sqlquery = "SELECT * FROM Quiz";
			SqlCommand command = new SqlCommand(sqlquery, myConnection);
			SqlDataReader sqlDataReader;

			sqlDataReader = command.ExecuteReader();

			while (sqlDataReader.Read())
			{
				int id = int.Parse(sqlDataReader["ID"].ToString());
				String questionText = sqlDataReader["Question"].ToString();
				Answer answerA = new Answer("A", sqlDataReader["AnswerA"].ToString());
				Answer answerB = new Answer("B", sqlDataReader["AnswerB"].ToString());
				Answer answerC = new Answer("C", sqlDataReader["AnswerC"].ToString());
				String correctAnswers = sqlDataReader["CorrectAnswer"].ToString();
				correctAnswers.Replace(" ", string.Empty);
				this.questions.Add(new Question(id, questionText, answerA, answerB, answerC, correctAnswers));
			}
			myConnection.Close();
		}

		public void AddData(Question question)
		{
			SqlConnection myConnection = new SqlConnection("" +
				"Data Source=DESKTOP-Q5Q63H0;Initial Catalog=Quiz;Integrated Security=True");

			try
			{
				myConnection.Open();

			}
			catch (Exception exp)
			{
				MessageBox.Show("Could not connect to database! (" + exp.StackTrace.ToString() + ")");
			}
			String querry = "INSERT INTO Quiz VALUES('" + question.GetId().ToString() +
				"', '" + question.GetQuestion() + "', '" + question.GetAnswerA().GetAnswerText() + "', '" +
				question.GetAnswerB().GetAnswerText() + "', '" + question.GetAnswerC().GetAnswerText() + "', '" +
				question.GetCorrectAnswers() + "');";
			SqlCommand command = new SqlCommand(querry, myConnection);
			try
			{
				command.ExecuteNonQuery();
			}
			catch
			{
				MessageBox.Show("Error trying to add value!");
			}
			myConnection.Close();
		}

		public List<Question> GetQuestions()
		{
			return this.questions;
		}

		public void SetQuestions(List<Question> questions)
		{
			this.questions = questions;
		}
	}
}
