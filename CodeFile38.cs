/*38. Write a C# program to count a specified number in a given 
 * array of integers.*/
using System;
public class ble38
{
    public static void Main()
    {
        int a, count = 0;
        int[] num = { 0, 1, 2, 3, 3, 4, 4, 5, 5, 6, 7, 7, 8, 8, 9, 9 };
        Console.WriteLine("\nInput an integer:");
        a = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] == a)
            {
                count++;
            }
        }
        Console.WriteLine("Number of occurence of {0}:",a);
        Console.WriteLine(count);
    }
}
//rajkumartetar