using System;

namespace Lab2._2
{
    public class Calculations
    {
        public double Divide(double number1, double number2)
        {
            if (number2 == 0)
            {
                throw new DivideByZeroException();
            }

            return (number1 / number2);
        }
        public double Add(double number1, double number2)
        {
            // Usually, we would use the alias "double" instead of "Double".
            if (number1 + number2 >= Double.MaxValue)
            {
                throw new OverflowException();
            }

            return number1 + number2;
        }
        public double Multiply(double number1, double number2)
        {
            // No overflow check? 
            return number1 * number2;
        }
        public double Substract(double number1, double number2)
        {
            // No overflow check?
            return number1 - number2;
        }
    }

    public class Calculator
    {
        private static void Main()
        {
            // What is the meaning for 'fNumber' and 'sNumber'? 
            double fNumber;
            double sNumber;
            var validOperator = false;
            Calculations myCalc = new Calculations();

            Console.Write("Insert First Number: ");
            double.TryParse(Console.ReadLine(), out fNumber);
            Console.Write("Insert Second Number: ");
            double.TryParse(Console.ReadLine(), out sNumber);

            // No validation check for fNumber & sNumber?

            // The convention is to use "!validOperator"
            // Also, you could have used a do-while loop
            while (validOperator == false)
            {
                Console.Write("Insert operator ( + / - * ) that you want: ");
                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "/":
                        try
                        {
                            Console.WriteLine("The Answer is: " + myCalc.Divide(fNumber, sNumber));

                            // Why is this here? Didn't you check this at myCalc.Divide?
                            if (sNumber == 0)
                            {
                                throw new DivideByZeroException();
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Can't Divide By Zero");
                        }
                        validOperator = true;
                        break;
                    case "+":
                        try
                        {
                            Console.WriteLine("The Answer is: " + myCalc.Add(fNumber, sNumber));

                            // Why is this here? Didn't you check this at myCalc.Add?
                            if (fNumber + sNumber >= Double.MaxValue)
                            {
                                throw new OverflowException();
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Overflow Exception");
                        }

                        validOperator = true;
                        break;
                    case "*":
                        Console.WriteLine("The Answer is: " + myCalc.Multiply(fNumber, sNumber));
                        validOperator = true;
                        break;
                    case "-":
                        Console.WriteLine("The Answer is: " + myCalc.Substract(fNumber, sNumber));
                        validOperator = true;
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}