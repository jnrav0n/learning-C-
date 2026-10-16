using System;
using System.Security.Cryptography.X509Certificates;

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
             int x=2;
             int sum=0;
            do
            {      
                bool result=PrimeFinder(x);
                if (result)
                {
                    prime_list.Add(x);
                }
                x++;
            }   
            while (x <1999999);
            foreach(int i in prime_list)
            {
                sum=sum+i;
            }
            Console.WriteLine(sum);   

        }
    }
}