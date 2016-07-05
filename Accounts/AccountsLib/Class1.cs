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
                Console.WriteLine("The amount can't be less or equal to zero!!!");
                return false;
            }
            else if (amount > Balance)
            {
                Console.WriteLine($"id number {Id} don't allow to go into overdraft. Your Balance is: {Balance}");
                return false;
            }
            else
            {
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
