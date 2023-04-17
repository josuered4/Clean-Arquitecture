public class ProductService
{
    readonly LogService logService;
    //constructor
    public ProductService(LogService LogService) => this.logService = LogService;
    
    public void Create(Product product)
    {
        //TODO : Codigo para crear el producto
        //...

        //Registrar la actividad 
        var Activity = new Activity
        {
            Message = $"Producto agregado {product.Id}", 
            Module = nameof(Create)
        };
        logService.Write(Activity);
    }
}
//Funcion de responsabilidad unica, Crear un prducto 
    //y registar la actividad