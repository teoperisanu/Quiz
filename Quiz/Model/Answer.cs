using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Model
{
	public class Answer
	{
		/// <summary>
		/// The attributes of the Answer class
		/// </summary>
		private String AnswerId;
		private String AnswerText;

		/// <summary>
		/// The default constructor of the Answer class
		/// </summary>
		public Answer()
		{

		}

		/// <summary>
		/// The explicit constructor of the Answer class
		/// </summary>
		/// <param name="answerId">String, letter of the answer</param>
		/// <param name="answerText">String, text of the answer</param>
		public Answer(String answerId, String answerText)
		{
			this.AnswerId = answerId;
			this.AnswerText = answerText;
		}


		/// <summary>
		/// The getters of the Answer class
		/// </summary>
		public String GetAnswerId()
		{
			return this.AnswerId;
		}

		public String GetAnswerText()
		{
			return this.AnswerText;
		}

		/// <summary>
		/// The setters of the Answer class
		/// </summary>
		public void SetAnswerId(String answerId)
		{
			this.AnswerId = answerId;
		}

		public void SetAnswerTest(String answerText)
		{
			this.AnswerText = answerText;
		}

	}
}
