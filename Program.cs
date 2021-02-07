using System;
using System.Collections.Generic;

namespace CreditManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager requirementCreditManager = new RequirementCreditManager();
            ICreditManager transportationCreditManager = new TransportationCreditManager();
            ICreditManager residenceCreditManager = new ResidenceCreditManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();



           ApplyCreditManager applyCreditManager = new ApplyCreditManager();
           applyCreditManager.Apply(new EmployeeCreditManager(), new SmsLoggerService());


            List<ICreditManager> credits = new List<ICreditManager>() { requirementCreditManager,transportationCreditManager};
            //applyCreditManager.CreditPreInformation(credits);

        }
    }
}
