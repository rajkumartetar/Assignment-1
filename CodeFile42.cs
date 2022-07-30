/*42. Write a C# program to rotate an array 
 * (length 3) of integers in left direction.*/
using System;
public class ble42
{
    public static void Main()
    {
        int[] arr = { 4, 5, 6 };
        int tmp;
        tmp = arr[0];
        for (int i = 0; i < arr.Length-1; i++)
        {
                arr[i] = arr[i + 1];
        }
        arr[arr.Length - 1] = tmp;
        Console.WriteLine("After Rotating Array...");
        foreach (int a in arr)
        {
            Console.Write(a + " ");
        }
    }
}
//rajkumartetar