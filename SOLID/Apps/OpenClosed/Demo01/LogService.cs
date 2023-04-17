public class LogService
{
	private readonly ILogger Logger;
	public LogService(ILogger Logger) => this.Logger = Logger;

	public void Write(Activity activity)
	{	
		Logger.Write(activity);
	}

	//En este ejemplo se atiende al principio de responsabilidad
	//unica, registrar las actividades eso lo hacemos con "Write", tenemos 
	//mas metodos, pero estan relacionados con la principal, por que todas 
	//hacen la misma funcion pero en direfentes salidad 


	//Es una guia 
	//Si solo tengo un metodo publico que indica la responsabilidad unica
	//y los demas privados pero que se utilizan dentro de la funcion principal 

	//Si una clase y cambio un metodo que afecta a otro, deben estar en una sola clase

	//Si pasamos los demas metodos a clases deferentes, al momento de hacer la llamada 
	//nos podemos ciclar al llamar clases 

	//Caundo tenemos las de 100 lineas debermos de ver si estamos cumpliendo 
	//los principios de responsabilidad unica y open-close
}