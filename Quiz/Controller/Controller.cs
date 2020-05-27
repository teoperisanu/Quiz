using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz.Controller
{

	public class Controller
	{
		/// <summary>
		/// The attribute of the Controller class
		/// </summary>
		private Repository.Repository repository;
		private List<Model.Question> questions;
		private int currentQuestion;
		private int correctQuestions;
		private int wrongQuestions;

		/// <summary>
		/// The default constructor of the Controller class
		/// </summary>
		public Controller()
		{

		}

		/// <summary>
		/// The explicit constructor of the Controller class
		/// </summary>
		/// <param name="repository">A Repositroy, the class that handles the CRUD data</param>
		public Controller(Repository.Repository repository)
		{
			this.repository = repository;
			this.currentQuestion = 0;
			this.correctQuestions = 0;
			this.wrongQuestions = 0;
		}

		public void ReadData()
		{
			this.repository.ReadData();
		}

		public void AddData(Model.Question question)
		{
			this.repository.AddData(question);
		}

		public Repository.Repository GetRepository()
		{
			return this.repository;
		}

		public void SetRepository(Repository.Repository repository)
		{
			this.repository = repository;																  
		}

		public List<Model.Question> GetQuestions()
		{
			return this.questions;
		}

		public void SetQuestions(List<Model.Question> questions)
		{
			this.questions = questions;
		}

		public int GetCurrentQuestion()
		{
			return this.currentQuestion;
		}

		public void SetCurrentQuestion(int number)
		{
			this.currentQuestion = number;
		}

		public int GetCorrectQuestions()
		{
			return this.correctQuestions;
		}

		public void SetCorrectQuestions(int number)
		{
			this.correctQuestions = number;
		}

		public int GetWrongQuestions()
		{
			return this.wrongQuestions;
		}

		public void SetWrongQuestions(int number)
		{
			this.wrongQuestions = number;
		}

		public void Get26Questions()
		{
			this.questions = this.repository.GetQuestions().OrderBy(arg => Guid.NewGuid()).Take(26).ToList();
		}

		public bool CheckQuestion(Model.Question question, string answers)
		{
			int count = 0;
			foreach(char character in question.GetCorrectAnswers())
			{
				if(character == 'A' || character == 'B' || character == 'C')
				{
					count++;
				}
			}
			if (count != answers.Count())
				return false;
			foreach(char answer in answers)
			{
				if (!question.GetCorrectAnswers().Contains(answer))
				{
					return false;
				}
			}
			return true;
		}
	}
}
