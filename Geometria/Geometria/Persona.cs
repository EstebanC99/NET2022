using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Persona
    {

        public string Nombre
        {
            get => default;
            set
            {
            }
        }

        public string Apellido
        {
            get => default;
            set
            {
            }
        }

        public int Edad
        {
            get => default;
            set
            {
            }
        }

        public long DNI
        {
            get => default;
            set
            {
            }
        }

        public Persona(string nombre, string apellido, int edad, long dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            DNI = dni;
        }
    }
}