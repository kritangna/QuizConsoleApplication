using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizLibrary;
using QuizLibrary.Questions;
using UserDetails;
//using DataSourceDAL;

namespace QuizChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            Console.WriteLine("Enter your name: ");
            user.Name = Console.ReadLine().ToUpper();
            Console.WriteLine("Choose from the given options: \n");
            Console.WriteLine("1: {0} \t 2: {1} \t 3: {2}          (Enter option number)", user.QuestionTypeA, user.QuestionTypeB, user.QuestionTypeC);
            user.TestOptionNumber = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Name of the candidate: {0}\nType of test opted for: {1}\n\n", user.Name, user.TestType(user.TestOptionNumber)); ;

            int attemptedQuestions = 0;
            var questionsForUser = QuestionBankFactory.GetQuestionsForUser(user.TestOptionNumber);
            foreach (IQuestionTemplate question in questionsForUser)
            {
                Console.WriteLine(question.GetQuestionPhrase);
                foreach (KeyValuePair<int, string> option in question.Options)
                {
                    Console.WriteLine($"{option.Key} :: {option.Value}");
                }

                Console.WriteLine("Please enter the answer (Give the option number)");
                int userAnswer = int.Parse(Console.ReadLine());
                question.UserAnswer = question.Options[userAnswer];
                ++attemptedQuestions;
               
                decimal attemptedPercent = user.TestCompletionPercentage(attemptedQuestions, questionsForUser.Count);
                Console.WriteLine(attemptedPercent + "% Completed");
                Console.WriteLine();
            }

            var computerScienceResult = QuestionBankFactory.GetComputerScienceResult(questionsForUser);
            int passCount = 0;
            foreach (KeyValuePair<string, bool> ans in computerScienceResult)
            {
                Console.WriteLine($"{ans.Key} :: {ans.Value}");
                if (ans.Value == true)
                    ++passCount;
            }
            decimal percentageOfUser = user.PercentageCalculationOfUser(passCount, questionsForUser.Count);
            Console.WriteLine("\n\n{0}, Your total percentage is: {1}%",user.Name, percentageOfUser);
            Console.WriteLine("\nRESULT: {0}",user.ResultDeclarationOfUser());
            Console.ReadKey();
        }
    }
}
