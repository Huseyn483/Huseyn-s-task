using System;

// Əsas class (Base Class)
class BankAccount
{
    public string OwnerName;
    public double Balance;

    public BankAccount(string name, double initialBalance)
    {
        OwnerName = name;
        Balance = initialBalance;
    }

    public void ShowBalance()
    {
        Console.WriteLine($"{OwnerName} - Cari balans: {Balance} AZN");
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"{amount} AZN balansa əlavə edildi.");
        }
    }
}