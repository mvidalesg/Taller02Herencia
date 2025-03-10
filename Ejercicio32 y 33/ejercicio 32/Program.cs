using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el tamaño del rombo (número impar): ");
        int n = int.Parse(Console.ReadLine());

        // Validar que el tamaño sea un número impar
        if (n % 2 == 0)
        {
            Console.WriteLine("Por favor, ingrese un número impar.");
            return;
        }

        int mid = n / 2;
        int spacingMultiplier = 3; // Puedes ajustar este valor para modificar el espaciado y obtener el formato deseado

        // Recorremos cada fila (de 0 a n-1)
        for (int i = 0; i < n; i++)
        {
            // Calcular los espacios antes de la primera '#' en la fila actual
            int spacesBefore = Math.Abs(mid - i);

            // Calcular los espacios entre los dos '#' (solo para filas intermedias)
            int spacesBetween = n - 2 * spacesBefore - 2;

            // Generar la parte inicial de la fila
            string lead = new string(' ', spacesBefore * spacingMultiplier);

            if (spacesBetween < 0)
            {
                // Para la primera y la última fila (cuando solo hay un símbolo)
                Console.WriteLine(lead + "#");
            }
            else
            {
                // Para las filas intermedias, se imprime '#' + espacios + '#'
                string inner = new string(' ', spacesBetween * spacingMultiplier);
                Console.WriteLine(lead + "#" + inner + "#");
            }
        }
    }
}
