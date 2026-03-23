using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_CALA_1129526
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("¿Cómo te llamas? ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");

            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            // ================= EJERCICIO 1 =================
            Console.WriteLine("Ejercicio #1\n");

            int nota;
            int aprobados = 0;
            int reprobados = 0;
            int acumulador = 0;
            double promedioNotas;

            for (int x = 1; x <= 10; x++)
            {
                Console.Write("Ingrese la nota #" + x + ": ");
                nota = Convert.ToInt32(Console.ReadLine());

                acumulador += nota;

                if (nota >= 65)
                    aprobados++;
                else
                    reprobados++;
            }

            promedioNotas = (double)acumulador / 10;

            Console.WriteLine("\nPromedio obtenido: " + promedioNotas);
            Console.WriteLine("Cantidad de aprobados: " + aprobados);
            Console.WriteLine("Cantidad de reprobados: " + reprobados);

            Console.WriteLine("\nPresione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();


            // ================= EJERCICIO 2 =================
            Console.WriteLine("Ejercicio #2\n");

            int limite;
            int sumaNumeros = 0;
            int num = 1;
            int contPares = 0;
            int contImpares = 0;

            Console.Write("Ingrese un número entero positivo: ");
            limite = int.Parse(Console.ReadLine());

            while (limite <= 0)
            {
                Console.WriteLine("El número debe ser mayor que 0.");
                Console.Write("Ingrese nuevamente: ");
                limite = int.Parse(Console.ReadLine());
            }

            while (num <= limite)
            {
                sumaNumeros += num;

                if (num % 2 == 0)
                    contPares++;
                else
                    contImpares++;

                num++;
            }

            Console.WriteLine("\nSuma total: " + sumaNumeros);
            Console.WriteLine("Cantidad de números pares: " + contPares);
            Console.WriteLine("Cantidad de números impares: " + contImpares);

            Console.WriteLine("\nPresione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();


            // ================= EJERCICIO 3 =================
            Console.WriteLine("Ejercicio #3\n");

            int opcionMenu;
            double ventasTotales = 0;
            int clientes = 0;
            double compra;

            do
            {
                Console.WriteLine("\n--- MENÚ DE TIENDA ---");
                Console.WriteLine("1. Registrar compra");
                Console.WriteLine("2. Ver total de ventas");
                Console.WriteLine("3. Ver número de clientes");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                opcionMenu = int.Parse(Console.ReadLine());

                switch (opcionMenu)
                {
                    case 1:
                        Console.Write("Monto de la compra: ");
                        compra = Convert.ToDouble(Console.ReadLine());

                        ventasTotales += compra;
                        clientes++;

                        Console.WriteLine("Compra registrada.");
                        break;

                    case 2:
                        Console.WriteLine("Total vendido hoy: Q" + ventasTotales);
                        break;

                    case 3:
                        Console.WriteLine("Clientes atendidos: " + clientes);
                        break;

                    case 4:
                        Console.WriteLine("Cerrando sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción incorrecta.");
                        break;
                }

            } while (opcionMenu != 4);

            Console.WriteLine("\nPresione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();


            // ================= EJERCICIO 4 =================
            Console.WriteLine("Ejercicio #4\n");

            int valor = 0;
            int contadorTotal = 0;
            int positivos = 0;
            int negativos = 0;
            int sumaGeneral = 0;

            Console.WriteLine("Ingrese números (0 para terminar)");

            do
            {
                Console.Write("Número: ");
                valor = int.Parse(Console.ReadLine());

                if (valor != 0)
                {
                    contadorTotal++;
                    sumaGeneral += valor;

                    if (valor > 0)
                        positivos++;
                    else
                        negativos++;
                }

            } while (valor != 0);

            Console.WriteLine("\nResultados:");
            Console.WriteLine("Total de números: " + contadorTotal);
            Console.WriteLine("Positivos: " + positivos);
            Console.WriteLine("Negativos: " + negativos);
            Console.WriteLine("Suma acumulada: " + sumaGeneral);

            Console.WriteLine("\nPresione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();


            // ================= EJERCICIO 5 =================
            Console.WriteLine("Ejercicio #5\n");

            Console.Write("Ingrese el valor de N: ");
            int limiteFigura = int.Parse(Console.ReadLine());

            for (int fila = 1; fila <= limiteFigura; fila++)
            {
                for (int columna = 1; columna <= fila; columna++)
                {
                    Console.Write(columna);
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nPresione una tecla para finalizar");
            Console.ReadKey();
            Console.Clear();

        }
    }
}