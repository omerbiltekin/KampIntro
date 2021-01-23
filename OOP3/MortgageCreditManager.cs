using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgage credit payment plan calculated");

        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
