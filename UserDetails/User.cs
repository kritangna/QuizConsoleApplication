using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDetails
{
    public class User
    {
        private decimal passingPercentage = 33.33m;
        private decimal finalResult=00.00m;
        public User()
        {

        }
        public string Name { get; set; }
        public int TestOptionNumber { get; set; }
        public string TestType(int optionNumber)
        {
            if (optionNumber == 1)
            {
                return QuestionTypeA;
            }
            else if (optionNumber == 2)
            {
                return QuestionTypeB;
            }
            else if (optionNumber == 3)
            {
                return QuestionTypeC;
            }
            else
            {
                return "Enter Valid Option number";
            }
        }
        public string QuestionTypeA
        {
            get
            {
                return "Computer Science";
            }
        }
        public string QuestionTypeB
        {
            get
            {
                return "General Knowledge";
            }
        }
        public string QuestionTypeC
        {
            get
            {
                return "History";
            }
        }
       
        public decimal TestCompletionPercentage(decimal attemptedQuestions, decimal totalQuestions)
        {
            return Math.Round(((attemptedQuestions / totalQuestions) * 100),2);
        }
        public decimal PercentageCalculationOfUser(decimal passCount,decimal totalQuestions)
        {
            return finalResult = Math.Round(((passCount / totalQuestions) * 100),2);
        }
        
        public string ResultDeclarationOfUser()
        {
            if (finalResult >= passingPercentage)
                return "PASS!";
            else
                return "FAIL!";
        }
    }
}
