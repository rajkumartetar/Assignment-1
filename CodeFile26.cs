/*26. Write a C# program to reverse the words of a sentence.*/
using System;
public class ble26
{
    public static void Main()
    {
        string s,str="";
        string[] ar;
        Console.WriteLine("Enter SENTENCE : ");
        s = Console.ReadLine();
        ar=s.Split(' ');
        for(int i=ar.Length-1;i>=0;i--)
        {
            str+=ar[i]+" ";
        }
        Console.WriteLine(str);
     }
}
//rajkumartetar
