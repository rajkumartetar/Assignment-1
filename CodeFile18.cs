/*18. Write a C# program to compute the sum of two given 
 * integers, if two values are equal then return the 
 * triple of their sum.*/
using System;
public class ble18
{
    public static void Main()
    {
        int a, b;
        Console.WriteLine("Enter A : ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter B : ");
        b = Convert.ToInt32(Console.ReadLine());
        if (a != b)
        {
            Console.WriteLine("Sum of A and B is... {0}", (a + b));
        }
        else 
        {
            Console.WriteLine("A and B are equal. Thrice of their sum is...{0}",(3*(a+b)));
        }
    } 
}
//rajkumartetar