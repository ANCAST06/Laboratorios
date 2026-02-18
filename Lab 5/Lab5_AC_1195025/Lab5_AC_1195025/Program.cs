using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_AC_1195025
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio 1: Panel de Acceso Numérico (Usuario + PIN + Modo seguro)
            int usuario, pin, token, modo_seguro;


            //a)
            Console.WriteLine("Ingerese el Usuario");
            usuario = Convert.ToInt32(Console.ReadLine());
            
            if (usuario == 2026)
            {
                Console.WriteLine("Usuario encontrado");
            }
            else

            {
                Console.WriteLine("Usuario no encontrado");
            }

            Console.WriteLine("Ingrese el pin");
            pin = Convert.ToInt32(Console.ReadLine());
            
            if (pin == 1234)
            {
                Console.WriteLine("Pin encontrado");
            }
            else
            {
                Console.WriteLine("Pin incorrecto, intente de nuevo");
            }

            Console.WriteLine("Ingrese el token");
            token = Convert.ToInt32(Console.ReadLine());

            if (token == 777)
            {
                Console.WriteLine("Token correcto");
            }
            else
            {
                Console.WriteLine("Token incorrecto");
            }

            Console.WriteLine("¿Es modo seguro? Escriba 1 (Si) o 0 (No)");
            modo_seguro = Convert.ToInt32(Console.ReadLine());

            if (modo_seguro == 1)
            {
                Console.WriteLine("Es seguro");
            }
            else
            {
                Console.WriteLine("No es seguro");
            }

            if (usuario == 2026 && pin == 1234 && token == 777 && modo_seguro == 1)
            {
                Console.WriteLine("Acceso total consedido");

            }
            else
            {
                Console.WriteLine("Acceso denegado");
            }

            if (token >=700 && modo_seguro == 1)
            {
                Console.WriteLine("Regla extra aprobada");

            }
            else
            {
                Console.WriteLine("Regla extra fallida");
            }








                //Ejercicio 2: Validador de PIN Inteligente (Módulo y rangos)
               

             



        }
    }
}
