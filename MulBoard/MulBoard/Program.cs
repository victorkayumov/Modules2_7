using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 1; row < 11; row++)
            {
                for (int column = 1; column < 11; column++)
                {
                    //1. Console.Write doesn't need string.Format. It has an overload that get's a format and an arguments.
                    //2. Why are you using the '+' string operator inside a string.Fomat?
                    //3. In C# we usually use the Alias string instead of String.
                    //I would have write it Console.Write("{0, 3} |", row * column);
                    Console.Write(String.Format("{0,3} "+ "|",row*column));
                }
                Console.WriteLine("");
            }
        }
    }
}

