/*40. Write a C# program to compute the sum of all the elements
 * of an array of integers.*/
using System;
public class ble40
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine("SUM OF ELEMENTS OF ARRAY is... {0}",sum);
    }
}