using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSourceDAL
{
    public class Options
    {
        public string One { get; set; }//one
        public string Two { get; set; }
        public string Three { get; set; }
        public string Four { get; set; }
    }
    public class Question
   
    {
        public string GetQuestionPhrase { get; set; }
        public Options Options { get; set; }
        public string CorrectAnswer { get; set; }
    } 
}
