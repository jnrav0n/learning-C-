//Number guessing game
using System;
using System.Runtime.CompilerServices;

namespace MainProg
{
    class Program
    {
        static void Main(string[] args)
        {
        Random rnd = new Random();
        int num  = rnd.Next(1, 101); 
        Console.WriteLine("Enter your first guess:"); 
        bool stat=true;
        while (stat == true)
            {
             int result = Convert.ToInt32(Console.ReadLine());
            if (result == num)
                {
                    Console.WriteLine("You got it! ");
                    stat=false;
                }
                else
                {
                    if (result > num)
                    {
                        Console.WriteLine("Too high!");
                    }
                    else
                    {
                        Console.WriteLine("Too low!");
                    }
                }
            }

            }

        }

} 