/*20. Write a C# program to check the sum of the two given 
 * integers and return true if one of the integer is 20 or
 * if their sum is 20.*/
using System;
public class ble20
{
    public static void Main()
    { 
        Console.WriteLine(check(10,10));
        Console.WriteLine(check(20,14));
        Console.WriteLine(check(4, 6));
    }
    public static bool check(int a, int b)
    {
        if (a == 20 || b == 20)
        {
            return true;
        }
        else if ((a + b == 20))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}