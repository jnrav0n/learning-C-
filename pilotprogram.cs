using System;

//This is how you comment in C#
namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!"); //Comments can go anywhere
      Console.WriteLine("This should print below");
      Console.Write("This should just go on the same line");
      //But for some reason the 7 gets added on too!
      Console.WriteLine(2 +5);
      Console.WriteLine(2*6);
    }
  }
}

/*Or go multiple lines
like this*/