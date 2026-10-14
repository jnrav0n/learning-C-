using System;


namespace Mathmy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number: ");
         int num1 = Convert.ToInt32(Console.ReadLine());
         Console.Write("Please Enter a second number: ");
         int num2= Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("What operation would you like to do? (+, -, /, *)");
         string reply=Console.ReadLine();
         if (reply == "+")
            {
                int result=num1+num2;
                Console.WriteLine($"The result is {result}");
            }
        else if (reply == "-")
            {
                int result=num1-num2;
                Console.WriteLine(result);
            }
        else if (reply == "/")
            {
                int result=num1/num2;
                Console.WriteLine(result);
            }
        else if (reply == "*")
            {
                int result=num1*num2;
                Console.WriteLine(result);
            }
        }
    }
}