using Clases;
using System;

namespace LabClases2
{
    class Program
    {
        static void Main(string[] args)
        {
            D d = new D();
            C c = d;
            c.F();
            d.F();
            c.G();
            d.G();

            Console.ReadKey();

        }
    }
}
