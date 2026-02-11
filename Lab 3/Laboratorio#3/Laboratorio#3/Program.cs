using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, curso;
            Console.WriteLine("Hello word");
            Console.WriteLine("programa creado por Andres Castillo");
            Console.WriteLine();
            Console.Write("Escriba su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Escriba su curso: ");
            curso = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Bienvenido " + nombre + " del curso: " + curso + ", Ten un excelente dia");
            Console.WriteLine();
            Console.Write("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}
