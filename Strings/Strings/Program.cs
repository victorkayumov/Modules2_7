using System;
using System.Text.RegularExpressions;


namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string str;
            do
            {
                Console.WriteLine("Insert a sentence:");
                str = Console.ReadLine();

                var split = new Split();
                split.SplitingString(str);
                
            } while (str != "");
        }

    }

    public class Split
    {
        public int SplitingString(string str)
        {

            if (string.IsNullOrEmpty(str))
                return 0 ;
            else
            {
                string[] splitStr = Regex.Split(str, " ");
                foreach (var split in splitStr)
                {
                    Console.WriteLine(split);
                }
                Console.WriteLine($"The number of words is: {splitStr.Length}");

                var reverse = new ReverseString();
                Console.WriteLine(reverse.ReverseStr(splitStr));
                var sort = new Sort();
                Console.WriteLine(sort.SortingString(splitStr));
                return splitStr.Length;
            }
           
        }
       
    }

    public class ReverseString
    {
        public string ReverseStr(string[] str)
        {
            Array.Reverse(str);
            return string.Join(" ", str);
        }
    }
    public class Sort
    {
        public string SortingString(string[] str)
        {
            Array.Sort(str);
            return string.Join(" ", str);
        }
    }

}
