﻿using System;

namespace QuadNS
{
    //Input 1 -2 1 is not working it is yeileding an empty result
    public class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, toSqrt;
            Quad quad = new Quad();

            //BIG design flow. calculations shouldn't print to console. Printing to console isn't part of the calculation.
            //Remember SOLID and single responsiblity? 
            //You should have printed the results and the errors on the console

            bool num = quad.CheckArgs(args);
            if (!num)
                return;

            bool parse = quad.CheckParse(args, out a, out b, out c);
            if (!parse)
                return;

            string stringOneSolution = quad.OneSolution(a, b, c);
            if (stringOneSolution != null)
                Console.WriteLine(stringOneSolution);

            // You are not using boolNoSolution.
            toSqrt = Math.Pow(b, 2) - 4*a*c;
            bool boolNoSolution = quad.NoSolution(a, b, c, toSqrt);

            // The else is not requireed.
            // I inverted the if statement and removed the else.

            if (!(toSqrt < 0) && a != 0)
            {
                toSqrt = Math.Sqrt(toSqrt);
                string stringSolution = quad.Solution(a, b, c, toSqrt);
                Console.WriteLine(stringSolution);
            }
        }
    }

    //Not a good idea to return a string. It isn't a good design.
    public class Quad
        {
            public  string Solution(double a, double b, double c, double toSqrt)
            {
                double x1 = (- b+ toSqrt) /(2*a);
                double x2 = (-1)*(toSqrt + b)/(2*a);
                if(x1 != x2)
                return "X1 = " + x1 + "\nX2 = " + x2;
                return null;
            }

            public  bool NoSolution(double a, double b, double c, double toSqrt)
            {
                if (!(toSqrt < 0)) return false;
                Console.WriteLine("no solution");
                return true;
            }

            public  string OneSolution(double a, double b, double c)
            {
                if (a == 0)
                     return "X = " + (-1) * c / b;
                else
                 {
                     if (b == 2 * Math.Sqrt(a) * Math.Sqrt(c))
                         return "X = " + (-b / 2 * a);   
                 }
                return null;
            }

            public  bool CheckArgs(string[] args)
            {
                if (args.Length < 3)
                {
                    Console.WriteLine("should be 3 arguments");
                    return false;
                }
                return true;

            }

            public  bool CheckParse(string[] args, out double a, out double b, out double c)
            {
                if (!double.TryParse(args[0], out a) || !double.TryParse(args[1], out b) ||
                    !double.TryParse(args[2], out c))
                {
                    Console.WriteLine("parsing didn't succseed");
                    a = 0;
                    b = 0;
                    c = 0;
                    return false;
                }
                return true;
            }
        }
    }

