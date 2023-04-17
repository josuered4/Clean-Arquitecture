class EvenNumbersSumCalculator : Calculator
{
    public EvenNumbersSumCalculator(int[] Numbers):base(numbers: Numbers){}
    public override int Calculate()=> Numbers.Where(n => n % 2 == 0).Sum();
}
