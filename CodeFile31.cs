/*31. Write a C# program to check if a given positive number is
 * a multiple of 3 or a multiple of 7.*/
using System;
public class ble31
{
    public static void Main()
    {
        int a;
        Console.WriteLine("Enter Number : ");
        a = Convert.ToInt32(Console.ReadLine());
        if (a % 3 == 0 || a % 7 == 0)
        {
            Console.WriteLine("True.");
        }
        else
        {
            Console.WriteLine("False.");
        }
    }
}
//rajkumartetar