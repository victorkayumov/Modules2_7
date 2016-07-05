using AccountsLib;
using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try {
                var acc = AccountFactory.CreateAccount(1000);
                var acc2 = AccountFactory.CreateAccount(900);
                var acc3 = AccountFactory.CreateAccount(0);
                acc.Deposit(50);
                acc2.Deposit(800);
                acc.WithDraw(1000);
                acc.Transfer(acc2, 50);
                acc2.Transfer(acc3, 400);
            }
            catch (ArgumentOutOfRangeException argex)
            {
                Console.WriteLine("We have catch an ArgumentOutOfRangeException\n\n" + argex.StackTrace.ToString());
            }
            
        }
    }
}
