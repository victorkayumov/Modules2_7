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
                    Console.Write(String.Format("{0,3} "+ "|",row*column));
                }
                Console.WriteLine("");
            }
        }
    }
}

