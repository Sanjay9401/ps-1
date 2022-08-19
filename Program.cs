using System;
public class SwapExample
{
    public static void Main(string[] args)
    {
        int a = 5, b = 6;
        Console.WriteLine("a= " + a + " b= " + b);
        a = a * b;
        b = a / b;
        a = a / b;
        Console.Write("a= " + a + " b= " + b);
    }
}