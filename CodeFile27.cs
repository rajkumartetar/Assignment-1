/*27. Write a C# program to find the size of a specified file 
 * in bytes.*/
using System;
using System.Collections.Generic;
using System.IO;

public class ble27
{
    public static void Main()
    {
        FileInfo f = new FileInfo("C:\\Users\\RaJ\\Desktop\\BSCIT\\sem_5\\C#\\lab_ex1.pdf");
        Console.WriteLine("\nSize of a file: " + f.Length.ToString());
    }
}
//rajkumartetar