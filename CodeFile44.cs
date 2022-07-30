/*44. Write a C# program to create a new 
 * array of length containing the middle 
 * elements of three arrays (each length 3) 
 * of integers.*/
using System;
public class ble44
{
    public static void Main()
    {
        int[] arr1 = { 1, 2, 3 }, arr2 = { 2, 4, 6 }, arr3 = { 3, 6, 9 };
        int[] narr = new int[3];
        narr[0] = getMidElement(arr1);
        narr[1] = getMidElement(arr2);
        narr[2] = getMidElement(arr3);
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(narr[i]);
        }
    }
    public static int getMidElement(int[] a)
    {
        return a[a.Length / 2];
    }
}
//rajkumartetar