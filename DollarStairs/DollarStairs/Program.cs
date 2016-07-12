using System;

namespace DollarStairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            
            //No error message when the number is not valid
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                //Nice addition
                Console.Write("Enter a character: ");
                var ch = Console.ReadLine();

                while (number > 0)
                {
                    //You are printing the pyramid upside down
                    for (int i = number; i > 0; i--)
                        Console.Write(ch);

                    Console.WriteLine();
                    number--;
                }
            }           
       
        }
        
    }
}

    