using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(int id);

        }
    }

    public class Account
    {
        private int _id;
        public int ID { get { return _id; } }

        private double _balance;
        public double Balance { get { return _balance; } }
        

        internal Account(int accountId)
        {
            _id = accountId;
        }
        //Deposit method//
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("The amount can't be less then zero!!!");
            }
            else
            {
                _balance += amount;
                _balance = _balance + amount;
                Console.WriteLine("Your new Balance is: {0}", _balance);
            }
        }

        //WithDraw method//
        public  void WithDraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("The amount can't be less then zero!!!");
            }
            else if (amount > _balance)
            {
                Console.WriteLine("You don't allow to go into overdraft. Your Balance is: {0}", _balance);
            }
            else
            {
                _balance -= amount;
                Console.WriteLine("Your new Balance is: {0}", _balance);
            }
        }

        //Transfer method
        public void Transfer(Account anotherAccount,double amount)
        {
            
        }

    }
}
