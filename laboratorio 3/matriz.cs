//Ejercicio 1:
//Crea una matriz de números aleatorios de tamaño 100x100.
using System;

namespace MatrizAleatoria
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definir el tamaño de la matriz
            int rows = 100;
            int columns = 100;

            // Crear la matriz
            int[,] matriz = new int[rows, columns];

            // Instanciar el generador de números aleatorios
            Random random = new Random();

            // Llenar la matriz con números aleatorios
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matriz[i][j] = random.Next(1, 101); // Genera números aleatorios entre 1 y 100
                }
            }

            // Imprimir la matriz (opcional)
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

////Ejercicio 2:
////Calcula la media, la mediana y la desviación estándar de los elementos de una matriz.
//using System;
//using System.Linq;

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

//        // Calcular la media
//        double media = CalcularMedia(matriz);

//        // Calcular la mediana
//        double mediana = CalcularMediana(matriz);

//        // Calcular la desviación estándar
//        double desviacionEstandar = CalcularDesviacionEstandar(matriz, media);

//        // Imprimir los resultados
//        Console.WriteLine($"La media de los elementos de la matriz es: {media}");
//        Console.WriteLine($"La mediana de los elementos de la matriz es: {mediana}");
//        Console.WriteLine($"La desviación estándar de los elementos de la matriz es: {desviacionEstandar}");
//    }

//    static double CalcularMedia(int[,] matriz)
//    {
//        int filas = matriz.GetLength(0);
//        int columnas = matriz.GetLength(1);
//        int suma = 0;

//        // Calcular la suma de todos los elementos de la matriz
//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                suma += matriz[i, j];
//            }
//        }

//        // Calcular el número total de elementos en la matriz
//        int totalElementos = filas * columnas;

//        // Calcular la media
//        double media = (double)suma / totalElementos;

//        return media;
//    }

//    static double CalcularMediana(int[,] matriz)
//    {
//        int filas = matriz.GetLength(0);
//        int columnas = matriz.GetLength(1);
//        int totalElementos = filas * columnas;
//        int[] elementos = new int[totalElementos];
//        int index = 0;

//        // Almacenar todos los elementos de la matriz en un array
//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                elementos[index++] = matriz[i, j];
//            }
//        }

//        // Ordenar el array
//        Array.Sort(elementos);

//        // Calcular la mediana
//        double mediana;
//        if (totalElementos % 2 == 0)
//        {
//            int medio1 = elementos[totalElementos / 2 - 1];
//            int medio2 = elementos[totalElementos / 2];
//            mediana = (medio1 + medio2) / 2.0;
//        }
//        else
//        {
//            mediana = elementos[totalElementos / 2];
//        }

//        return mediana;
//    }

//    static double CalcularDesviacionEstandar(int[,] matriz, double media)
//    {
//        int filas = matriz.GetLength(0);
//        int columnas = matriz.GetLength(1);
//        int totalElementos = filas * columnas;
//        double sumaCuadrados = 0;

//        // Calcular la suma de los cuadrados de las diferencias entre cada elemento y la media
//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                double diferencia = matriz[i, j] - media;
//                sumaCuadrados += diferencia * diferencia;
//            }
//        }

//        // Calcular la varianza
//        double varianza = sumaCuadrados / totalElementos;

//        // Calcular la desviación estándar como la raíz cuadrada de la varianza
//        double desviacionEstandar = Math.Sqrt(varianza);

//        return desviacionEstandar;
//    }
//}

////Ejercicio 3:
////Escribe una función que encuentre el elemento máximo de una matriz.
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Definir una matriz de ejemplo
//        int[,] matriz = {
//            { 1, 5, 3 },
//            { 8, 2, 4 },
//            { 6, 7, 9 }
//        };

//        // Encontrar el elemento máximo de la matriz
//        int maximo = EncontrarMaximo(matriz);

//        // Imprimir el resultado
//        Console.WriteLine($"El elemento máximo de la matriz es: {maximo}");
//    }

//    static int EncontrarMaximo(int[,] matriz)
//    {
//        int filas = matriz.GetLength(0);
//        int columnas = matriz.GetLength(1);
//        int maximo = matriz[0, 0];

//        // Recorrer la matriz para encontrar el elemento máximo
//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                if (matriz[i, j] > maximo)
//                {
//                    maximo = matriz[i, j];
//                }
//            }
//        }

//        return maximo;
//    }
//}

/// ejercicio 4
////Escribe una función que encuentre la submatriz de mayor suma de una matriz.
//using System;

//class Program
//{
//    static void Main()
//    {
//        // Ejemplo de matriz
//        int[,] matriz = {
//            { 1, 2, -1, 4, -20 },
//            { -8, -3, 4, 2, 1 },
//            { 3, 8, 10, -8, 3 },
//            { -4, -1, 1, 7, -6 }
//        };

//        // Encuentra la submatriz de mayor suma
//        int[,] submatrizMaxima = EncontrarSubmatrizMaxima(matriz);

