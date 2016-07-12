using System;


namespace BinaryDisplay
{
    public class Program
    {
        static void Main(string[] args)
        {          
            Console.Write("Enter a number:");
            string str = Console.ReadLine();

            //You could have used a static method instead of creating a new instance.
            Program parse = new Program();
            parse.Parse(str);
            
        }
        public string Parse(string str)
        {
            ConvertToBinary convert = new ConvertToBinary();
            int num;
            
            //The conventino is use the int alias over int32
            if (Int32.TryParse(str, out num))
            {
                string s = convert.IntToBinaryString(num);
                Console.WriteLine("The Answer in Binary is: {0}",s);
                return str;
            }
            else
            {
                Console.WriteLine("The number is not an integer.");
                return "The number is not an integer.";    
            }
        }

       
    }
   
}

