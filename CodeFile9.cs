/*9. Write a C# Sharp program that takes four numbers as
 * input to calculate and print the average. */
using System;
public class ble9
{
    public static void Main()
    {
        int a, b, c, d;
        Console.WriteLine("Enter 1st Number : ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 2nd Number : ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 3rd Number : ");
        c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 4th Number : ");
        d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The AVG. of {0}, {1}, {2} and {3} is... {4}",a,b,c,d,((a+b+c+d)/4));
    }
}
//rajkumartetar