//        // Imprime la submatriz de mayor suma
//        ImprimirMatriz(submatrizMaxima);
//    }

//    static int[,] EncontrarSubmatrizMaxima(int[,] matriz)
//    {
//        int filas = matriz.GetLength(0);
//        int columnas = matriz.GetLength(1);

//        // Variables para rastrear la mejor submatriz y su suma máxima
//        int maxSuma = int.MinValue;
//        int[,] mejorSubmatriz = null;

//        // Iterar sobre todas las submatrices posibles
//        for (int i = 0; i < filas; i++)
//        {
//            int[] temp = new int[columnas];
//            for (int j = i; j < filas; j++)
//            {
//                // Actualiza la suma temporal
//                for (int k = 0; k < columnas; k++)
//                {
//                    temp[k] += matriz[j, k];
//                }

//                // Encuentra la subsecuencia de suma máxima en temp[]
//                int inicio = 0, fin = 0;
//                int sumaTemp = temp[0], maxTemp = temp[0];
//                for (int k = 1; k < columnas; k++)
//                {
//                    if (temp[k] > temp[k] + maxTemp)
//                    {
//                        inicio = k;
//                        maxTemp = temp[k];
//                    }
//                    else
//                    {
//                        maxTemp += temp[k];
//                    }

//                    if (maxTemp > sumaTemp)
//                    {
//                        sumaTemp = maxTemp;
//                        fin = k;
//                    }
//                }

//                // Si la suma temporal es mayor que la máxima, actualiza
//                if (sumaTemp > maxSuma)
//                {
//                    maxSuma = sumaTemp;

//                    // Crear la submatriz de mayor suma
//                    mejorSubmatriz = new int[j - i + 1, fin - inicio + 1];
//                    for (int x = i, a = 0; x <= j; x++, a++)
//                    {
//                        for (int y = inicio, b = 0; y <= fin; y++, b++)
//                        {
//                            mejorSubmatriz[a, b] = matriz[x, y];
//                        }
//                    }
//                }
//            }
//        }

//        return mejorSubmatriz;
//    }

//    static void ImprimirMatriz(int[,] matriz)
//    {
//        int filas = matriz.GetLength(0);
//        int columnas = matriz.GetLength(1);

//        Console.WriteLine("Submatriz de mayor suma:");
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


////Ejercicio 5:
////Escribe una función que encuentre la matriz de covarianza de dos matrices.
//using System;

//class Program
//{
//    static void Main()
//    {
//        // Ejemplo de dos matrices
//        double[,] matriz1 = {
//            { 1, 2, 3 },
//            { 4, 5, 6 },
//            { 7, 8, 9 }
//        };

//        double[,] matriz2 = {
//            { 9, 8, 7 },
//            { 6, 5, 4 },
//            { 3, 2, 1 }
//        };

//        // Calcula la matriz de covarianza
//        double[,] covarianza = CalcularMatrizCovarianza(matriz1, matriz2);

//        // Imprime la matriz de covarianza
//        ImprimirMatriz(covarianza);
//    }

//    static double[,] CalcularMatrizCovarianza(double[,] matriz1, double[,] matriz2)
//    {
//        int filas = matriz1.GetLength(0);
//        int columnas = matriz1.GetLength(1);

//        // Verifica que ambas matrices tengan el mismo número de columnas
//        if (columnas != matriz2.GetLength(1))
//        {
//            throw new ArgumentException("Las matrices deben tener el mismo número de columnas.");
//        }

//        // Calcula las medias de cada columna en ambas matrices
//        double[] media1 = CalcularMediaPorColumna(matriz1);
//        double[] media2 = CalcularMediaPorColumna(matriz2);

//        // Inicializa la matriz de covarianza
//        double[,] covarianza = new double[columnas, columnas];

//        // Calcula la covarianza para cada par de columnas
//        for (int i = 0; i < columnas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                double sum = 0;
//                for (int k = 0; k < filas; k++)
//                {
//                    sum += (matriz1[k, i] - media1[i]) * (matriz2[k, j] - media2[j]);
//                }
//                covarianza[i, j] = sum / (filas - 1);
//            }
//        }

//        return covarianza;
//    }

//    static double[] CalcularMediaPorColumna(double[,] matriz)
//    {
//        int filas = matriz.GetLength(0);
//        int columnas = matriz.GetLength(1);

//        double[] medias = new double[columnas];

//        for (int j = 0; j < columnas; j++)
//        {
//            double suma = 0;
//            for (int i = 0; i < filas; i++)
//            {
//                suma += matriz[i, j];
//            }
//            medias[j] = suma / filas;
//        }

//        return medias;
//    }

//    static void ImprimirMatriz(double[,] matriz)
//    {
//        int filas = matriz.GetLength(0);
//        int columnas = matriz.GetLength(1);

//        Console.WriteLine("Matriz de covarianza:");
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