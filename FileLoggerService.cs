using System;

namespace CreditManagement
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("log has saved to file");
        }
    }
}
