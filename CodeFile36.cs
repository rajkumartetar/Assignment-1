/*36. Write a C# program to find the largest and lowest values 
 * from three integer values.*/
using System;
public class ble36
{
    public static void Main()
    {
        int a, b, c;
        Console.WriteLine("\nInput first integer:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input second integer:");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input third integer:");
        c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Largest of three: " + Math.Max(a, Math.Max(b, c)));
        Console.WriteLine("Lowest of three: " + Math.Min(a, Math.Min(b, c)));
    }
}
//rajkumartetar