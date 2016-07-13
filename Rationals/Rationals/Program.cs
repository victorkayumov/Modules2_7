using System;

namespace Rationals
{
    //It's better to exctract such types to a new file.
    #region Struct
    public struct Rational
        {

        public Rational(int numerator, int denominator)
        {
            Numenator = numerator;
            Denomirator = denominator;
        }
        public Rational(int numerator)
        {
            Numenator = numerator;
            Denomirator = 1;
        }

            public int Numenator { get; private set; }
            public int Denomirator { get; private set; }
            public double Value { get { return (double)this.Numenator / this.Denomirator; } }
            
           
            public Rational Add(Rational rational)
            {
                if (Denomirator == rational.Denomirator) //Checks if the denominator is the same
                {
                    var newRationalNumber = new Rational(Numenator + rational.Numenator, Denomirator);
                    return newRationalNumber;
                }
                else
                {
                    int denomirator = Denomirator * rational.Denomirator;
                    var newRationalNumber = new Rational((denomirator / rational.Denomirator) * rational.Numenator
                        + (denomirator / Denomirator) * Numenator, denomirator);
                    return newRationalNumber;
                }
            }

            public Rational Mul(Rational rational)
            {
                var newRationalNumber = new Rational(Numenator * rational.Numenator, Denomirator * rational.Denomirator);
                return newRationalNumber;
            }

            public void Reduce()
            {
                var numerator = Numenator;
                 Numenator /= Gcd(Numenator, Denomirator); 
                 Denomirator /= Gcd(numerator, Denomirator);
            }
          
        // Greatest Common Divisor, from internet
        public static int Gcd(int a, int b) 
        {
            while (true)
            {
                if (b == 0)
                {
                    return a;
                }
                var r = a % b;
                a = b;
                b = r;
            }
        }

        //You don't have to call 'ToString'. the '+' string operator will do that for you for each object are are contactenating with a string
        //Also, you could use string interpolation or string.format.
        //try: return $"{Numenator}/{Denomirator}".
        public override string ToString()
        {
            return Numenator.ToString() + "/" + Denomirator.ToString();
        }

    }
    #endregion


    class Program
        {
            static void Main(string[] args)
            {
                var rational = new Rational(7);
                var rational1 = new Rational(1, 2);
                var rational2 = new Rational(1, 4);

                var rational3 = rational1.Add(rational2);
                var rational4 = rational1.Mul(rational2);
                var rational5 = rational.Add(rational1);

                Console.WriteLine("Calculations of rational numbers\n");
                Console.WriteLine(rational1.ToString() + " + " + rational2.ToString() + " = " + rational3.ToString() + " = " + rational3.Value);
                Console.WriteLine(rational1.ToString() + " * " + rational2.ToString() + " = " + rational4.ToString() + " = " + rational4.Value);
                Console.WriteLine(rational.ToString() + " + " + rational1.ToString() + " = " + rational5.ToString() + " = " + rational5.Value);


                 rational1.Reduce();
                 rational2.Reduce();
                 rational3.Reduce();
                 rational4.Reduce();
                 rational5.Reduce();

                Console.WriteLine("\nAfter reduce rational numbers\n");

                Console.WriteLine(rational1.ToString() + " + " + rational2.ToString() + " = " + rational3.ToString() + " = " + rational3.Value);
                Console.WriteLine(rational1.ToString() + " * " + rational2.ToString() + " = " + rational4.ToString() + " = " + rational4.Value);
                Console.WriteLine(rational.ToString() + " + " + rational1.ToString() + " = " + rational5.ToString() + " = " + rational5.Value);
        }
    }
        
  }
