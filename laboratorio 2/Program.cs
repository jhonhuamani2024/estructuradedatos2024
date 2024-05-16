
////Recursividad:
////1) Ejercicio 1: Escribe una función recursiva que imprima los números pares del 1 al 100.
//class Pares
//{
//    static void Main(string[] args)
//    {
//        PrintEvenNumbers(1);
//    }
//    static void PrintEvenNumbers(int n)
//    {
//        if (n <= 100)
//        {
//            if (n % 2 == 0)
//            {
//                Console.WriteLine(n);
//            }
//            PrintEvenNumbers(n + 1);
//        }
//    }
//}

//2) Ejercicio 2: Escribe una función recursiva que imprima la suma de los números del 1 al n.
class suma
{
    static void Main(string[] args)
    {
        int n = 10; //podemos cambiar con cualquier numero que necesitemos  
        Console.WriteLine($"La suma de los números del 1 al {n} es: {SumNumeros(1, n)}");
    }

    static int SumNumeros(int start, int end)
    {
        if (start == end)
        {
            return start;
        }
        else
        {
            return start + SumNumeros(start + 1, end);
        }
    }
}


////3) Ejercicio 3: Escribe una función recursiva que imprima la pirámide de números del 1 al n.
//class priramide
//{
//    static void Main(string[] args)
//    {
//        int n = 100; // Puedes cambiar el valor de n según tus necesidades
//        Console.WriteLine($"La suma de los números del 1 al {n} es: {SumNumbers(1, n)}");
//    }

//    static int SumNumbers(int start, int end)
//    {
//        if (start == end)
//        {
//            return start;
//        }
//        else
//        {
//            return start + SumNumbers(start + 1, end);
//        }
//    }
//}

////4) Ejercicio 4: Escribe una función recursiva que imprima la pirámide de números invertidos del 1 al n.
//class invertido
//{
//    static void Main(string[] args)
//    {
//        int n = 5; // Puedes cambiar el valor de n según tus necesidades
//        PrintInvertedPyramid(n, n);
//    }

//    static void PrintInvertedPyramid(int current, int n)
//    {
//        if (current == 0)
//            return;

//        PrintRow(n - current + 1, current);
//        PrintInvertedPyramid(current - 1, n);
//    }

//    static void PrintRow(int start, int end)
//    {
//        if (start > end)
//            return;

//        Console.Write($"{end - start + 1} ");
//        PrintRow(start + 1, end);
//    }
//}
