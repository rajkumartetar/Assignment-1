/*13. Write a C# program that takes a number as input and then
 * displays a rectangle of 3 columns wide and 5 rows tall
 * using that digit. */
using System;
public class ble13
{
    public static void Main()
    {
        int a;
        Console.WriteLine("Enter Number : ");
        a=Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < 5; i++)
        {
            if (i == 0 || i == 4)
            {
                Console.WriteLine("{0}{0}{0}", a);
            }
            else
            {
                Console.WriteLine("{0} {0}", a);
            }
        }    

    }
}
//rajkumartetar