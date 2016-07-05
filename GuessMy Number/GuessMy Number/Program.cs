﻿using System;

namespace GuessMy_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int secret = new Random().Next(1, 101);
            int numOfGusses = 0;

            Console.WriteLine("Enetr a Guess number: ");
            while (numOfGusses++ < 7)
            {
                int i = ParseNumber();

                if (i < secret)
                    Console.WriteLine("too small");
                else if (i > secret)
                    Console.WriteLine("too big");
                else
                {
                    Console.WriteLine("you rigth. The secret number is: {0}", secret);
                    break;
                }
            }
            if (numOfGusses == 8)
                Console.WriteLine("you have failed,The secret number is: {0}", secret);
            Console.ReadLine();
        }

         public static int ParseNumber()
         {
            int i;
            if(int.TryParse(Console.ReadLine(), out i)==false)
                throw new Exception("TryParse is failed");
             return i;
         }

        
    }
}


