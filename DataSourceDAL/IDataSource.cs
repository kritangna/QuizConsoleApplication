using System.Collections.Generic;

namespace DataSourceDAL
{
    public interface IDataSource
    {
        List<Question> GetQuestions();
    }
}