using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSourceDAL
{
    public static class DataSourceFactory
    {
        public static List<Question> CreateJsonDataSource(string filePath)
        {
            return new JsonDataSource(filePath).GetQuestions();
        }
    }
}
