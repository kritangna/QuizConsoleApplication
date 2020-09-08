using DataSourceDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLibrary
{
    public interface IQuestionBank
    {
        List<QuestionTemplate> GetAllQuestions { get; }
        Dictionary<string, bool> GetResult();
    }
}
