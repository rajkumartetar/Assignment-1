/*29. Write a C# program to multiply corresponding elements of 
 * two arrays of integers.*/
using System;
public class ble29
{
    public static void Main()
    {
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = { 5, 6, 7 };
        int[] arr3 = new int[3];
        for (int i = 0; i < 3; i++)
        {
            arr3[i] = arr1[i] * arr2[i];
        }
        foreach (int a in arr3)
        {
            Console.WriteLine(a);
        }
    }
}
//rajkumartetar