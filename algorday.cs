using System;

namespace DistCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance:");
            int distance=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of passengers:");
            int pass_no=Convert.ToInt32(Console.ReadLine());
            distance=distance-1;
            double price=distance*2;
            price=price+3;

            if (pass_no > 5)
            {
                price=price*1.5;
            }
            Console.WriteLine(price);
        }
    }
}