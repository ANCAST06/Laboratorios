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


                // Ejercicio 2

                Console.WriteLine("Ejercicio #2");


                string tipo;
                double lim;

                Console.WriteLine("Ingrese su tipo de tarjeta, escriba una de las siguientes opciones, tipo 1/2/3/otro");
                tipo = Console.ReadLine();

                Console.WriteLine("Ingrese su limite de credito actual");
                lim = Convert.ToDouble(Console.ReadLine());

                if (tipo.ToLower() == "1")
                {
                    lim = lim * 0.25 + lim;
                    Console.WriteLine("Su nuevo limite de credito tiene un aumento del 25%  " + lim);
                }
                else if (tipo.ToLower() == "2")
                {
                    lim = lim * 0.35 + lim;
                    Console.WriteLine("Su nuevo limite de credito tiene un aumento del 35%  " + lim);
                }
                else if (tipo.ToLower() == "3")
                {
                    lim = lim * 0.40 + lim;
                    Console.WriteLine("Su nuevo limite de credito tiene un aumento del 40%  " + lim);
                }
                else
                {
                    lim = lim * 0.50 + lim;
                    Console.WriteLine("Su nuevo limite de credito tiene un aumento del 50%  " + lim);

                }

                // Ejercicio #3


                Console.WriteLine("Ejercicio #3");



                double puntos;
                double sueldo = 2400;
                double sueldo_aum;

                Console.WriteLine("Ingrese su cantidad de puntos , escriba una de las siguientes opciones, 0.0/0.4/0.6");
                puntos = double.Parse(Console.ReadLine());


                if (puntos == 0.0)
                {
                    sueldo_aum = sueldo * 0.0 + sueldo;
                    Console.WriteLine("Su desempeño a lo largo del año a sido inaceptable, su aumento sera de 0.0 puntos,  " + sueldo_aum);
                }
                else if (puntos == 0.4)
                {
                    sueldo_aum = sueldo * 0.4 + sueldo;
                    Console.WriteLine("Su desempeño a lo largo del año a sido aceptable, su aumento sera de 0.4 puntos,  " + sueldo_aum);
                }
                else if (puntos == 0.6)
                {
                    sueldo_aum = sueldo * 0.6 + sueldo;
                    Console.WriteLine("Su desempeño a lo largo del año a sido meritorio, su aumento sera de 0.6 puntos,  " + sueldo_aum);
                }


                // Ejercicio #4 Bella Napoli


                Console.WriteLine("Ejercicio #4");


                string tipo_pizza;
                string ingrediente;

                Console.WriteLine("Que tipo de pizza le gustaria ordenar?, vegetariana o no vegetariana");
                tipo_pizza = Console.ReadLine();

                if (tipo_pizza.ToLower() == "vegetariana")
                {
                    Console.WriteLine("Ingredientes disponibles: Pimiento, Champiñones, Tomate y Tofu");
                }
                else if (tipo_pizza.ToLower() == "no vegetariana")
                {
                    Console.WriteLine("Ingredientes disponibles: Peperoni, Jamón, Salmón y Camarón ");
                }

                Console.WriteLine("Ingrese el ingrediente que desea agregar a su pizza");
                ingrediente = Console.ReadLine();

                if (tipo_pizza.ToLower() == "vegetariana")
                {
                    if (ingrediente.ToLower() == "pimiento" || ingrediente.ToLower() == "champiñones" || ingrediente.ToLower() == "tomate" || ingrediente.ToLower() == "tofu")
                    {
                        Console.WriteLine("Ingrediente agregado a su pizza vegetariana: " + ingrediente);
                    }
                    else
                    {
                        Console.WriteLine("Ingrediente no disponible para pizza vegetariana");
                    }
                }
                else if (tipo_pizza.ToLower() == "no vegetariana")
                {
                    if (ingrediente.ToLower() == "peperoni" || ingrediente.ToLower() == "jamón" || ingrediente.ToLower() == "salmón" || ingrediente.ToLower() == "camarón")
                    {
                        Console.WriteLine("Ingrediente agregado a su pizza no vegetariana: " + ingrediente);
                    }
                    else
                    {
                        Console.WriteLine("Ingrediente no disponible para pizza no vegetariana");
                    }
                }

                Console.WriteLine("Gracias por su orden, su pizza estará lista en 20 minutos.");







            }
        }
    }
}
