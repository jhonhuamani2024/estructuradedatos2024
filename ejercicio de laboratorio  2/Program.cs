//Ejercicio parte 01: 
//Operaciones Básicas: 
//1) Realiza la suma, resta, multiplicación y división de dos números ingresados por el usuario. 
class operaciones
{
    static void Main() 
    {
        Console.WriteLine("Ingrese el primer número:");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        double n2 = Convert.ToDouble(Console.ReadLine());

        double suma = n1 + n2;
        double resta = n1 - n2;
        double multiplicacion = n1 * n2;
        double division = n1 / n2;

        Console.WriteLine($"La suma de {n1} y {n2} es: {suma}");
        Console.WriteLine($"La resta de {n1} y {n2} es: {resta}");
        Console.WriteLine($"La multiplicación de {n1} y {n2} es: {multiplicacion}");
        Console.WriteLine($"La división de {n1} y {n2} es: {division}");
    }
}
//Verificación de Número Par o Impar: 
//2) Solicita un número al usuario y determina si es par o impar. 

class verificacion
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número:");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0) // este va comprobar si es par o impar 
        {
            Console.WriteLine("El número ingresado es par.");
        }
        else
        {
            Console.WriteLine("El número ingresado es impar.");
        }
    }
}

////Área de un Triángulo: 
////3) Pide la base y la altura de un triángulo al usuario y calcula su área. 

class area
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la base del triángulo:");
        double baseTriangulo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la altura del triángulo:");
        double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

        double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

        Console.WriteLine("El área del triángulo es: " + areaTriangulo);
    }
}
////Calculadora de Factorial: 
////4) Crea una función que calcule la factorial de un número. 
class factorial
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa un número para calcular su factorial: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        long factorial = CalcularFactorial(numero);
        Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }

    static long CalcularFactorial(int n)
    {
        if (n == 0)
            return 1;

        long factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}


////Número Primo: 
////5) Verifica si un número ingresado por el usuario es primo o no. 

class primos
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número para verificar si es primo:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.WriteLine($"{number} es un número primo.");
        }
        else
        {
            Console.WriteLine($"{number} no es un número primo.");
        }
    }

    static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;

        if (n <= 3)
            return true;

        if (n % 2 == 0 || n % 3 == 0)
            return false;

        for (int i = 5; i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0)
                return false;
        }

        return true;
    }
}

////Inversión de Cadena: 
////6) Toma una cadena de texto y muestra su inversión. 

class inversion
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una cadena de texto:");
        string input = Console.ReadLine();

        string reversedString = ReverseString(input);

        Console.WriteLine($"La cadena invertida es: {reversedString}");
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

////Suma de Números Pares: 
////7)  Calcula la suma de los números pares en un rango especificado por el usuario

class pares
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el valor inicial del rango:");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el valor final del rango:");
        int end = Convert.ToInt32(Console.ReadLine());

        int sumOfEvenNumbers = SumOfEvenNumbers(start, end);

        Console.WriteLine($"La suma de los números pares en el rango [{start}, {end}] es: {sumOfEvenNumbers}");
    }

    static int SumOfEvenNumbers(int start, int end)
    {
        int sum = 0;
        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }
}

////Lista de Cuadrados: 
////8) Crea una lista de los cuadrados de los primeros 10 números naturales. 

class lista
{
    static void Main(string[] args)
    {
        List<int> squares = GetSquaresOfFirstNaturals(10);

        Console.WriteLine("Los cuadrados de los primeros 10 números naturales son:");
        foreach (int square in squares)
        {
            Console.WriteLine(square);
        }
    }

    static List<int> GetSquaresOfFirstNaturals(int n)
    {
        List<int> squares = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            squares.Add(i * i);
        }
        return squares;
    }
}

////Contador de Vocales: 
////9) Cuenta el número de vocales en una cadena de texto. 

class vocales
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una cadena de texto:");
        string input = Console.ReadLine();

        int vowelCount = CountVowels(input);

        Console.WriteLine($"El número de vocales en la cadena es: {vowelCount}");
    }

    static int CountVowels(string str)
    {
        int count = 0;
        foreach (char c in str)
        {
            if (IsVowel(c))
            {
                count++;
            }
        }
        return count;
    }

    static bool IsVowel(char c)
    {
        c = char.ToLower(c);
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}

////Números de la Serie Fibonacci: 
////10) Genera los primeros 10 números de la serie Fibonacci. 

class fibonacci
{
    static void Main(string[] args)
    {
        int n = 10;
        Console.WriteLine($"Los primeros {n} números de la serie Fibonacci son:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        int a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            int temp = b;
            b = a + b;
            a = temp;
        }
        return b;
    }
}

////Ordenamiento de Lista: 
////11) Ordena una lista de números ingresados por el usuario de menor a mayor. 

class ordenamiento
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una lista de números separados por espacios:");
        string input = Console.ReadLine();

        // Dividir la cadena de entrada en números individuales
        string[] numbersStr = input.Split(' ');

        // Convertir los números de cadena a tipo int
        List<int> numbers = new List<int>();
        foreach (string numberStr in numbersStr)
        {
            if (int.TryParse(numberStr, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine($"'{numberStr}' no es un número válido y será ignorado.");
            }
        }

        // Ordenar la lista de números
        numbers.Sort();

        // Mostrar la lista ordenada
        Console.WriteLine("Lista ordenada de menor a mayor:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}

////Palíndromo: 
////12) Verifica si una palabra ingresada por el usuario es un palíndromo. 

class palindromo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una palabra para verificar si es un palíndromo:");
        string word = Console.ReadLine();

        if (IsPalindrome(word))
        {
            Console.WriteLine($"{word} es un palíndromo.");
        }
        else
        {
            Console.WriteLine($"{word} no es un palíndromo.");
        }
    }

    static bool IsPalindrome(string str)
    {
        // Eliminar los espacios y convertir la palabra a minúsculas para una comparación sin distinción entre mayúsculas y minúsculas
        str = str.Replace(" ", "").ToLower();

        // Comprobar si la palabra es un palíndromo
        int left = 0;
        int right = str.Length - 1;
        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}

////Generador de Tablas de Multiplicar: 
////13) Crea un programa que genere la tabla de multiplicar de un número ingresado por el usuario. 

class multiplicacion
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número para generar su tabla de multiplicar:");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Tabla de multiplicar del número {number}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
}

////Cálculo del Área de un Círculo: 
////14) Pide el radio de un círculo al usuario y calcula su área. 

class area
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el radio del círculo:");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = CalculateCircleArea(radius);

        Console.WriteLine($"El área del círculo con radio {radius} es: {area}");
    }

    static double CalculateCircleArea(double radius)
    {
        // Calcula el área del círculo usando la fórmula A = π * r^2
        double area = Math.PI * Math.Pow(radius, 2);
        return area;
    }
}

////Suma de Dígitos: 
////15) Toma un número entero y calcula la suma de sus dígitos. 

class sumadigito
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número entero:");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = SumOfDigits(number);

        Console.WriteLine($"La suma de los dígitos de {number} es: {sum}");
    }

    static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10; // Obtiene el último dígito y lo suma al total
            number /= 10; // Elimina el último dígito del número
        }
        return sum;
    }
}

