using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingClass
{
    public class FilePathNotFoundException:Exception
    {
        public FilePathNotFoundException(string message):base(message)
        {

        }
    }
}
