using System;
using System.Collections.Generic;
using System.Text;

namespace CreditManagement
{
    class TransportationCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("transportation credit has calculated");

        }

        public void Print()
        {           
            throw new NotImplementedException();


        }
    }
}
