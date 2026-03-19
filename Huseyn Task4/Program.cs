namespace Huseyn_Task4
{
    internal class Program
    {
        static void Main()
        {
            SavingsAccount myAccount = new SavingsAccount("Sizin Adınız", 1000, 5);
            myAccount.Deposit(500);
            myAccount.ShowBalance();
            myAccount.CalculateInterest();
        }
    }
}
