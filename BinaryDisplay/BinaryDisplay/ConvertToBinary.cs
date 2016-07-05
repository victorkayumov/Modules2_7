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
                Console.WriteLine("The number of ones is: {0}", number);
                return "0000";
            }
            if (number < 0)
            {
                binary = Convert.ToString(number, 2);//convert number to binary
                var arr = binary.ToCharArray();
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
                binary = (number & 1) + binary;

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