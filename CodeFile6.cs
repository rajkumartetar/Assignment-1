/*6. Write a C# Sharp program to print the output of 
 * multiplication of three numbers which will be entered by the user.*/
using System;
public class ble6
{
    public static void Main()
    {
        int a, b, c;
        Console.WriteLine("Enter A =");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter B =");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter C =");
        c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Multiplication of {0}, {1} and {2} is... {3}",a,b,c,(a*b*c));
    }
}
//rajkumartetar