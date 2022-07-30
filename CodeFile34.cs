/*34. Write a C# program to check if an integer (from the two
 * given integers) is in the range -10 to 10.*/
using System;
public class ble34
{
    public static void Main()
    {
        int a, b;
        Console.WriteLine("Input a first number(<100) : ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input a second number(>100):");
        b = Convert.ToInt32(Console.ReadLine());
        if ((a > (-10) && a < 10) || (b > (-10) && b < 10))
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