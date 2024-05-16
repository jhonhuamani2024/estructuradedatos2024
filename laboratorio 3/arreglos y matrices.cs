//Arreglos y Matrices:
//6) Crea una matriz de números reales.

//using System.Numerics;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Crear una matriz de números reales de 2x3
//        double[,] matriz = new double[2, 3];

//        // Asignar valores a la matriz
//        matriz[0, 0] = 1.5;
//        matriz[0, 1] = 2.3;
//        matriz[0, 2] = 3.7;
//        matriz[1, 0] = 4.2;
//        matriz[1, 1] = 5.1;
//        matriz[1, 2] = 6.9;

//        // Imprimir la matriz
//        Console.WriteLine("Matriz de números reales:");
//        for (int i = 0; i < 2; i++)
//        {
//            for (int j = 0; j < 3; j++)
//            {
//                Console.Write(matriz[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}

////7) Crea una matriz de números complejos.
//using System;
//using System.Numerics;

//class Program
//{
//    static void Main()
//    {
//        // Definir las dimensiones de la matriz
//        int filas = 3;
//        int columnas = 3;

//        // Crear una matriz de números complejos
//        Complex[,] matrizCompleja = new Complex[filas, columnas];

//        // Rellenar la matriz con números complejos
//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                // Puedes asignar números complejos directamente con la clase Complex
//                matrizCompleja[i, j] = new Complex(i + 1, j + 1); // Por ejemplo, (1 + 1i), (2 + 2i), etc.
//            }
//        }

//        // Imprimir la matriz
//        Console.WriteLine("Matriz de números complejos:");
//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                Console.Write(matrizCompleja[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}

////8) Crea una matriz de matrices.
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Crear una matriz de matrices de enteros de 2x2
//        int[][,] matrizDeMatrices = new int[2][,];

//        // Asignar valores a las matrices internas
//        matrizDeMatrices[0] = new int[2, 2] { { 1, 2 }, { 3, 4 } };
//        matrizDeMatrices[1] = new int[3, 3] { { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

//        // Imprimir las matrices
//        Console.WriteLine("Matriz de matrices de enteros:");
//        for (int i = 0; i < matrizDeMatrices.Length; i++)
//        {
//            Console.WriteLine($"Matriz {i + 1}:");
//            for (int j = 0; j < matrizDeMatrices[i].GetLength(0); j++)
//            {
//                for (int k = 0; k < matrizDeMatrices[i].GetLength(1); k++)
//                {
//                    Console.Write(matrizDeMatrices[i][j, k] + " ");
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine();
//        }
//    }
//}

////9) Accede al elemento central de una matriz.
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Definir una matriz de ejemplo
//        int[,] matriz = {
//            { 1, 2, 3 },
//            { 4, 5, 6 },
//            { 7, 8, 9 }
//        };

//        // Calcular las coordenadas del elemento central
//        int filaCentral = matriz.GetLength(0) / 2;
//        int columnaCentral = matriz.GetLength(1) / 2;

//        // Acceder al elemento central
//        int elementoCentral = matriz[filaCentral, columnaCentral];

//        // Imprimir el elemento central
//        Console.WriteLine($"El elemento central de la matriz es: {elementoCentral}");
//    }
//}

////10) Suma dos matrices de diferentes tamaños.
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Definir dos matrices de diferentes tamaños
//        int[,] matriz1 = {
//            { 1, 2, 3 },
//            { 4, 5, 6 }
//        };

//        int[,] matriz2 = {
//            { 7, 8 },
//            { 9, 10 }
//        };

//        // Verificar si las matrices tienen el mismo tamaño
//        if (matriz1.GetLength(0) != matriz2.GetLength(0) || matriz1.GetLength(1) != matriz2.GetLength(1))
//        {
//            Console.WriteLine("No se pueden sumar las matrices porque tienen diferentes tamaños.");
//            return;
//        }

//        // Sumar las matrices
//        int[,] resultado = SumarMatrices(matriz1, matriz2);

//        // Imprimir la matriz resultante
//        Console.WriteLine("La suma de las matrices es:");
//        ImprimirMatriz(resultado);
//    }

//    static int[,] SumarMatrices(int[,] matriz1, int[,] matriz2)
//    {
//        int filas = matriz1.GetLength(0);
//        int columnas = matriz1.GetLength(1);
//        int[,] resultado = new int[filas, columnas];

//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                resultado[i, j] = matriz1[i, j] + matriz2[i, j];
//            }
//        }

//        return resultado;
//    }

//    static void ImprimirMatriz(int[,] matriz)
//    {
//        int filas = matriz.GetLength(0);
//        int columnas = matriz.GetLength(1);

//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                Console.Write(matriz[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}

////11) Multiplica una matriz por un número.

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Definir una matriz
//        int[,] matriz = {
//            { 1, 2, 3 },
//            { 4, 5, 6 },
//            { 7, 8, 9 }
//        };

//        // Definir el número por el que se multiplicará la matriz
//        int numero = 9;

//        // Multiplicar la matriz por el número
//        int[,] resultado = MultiplicarMatrizPorNumero(matriz, numero);

//        // Imprimir la matriz resultante
//        Console.WriteLine("Matriz resultante:");
//        ImprimirMatriz(resultado);
//    }

//    static int[,] MultiplicarMatrizPorNumero(int[,] matriz, int numero)
//    {
//        int filas = matriz.GetLength(0);
//        int columnas = matriz.GetLength(1);
//        int[,] resultado = new int[filas, columnas];

//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                resultado[i, j] = matriz[i, j] * numero;
//            }
//        }

//        return resultado;
//    }

//    static void ImprimirMatriz(int[,] matriz)
//    {
//        int filas = matriz.GetLength(0);
//        int columnas = matriz.GetLength(1);

//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                Console.Write(matriz[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//12) Calcula la media de los elementos de una matriz.

class media
{
    static void Main(string[] args)
    {
        // Definir una matriz
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 9, 6 },
            { 7, 8, 9 }
        };

        // Calcular la media de los elementos de la matriz
        double media = CalcularMedia(matriz);

        // Imprimir la media
        Console.WriteLine($"La media de los elementos de la matriz es: {media}");
    }

    static double CalcularMedia(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int suma = 0;

        // Calcular la suma de todos los elementos de la matriz
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                suma += matriz[i, j];
            }
        }

        // Calcular el número total de elementos en la matriz
        int totalElementos = filas * columnas;

        // Calcular la media
        double media = (double)suma / totalElementos;

        return media;
    }
}
