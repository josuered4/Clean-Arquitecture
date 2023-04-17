public class FileLogger : ILogger
{
    public void Write(Activity activity)
    {
        System.IO.File.AppendText(activity.Message);
    }
}