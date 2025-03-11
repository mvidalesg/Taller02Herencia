using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el tamaño del rombo: ");
        int n = int.Parse(Console.ReadLine());

        // Verificar que el número sea impar
        if (n % 2 == 0)
        {
            Console.WriteLine("El tamaño debe ser un número impar.");
            return;
        }

        char[,] r = new char[n, n];

        // Llenamos el rombo con espacios en blanco
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                r[i, j] = ' ';
            }
        }

        // Lógica para dibujar el rombo
        int m = n / 2;
        for (int i = 0; i <= m; i++)
        {
            r[i, m - i] = '#';
            r[i, m + i] = '#';
            r[n - i - 1, m - i] = '#';
            r[n - i - 1, m + i] = '#';
        }

        // Mostrar el rombo
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(r[i, j]);
            }
            Console.WriteLine();
        }
    }
}
