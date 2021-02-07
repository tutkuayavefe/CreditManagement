using System;
using System.Collections.Generic;
using System.Text;

namespace CreditManagement
{
    class ResidenceCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("residence credit has calculated");
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}
