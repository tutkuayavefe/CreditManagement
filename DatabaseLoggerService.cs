using System;
using System.Collections.Generic;
using System.Text;

namespace CreditManagement
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("log has saved to db");        }
    }
}
