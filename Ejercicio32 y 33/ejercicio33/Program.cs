using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar los valores de m, n y p
        Console.Write("Ingrese el valor de m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el valor de n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el valor de p: ");
        int p = int.Parse(Console.ReadLine());

        // Declarar las matrices:
        // A de dimensiones m x n
        // B de dimensiones n x p
        // C de dimensiones m x p
        int[,] A = new int[m, n];
        int[,] B = new int[n, p];
        int[,] C = new int[m, p];

        // Llenar la matriz A utilizando la fórmula: A[i, j] = (i+1) * j
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                A[i, j] = (i + 1) * j;
            }
        }

        // Llenar la matriz B utilizando la fórmula: B[i, j] = i * (j+1)
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < p; j++)
            {
                B[i, j] = i * (j + 1);
            }
        }

        // Calcular la matriz producto C = A * B
        // C[i, j] = suma desde k=0 hasta n-1 de (A[i, k] * B[k, j])
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < p; j++)
            {
                int suma = 0;
                for (int k = 0; k < n; k++)
                {
                    suma += A[i, k] * B[k, j];
                }
                C[i, j] = suma;
            }
        }

        // Imprimir la matriz A
        Console.WriteLine("\n*** A ***");
        ImprimirMatriz(A, m, n);

        // Imprimir la matriz B
        Console.WriteLine("\n*** B ***");
        ImprimirMatriz(B, n, p);

        // Imprimir la matriz C
        Console.WriteLine("\n*** C ***");
        ImprimirMatriz(C, m, p);
    }

    // Método auxiliar para imprimir una matriz
    static void ImprimirMatriz(int[,] matriz, int filas, int columnas)
    {
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

