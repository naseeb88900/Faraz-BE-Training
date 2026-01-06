
//Write a C# program that takes a string and an integer from the user. Print the string in uppercase and then print the integer incremented by 1.
//using System;
using System;
using System.Collections.Generic;
    using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
    using System.Threading.Tasks;

namespace CsharpProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double avg;
            double[] age = new double[6];
            string[] names = new string[6];
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Person" + i + "Name");
                names[i] = Console.ReadLine();
                Console.WriteLine("Age");
                age[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (age[1] < age[2] && age[1] < age[3] && age[1] < age[4] && age[1] < age[5])
            {
                Console.WriteLine("Youngest Person :" + names[1] + "age :" + age[1]);

            }
             if (age[2] < age[1] && age[2] < age[3] && age[2] < age[4] && age[2] < age[5])
            {
                Console.WriteLine("Youngest Person :" + names[2] + "age :" + age[2]);

            }
            if (age[3] < age[1] && age[3] < age[2] && age[3] < age[4] && age[3] < age[5])
            {
                Console.WriteLine("Youngest Person :" + names[3] + "age :" + age[3]);

            }
            if (age[4] < age[1] && age[4] < age[2] && age[4] < age[3] && age[2] < age[5])
            {
                Console.WriteLine("Youngest Person :" + names[4] + "age :" + age[4]);

            }
            if (age[5] < age[1] && age[5] < age[2] && age[5] < age[3] && age[5] < age[4])
            {
                Console.WriteLine("Youngest Person :" + names[5] + "age :" + age[5]);

            }



























            if (age[1] > age[2] && age[1] > age[3] && age[1] > age[4] && age[1] > age[5])
            {
                Console.WriteLine("Oldest Person :" + names[1] + "age :" + age[1]);

            }
             if (age[2] > age[1] && age[2] > age[3] && age[2] > age[4] && age[2] > age[5])
            {
                Console.WriteLine("Oldest Person :" + names[2] + "age :" + age[2]);

            }
            if (age[3] > age[1] && age[3] > age[2] && age[3] > age[4] && age[3] > age[5])
            {
                Console.WriteLine("Oldest Person :" + names[3] + "age :" + age[3]);

            }
            if (age[4] > age[1] && age[4] > age[2] && age[4] > age[3] && age[4] > age[5])
            {
                Console.WriteLine("Oldest Person :" + names[4] + "age :" + age[4]);

            }
            if (age[5] > age[1] && age[5] > age[2] && age[5] > age[3] && age[5] > age[4])
            {
                Console.WriteLine("Oldest Person :" + names[5] + "age :" + age[5]);

            }

            avg = (age[1] + age[2] + age[3] + age[4] + age[5])/5;
            Console.WriteLine("avg" + avg);

























            //int[] marks = new int[4];
            //int[] marks1 = new int[4];
            //int[] marks2 = new int[4];
            //string[] stuName = new string[4];
            //string[] sub = { "Maths", "Urdu", "English" };
            //for (int i = 1; i <=3; i++)
            //{
            //    Console.WriteLine("enter" + i + " name");
            //    stuName[i] = Console.ReadLine();

            //    Console.WriteLine("Enter Maths marks:");
            //    marks[i] = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter urdu marks:");
            //    marks1[i] = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter eng marks:");
            //    marks2[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //if (marks[1] > marks1[2] && marks[1] > marks[3])
            //{
            //    Console.WriteLine(stuName[1] + " " + "have more marks in" + " " + sub[0] + " " + "than" + " " + stuName[2] + " " + "and" + " " + stuName[3]);
            //}
            //if (marks[2] > marks[1] && marks[2] > marks[3])
            //{
            //    Console.WriteLine(stuName[2] + " " + "have more marks in" + " " + sub[0] + " " + "than" + " " + stuName[1] + " " + "and" + " " + stuName[3]);
            //}
            //if (marks[3] > marks[1] && marks[3] > marks[2])
            //{
            //    Console.WriteLine(stuName[3] + " " + "have more marks in" + " " + sub[0] + " " + "than" + " " + stuName[1] + " " + "and" + " " + stuName[2]);
            //}



            //if (marks1[1] > marks1[2] && marks1[1] > marks1[3])
            //{
            //    Console.WriteLine(stuName[1] + " " + "have more marks in" + " " + sub[1] + " " + "than" + " " + stuName[2] + " " + "and" + " " + stuName[3]);
            //}
            //if (marks1[2] > marks1[1] && marks1[2] > marks1[3])
            //{
            //    Console.WriteLine(stuName[2] + " " + "have more marks in" + " " + sub[1] + " " + "than" + " " + stuName[1] + " " + "and" + " " + stuName[3]);
            //}
            //if (marks1[3] > marks1[1] && marks1[3] > marks1[2])
            //{
            //    Console.WriteLine(stuName[3] + " " + "have more marks in" + " " + sub[1] + " " + "than" + " " + stuName[1] + " " + "and" + " " + stuName[2]);
            //}



            //if (marks2[1] > marks2[2] && marks2[1] > marks2[3])
            //{
            //    Console.WriteLine(stuName[1] + " " + "have more marks in" + " " + sub[2] + " " + "than" + " " + stuName[2] + " " + "and" + " " + stuName[3]);
            //}
            //if (marks2[2] > marks2[1] && marks2[2] > marks2[3])
            //{
            //    Console.WriteLine(stuName[2] + " " + "have more marks in" + " " + sub[2] + " " + "than" + " " + stuName[1] + " " + "and" + " " + stuName[3]);
            //}
            //if (marks2[3] > marks2[1] && marks2[3] > marks2[2])
            //{
            //    Console.WriteLine(stuName[3] + " " + "have more marks in" + " " + sub[2] + " " + "than" + " " + stuName[1] + " " + "and" + " " + stuName[2]);
            //}
















            //    Console.WriteLine("Enter Student 2nd Name ");
            //    string mystring = Console.ReadLine();
            //    Console.WriteLine("Enter Maths Marks ");
            //    int Sub1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter English Marks ");
            //    int Sub2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter Urdu Marks ");
            //    int Sub3 = Convert.ToInt32(Console.ReadLine());
            //    if(sub1 >Sub1)
            //    {
            //        Console.WriteLine("Student" + myString + "have more marks in Maths than student"+ mystring);
            //    }
            //    else if (Sub1 > sub1)
            //    {
            //        Console.WriteLine("Student" + mystring + " have more marks in Maths than student"+myString);
            //    }
            //    if (sub2 > Sub2)
            //    {
            //        Console.WriteLine("Student"+ myString + "have more marks in English than student "+mystring);
            //    }
            //    else if (Sub2 > sub2)
            //    {
            //        Console.WriteLine("Student" + mystring + " have more marks in English than student "+myString);
            //    }
            //    if (sub3 > Sub3)
            //    {
            //        Console.WriteLine("Student" + myString +"have more marks in Urdu than student"+mystring);
            //    }
            //    else if (Sub3 > sub3)
            //    {
            //        Console.WriteLine("Student  have more marks in Urdu than student 1st");
            //    }



            //}










            ////int num = 2;
            ////int power = 8;
            ////int ans = 1;
            ////int i = 1;
            ////while (i <= power)
            ////{
            ////    ans *= num;
            //    i++;
            //    Console.WriteLine(ans);










            //    int num = 2;
            //    int power = 8;
            //    int answer = 1;
            //    for (int i = 1; i <= power; i++)
            //    {
            //        answer *= num;
            //        Console.WriteLine(answer);





















            //Console.WriteLine("Enter your first number");
            //double firstNumber = Convert.ToDouble (Console.ReadLine());
            //Console.WriteLine("Enter your second number");
            //double secondNumber = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter your operator (+ , - , * , / ): ");
            //string myOperator = Console.ReadLine();
            //if (myOperator == "+")
            //{
            //    Console.WriteLine(firstNumber + secondNumber);
            //}
            //if (myOperator == "-")
            //{
            //    Console.WriteLine(firstNumber - secondNumber);
            //}
            //if (myOperator == "*")
            //{
            //    Console.WriteLine(firstNumber * secondNumber);
            //}
            //if (myOperator == "/")
            //{
            //    Console.WriteLine(firstNumber / secondNumber);
            //}








            //string mystring = "2.3";
            //double math = Convert.ToDouble(mystring) / 2;
            //Console.WriteLine (math);

            //Console.WriteLine(mystring + 1);
            ////this is for min or max value method
            //Console.WriteLine("this is for minimun or maximum value method");
            //Console.WriteLine(Math.Min(12.1,4));
            //Console.WriteLine(Math.Max(12, 3));
            ////Power method::::::::::::::
            //Console.WriteLine("this is for power method");
            //Console.WriteLine(Math.Pow(2, 3));
            ////sqaure root::::::::::::
            //Console.WriteLine("this is for square root method ");
            //Console.WriteLine(Math.Sqrt(36));
            ////ABS for absolute value Method::::::::::
            //Console.WriteLine("this is for Absolute vaalue ");
            //Console.WriteLine(Math.Abs(17 * 2));

            //Console.ReadLine();



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






            //Take 2 numbers as inputs from user and display the highest number
            //for example if user input 2 and 3 it should say 3 is the highest number

            //Console.WriteLine("Enter first value ");
            //  int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second value ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //if (num1 < num2)
            //{
            //    Console.WriteLine("max value" + num2);
            //}
            //if (num2 < num1)
            //{
            //    Console.WriteLine("max value" + num1);
            //}













        }
    }
}
