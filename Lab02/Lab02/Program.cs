using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            var valor1 = "Este es el valor 1.";
            var valor2 = 5;

            var valor3 = valor2.ToString();

            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
            Console.WriteLine(valor3);

            Console.ReadKey();
        }
    }
}
