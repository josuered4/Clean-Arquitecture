// See https://aka.ms/new-console-template for more information
class Program
{

    public static void Main(string[] Args)
    {
        Console.WriteLine("Hello, World!");

        var Numbers = new int[]{1,2,3,4,5};
        SumCalculator sum = new(Numbers);
        Console.WriteLine($"suma de numeros: {sum.Calculate()}");

        EvenNumbersSumCalcular Even = new EvenNumbersSumCalcular(Numbers);
        Console.WriteLine($"suma de numeros pares: {Even.Calculate()}");

        Console.WriteLine("Principio de sustitucion");
        sum = new EvenNumbersSumCalcular(Numbers);
        Console.WriteLine($"suma de numeros pares: {sum.Calculate()}");
    }

}

//Violacion del principio
// Al momento de sustituir el valor de un padre por una clase hija 
// se debe de usar el valor y funciones de la clase hija.