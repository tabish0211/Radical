using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetDevs
{
    class Program
    {
        //method--function--entry point method
        //static void Main(string[] args)
        //{
        //}
        //1
        //static void Main()
        //{
        //    //to print any thing in console
        //    Console.WriteLine("Hello World");//printf("hi\n")
        //    Console.Write("Bye");
        //    //how to wait for a character--scanf()..getch()...i/p
        //     Console.ReadLine();
        //}

        ////2
        //static void Main()
        //{
        //    //to print any thing in console
        //    Console.WriteLine("Enter User name:");
        //    string name = Console.ReadLine();
        //    Console.WriteLine("Hello world "+name);
        //    //using place holder you can also call variables inside constant string
        //    Console.WriteLine("HEllo world {0}",name);
        // //   Console.WriteLine($"HEllo world {name}");--VS2017>
        //    Console.ReadLine();


        //}

        //3
        //        static void Main()
        //        {
        //            //Multi line string
        //            string str = @"Select * from emp where
        //             userid=1 and
        //             desg=trainer";
        //            Console.WriteLine(str);
        //            Console.ReadLine();

        //        }

        //4
        //to print the sum three digits
        //123--i/p
        ////6
        //static void Main()
        //{
        //    Console.WriteLine("Enter the number:");
        //    int num = Convert.ToInt32(Console.ReadLine());//523
        //    int n1 = num % 10;//3..num--523---num should be 52
        //    num = num / 10;//52
        //    int n2 = num % 10;//2
        //    num = num / 10;//5
        //    int n3 = num % 10;
        //    int sum = n1 + n2 + n3;
        //    Console.WriteLine("Sum of three digits ={0}",sum);
        //    Console.ReadLine();

        //}

        //6
        //code clean up;
        ////ctrl+K+D --formatting
        //static void Main()
        //{
        //    int num, n1, n2, n3, sum;
        //    Console.WriteLine("Enter the number:");
        //    num = Convert.ToInt32(Console.ReadLine());//523
        //    n1 = num % 10;//3..num--523---num should be 52
        //    num = num / 10;//52
        //    n2 = num % 10;//2
        //    num = num / 10;//5
        //    n3 = num % 10;
        //    sum = n1 + n2 + n3;
        //    Console.WriteLine("Sum of three digits ={0}", sum);
        //    Console.ReadLine();

        //}


        //6
        
        ////swapping using three variables
        //static void Main()
        //{
        //    int num1,num2,temp;
        //    Console.WriteLine("Enter the number:");
        //    num1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter the number:");
        //    num2 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("before swap numbers {0},{1}", num1, num2);
        //    temp = num1;
        //    num1 = num2;
        //    num2 = temp;
        //    Console.WriteLine("swapped numbers {0},{1}", num1,num2);
        //    Console.ReadLine();

        //}

        //7
        ////swapping using two variables
        //static void Main()
        //{
        //    int num1, num2;
        //    Console.WriteLine("Enter the number:");
        //    num1 = Convert.ToInt32(Console.ReadLine());//5
        //    Console.WriteLine("Enter the number:");
        //    num2 = Convert.ToInt32(Console.ReadLine());//3
        //    Console.WriteLine("before swap numbers {0},{1}", num1, num2);
        //    num1 = num1 + num2;//8
        //    num2 = num1 - num2;//8-3--5
        //    num1 = num1 - num2;//8-5...3
        //    Console.WriteLine("swapped numbers {0},{1}", num1, num2);
        //    Console.ReadLine();

        //}

       // //8
       // static void Main()
       // {

       //     DoSwapping();
       //     Console.ReadLine();

       // }

       //static void DoSwapping() {
       //     int num1, num2;
       //     Console.WriteLine("Enter the number:");
       //     num1 = Convert.ToInt32(Console.ReadLine());//5
       //     Console.WriteLine("Enter the number:");
       //     num2 = Convert.ToInt32(Console.ReadLine());//3
       //     Console.WriteLine("before swap numbers {0},{1}", num1, num2);
       //     num1 = num1 + num2;//8
       //     num2 = num1 - num2;//8-3--5
       //     num1 = num1 - num2;//8-5...3
       //     Console.WriteLine("swapped numbers {0},{1}", num1, num2);
 
       // }


        ////9
        //static void Main()
        //{

        //    //int sum=DoSum();
        //    int sumOfTwoNumbers = DoSum();
        //    Console.WriteLine(sumOfTwoNumbers);
        //    Console.ReadLine();

        //}

        //static int  DoSum()
        //{
        //    int num1, num2;
        //    Console.WriteLine("Enter the number:");
        //    num1 = Convert.ToInt32(Console.ReadLine());//5
        //    Console.WriteLine("Enter the number:");
        //    num2 = Convert.ToInt32(Console.ReadLine());//3
        //    int sum = num1 + num2;
        //    return sum;                        

        //}

        //10
        //Parametrized demo
        static void Main()
        {
            string Id=GetId();
            string desg=GetDesg();
            ShowDetails(Id,desg);
            Console.ReadLine();

        }

        private static void ShowDetails(string Id, string desg)
        {
            Console.WriteLine("Id is :{0} and Desg is {1}",Id,desg);
        }

        private static string GetDesg()
        {
            return "Trainer";
        }

        private static string GetId()
        {
            Console.WriteLine("Enter Id");
            string id = Console.ReadLine();
            return id;
        }

        static int DoSum()
        {
            int num1, num2;
            Console.WriteLine("Enter the number:");
            num1 = Convert.ToInt32(Console.ReadLine());//5
            Console.WriteLine("Enter the number:");
            num2 = Convert.ToInt32(Console.ReadLine());//3
            int sum = num1 + num2;
            return sum;

        }
    }
}
