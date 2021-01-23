using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonalFinanceCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personal finance credit payment plan calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
