public class LogService
{
    public void Write(Activity activity)
    {
        //TODO: Codigo para registrar la actividad
        Console.WriteLine("{0}, {1}, {2}", activity.CreatedDate, activity.Module, activity.Message);
    }
}
//Clase que solo tiene una unica tarea, imprimir el historial