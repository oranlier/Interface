using System;

namespace Interface
{
    public class SMSLogger : ILogger
    {
        public void writeLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("SMS olarak log yazar.");
        }
    }
}