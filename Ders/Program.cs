using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger filelogger = new FileLogger();
            filelogger.writeLog();

            DatabaseLogger databaselogger = new DatabaseLogger();
            databaselogger.writeLog();

            SMSLogger smslogger = new SMSLogger();
            smslogger.writeLog();

            LogManager logmanager = new LogManager(new FileLogger());
            logmanager.writeLog();
        }
    }
}
