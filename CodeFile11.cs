/*11. Write a C# Sharp program that takes an age (for example 20) as 
 * input and prints something as "You look older than 20".*/
using System;
public class ble11
{
    public static void Main()
    {
        int age;
        Console.WriteLine("Enter Your Age : ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ypu Look Older Than {0}.",age);
    }
}
//rajkumartetar