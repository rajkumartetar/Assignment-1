/*43. Write a C# program to get the larger
 * value between first and last element of 
 * an array (length 3) of integers.*/
using System;
public class ble43
{
    public static void Main()
    {
        int[] a = { 1, 2, 3 };
        Console.WriteLine(max(a) + " is the max value in array");
    }
    public static int max(int[] a)
    {
        int m = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] > m)
            {
                m = a[i];
            }
        }
        return m;
    }
}
//rajkumartetar