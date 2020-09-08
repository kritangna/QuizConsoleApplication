using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingClass
{
    public class DataNotInFileException : Exception
    {
        public DataNotInFileException(string message):base(message)
        {

        }
    }
}
