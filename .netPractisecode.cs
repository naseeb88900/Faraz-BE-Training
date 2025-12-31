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
                string myString = "faraz \nsattaR";
                Console.WriteLine(myString.Length);
                Console.WriteLine(myString.ToUpper());
                Console.WriteLine(myString.Contains("faraz"));
                Console.WriteLine(myString.IndexOf("R"));
                Console.Write(myString.Substring(2, 11));




                Console.WriteLine("Enter your name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your name is "+ name);
                Console.WriteLine("And your age is " + age);
                age = age + 1;
                Console.WriteLine("And next year you will be "+ age);
                Console.ReadLine();

            }
        }
    }
git@github.com:farazsattar603-web/my-project.git