using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.WriteLine("Bienvenido(a), " + nombre);
        Console.WriteLine("MENÚ DE EJERCICIOS");
        Console.WriteLine("1. Validación de contraseña");
        Console.WriteLine("2. Invertir texto");
        Console.WriteLine("3. Suma y promedio de números");
        Console.WriteLine("4. Buscar número en arreglo");
        Console.WriteLine("5. Nombres en arreglo");
        Console.Write("Seleccione ejercicio (1-5): ");

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Ejercicio1_ValidacionContraseña();
                break;
            case 2:
                Ejercicio2_InvertirTexto();
                break;
            case 3:
                Ejercicio3_SumaPromedio();
                break;
            case 4:
                Ejercicio4_BuscarNumero();
                break;
            case 5:
                Ejercicio5_NombresArreglo();
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }

    // EJERCICIO 1: Validación de contraseña
    static void Ejercicio1_ValidacionContraseña()
    {
        Console.Write("Ingrese la contraseña: ");
        string contraseña = Console.ReadLine();

        bool esLarga = contraseña.Length >= 8;
        bool tieneMayuscula = false;
        bool tieneNumero = false;
        bool tieneEspecial = false;

        string caracteresEspeciales = "@#$%";

        foreach (char c in contraseña)
        {
            if (char.IsUpper(c)) tieneMayuscula = true;
            if (char.IsDigit(c)) tieneNumero = true;
            if (caracteresEspeciales.Contains(c)) tieneEspecial = true;
        }

        if (esLarga && tieneMayuscula && tieneNumero && tieneEspecial)
        {
            Console.WriteLine("Contraseña válida");
        }
        else
        {
            Console.Write("Inválida: falta ");
            if (!esLarga) Console.Write("longitud ");
            if (!tieneMayuscula) Console.Write("mayúscula ");
            if (!tieneNumero) Console.Write("número ");
            if (!tieneEspecial) Console.Write("carácter especial");
            Console.WriteLine();
        }
    }

    // EJERCICIO 2: Invertir texto
    static void Ejercicio2_InvertirTexto()
    {
        Console.Write("Ingrese el texto: ");
        string texto = Console.ReadLine();

        string textoInvertido = "";
        for (int i = texto.Length - 1; i >= 0; i--)
        {
            textoInvertido += texto[i];
        }

        Console.WriteLine("Texto invertido: " + textoInvertido);
    }

    // EJERCICIO 3: Suma y promedio
    static void Ejercicio3_SumaPromedio()
    {
        Console.Write("¿Cuántos números desea ingresar? ");
        int cantidad = int.Parse(Console.ReadLine());

        int[] numeros = new int[cantidad];

        Console.WriteLine("Ingrese los " + cantidad + " números:");
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int suma = 0;
        int mayor = numeros[0];
        int menor = numeros[0];

        foreach (int num in numeros)
        {
            suma += num;
            if (num > mayor) mayor = num;
            if (num < menor) menor = num;
        }

        double promedio = (double)suma / cantidad;

        Console.WriteLine($"Suma = {suma}, Promedio = {promedio:F0}, Mayor = {mayor}, Menor = {menor}");
    }

    // EJERCICIO 4: Buscar número
    static void Ejercicio4_BuscarNumero()
    {
        int[] arreglo = new int[8];

        Console.WriteLine("Ingrese 8 números para el arreglo:");
        for (int i = 0; i < 8; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            arreglo[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Número a buscar: ");
        int numeroBuscar = int.Parse(Console.ReadLine());

        bool encontrado = false;
        for (int i = 0; i < 8; i++)
        {
            if (arreglo[i] == numeroBuscar)
            {
                Console.WriteLine($"El número sí existe en la posición {i}");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("El número no existe en el arreglo");
        }
    }

    // EJERCICIO 5: Nombres en arreglo
    static void Ejercicio5_NombresArreglo()
    {
        string[] nombres = new string[5];

        Console.WriteLine("Ingrese 5 nombres:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Nombre " + (i + 1) + ": ");
            nombres[i] = Console.ReadLine();
        }

        // Mostrar todos los nombres
        Console.Write("Nombres ingresados: ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(nombres[i]);
            if (i < 4) Console.Write(", ");
        }

        // Contar nombres con más de 5 letras
        int countLargos = 0;
        string nombreMasLargo = nombres[0];

        for (int i = 0; i < 5; i++)
        {
            if (nombres[i].Length > 5) countLargos++;
            if (nombres[i].Length > nombreMasLargo.Length)
            {
                nombreMasLargo = nombres[i];
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Más de 5 letras: {countLargos} / Nombre más largo: {nombreMasLargo}");
    }
}