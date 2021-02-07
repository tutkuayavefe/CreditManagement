using System;
using System.Collections.Generic;
using System.Text;

namespace CreditManagement
{
    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms has sent");        }
    }
}
