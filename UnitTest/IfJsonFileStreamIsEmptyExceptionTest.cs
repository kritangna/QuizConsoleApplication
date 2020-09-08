using System;
using DataSourceDAL;
using ExceptionHandlingClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class IfJsonFileStreamIsEmptyExceptionTest
    {
        [TestMethod]
        [ExpectedException(typeof(DataNotInFileException))]
        public void If_Json_FileStream_Is_Empty_Then_Throw_DataNotInFileException()
        {
            var jsonFileStream = new JsonDataSource(@"D:\AssignmentProjects\C# Training\QuizProject\UnitTest\bin\Debug\QuestionLibraryEmptyFile_UnitTest.json").GetQuestions();
        }
    }
}
