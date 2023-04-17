class SumCalculator
{

    protected readonly int[] Numbers;
    public SumCalculator(int[] Numbers) => this.Numbers = Numbers;

    public int Calculate() => Numbers.Sum();

}