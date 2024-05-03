//Ejercicio parte 01: 
//Operaciones Básicas: 
//1) Realiza la suma, resta, multiplicación y división de dos números ingresados por el usuario. 
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el primer número:");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double suma = numero1 + numero2;
        double resta = numero1 - numero2;
        double multiplicacion = numero1 * numero2;
        double division = numero1 / numero2;

        Console.WriteLine($"La suma de {numero1} y {numero2} es: {suma}");
        Console.WriteLine($"La resta de {numero1} y {numero2} es: {resta}");
        Console.WriteLine($"La multiplicación de {numero1} y {numero2} es: {multiplicacion}");
        Console.WriteLine($"La división de {numero1} y {numero2} es: {division}");
    }
}
//Verificación de Número Par o Impar: 
//2) Solicita un número al usuario y determina si es par o impar. 

//Área de un Triángulo: 
//3) Pide la base y la altura de un triángulo al usuario y calcula su área. 

//Calculadora de Factorial: 
//4) Crea una función que calcule la factorial de un número. 

//Número Primo: 
//5) Verifica si un número ingresado por el usuario es primo o no. 

//Inversión de Cadena: 
//6) Toma una cadena de texto y muestra su inversión. 

//Suma de Números Pares: 
//7) Calcula la suma de los números pares en un rango especificado por el usuario. 

//Lista de Cuadrados: 
//8) Crea una lista de los cuadrados de los primeros 10 números naturales. 

//Contador de Vocales: 
//9) Cuenta el número de vocales en una cadena de texto. 

//Números de la Serie Fibonacci: 
//10) Genera los primeros 10 números de la serie Fibonacci. 


//Ordenamiento de Lista: 
//11) Ordena una lista de números ingresados por el usuario de menor a mayor. 

//Palíndromo: 
//12) Verifica si una palabra ingresada por el usuario es un palíndromo. 

//Generador de Tablas de Multiplicar: 
//13) Crea un programa que genere la tabla de multiplicar de un número ingresado por el usuario. 

//Cálculo del Área de un Círculo: 
//14) Pide el radio de un círculo al usuario y calcula su área. 

//Suma de Dígitos: 
//15) Toma un número entero y calcula la suma de sus dígitos. 

