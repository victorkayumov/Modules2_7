using System;

namespace GenericApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var multiDictionary = new MultiDictionary<int, string>();

            multiDictionary.Add(1, "one");
            multiDictionary.Add(2, "two");
            multiDictionary.Add(3, "three");
            multiDictionary.Add(1, "ich");
            multiDictionary.Add(2, "nee");
            multiDictionary.Add(3, "sun");


            foreach (var key in multiDictionary)
            {
                foreach (var value in key.Value)
                {
                    Console.WriteLine($"Key = {key.Key}  :  Value = {value}");
                }
            }
        }
    }
}
