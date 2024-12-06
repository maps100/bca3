using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, f = 0;

            Console.WriteLine("Enter a Number:");
            num = int.Parse(Console.ReadLine());

            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    f++;
                }
            }

            if (f == 2)
            {
                Console.WriteLine("Number is prime.");
            }
            else
            {
                Console.WriteLine("Number is not prime.");
                Console.WriteLine("Factors of the number are:");

                for (int factor = 1; factor <= num; factor++)
                {
                    if (num % factor == 0)
                    {
                        Console.Write(factor + " ");
                    }
                }
                Console.WriteLine(); 
            }

            Console.ReadKey();
        }
    }
}
