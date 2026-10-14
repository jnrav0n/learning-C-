using System;

namespace Lister
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names={"Harrison", "Tom", "James", "Greg", "Thomas"};
            Array.Sort(names);
            foreach (string i in names)
            {
                if (i == "Harrison")
                {
                    Console.WriteLine("Harrison has been found");
                }
            }
        
        }
    }
}