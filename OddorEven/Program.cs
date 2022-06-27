// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Kata
{
    public static string OddOrEven(int[] array)
    {
        int result = 0;
        foreach (var item in array)
        {
            result += item;
        }
        if (result % 2 == 0 || result == 0)
        {
            return "even";
        }
        return "odd";
    }
}
