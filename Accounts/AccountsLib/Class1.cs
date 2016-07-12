using System;

namespace AccountsLib
{

    public class Account
    {
 #region Property
       // private readonly int _id;
        public int Id { get; }

       // private double _balance;
        public double Balance { get; private set; }
#endregion  
        internal Account(int accountId)
        {
            Id = accountId;         
        }
#region Methods

        //Deposit method//
        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                //Not good. how the client should know that the deposite failed? how the Unit tests will know? 
                Console.WriteLine("The amount must be more then zero!!!");
            }
            else
            {
                Balance += amount;
                Console.WriteLine($"id number {Id} Your new Balance is: {Balance}");
            }
        }

        //WithDraw method//
        public bool WithDraw(double amount)
        {
            if (amount <= 0)
            {
                //It isn't a good idea print messages to the user inside your buisness logic.
                Console.WriteLine("The amount can't be less or equal to zero!!!");
                return false;
            }
            else if (amount > Balance)
            {
                //It isn't a good idea print messages to the user inside your buisness logic.
                Console.WriteLine($"id number {Id} don't allow to go into overdraft. Your Balance is: {Balance}");
                return false;
            }
            // The else is not neccessary. Consider using ReSharper
            else
            {
                //It isn't a good idea print messages to the user inside your buisness logic.
                Balance -= amount;
                Console.WriteLine($"id number {Id} your new balance after withdraw/transference is: { Balance}");
            }
            return true;
        }

        //Transfer method
        public void Transfer(Account distenationAccount, double amount)
        {
            if (!WithDraw(amount))
            { 
                //How would you unit test this if this doesn't return a value or throw an exception?
                //How will the user now? 
                Console.WriteLine("Can't transfer the money");
            }
            else
            {
                distenationAccount.Balance += amount;
                Console.WriteLine($"id number {distenationAccount.Id} new Balance is: {distenationAccount.Balance}");
            }
        }
#endregion 
    }

    public static class AccountFactory
    {
        private static int _id=1;
        public static Account CreateAccount(double initialBalance)
        {    
            Account acc = new Account(_id++);
            acc.Deposit(initialBalance);
            return acc;
            
        }
    }
}
