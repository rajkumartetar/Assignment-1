/*35. Write a C# program to check if "HP" appears at second 
 * position in a string and returns the string without "HP".*/
using System;
public class ble35
{
    public static void Main()
    {
        string str = "PHP Tutorial", s ;
        s = str.Substring(1, 2);
        if (s == "HP")
        {
            Console.WriteLine(str.Remove(1,2));
        }
    }
}
//rajkumartetar