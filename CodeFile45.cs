/*45. Write a C# program to check if an 
 * array contains an odd number.*/
using System;
public class ble45
{
    public static void Main()
    {
        int[] arr1 = { 1, 2, 4, 6 };
        int[] arr2 = { 2, 4, 6, 8, };
        Console.WriteLine(checkIfOdd(arr1));
        Console.WriteLine(checkIfOdd(arr2));
    }
    public static bool checkIfOdd(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] % 2 != 0)
            {
                return true;
            }
        }
        return false;
    }
}
//rajkumartetar