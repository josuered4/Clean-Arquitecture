class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        Activity activity = new(){
            Message = "Hola Mundo!!!"
        };

        ConsoleLogger consoleLogger = new();
        LogService log = new(consoleLogger);
        log.Write(activity);

        FileLogger fileLogger = new();
        LogService logTwo = new(fileLogger);
        logTwo.Write(activity);
    }
}
