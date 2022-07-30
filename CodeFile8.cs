/*8. Write a C# Sharp program that takes a number as 
 * input and print its multiplication table.*/
using System;
public class ble8
{
    public static void Main()
    {
        int a;
        Console.WriteLine("Enter Number : ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Table of {0} : ",a);
        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine("{0} x {1} = {2}",a,i,a*i);
        }
    }
}
//rajkumartetar
