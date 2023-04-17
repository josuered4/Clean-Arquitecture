abstract class Calculator
{
    protected readonly int[] Numbers;
    public Calculator(int[] numbers) => this.Numbers = numbers;

    public abstract int Calculate();
}

//Para no violar el principio de Liskoc
//Nosotros podriamos crear clases abstractas 
//Para despues sobre escribir los metodos 
//hora bien ya no usamo virtual, si no override.

//Al momento de poner un solo metodo, e implementando 
//funcionalidad ya no puede ser una interfaz, en este 
//caso con se implementa con un capo y el constructor