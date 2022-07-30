/*5. Write a C# Sharp program to swap two numbers.*/
using System;
public class ble5
{
    public static void Main()
    {
        int a, b, tmp;
        Console.WriteLine("Enter A =");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter B =");
        b = Convert.ToInt32(Console.ReadLine());
        tmp = a;
        a = b;
        b = tmp;
        Console.WriteLine("After Swapping...");
        Console.WriteLine("A = {0}", a);
        Console.WriteLine("B = {0}", b);
    
    }
}
//rajkumartetar