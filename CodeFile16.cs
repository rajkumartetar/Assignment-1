/*16. Write a C# program to create a new string from a given
 *  string (length 1 or more) with the first character added
 *  at the front and back.*/
using System;
public class ble16
{
    public static void Main()
    {
        char c;
        string str;
        Console.WriteLine("Enter String : ");
        str = Console.ReadLine();
        c = str[0];
        string nstr = c + " " + str + " " + c;
        Console.WriteLine("New String : {0}",nstr);
    }
}
//rajkumartetar