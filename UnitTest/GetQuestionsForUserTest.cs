using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuizLibrary;
using QuizLibrary.Questions;

namespace UnitTest
{
    [TestClass]
    public class GetQuestionsForUserTest
    {
        [TestMethod]
        public void If_History_Questions_Are_Fetched()
        {
            //Arrange
            int expectedNumberOfHistoryQuestions = 3;

            //Act
            List<QuestionTemplate> actualListOfHistoryQuestions =new  QuestionBankForUser(@"D:\AssignmentProjects\C# Training\QuizProject\UnitTest\bin\Debug\QuestionLibraryHistory_UnitTest.json").GetAllQuestions;
            int actualNumberOfHistoryQuestions = actualListOfHistoryQuestions.Count;

            //Assert
            Assert.AreEqual(expectedNumberOfHistoryQuestions, actualNumberOfHistoryQuestions);
        }

        [TestMethod]
        public void If_GK_Questions_Are_Fetched()
        {
            //Arrange
            int expectedNumberOfGKQuestions = 3;

            //Act
            List<QuestionTemplate> actuaListOfGKQuestions = new QuestionBankForUser(@"D:\AssignmentProjects\C# Training\QuizProject\UnitTest\bin\Debug\QuestionLibraryGK_UnitTest.json").GetAllQuestions;
            int actuaNumberOfGKQuestions = actuaListOfGKQuestions.Count;
            //Assert
            Assert.AreEqual(expectedNumberOfGKQuestions, actuaNumberOfGKQuestions);
        }

        [TestMethod]
        public void If_CS_Questions_Are_Fetched()
        {
            //Arrange
            int expectedNumberOfCSQuestions = 8;

            //Act
            List<QuestionTemplate> actualListOfCSQuestions = new QuestionBankForUser(@"D:\AssignmentProjects\C# Training\QuizProject\UnitTest\bin\Debug\QuestionLibraryCS_UnitTest.json").GetAllQuestions;
            int actualNumberOfCSQuestions = actualListOfCSQuestions.Count;

            //Assert
            Assert.AreEqual(expectedNumberOfCSQuestions, actualNumberOfCSQuestions);
        }
    }
}
