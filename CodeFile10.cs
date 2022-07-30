/*10. Write a C# Sharp program to that takes three numbers(x,y,z) as
 * input and print the output of (x+y).z and x.y + y.z.*/
using System;
public class ble10
{
    public static void Main()
    {
        int x, y, z;
        Console.WriteLine("Enter X : ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Y : ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Z : ");
        z = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Result : ");
        Console.WriteLine("(x+y)*z = {0} ", ((x + y)*z));
        Console.WriteLine("(x.y + y.z.) = {0}", ((x * y) + (y * z)));
    }
}
//rajkumartetar