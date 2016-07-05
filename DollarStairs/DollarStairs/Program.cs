using System;

namespace DollarStairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Enter a character: ");
                var ch = Console.ReadLine();

                while (number > 0)
                {
                    for (int i = number; i > 0; i--)
                        Console.Write(ch);
                    Console.WriteLine();
                    number--;
                }
            }           
       
        }
        
    }
}

    