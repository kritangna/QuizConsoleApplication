using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ExceptionHandlingClass;

namespace DataSourceDAL
{
    public class JsonDataSource : IDataSource
    {
        private string _filePath;
        private string _fileStream;
        public JsonDataSource(string filePath)
        {
            _filePath = filePath;
        }
        public List<Question> GetQuestions()
        {
            ValidateFilePath(_filePath);

            _fileStream = ReadStreamFromJsonFile(_filePath);
            ValidateFileStream(_fileStream);
            return ReadQuestionsFromJsonStream(_fileStream);
        }

        //private bool IsFilePathValid()
        //{
        //    if (!(File.Exists(fileSource)))
        //    {
        //        //log()// Create a logger for next time.
        //        return false;
        //    }

        //    return true;
        //}
        private void ValidateFilePath(string filePath)
        {
            if (!(File.Exists(filePath)))
                throw new FilePathNotFoundException("File does not exist!");
        }
        private void ValidateFileStream(string fileStream)
        {
            if (fileStream =="")
               throw new DataNotInFileException("File is empty!");
        }

        private List<Question> ReadQuestionsFromJsonStream(string fileStream)
        {
            List<Question> questionList = JsonConvert.DeserializeObject<List<Question>>(fileStream);
            return questionList;
        }

        private string ReadStreamFromJsonFile(string fileName)
        {
            StreamReader streamReader = new StreamReader(fileName);
            string jsonFile = streamReader.ReadToEnd();
            return jsonFile; 
        }

    }
}
