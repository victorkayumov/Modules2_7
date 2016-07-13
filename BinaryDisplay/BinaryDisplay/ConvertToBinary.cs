using System;

namespace BinaryDisplay
{
    public class ConvertToBinary
    {
        public string IntToBinaryString(int number)
        {
            int count = 0;

            var binary = string.Empty;
            if (number == 0)
            {
                //It isn't a good idea to print that here.
                //Seperation of concerns, single responsiblity, etc...
                Console.WriteLine("The number of ones is: {0}", number);
                return "0000";
            }

            if (number < 0)
            {
                //Ok, nice.
                //Try to implement it yourslef :)
                binary = Convert.ToString(number, 2);//convert number to binary

       
                var arr = binary.ToCharArray();

                //Not good. It is 'cheating. Where is the bitwise operations?
                //It works exactly as positive numbers.
                foreach (var array in arr)
                {
                    if (array == '1')
                        count++;
                }
                Console.WriteLine("The number of ones is: {0}", count);
                return binary;
            }
            while (number > 0)
            {
                //You are appending an unkown numbers of strings (max 32) without using a StringBuilder.
                // this isn't the most effienct way.
                binary = (number & 1) + binary;

                //You did the same calculation (number & 1) twice.
                if ((number & 1) == 1)
                {   
                    count++;
                    
                }
                number = number >> 1; 

            }
            Console.WriteLine("The number of ones is: {0}", count);
            return binary;
        }



    }

}