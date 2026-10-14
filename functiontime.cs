using System;

namespace testspace
{
    class Program
    {
        static bool PrimeFinder(int number)
        {
            bool prime=true;
            List<int> output = new List<int>();           
            int number1=number;
            int number2 = (int)Math.Round(Math.Sqrt(number1)) + 1;
            for (int i = 2; i < number2; i++)
            {
                if (number1 % i == 0)
                {
                    prime=false;
                    output.Add(i);
                }
            }
            return prime;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());            
            bool result=PrimeFinder(num);
            if (result)
            {
                Console.WriteLine($"{num} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{num} is not a prime number.");
            }
        }
    }
}