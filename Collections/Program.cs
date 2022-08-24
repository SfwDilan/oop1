using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> { "Buse","Hayati","Can","Mert"};
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            isimler.Add("Hasan");
            isimler.Add("Veli");
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[5]);
            Console.WriteLine(isimler[0]);
        }
    }
}
