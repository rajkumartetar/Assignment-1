/*37. Write a C# program to check the nearest value of 20 of 
 * two given integers and return 0 if two numbers are same.*/
using System;
public class ble37
{
    public static void Main()
    {
        int x, y, n, val1, val2;
        Console.WriteLine("\nInput first integer:");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input second integer:");
        y = Convert.ToInt32(Console.ReadLine());
        n = 20;
        val1 = Math.Abs(x - n);
        val2 = Math.Abs(y - n);
        Console.WriteLine(val1 == val2 ? 0 : (val1 < val2 ? x : y));
    }
}
//rajkumartetar