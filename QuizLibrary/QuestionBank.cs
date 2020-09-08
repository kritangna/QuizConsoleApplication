using DataSourceDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLibrary
{
    abstract public class QuestionBank : IQuestionBank
    {
        public abstract List<QuestionTemplate> GetAllQuestions { get; }
        abstract public Dictionary<string, bool> GetResult();
    }
}
