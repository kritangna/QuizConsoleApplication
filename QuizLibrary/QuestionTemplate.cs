using DataSourceDAL;
using QuizLibrary.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLibrary
{
   // question
    public class QuestionTemplate : IQuestionTemplate
    {
        private string userAnswer;
        Dictionary<int, string> _options;
        public QuestionTemplate(Question question)
        {
            _options = new Dictionary<int, string>();
            this.GetQuestionPhrase = question.GetQuestionPhrase;
            _options.Add(1, question.Options.One);
            _options.Add(2, question.Options.Two);
            _options.Add(3, question.Options.Three);
            _options.Add(4, question.Options.Four);
            CorrectAnswer = question.CorrectAnswer;
        }

        public string GetQuestionPhrase { get; }
        public Dictionary<int, string> Options
        {
            get
            {
                return _options;
            }
        }
        public string CorrectAnswer { get; }
        public  string UserAnswer
        {
            set
            {
                userAnswer = value.Trim();
            }
        }
        public bool GetResult()
        {
            if (CorrectAnswer == userAnswer)
                return true;
            return false;
        }
        public bool ValidateAnswer
        {
            get
            {
                return userAnswer == CorrectAnswer;
            }
        }

    }
}
