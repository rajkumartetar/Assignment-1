/*7. Write a C# Sharp program to print on screen the output
 * of adding, subtracting, multiplying and dividing of two numbers
 * which will be entered by the user.*/
using System;
public class ble7
{
    public static void Main()
    {
        int a, b;
        Console.WriteLine("Enter A =");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter B =");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0} + {1} = {2}", a, b, (a + b));
        Console.WriteLine("{0} - {1} = {2}", a, b, (a - b));
        Console.WriteLine("{0} x {1} = {2}", a, b, (a * b));
        Console.WriteLine("{0} / {1} = {2}", a, b, (a / b));
        Console.WriteLine("{0} % {1} = {2}", a, b, (a % b));
 
    }
}
//rajkumartetar