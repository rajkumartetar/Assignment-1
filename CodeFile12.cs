/*12. Write a C# program to that takes a number as input and 
 * display it four times in a row (separated by blank spaces),
 * and then four times in the next row, with no separation.
 * You should do it two times: Use Console. Write and then 
 * use {0}.*/
using System;
public class ble12
{
    public static void Main()
    {
        int a;
        Console.WriteLine("Enter NUmber : ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0} {0} {0} {0}",a);
        Console.WriteLine("{0}{0}{0}{0}", a);
        Console.WriteLine("{0} {0} {0} {0}", a);
        Console.WriteLine("{0}{0}{0}{0}", a);
    }
}
//rajkumartetar