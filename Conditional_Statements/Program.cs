using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years of experience do you have in professional programming?");
            try
            {
                string exp = Console.ReadLine();

                switch(int.Parse(exp))
                {
                    case 0:
                        Console.WriteLine("Need lots of practice!");
                        break;
                    case 1:
                        Console.WriteLine("Looks like you have a little experience!");
                        break;
                    case 2:
                        Console.WriteLine("Wow! You've been doing this for a little while!");
                        break;
                    default:
                        Console.WriteLine("You are an expert!");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer value.");
            }
        }
    }
}
