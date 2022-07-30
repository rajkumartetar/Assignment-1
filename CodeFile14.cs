/*14. Write a C# program to convert from celsius degrees to
 * Kelvin and Fahrenheit.*/
using System;
public class ble14
{
    public static void Main()
    {
        double c, f, k;
        Console.WriteLine("Enter Temperature in Celsius : ");
        c = Convert.ToDouble(Console.ReadLine());
        f=(9*c)/5 + 32;
        k=c+273;
        Console.WriteLine("Temperature in Fahrenheit is... {0}",f);
        Console.WriteLine("Temperature in Kelvin is... {0}", k);
    }
}
//rajkumartetar