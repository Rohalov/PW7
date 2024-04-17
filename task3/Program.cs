internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = { 10, 17, 71, 22, 56, -10, 44, -87 };
        var sum = Sum(numbers, 0);
        Console.WriteLine($"Сума чисел масиву: {sum}");
    }

    private static int Sum(int[] numbers, int index)
    {
        if (index < numbers.Length)
        {
            return numbers[index] + Sum(numbers, ++index);
        }
        return 0;
    }
}