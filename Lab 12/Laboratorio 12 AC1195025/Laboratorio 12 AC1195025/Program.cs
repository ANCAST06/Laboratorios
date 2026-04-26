using System;

class Program
{
    //EJERCICIO 1
    static void Main()
    {
        Console.WriteLine("EJERCICIO 1: Matriz 4x4");
        int[,] matriz1 = new int[4, 4];

        llenarMatriz(matriz1);
        Console.WriteLine("Matriz:");
        mostrarMatriz(matriz1, 4, 4);

        int fila = 0;
        do
        {
            Console.Write("Ingrese número de fila (0-3): ");
            if (int.TryParse(Console.ReadLine(), out fila) && fila >= 0 && fila < 4)
                break;
            Console.WriteLine("Fila inválida. Intente nuevamente.");
        } while (true);

        int col = 0;
        do
        {
            Console.Write("Ingrese número de columna (0-3): ");
            if (int.TryParse(Console.ReadLine(), out col) && col >= 0 && col < 4)
                break;
            Console.WriteLine("Columna inválida. Intente nuevamente.");
        } while (true);

        Console.WriteLine($"Suma fila {fila}: {sumaFila(matriz1, fila)}");
        Console.WriteLine($"Suma columna {col}: {sumaColumna(matriz1, col)}");
        Console.WriteLine();
    }

    static void llenarMatriz(int[,] m)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                while (!int.TryParse(Console.ReadLine(), out m[i, j]))
                {
                    Console.Write("Ingrese un número válido: ");
                }
            }
        }
    }

    static int sumaFila(int[,] m, int fila)
    {
        int suma = 0;
        for (int j = 0; j < 4; j++)
            suma += m[fila, j];
        return suma;
    }

    static int sumaColumna(int[,] m, int col)
    {
        int suma = 0;
        for (int i = 0; i < 4; i++)
            suma += m[i, col];
        return suma;
    }

    //EJERCICIO 2
    static void Ejercicio2()
    {
        Console.WriteLine("EJERCICIO 2: Matriz 3x5 (float)");
        float[,] matriz2 = new float[3, 5];

        cargarMatriz(matriz2);
        Console.WriteLine("Matriz:");
        mostrarMatrizFloat(matriz2, 3, 5);

        float mayor = mayorMatriz(matriz2);
        Console.WriteLine($"Mayor valor: {mayor}");
        Console.WriteLine();
    }

    static void cargarMatriz(float[,] m)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                while (!float.TryParse(Console.ReadLine(), out m[i, j]))
                {
                    Console.Write("Ingrese un número válido: ");
                }
            }
        }
    }

    static float mayorMatriz(float[,] m)
    {
        float mayor = m[0, 0];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (m[i, j] > mayor)
                    mayor = m[i, j];
            }
        }
        return mayor;
    }

    //EJERCICIO 3
    static void Ejercicio3()
    {
        Console.WriteLine("EJERCICIO 3: Multiplicación de matrices 3x2");
        int[,] A = new int[3, 2];
        int[,] B = new int[3, 2];
        int[,] R = new int[3, 2];

        Console.WriteLine("Llenando matriz A:");
        llenarMatriz32(A);
        Console.WriteLine("Llenando matriz B:");
        llenarMatriz32(B);

        Console.WriteLine("Matriz A:");
        mostrarMatriz(A, 3, 2);
        Console.WriteLine("Matriz B:");
        mostrarMatriz(B, 3, 2);

        multiplicar(A, B, R);
        Console.WriteLine("Matriz Resultante R:");
        mostrarMatriz(R, 3, 2);
        Console.WriteLine();
    }

    static void llenarMatriz32(int[,] m)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                while (!int.TryParse(Console.ReadLine(), out m[i, j]))
                {
                    Console.Write("Ingrese un número válido: ");
                }
            }
        }
    }

    static void multiplicar(int[,] A, int[,] B, int[,] R)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                R[i, j] = A[i, 0] * B[0, j] + A[i, 1] * B[1, j];
            }
        }
    }

    //EJERCICIO 4
    static void Ejercicio4()
    {
        Console.WriteLine("EJERCICIO 4: Diagonal 5x5");
        int[,] matriz4 = new int[5, 5];

        llenarMatriz5x5(matriz4);
        Console.WriteLine("Matriz:");
        mostrarMatriz(matriz4, 5, 5);

        int diagPrincipal = sumaDiagonalPrincipal(matriz4);
        int diagSecundaria = sumaDiagonalSecundaria(matriz4);

        Console.WriteLine($"Suma Diagonal Principal: {diagPrincipal}");
        Console.WriteLine($"Suma Diagonal Secundaria: {diagSecundaria}");
    }

    static void llenarMatriz5x5(int[,] m)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                while (!int.TryParse(Console.ReadLine(), out m[i, j]))
                {
                    Console.Write("Ingrese un número válido: ");
                }
            }
        }
    }

    static int sumaDiagonalPrincipal(int[,] m)
    {
        int suma = 0;
        for (int i = 0; i < 5; i++)
            suma += m[i, i];
        return suma;
    }

    static int sumaDiagonalSecundaria(int[,] m)
    {
        int suma = 0;
        for (int i = 0; i < 5; i++)
            suma += m[i, 4 - i];
        return suma;
    }

    //FUNCIONES AUXILIARES
    static void mostrarMatriz(int[,] m, int filas, int cols)
    {
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write($"{m[i, j],4} ");
            Console.WriteLine();
        }
    }

    static void mostrarMatrizFloat(float[,] m, int filas, int cols)
    {
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write($"{m[i, j],8:F2} ");
            Console.WriteLine();
        }
    }
}