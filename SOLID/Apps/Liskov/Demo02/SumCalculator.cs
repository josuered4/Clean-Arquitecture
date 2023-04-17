class SumCalculator : Calculator
{
    public SumCalculator(int[] Numbers):base(numbers: Numbers){}

    public override int Calculate() => Numbers.Sum();

}