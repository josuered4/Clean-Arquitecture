public class ConsoleLogger : ILogger
{
    public void Write(Activity activity){
        Console.WriteLine(activity.Message);
    }
}