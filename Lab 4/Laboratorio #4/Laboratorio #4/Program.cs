using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Comó te llamas?");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");

            //Ejercicio 1
            string Area_51;
            int capacidad_de_carga;
            float nivel_de_combustible;
            bool activo_o_no_activo;

            Console.WriteLine("Ingrese el nombre del modelo");
            Area_51 = Console.ReadLine();

            Console.WriteLine("Ingrese capacidad de carga");
            capacidad_de_carga = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese nivel de combustible");
           
        }
    }
}


