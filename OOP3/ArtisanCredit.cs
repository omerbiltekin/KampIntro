using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ArtisanCredit : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Artisan credit payment plan calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
