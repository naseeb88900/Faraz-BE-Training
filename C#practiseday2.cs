
//Write a C# program that takes a string and an integer from the user. Print the string in uppercase and then print the integer incremented by 1.
//using System;
using System;
using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;   

    namespace CsharpProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mystring = "2.3";
            double math = Convert.ToDouble(mystring) / 2;
            Console.WriteLine (math);

            Console.WriteLine(mystring + 1);
            //this is for min or max value method
            Console.WriteLine("this is for minimun or maximum value method");
            Console.WriteLine(Math.Min(12.1,4));
            Console.WriteLine(Math.Max(12, 3));
            //Power method::::::::::::::
            Console.WriteLine("this is for power method");
            Console.WriteLine(Math.Pow(2, 3));
            //sqaure root::::::::::::
            Console.WriteLine("this is for square root method ");
            Console.WriteLine(Math.Sqrt(36));
            //ABS for absolute value Method::::::::::
            Console.WriteLine("this is for Absolute vaalue ");
            Console.WriteLine(Math.Abs(17 * 2));

            Console.ReadLine();
            //:::::::::::::::Evaluation 1:::::::::::::::::::::::::::::
            //Console.WriteLine("type any string: ");
            //string myname = Console.ReadLine();
            //Console.WriteLine("your string is: " + myname.ToUpper());
            //Console.WriteLine("type any integer: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //x++;
            //Console.WriteLine("your integer is: " + x);

            //string NAme = Console.ReadLine();
            //int x = 2;
            //double y = 6.0;
            //Console.WriteLine("your name is: " + NAme);

            //Console.WriteLine(x + y);
            //Console.WriteLine(Math.Pow(2.2,2));

            //string Name = "faraz sattar";
            //Console.WriteLine(Name.Contains("faraz"));
            //Console.WriteLine("your name is: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("your age is: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //age++;
            //Console.WriteLine("your age nex year will be: " + age);
            //Console.ReadLine();
        }
    }
}
