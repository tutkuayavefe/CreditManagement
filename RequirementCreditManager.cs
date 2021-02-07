using System;
using System.Collections.Generic;
using System.Text;

namespace CreditManagement
{
    class RequirementCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("requirement credit has calculated");
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}
