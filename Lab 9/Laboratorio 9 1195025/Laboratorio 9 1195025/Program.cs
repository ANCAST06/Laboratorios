using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Laboratorio 9 - Procedimientos");

        // Ejecutar cada ejercicio
        Ejercicio1();
        Ejercicio2();
        Ejercicio3();
        Ejercicio4();
        Ejercicio5();
    }

    
    // EJERCICIO 1
  
    static void Ejercicio1()
    {
        Console.WriteLine("Ejercicio 1");

        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Saludo(nombre);
        MostrarCurso();
    }

    static void Saludo(string nombre)
    {
        Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");
    }

    static void MostrarCurso()
    {
        Console.WriteLine("Curso: Programación - Laboratorio 9");
        Console.WriteLine();
    }

    // EJERCICIO 2
   
    static void Ejercicio2()
    {
        Console.WriteLine("Ejercicio 2");

        Console.Write("Ingrese lado del cuadrado: ");
        double lado = double.Parse(Console.ReadLine());
        AreaCuadrado(lado);

        Console.Write("Ingrese base del rectángulo: ");
        double baseR = double.Parse(Console.ReadLine());
        Console.Write("Ingrese altura del rectángulo: ");
        double alturaR = double.Parse(Console.ReadLine());
        AreaRectangulo(baseR, alturaR);

        Console.Write("Ingrese base del triángulo: ");
        double baseT = double.Parse(Console.ReadLine());
        Console.Write("Ingrese altura del triángulo: ");
        double alturaT = double.Parse(Console.ReadLine());
        AreaTriangulo(baseT, alturaT);
    }

    static void AreaCuadrado(double lado)
    {
        double area = lado * lado;
        Console.WriteLine($"Área del cuadrado: {area}");
    }

    static void AreaRectangulo(double b, double h)
    {
        double area = b * h;
        Console.WriteLine($"Área del rectángulo: {area}");
    }

    static void AreaTriangulo(double b, double h)
    {
        double area = (b * h) / 2;
        Console.WriteLine($"Área del triángulo: {area}");
    }

 
    // EJERCICIO 3
   
    static void Ejercicio3()
    {
        Console.WriteLine("Ejercicio 3");

        int opcion;
        do
        {
            Console.WriteLine("\n1. Cuadrado");
            Console.WriteLine("2. Triángulo");
            Console.WriteLine("3. Línea");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion != 4)
            {
                Console.Write("Ingrese N: ");
                int n = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        DibujarCuadrado(n);
                        break;
                    case 2:
                        DibujarTriangulo(n);
                        break;
                    case 3:
                        DibujarLinea(n);
                        break;
                }
            }

        } while (opcion != 4);
    }

    static void DibujarCuadrado(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('*', n));
        }
    }

    static void DibujarTriangulo(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(new string('*', i));
        }
    }

    static void DibujarLinea(int n)
    {
        Console.WriteLine(new string('*', n));
    }


    // EJERCICIO 4
 
    static void Ejercicio4()
    {
        Console.WriteLine("\n--- Ejercicio 4 ---");

        int aprobados = 0, reprobados = 0;
        double suma = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Ingrese nota {i}: ");
            double nota = double.Parse(Console.ReadLine());

            EvaluarNota(nota, ref aprobados, ref reprobados);
            suma += nota;
        }

        MostrarResumen(suma, aprobados, reprobados);
    }

    static void EvaluarNota(double nota, ref int aprobados, ref int reprobados)
    {
        if (nota >= 61)
        {
            Console.WriteLine("Aprobado");
            aprobados++;
        }
        else
        {
            Console.WriteLine("Reprobado");
            reprobados++;
        }
    }

    static void MostrarResumen(double suma, int aprobados, int reprobados)
    {
        double promedio = suma / 5;

        Console.WriteLine("Resumen");
        Console.WriteLine($"Promedio: {promedio}");
        Console.WriteLine($"Aprobados: {aprobados}");
        Console.WriteLine($"Reprobados: {reprobados}");
    }

 
    // EJERCICIO 5
  
    static void Ejercicio5()
    {
        Console.WriteLine("Ejercicio 5");

        Console.Write("Ingrese número 1: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Ingrese número 2: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Antes: {a}, {b}");

        Intercambiar(ref a, ref b);

        Console.WriteLine($"Después: {a}, {b}");
    }

    static void Intercambiar(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
}












