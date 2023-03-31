namespace Calidad20231Demo.Services;

public class NumericService
{
    public int Sumar(int a, int b)
    {
        return a + b;
    }

    public int SumarArray(int[] nums)
    {
        return nums.Sum();
    }
}