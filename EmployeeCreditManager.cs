using System;
using System.Collections.Generic;
using System.Text;

namespace CreditManagement
{
    class EmployeeCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Employee Credit has calculated");

        }

        public void Print()
        {
            throw new NotImplementedException();

        }
    }
}
