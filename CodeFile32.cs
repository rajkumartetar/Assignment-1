/*32. Write a C# program to check if a string starts with a 
 * specified word.*/
using System;
public class ble32
{
    public static void Main()
    {
        string str;
        Console.WriteLine("Input a String : ");
        str = Console.ReadLine();
        Console.WriteLine((str.Length < 7 && str.Equals("Namaste")) || (str.StartsWith("Namaste") && str[7] == ' '));
    }
}
//rajkumartetar