
internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = { 10, 17, 71, 22, 56, -10, 44, -87 };
        var maxValue = GetMaxValue(numbers);
        Console.WriteLine($"Максимальне значення масиву: {maxValue}") ;
    }

    private static int GetMaxValue(int[] numbers)
    {
        return numbers.Max();
    }
}