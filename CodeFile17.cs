/*17. Write a C# program to check two given integers and 
 * return true if one is negative and one is positive.*/
using System;
public class ble17
{
    public static void Main()
    {
        int a, b;
        Console.WriteLine("Enter 1st Number : ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 2nd Number : ");
        b = Convert.ToInt32(Console.ReadLine());
        if (a > 0 && b < 0)
        {
            Console.WriteLine("true");
        } 
        if (a < 0 && b > 0)
        {
            Console.WriteLine("true");
        }
    }
}
//rajkumartetar