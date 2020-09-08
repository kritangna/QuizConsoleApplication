using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataSourceDAL;
using QuizLibrary.Questions;

namespace QuizLibrary
{
    public static class QuestionBankFactory
    {
        public static List<QuestionTemplate> GetQuestionsForUser(int choice)
        {
            if(choice==1)
            {
                return new QuestionBankForUser(@"QuestionLibrary\QuestionLibraryCS.json").GetAllQuestions;
            }
            else if(choice==2)
            {
                return new QuestionBankForUser(@"QuestionLibrary\QuestionLibraryGK.json").GetAllQuestions;
            }
            else
            {
                return new QuestionBankForUser(@"QuestionLibrary\QuestionLibraryHistory.json").GetAllQuestions;
            }
        }
        public static List<QuestionTemplate> GetComputerScienceQuestionBank()
        {
            var questionList = new QuestionBankForUser("QuestionLibraryCS.json").GetAllQuestions;
            return questionList;
        }
        public static Dictionary<string,bool> GetComputerScienceResult(List<QuestionTemplate> computerScienceQuestions)
        {
            return new QuestionBankForUser(computerScienceQuestions).GetResult() ;
        }
    }
}
