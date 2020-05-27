using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Model
{
	public class Question
	{
		/// <summary>
		/// The attributes of the Question class
		/// </summary>
		private int Id;
		private String QuestionText;
		private Answer AnswerA;
		private Answer AnswerB;
		private Answer AnswerC;
		private String CorrectAnswers;

		/// <summary>
		/// The default constructor of the Question class
		/// </summary>
		public Question()
		{

		}

		/// <summary>
		/// The explicit constructor of the Question class
		/// </summary>
		/// <param name="id">Integer, unique for every QuestionText</param>
		/// <param name="question">String, the text of the QuestionText</param>
		/// <param name="answerA">Answer, class that containts the text and id of the answer</param>
		/// <param name="answerB">Answer, class that containts the text and id of the answer</param>
		/// <param name="answerC">Answer, class that containts the text and id of the answer</param>
		/// <param name="correctAnswers">An array, containts the characters of the correct answers</param>
		public Question(int id, String questionText, Answer answerA, Answer answerB, Answer answerC,
			String correctAnswers)									  
		{
			this.Id = id;
			this.QuestionText = questionText;
			this.AnswerA = answerA;
			this.AnswerB = answerB;
			this.AnswerC = answerC;
			this.CorrectAnswers = correctAnswers;
		}

		/// <summary>
		/// 		  The getter of the Question class
		/// </summary>
		public int GetId()
		{
			return this.Id;
		}

		public String GetQuestion()
		{
			return this.QuestionText;
		}

		public Answer GetAnswerA()
		{
			return this.AnswerA;
		}

		public Answer GetAnswerB()
		{
			return this.AnswerB;
		}

		public Answer GetAnswerC()
		{
			return this.AnswerC;
		}

		public String GetCorrectAnswers()
		{
			return this.CorrectAnswers;
		}

		/// <summary>
		///			The setter of the Question class
		/// </summary>
		public void SetId(int id)
		{
			this.Id = id;
		}

		public void SetQuestionText(String questionText)
		{
			this.QuestionText = questionText;
		}

		public void SetAnswerA(Answer answerA)
		{
			this.AnswerA = answerA;
		}

		public void SetAnswerB(Answer answerB)
		{
			this.AnswerB = answerB;
		}

		public void SetAnswerC(Answer answerC)
		{
			this.AnswerC = answerC;
		}

		public void SetCorrectAnswers(String correctAnswers)
		{
			this.CorrectAnswers = correctAnswers;
		}
    }
}
