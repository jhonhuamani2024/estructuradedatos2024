//1) generar una torre triangular de cualquier numero de pisos 20 pisos 
using System;

class triangular
{
    static void Main()
    {
        int numeroPisos = 20;
        generamosdeformatriangular(numeroPisos);
    }

    static void generamosdeformatriangular(int pisos)
    {
        for (int i = 1; i <= pisos; i++)
        {

            for (int j = 0; j < pisos - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < (2 * i - 1); k++)
            {
                Console.Write("1");
            }

            Console.WriteLine();
        }
    }
}

//2) crear y asignar valores por consola a una matriz de 4 dimenciones por pantalla
using System;

class matriz
{
    static void Main()
    {
        int[,] matriz = new int[4, 4];

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Ingrese el valor para matriz[{i},{j}]: ");
                while (!int.TryParse(Console.ReadLine(), out matriz[i, j]))
                {
                    Console.Write("Entrada no válida. Ingrese un número entero: ");
                }
            }
        }

        Console.WriteLine("Valores de la matriz 4x4:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}


3) crear una matriz que guarde los 50 primeros numeros primos y luego mostrar en pantalla entre comas 
using System;

class primos
{
    static void Main()
    {
        int[] numeroPrimo = new int[50];
        int contador = 0;
        int numero = 2;

        while (contador < 50)
        {
            if (esPrimo(numero))
            {
                numeroPrimo[contador] = numero;
                contador++;
            }
            numero++;
        }

        Console.WriteLine("Los primeros 50 números primos son:");
        Console.WriteLine(string.Join(", ", numeroPrimo));
    }

    static bool esPrimo(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}

4) ingresar el numero de inicio y fin de un rango de numeros, se pide calcular la cantidad de numeros pares, impares y divisores de 5 y 7.
using System;

class parImDiv
{
    static void Main()
    {
        Console.Write("Ingrese el número de inicio del rango: ");
        int inicioRango = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el número de fin del rango: ");
        int finRango = int.Parse(Console.ReadLine());
        Console.WriteLine("numeros pares");
        for (int i = inicioRango; i <= finRango; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine("numeros impares");
        for (int i = inicioRango; i <= finRango; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine("numeros divisible por 5");
        for (int i = inicioRango; i <= finRango; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine("numeros divisible por 7");
        for (int i = inicioRango; i <= finRango; i++)
        {
            if (i % 7 == 0)
            {
                Console.WriteLine(i);
            }
        }
        int contadordePares = 0;
        int contadorInpares = 0;
        int contadorDiv5 = 0;
        int contadorDiv7 = 0;

        for (int i = inicioRango; i <= finRango; i++)
        {
            if (i % 2 == 0)
            {
                contadordePares++;
            }
            else
            {
                contadorInpares++;
            }

            if (i % 5 == 0)
            {
                contadorDiv5++;
            }

            if (i % 7 == 0)
            {
                contadorDiv7++;
            }
        }

        Console.WriteLine($"Cantidad de números pares: {contadordePares}");
        Console.WriteLine($"Cantidad de números impares: {contadorInpares}");
        Console.WriteLine($"Cantidad de números divisibles por 5: {contadorDiv5}");
        Console.WriteLine($"Cantidad de números divisibles por 7: {contadorDiv7}");
    }
}
