using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_AC_1195025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1

            // Entrada de usuario
            Console.Write("¿Cómo te llamas? ");
            string nombre = Console.ReadLine();

            // Salida de datos
            Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");

            Console.WriteLine("\n--- Clasificación de Vehículos ---\n");

            // Menú de opciones
            Console.WriteLine("1. Bicicleta");
            Console.WriteLine("2. Motocicleta");
            Console.WriteLine("3. Auto");
            Console.WriteLine("4. Camión");
            Console.WriteLine("5. Autobús");

            // Solicitar tipo de vehículo
            Console.Write("\nIngrese el tipo de vehículo (1-5): ");

            // Validar que sea un número
            if (int.TryParse(Console.ReadLine(), out int tipoVehiculo))
            {
                // Clasificación según el tipo de vehículo
                switch (tipoVehiculo)
                {
                    case 1:
                        Console.WriteLine("Clasificación: No motorizado");
                        break;
                    case 2:
                        Console.WriteLine("Clasificación: Ligero");
                        break;
                    case 3:
                        Console.WriteLine("Clasificación: Mediano");
                        break;
                    case 4:
                        Console.WriteLine("Clasificación: Pesado");
                        break;
                    case 5:
                        Console.WriteLine("Clasificación: Transporte público");
                        break;
                    default:
                        Console.WriteLine("Error: Número fuera del rango (1-5)");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error: Debe ingresar un número válido");











            }
        }
    }
}
