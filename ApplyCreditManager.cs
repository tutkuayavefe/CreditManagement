using System;
using System.Collections.Generic;
using System.Text;

namespace CreditManagement
{
    class ApplyCreditManager
    {
        public void Apply(ICreditManager creditManager, ILoggerService loggerService)
        {
            creditManager.Calculate();
            loggerService.Log();
        }


        public void CreditPreInformation(List <ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }

        }

    }
}
