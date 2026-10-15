using System;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a=1; a < 1000; a++)
            {
                for (int b=1; b < 1000; b++)
                {
                    for (int c=1; c < 1000; c++)
                    {
                        if (a*a + b*b == c*c)
                        {
                            if (a + b + c == 1000)
                            {
                                Console.WriteLine($"{a}, {b}, {c}");
                                Console.WriteLine($"Product is: {a*b*c}");
                            }
                        }
                    }
                }
            }
        }
    }
}