/*19. Write a C# program to get the absolute value of the 
 * difference between two given numbers. Return double the 
 * absolute value of the difference if the first number is
 * greater than second number.*/
using System;
public class ble19
{
    public static void Main()
    {
        int a, b;
        Console.WriteLine("Enter A : ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter B : ");
        b = Convert.ToInt32(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine((a - b) * 2);
        }
        else 
        {
            Console.WriteLine(b-a);
        }    
    }
}
//rajkumartetar