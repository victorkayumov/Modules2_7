using System;
using System.Collections;

namespace Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum = 0;
            Console.WriteLine("Insert two integer numbers");
            Int32.TryParse((Console.ReadLine()), out num1);
            Int32.TryParse((Console.ReadLine()), out num2);
            ArrayList array = new ArrayList();

            array = CalcPrimes(num1, num2);
            Console.Write($"The sum of all prime numbers in the range {num1} to {num2} is: ");
            foreach (var arr in array)
            {
                sum += Convert.ToInt32(arr);
            }
            Console.WriteLine(sum);
            Console.WriteLine("The result is:");
            if(sum>0)
                 foreach (var arr in array)
                 {
                     Console.WriteLine(arr);
                 }
            else Console.WriteLine("NON prime numbers!!!");
        }

        public static ArrayList CalcPrimes(int num1, int num2)
        {
            var arr = new ArrayList();
            bool isPrime;
            for (int i = num1; i < num2; i++)
            {
                isPrime = true;
                if (i % 2 == 0 && i != 2)
                    isPrime = false;

                for (int j = 3; j <= i / 2 && isPrime == true; j += 2)
                {
                    if (i % j == 0)
                        isPrime = false;
                }
                if (isPrime == true)
                    arr.Add(i);
            }
            return arr;               
        }
    }
}



        