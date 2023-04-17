class EvenNumbersSumCalcular : SumCalculator
{
    public EvenNumbersSumCalcular(int[] Numbers) : base(Numbers:Numbers){}

    public new int Calculate() => Numbers.Where(n => n%2 ==0).Sum();
}

//Si ponemos un metodo con el mismo nombre debemos o sobre escribirlo o poner
//la palabra new, "new es para ocultar el metodo del padre", de lo contrario
//tambien lo oculta pero lanza la advertencia.
// public new int Calculate() => Numbers.Where(n => n%2 ==0).Sum();