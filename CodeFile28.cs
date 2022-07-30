/*28. Write a C# program to convert a hexadecimal number to 
 * decimal number.*/
using System;
using System.Collections.Generic;
public class ble28
{
    public static void Main()
    {

        string hexval = "4A6";
        Console.WriteLine("Hexadecimal number: " + hexval);
        int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine("Converted to:-");
        Console.WriteLine("Decimal number: " + decValue);
    }
}
//rajkumartetar