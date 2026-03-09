using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_1195025
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Entrada
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            // Proceso + Salida
            Console.WriteLine("Hola, " + nombre + ". ¡Bienvenido/a al Laboratorio7!");

            //Ejercicio 1 Suma controlada por contador (WHILE)
            int cantidad, suma;
            int contador = 1;
            float promedio;

            Console.Write("¿Cuantos numeros desea sumar?: ");
            cantidad = int.Parse(Console.ReadLine());
            while (cantidad <= 0)
            {
                Console.WriteLine("La cantidad debe ser mayor o igual a cero, intente de nuevo");
                Console.WriteLine("¿Cuantos numeros desea sumar?");
                cantidad = int.Parse(Console.ReadLine());
            }

            suma = 0;

            while (contador <= cantidad)
            {
               
                suma = suma + contador;
                contador++;
            }

            Console.WriteLine();
            Console.WriteLine("La suma de los numeros es: "+ suma);

            promedio = suma / cantidad;
            Console.WriteLine("El promedio es: " + promedio);







        }
    }
}
