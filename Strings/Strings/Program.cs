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
                
                //Why didn't you use string.isNullOrEmpty? You used it in other place.
            } while (str != "");
        }

    }

    //usually it is better to extract the class to a different file(s)
    public class Split
    {
        //the name of the method is 'SplittingString' but it does a lot more than that. It split strings, print them and then reverse and sort them.
        //Try to find better names for methods
        public int SplitingString(string str)
        {
            //Good. Also, look at string.IsNullOrWhiteSpace
            if (string.IsNullOrEmpty(str))
                return 0 ;
            //The else is not neccessary
            else
            {
                //This doesnn't handle multiple whitespaces, or even tabs.
                //The regular expression pattern you used isn't optimal.
                //Look at the following pattern "\s+". It will match multiple whitespaces and it will solve your problem
                string[] splitStr = Regex.Split(str, @"\s+");
                foreach (var split in splitStr)
                {
                    Console.WriteLine(split);
                }

                //Nice use of the new string interpolation in C#
                Console.WriteLine($"The number of words is: {splitStr.Length}");

                var reverse = new ReverseString();
                Console.WriteLine(reverse.ReverseStr(splitStr));
                var sort = new Sort();
                Console.WriteLine(sort.SortingString(splitStr));
                return splitStr.Length;
            }
           
        }
       
    }

    //usually it is better to extract such classes to seperate file(s)
    public class ReverseString
    {
        public string ReverseStr(string[] str)
        {
            Array.Reverse(str);

            //Why didn't you return an array of strings? This approach is not good.
            return string.Join(" ", str);
        }
    }

    //Well, this class might have been better as a method.
    public class Sort
    {
        public string SortingString(string[] str)
        {
            Array.Sort(str);

            //Why didn't you return an array of strings, then printed the array? 
            return string.Join(" ", str);
        }
    }

}
