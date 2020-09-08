using DataSourceDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ExceptionHandlingClass;

namespace UnitTest
{
    [TestClass]
    public class FilePathNotFoundExceptionTest
    {
        [TestMethod]
        [ExpectedException(typeof(FilePathNotFoundException))]
        public void When_FilePath_For_JsonFile_Is_Not_Found_Then_Throw_FilePathNotFoundException()
        {
            string filePath = @"D:\AssignmentProjects\C# Training\QuizProject\UnitTest\bin\Debug\QuestionLibraryHistoryy_UnitTest.json";
            var jsonFile = new JsonDataSource(filePath).GetQuestions();
        }
    }
}
