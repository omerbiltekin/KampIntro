using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Ömer");

            List<string> liste = new List<string>();
            Console.WriteLine(liste.Count);


        }
    }
}
