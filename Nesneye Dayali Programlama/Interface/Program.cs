using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            // FileLogger fileLogger = new FileLogger();
            // fileLogger.WriteLog();
            // DatabaseLogger dataLogger = new DatabaseLogger();
            // dataLogger.WriteLog();
            // SmsLogger smsLogger = new();
            // smsLogger.WriteLog();
            LogManager logManager = new(new FileLogger());
            logManager.WriteLog();

        }
    }
}
