using QuizLibrary.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using QuizLibrary.Questions.ComputerScienceQuestions;
using QuizLibrary.Questions.GeneralKnowledgeQuestions;

namespace QuizLibrary
{
    public class QuestionBankcopy : IQuestionBank
    {
        List<IBaseQuestion> baseQuestions;

        public QuestionBankcopy()
        {
            Register();
        }
        private void Register()
        {
            baseQuestions = new List<IBaseQuestion>();
            baseQuestions.Add(new QuestionWorldBank());
            baseQuestions.Add(new QuestionTrojan());
            baseQuestions.Add(new QuestionSuperComputer());
            baseQuestions.Add(new QuestionMechanicalComputer());
            baseQuestions.Add(new QuestionHardDisk());
            baseQuestions.Add(new QuestionAssemblyLanguage());
            baseQuestions.Add(new QuestionComputerFolder());
            baseQuestions.Add(new QuestionGraphicInterface());
            baseQuestions.Add(new QuestionIntegratedChip());
        }
        public List<IBaseQuestion> GetAllQuestions
        {
            get
            {
                return baseQuestions;
            }
        }

        public Dictionary<string, bool> GetResult()
        {
            Dictionary<string, bool> results = new Dictionary<string, bool>();
            foreach (IBaseQuestion item in baseQuestions)
            {
                results.Add(item.GetQuestionPhrase, item.GetResult());
            }
            return results;
        }
    }
}

