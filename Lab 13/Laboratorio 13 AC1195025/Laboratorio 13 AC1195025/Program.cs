using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    // Las clases se definen aquí afuera para que la estructura cambie totalmente
    class Humano
    {
        public string primerNombre;
        public int edadAnios;
        public double estatura;
        public bool esEstudiante;
    }

    class Auto
    {
        public string fabricante;
        public string version;
        public int modeloAnio;
        public string tonoColor;
        public string numeroPlaca;
    }

    class Articulo
    {
        public string idCodigo;
        public string descripcion;
        public double costo;
        public int cantidad;
        public bool estaActivo;
    }

    class Animalito
    {
        public string apodo;
        public string raza;
        public int tiempoVida;
        public double masa;
        public bool tieneVacunas;
    }

    internal class Program
    {
        static void Main()
        {
            // Sección de Inicio
            Console.Write("Ingrese su nombre: ");
            string usuario = Console.ReadLine();
            Console.WriteLine("Hola, " + usuario + " ¡Bienvenido al Laboratorio 13!");

            Console.WriteLine("Presione Enter para iniciar los ejercicios");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("=== LABORATORIO 13: POO ===");
            Console.WriteLine(); // Reemplaza el \n

            TareaPersona();
            TareaCarro();
            TareaInventario();
            TareaAnimal();
        }

        static void TareaPersona()
        {
            Console.Clear();
            Console.WriteLine("=== EJERCICIO 1: PERSONA ===");
            Console.WriteLine();

            Humano sujeto = new Humano();
            sujeto.primerNombre = "Carlos Martinez";
            sujeto.estatura = 1.78;
            sujeto.edadAnios = 20;
            sujeto.esEstudiante = true;

            Console.WriteLine("Datos registrados:");
            Console.WriteLine("Nombre: " + sujeto.primerNombre);
            Console.WriteLine("Edad: " + sujeto.edadAnios);
            Console.WriteLine("Altura: " + sujeto.estatura);
            Console.WriteLine("Estudiante: " + sujeto.esEstudiante);

            Console.WriteLine();
            Console.WriteLine("Pulse una tecla para seguir...");
            Console.ReadLine();
        }

        static void TareaCarro()
        {
            Console.Clear();
            Console.WriteLine("=== EJERCICIO 2: VEHICULO ===");
            Console.WriteLine();

            Auto movil = new Auto();
            movil.fabricante = "Honda";
            movil.version = "Civic";
            movil.modeloAnio = 2022;
            movil.tonoColor = "Gris";
            movil.numeroPlaca = "XYZ-789";

            Console.WriteLine("Ficha técnica:");
            Console.WriteLine("Marca: " + movil.fabricante);
            Console.WriteLine("Modelo: " + movil.version);
            Console.WriteLine("Año: " + movil.modeloAnio);
            Console.WriteLine("Color: " + movil.tonoColor);
            Console.WriteLine("Placa: " + movil.numeroPlaca);

            Console.WriteLine();
            Console.WriteLine("Siguiente ejercicio...");
            Console.ReadLine();
        }

        static void TareaInventario()
        {
            Console.Clear();
            Console.WriteLine("=== EJERCICIO 3: PRODUCTOS ===");
            Console.WriteLine();

            Articulo itemA = new Articulo();
            itemA.idCodigo = "PRD001";
            itemA.descripcion = "Teclado Mecánico";
            itemA.costo = 75.50;
            itemA.cantidad = 15;
            itemA.estaActivo = true;

            Console.WriteLine("Producto A:");
            Console.WriteLine("ID: " + itemA.idCodigo);
            Console.WriteLine("Nombre: " + itemA.descripcion);
            Console.WriteLine("Precio: " + itemA.costo);
            Console.WriteLine("Stock: " + itemA.cantidad);
            Console.WriteLine("En Venta: " + itemA.estaActivo);

            Console.WriteLine();

            Articulo itemB = new Articulo();
            itemB.idCodigo = "PRD002";
            itemB.descripcion = "Monitor 24 pulgadas";
            itemB.costo = 199.99;
            itemB.cantidad = 8;
            itemB.estaActivo = true;

            Console.WriteLine("Producto B:");
            Console.WriteLine("ID: " + itemB.idCodigo);
            Console.WriteLine("Nombre: " + itemB.descripcion);
            Console.WriteLine("Precio: " + itemB.costo);
            Console.WriteLine("Stock: " + itemB.cantidad);
            Console.WriteLine("En Venta: " + itemB.estaActivo);

            Console.WriteLine();
            Console.WriteLine("Presione para continuar...");
            Console.ReadLine();
        }

        static void TareaAnimal()
        {
            Console.Clear();
            Console.WriteLine("=== EJERCICIO 4: MASCOTA ===");
            Console.WriteLine();

            Animalito mascotaUno = new Animalito();
            mascotaUno.apodo = "Luna";
            mascotaUno.raza = "Gato";
            mascotaUno.tiempoVida = 2;
            mascotaUno.masa = 4.5;
            mascotaUno.tieneVacunas = true;

            Console.WriteLine("Reporte de mascota:");
            Console.WriteLine("Nombre: " + mascotaUno.apodo);
            Console.WriteLine("Especie: " + mascotaUno.raza);
            Console.WriteLine("Edad: " + mascotaUno.tiempoVida);
            Console.WriteLine("Peso: " + mascotaUno.masa);
            Console.WriteLine("Vacunas al día: " + mascotaUno.tieneVacunas);

            Console.WriteLine();
            Console.WriteLine("Fin del laboratorio.");
            Console.ReadLine();
        }
    }
}
