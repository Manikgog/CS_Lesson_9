using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_9
{
    internal class ExceptionHandler
    {
        private string message;
        private string source;
        private string stackTrace;
        private string innerException;
        private string filePath;
        private bool dateStamp;
        private bool messageStamp;
        private bool stackTraceStamp;
        private bool sourceStamp;
        private bool innerExceptionStamp;
        public ExceptionHandler(Exception ex, string filePath, bool dateStamp = true, bool messageStamp = true, bool stackTraceStamp = true, bool sourceStamp = true, bool innerExceptionStamp = true)
        {
            this.message = ex.Message;
            this.source = ex.Source;
            this.stackTrace = ex.StackTrace;
            this.dateStamp = dateStamp;
            this.messageStamp = messageStamp;
            this.stackTraceStamp = stackTraceStamp;
            this.sourceStamp = sourceStamp;
            this.innerExceptionStamp = innerExceptionStamp;
            if (ex.InnerException != null)
            {
                this.innerException = ex.InnerException.ToString();
            }
            this.filePath = filePath;
            ToConsole();
            ToLogFile();
        }

        public void ToConsole()
        {
            if (dateStamp)
            {
                Console.WriteLine(this.Date());
            }
            if (messageStamp)
            {
                Console.WriteLine(this.Message());
            }
            if(stackTraceStamp)
            {
                Console.WriteLine(this.Source());
            }
            if (sourceStamp)
            {
                Console.WriteLine(this.StackTrace());
            }
            if (innerExceptionStamp)
            {
                Console.WriteLine(this.InnerException());
            }
           
        }

        public override string ToString()
        {
            DateTime dateTime = DateTime.Now;
            return "******************************************************************************" +
                "\nДата и время: " + dateTime + 
                "\nСообщение об ошибке: " + this.message + 
                "\nИсточник ошибки: " + this.source + 
                "\nСтек вызовов: " + this.stackTrace + 
                "\nКласс в котором возникло исключение: " + this.innerException +
                "\n******************************************************************************\n";
        }

        public string Date()
        {
            DateTime dateTime = DateTime.Now;
            return "******************************************************************************" +
                "\nДата и время: " + dateTime;
        }

        public string Message()
        {
            return "\nСообщение об ошибке: " + this.message;
        }

        public string Source()
        {
            return "\nИсточник ошибки: " + this.source;
        }

        public string StackTrace()
        {
            return "\nСтек вызовов: " + this.stackTrace;
        }

        public string InnerException()
        {
            return "\nКласс в котором возникло исключение: " + this.innerException;
        }

        public void ToLogFile()
        {
            Logger log = new Logger(filePath);
            
            if (dateStamp)
            {
                log.Log(this.Date());
            }
            if (messageStamp)
            {
                log.Log(this.Message());
            }
            if (stackTraceStamp)
            {
                log.Log(this.Source());
            }
            if (sourceStamp)
            {
                log.Log(this.StackTrace());
            }
            if (innerExceptionStamp)
            {
                log.Log(this.InnerException());
            }
        }

    }
}
