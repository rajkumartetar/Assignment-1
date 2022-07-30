/*33. Write a C# program to check two given numbers where one 
 * is less than 100 and other is greater than 200.*/
using System;
public class ble33
{
    public static void Main()
    {
        int a, b;
        Console.WriteLine("Input a first number(<100) : ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input a second number(>100):");
        b = Convert.ToInt32(Console.ReadLine());
        if (a < 100 && b > 200)
        {
            Console.WriteLine("TRUE");
        }
        else
        {
            Console.WriteLine("FALSE");
        }
    }
}
//rajkumartetar