using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CustomersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] array = new Customer[6];

            array[0] = new Customer("victor", 1, "karmiel");
            array[1] = new Customer("dan", 2, "maalot");
            array[2] = new Customer("lior", 5, "karmiel");
            array[3] = new Customer("haim", 3, "haifa");
            array[4] = new Customer("yossi", 4, "maalot");
            array[5] = new Customer("Dan", 2, "maalot");

            Console.WriteLine("Array of customers:");           
            Display(array);

            Console.WriteLine("\nSorted array of customers:");
            Array.Sort(array);
            Display(array);

            var comparer = new Customer.AnotherCustomerComparer();
            Array.Sort(array, comparer);
            Console.WriteLine("\nSorted array by ID:");
            Display(array);
        }

        public static void Display(Customer[] array)
        {
            foreach (var customers in array)
            {
                Console.WriteLine($" Name: {customers.Name}\t Id: {customers.Id}\t Address: {customers.Address}\t");
            }
        }
    }
  

    public class Customer : IComparable<Customer>, IEquatable<Customer>
    {
        public string Name { get; set; }
        public int Id { get; }
        public string Address { get; set; }

        public Customer(string name, int id, string address)
        {
            Name = name;
            Id = id;
            Address = address;
        }



        public int CompareTo(Customer other)
        {
            return Name.ToUpper().CompareTo(other.Name.ToUpper());
        }

        public bool Equals(Customer other)
        {
            return this.Id.Equals(other.Id) && this.Name.Equals(other.Name);

        }

        public class AnotherCustomerComparer : IComparer<Customer>
        {
            public int Compare(Customer customer1, Customer customer2)
            {
                return customer1.Id.CompareTo(customer2.Id);
            }
        }
    }
}
