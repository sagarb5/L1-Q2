using System;

namespace L1_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Number");
            int i;
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0) 
            {
                Console.WriteLine("Entered number is an even number");
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine("Entered number is an odd number");
                Console.ReadKey(true);
            }
        }
    }
}
