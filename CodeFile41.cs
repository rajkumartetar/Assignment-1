/*41. Write a C# program to check if the first element or the
 * last element of the two arrays ( length 1 or more) 
 * are equal.*/
using System;
public class ble41
{
    public static void Main()
    {

        int[] arr1 = { 1, 2, 3, 4, 5 };
        int[] arr2 = { 0, 1, 2, 3, 4, 5 };
        if (arr1[0] == arr2[0] || arr1[arr1.Length - 1] == arr2[arr2.Length - 1])
        {
            Console.WriteLine("TRUE");
        }
        else
        {
            Console.WriteLine("FALSE");
        }
    }
}
//rajkumartetar