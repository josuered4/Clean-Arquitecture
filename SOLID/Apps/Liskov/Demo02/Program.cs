// See https://aka.ms/new-console-template for more information
class Program
{

    public static void Main(string[] Args)
    {
        Console.WriteLine("Hello, World!");
        var Numbers = new int[]{1,2,3,4,5};

        Calculator Base; //Este es una instancia de la clase padre
        Base = new SumCalculator(Numbers); //se le asigna el valor de la clase hija 
        Console.WriteLine($"suma de numeros: {Base.Calculate()}");

        
        Base = new EvenNumbersSumCalculator(Numbers);
        Console.WriteLine($"suma de numeros: {Base.Calculate()}");

    }

}

//En este caso no se viola el principio
//Por que apesar de que podemos usar las clases hijas como 
//si se tratase del padre, casa una implementa su funcionamiento 
//a como lo requieren.
