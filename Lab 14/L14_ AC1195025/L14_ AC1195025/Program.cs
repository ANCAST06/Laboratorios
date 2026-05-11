using System;
using System.Collections.Generic;
using System.Linq;

namespace Laboratorio14POO
{
    // Ejercicio 1: Libro
    public class Libro
    {
        // Atributos
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public int AnioPublicacion { get; private set; }
        public bool Disponible { get; private set; }

        // Constructor
        public Libro(string titulo, string autor, int anioPublicacion, bool disponible)
        {
            Titulo = titulo;
            Autor = autor;
            AnioPublicacion = anioPublicacion;
            Disponible = disponible;
        }

        // Métodos
        public void MostrarInformacion()
        {
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Año de publicación: {AnioPublicacion}");
            Console.WriteLine($"Disponible: {Disponible}");
        }

        public void PrestarLibro()
        {
            if (Disponible)
            {
                Disponible = false;
                Console.WriteLine($"El libro '{Titulo}' ha sido prestado.");
            }
            else
            {
                Console.WriteLine($"El libro '{Titulo}' ya no está disponible para préstamo.");
            }
        }

        public void DevolverLibro()
        {
            if (!Disponible)
            {
                Disponible = true;
                Console.WriteLine($"El libro '{Titulo}' ha sido devuelto y ahora está disponible.");
            }
            else
            {
                Console.WriteLine($"El libro '{Titulo}' ya está disponible.");
            }
        }
    }

    // Ejercicio 2: Mascota
    public class Mascota
    {
        // Atributos
        public string Nombre { get; private set; }
        public string Especie { get; private set; }
        public int Edad { get; private set; }
        public bool Vacunado { get; private set; }

        // Constructor
        public Mascota(string nombre, string especie, int edad, bool vacunado)
        {
            Nombre = nombre;
            Especie = especie;
            Edad = edad;
            Vacunado = vacunado;
        }

        // Métodos
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Especie: {Especie}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Vacunado: {Vacunado}");
        }

        public void Vacunar()
        {
            if (!Vacunado)
            {
                Vacunado = true;
                Console.WriteLine($"{Nombre} ha sido vacunado.");
            }
            else
            {
                Console.WriteLine($"{Nombre} ya está vacunado.");
            }
        }

        public void CumplirAnios()
        {
            Edad += 1;
            Console.WriteLine($"{Nombre} ha cumplido años. Nueva edad: {Edad}");
        }
    }

    // Ejercicio 3: Estudiante
    public class Estudiante
    {
        // Atributos
        public string Nombre { get; private set; }
        public int Edad { get; private set; }
        public string Grado { get; private set; }
        public List<double> Notas { get; private set; }
        public double Promedio { get; private set; }

        // Constructor
        public Estudiante(string nombre, int edad, string grado, List<double> notas)
        {
            Nombre = nombre;
            Edad = edad;
            Grado = grado;
            Notas = new List<double>(notas ?? new List<double>());
            CalcularPromedio();
        }

        // Métodos
        public void CalcularPromedio()
        {
            if (Notas.Count == 0)
            {
                Promedio = 0;
            }
            else
            {
                Promedio = Notas.Average();
            }
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Grado: {Grado}");
            Console.WriteLine($"Notas: [{string.Join(", ", Notas)}]");
            Console.WriteLine($"Promedio: {Promedio:F2}");
        }

        public bool Aprobar()
        {
            // Nota: en el enunciado se indica aprobar si promedio >= 61
            // Asumiendo escala de 0-100
            return Promedio >= 61.0;
        }

        public void AgregarNota(double nuevaNota)
        {
            Notas.Add(nuevaNota);
            CalcularPromedio();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1: Libros
            Console.WriteLine("Ejercicio 1: Libros");
            Libro libro1 = new Libro("C# desde cero", "Autor A", 2020, true);
            Libro libro2 = new Libro("Programación Orientada a Objetos", "Autor B", 2018, true);

            Console.WriteLine("Información del libro 1:");
            libro1.MostrarInformacion();
            Console.WriteLine();

            Console.WriteLine("Información del libro 2:");
            libro2.MostrarInformacion();
            Console.WriteLine();

            Console.WriteLine("Préstamo de libro 1:");
            libro1.PrestarLibro();
            Console.WriteLine("Estado actual del libro 1:");
            libro1.MostrarInformacion();
            Console.WriteLine();

            Console.WriteLine("Devolución de libro 1:");
            libro1.DevolverLibro();
            Console.WriteLine("Estado actual del libro 1:");
            libro1.MostrarInformacion();
            Console.WriteLine("");

            // Ejercicio 2: Mascotas
            Console.WriteLine("Ejercicio 2: Mascotas");
            Mascota mascota1 = new Mascota("Luna", "Perro", 3, false);
            Mascota mascota2 = new Mascota("Nina", "Gato", 2, true);

            Console.WriteLine("Información de las mascotas:");
            mascota1.MostrarInformacion();
            Console.WriteLine();
            mascota2.MostrarInformacion();
            Console.WriteLine();

            Console.WriteLine("Vacunación de Luna:");
            mascota1.Vacunar();
            mascota1.MostrarInformacion();
            Console.WriteLine();

            Console.WriteLine("Cumplir años de Nina:");
            mascota2.CumplirAnios();
            mascota2.MostrarInformacion();
            Console.WriteLine("");

            // Ejercicio 3: Estudiantes
            Console.WriteLine("Ejercicio 3: Estudiantes");

            var notas1 = new List<double> { 70.5, 62.0, 55.0 };
            var notas2 = new List<double> { 85.0, 90.0, 78.0, 92.0 };

            Estudiante est1 = new Estudiante("Carlos Rivera", 16, "9º A", notas1);
            Estudiante est2 = new Estudiante("Ana Martínez", 17, "11º B", notas2);

            Console.WriteLine("Promedios iniciales:");
            est1.MostrarInformacion();
            Console.WriteLine();
            est2.MostrarInformacion();
            Console.WriteLine();

            Console.WriteLine($"¿{est1.Nombre} aprueba? {est1.Aprobar()}");
            Console.WriteLine($"¿{est2.Nombre} aprueba? {est2.Aprobar()}");
            Console.WriteLine();

            Console.WriteLine("Agregando una nota a Carlos (60.0):");
            est1.AgregarNota(60.0);
            est1.MostrarInformacion();
            Console.WriteLine($"¿{est1.Nombre} aprueba ahora? {est1.Aprobar()}");

            // Mantener la consola abierta al final (opcional)
            Console.WriteLine("Programa finalizado. Presione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
