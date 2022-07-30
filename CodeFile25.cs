/*25. Write a C# program and compute the sum of the digits of 
 * an integer.*/
using System;
public class ble25
{
    public static void Main()
    {
        Console.Write("Input a Number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }
        Console.WriteLine("Sum of the digits of the given integer: " + sum);
    }
}
//rajkumartetar