using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

// взаимодействие с файловой системой

namespace CS_Lesson_9
{
    internal class Program
    {

        static void Main(string[] args)
        {
           
            try
            {
                
                int j = 0;
                int d = 1 / j;

                //throw new Exception( new ExceptionHandler());
            }
            catch (Exception ex)
            {
                ExceptionHandler eh = new ExceptionHandler(ex, "C:\\Users\\С - 3\\Documents\\Тулинов Андрей\\CS_Lesson_9\\test_file_.txt",
                    /*dateStamp*/ true, /*messageStamp*/ true, /*stackTraceStamp*/ true, /*sourceStamp*/ true, /*innerExceptionStamp*/ true);
            }
            
            
        }

        public void Lesson_1()
        {
            //File.Create("C:\\Users\\С - 3\\Documents\\Тулинов Андрей\\CS_Lesson_9\\test_file_.txt");

            FileStream fstream = new FileStream("C:\\Users\\С - 3\\Documents\\Тулинов Андрей\\CS_Lesson_9\\test_file_.txt", FileMode.OpenOrCreate);
            fstream.Close();
            using (StreamWriter writer = new StreamWriter("C:\\Users\\С - 3\\Documents\\Тулинов Андрей\\CS_Lesson_9\\test_file_.txt", true))
            {
                writer.WriteLine("Привет мир!");

            }

            using (StreamReader reader = new StreamReader("C:\\Users\\С - 3\\Documents\\Тулинов Андрей\\CS_Lesson_9\\test_file_.txt"))
            {
                string line = reader.ReadToEnd();
                Console.Write(line);
            }

            Logger logger = new Logger("C:\\Users\\С - 3\\Documents\\Тулинов Андрей\\CS_Lesson_9\\test_file_.txt");
            logger.Log("Error Error Error Error Error Error");

        }
    }
}
