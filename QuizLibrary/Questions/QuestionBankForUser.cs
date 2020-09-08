using DataSourceDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLibrary.Questions
{
    public class QuestionBankForUser : QuestionBank
    {
        private string _fileSource;
        List<QuestionTemplate> convertedQuestions;

        public QuestionBankForUser(List<QuestionTemplate> computerScienceQuestions)
        {
            convertedQuestions =new List<QuestionTemplate>(computerScienceQuestions);
        }

        public QuestionBankForUser(string fileSource)
        {
            _fileSource = fileSource;
        }
        public override List<QuestionTemplate> GetAllQuestions
        {
            get
            {
                convertedQuestions = new List<QuestionTemplate>();
                var allQuestions= DataSourceFactory.CreateJsonDataSource(_fileSource);
                foreach (var item in allQuestions)
                {
                    convertedQuestions.Add(new QuestionTemplate(item));
                }
                return convertedQuestions;
            }
        }
        public override Dictionary<string, bool> GetResult()
        {
            Dictionary<string, bool> results = new Dictionary<string, bool>();
            foreach (IQuestionTemplate item in convertedQuestions)
            {
                results.Add(item.GetQuestionPhrase, item.GetResult());
            }
            return results;
        }
    }
}
