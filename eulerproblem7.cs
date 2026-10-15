using System;

namespace Problem
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
             List<int> prime_list = new List<int>();           
            for (int x = 2; prime_list.Count<10002; x++)
            {      
                bool result=PrimeFinder(x);
                if (result)
                {
                    prime_list.Add(x);
                }

            }   
            Console.WriteLine(prime_list[10000]);   

        }
    }
}