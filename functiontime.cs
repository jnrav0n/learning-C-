using System;

namespace testspace
{
    class Program
    {
        static void PrimeFinder(int number)
        {
            bool prime=true;
            int[] output={};
            int number1=number;
            int number2=Math.Round(Math.Sqrt(number1))+1;
            for (int i = 0; i < number2; i++)
            {
                if (number1 % i == 0)
                {
                    bool prime=false;
                    output[i]=i;
                }
            }
            return prime;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num=Convert.ToInt32(Console.ReadLine);
            Console.WriteLine(PrimeFinder(num));
        }
    }
}