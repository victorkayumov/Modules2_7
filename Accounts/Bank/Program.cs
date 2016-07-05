using AccountsLib;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var acc = AccountFactory.CreateAccount(1000);
            var acc2 = AccountFactory.CreateAccount(900);
            var acc3 = AccountFactory.CreateAccount(0);
            acc.Deposit(50);
            acc2.Deposit(800);
            acc.WithDraw(100);
            acc.Transfer(acc2,400);
            acc2.Transfer(acc3, 400);
        }
    }
}
