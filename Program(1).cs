using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            /*Console.WriteLine("Hello");
            Console.WriteLine("Tirtha here");
            
            //2
            int a = 6;
            int b = 9;
            Console.WriteLine("a + b= "+(a+b));

            //3
            int k = 6;
            int j = 9;
            Console.WriteLine(j + "/" + k + "=" + (j / k));
            //4
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
           
            //5
            int a = 5, b = 6;
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b; //a=30 (5*6)      
            b = a / b; //b=.. (5/6)      
            a = a / b; //a=.. (5/6)    
            Console.WriteLine("After swap a= " + a + " b= " + b);       

            //6
            int x, y, z, r; 
            Console.WriteLine("Input the first number to multiply");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number to multiply");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number to multiply");
            z = Convert.ToInt32(Console.ReadLine());
            r = x * y * z ;
            Console.WriteLine("Output: {0} x {1} x {2} = {3}", x, y, z, r);*/

            //7
            /*float j, k;
            Console.WriteLine("Input the first number");
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(j+ "+"+ k + "=" +( j + k));
            Console.WriteLine(j+ "-" +k +"="+( j - k));
            Console.WriteLine(j + "*" + k + "=" + (j * k));
            Console.WriteLine(j + "/" + k + "=" + (j / k));
            Console.WriteLine(j + "%" + k + "=" + (j % k));*/
           
            //8
           /* Console.Write("Input the number= ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                Console.Write(n + " * " + i +" = " + n * i + "\n");
            }
            
            //9
            Console.Write("Input the first number= ");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number= ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the third number= ");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the four number= ");
            int o = Convert.ToInt32(Console.ReadLine());
            Console.Write("the average of"+ f +"," + s +"," + t+ ","+ o+ ", "+"is:"+(f+s+t+o/4)+"/n");

            //10
            Console.Write("Input the first number= ");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number= ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the third number= ");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("result of specified numbers" + f + "," + s + "and" + t + ",(x+y).z is " + (f+s)*t + " and x.y+y.z is " + (f*s+s*t) +" ");

            //11
            Console.Write("Input the age= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you look older than " +a);

            //12
            Console.Write("Input a digit: ");
            int a = Convert.ToInt32(Console.ReadLine());
            string s = "", ns = "";
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == 0)
                    {
                        s += string.Format("{0} ", a);
                    }
                    else
                    {
                        ns += a;
                    }
                }
            }
            Console.WriteLine("{0}\n{1}\n{0}\n{1}",s,ns);
            Console.Read();*/

            //13
            int num;
            Console.WriteLine("Please enter a numeric value= ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n");
            for (int i = 0; i < 5; i++)
            {
                if (i == 0 || i == 4)
                {
                    Console.WriteLine("{0}{0}{0}", num);
                }
                else
                {
                    Console.WriteLine("{0} {0}", num);
                }
            }
            Console.Read();
        }
    }
}
