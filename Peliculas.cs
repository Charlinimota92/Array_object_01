using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_object_01
{
    internal class Peliculas
    {
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public double Duracion { get; set; }
        public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Género: {Genero}");
            Console.WriteLine($"Duración: {Duracion}");
        }
    }
}
