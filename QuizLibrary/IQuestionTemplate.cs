using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLibrary
{
    public interface IQuestionTemplate
    {
        string GetQuestionPhrase { get; }
        string UserAnswer { set; }
        bool GetResult();
        Dictionary<int, string> Options { get; }

    }
}
