/*39. Write a C# program to check if a number appears as either 
 * the first or last element of an array of integers and the 
 * length is 1 or more.*/
using System;
public class ble39
{
    public static void Main()
    {
        int a;
        int[] arr = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
        Console.WriteLine("\nInput an integer:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((arr[0] == a) || (arr[arr.Length - 1] == a));
    } 
}
//rajkumartetar