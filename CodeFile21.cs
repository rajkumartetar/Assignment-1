/*21. Write a C# program to check if an given integer is 
 * within 20 of 100 or 200.*/
using System;
public class ble21
{
    public static void Main()
    {
        int a;
        Console.WriteLine("Input A Number:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(check(a));    
    }
    static bool check(int a)
    {
        if (Math.Abs(a - 100) <= 20 || Math.Abs(a - 200) <= 20)
        {
            return true;
        }
        return false;   
    }
}
//rajkumartetar