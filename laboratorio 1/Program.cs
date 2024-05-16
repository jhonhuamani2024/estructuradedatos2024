// suma de n primeros numeros 
//var n = 8;
//var suma = 0;
//for (var i = 1; i <= n; i++)
//{
//    suma += i;
//}
//Console.WriteLine($"la suma de los {n} numeros naturales son:{suma}");

// con entrada de datos mediannte consola
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer numero a operarar:");
        double n = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero a operar:");
        double n1= Convert.ToDouble(Console.ReadLine());

        Double suma = n + n1;
        double resta = n - n1;
        double multiplicacion = n * n1;
        double division = n / n1;
        Console.WriteLine($"La suma de {n1} y {n} es: {suma}");
        Console.WriteLine($"La resta de {n1} y {n} es: {resta}");
        Console.WriteLine($"La multiplicación de {n1} y {n} es: {multiplicacion}");
        Console.WriteLine($"La división de {n1} y {n} es: {division}");
    }
}



1) 
