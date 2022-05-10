using Clases;
using System;

namespace LabClases1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Programa de Clases");

            var instanciaAsinNombre = new A();
            var instanciaAconNombre = new A("A con Nombre");
            var instanciaB = new B();

            Console.WriteLine("Instancia de A sin nombre: " + instanciaAsinNombre.MostrarNombre());
            Console.WriteLine("Instancia de A con nombre: " + instanciaAconNombre.MostrarNombre());
            Console.WriteLine(string.Join(" - ", instanciaAconNombre.M1(), instanciaAconNombre.M2(), instanciaAconNombre.M3()));
            Console.WriteLine("Instancia de B: " + instanciaB.MostrarNombre());
            Console.WriteLine(instanciaB.M4());

            Console.ReadKey();
        }
    }
}
