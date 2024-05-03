using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el tamaño del arreglo:");
        int tamano = Convert.ToInt32(Console.ReadLine());

        int[] arreglo = new int[tamano];

        // Solicitar al usuario que ingrese los elementos del arreglo
        for (int i = 0; i < tamano; i++)
        {
            Console.WriteLine($"Ingrese el elemento {i + 1}:");
            arreglo[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Calcular la suma de los elementos del arreglo
        int suma = 0;
        foreach (int num in arreglo)
        {
            suma += num;
        }

        // Mostrar la cantidad de elementos y la suma
        Console.WriteLine($"La cantidad de elementos del arreglo es: {tamano}");
        Console.WriteLine($"La suma de los elementos del arreglo es: {suma}");
    }
}
