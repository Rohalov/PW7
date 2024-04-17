using task2;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = { 10, 17, 71, 22, 56, -10, 44, -87 };
        Console.WriteLine($"Максимальне значення масиву: {numbers.GetMaxValue()}");
    }
}