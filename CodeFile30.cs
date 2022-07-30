/*30. Write a C# program to create a new string of four copies,
 * taking last four characters from a given string. If the 
 * length of the given string is less than 4 return the 
 * original one.*/
using System;
public class ble30
{
    public static void Main()
    {
        string ms;
        Console.WriteLine("Enter String :");
        ms = Console.ReadLine();
        char[] ca = ms.ToCharArray();
        if (ca.Length > 4)
        {
            int k = ca.Length, c = 0 ;
            while (c < 4)
            {
                c++;
                for (int i = k - 5; i < k; i++)
                {
                    Console.Write(ca[i]);
                }
            }
        }
        else
        {
            Console.WriteLine(ms);
        }
    }
}
//rajkumartetar