using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huseyn_Task4
{
    class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }

        public SavingsAccount(string name, double initialBalance, double rate)
            : base(name, initialBalance) 
        {
            InterestRate = rate;
        }

        public void CalculateInterest()
        {
            double interest = Balance * (InterestRate / 100);
            Console.WriteLine($"Faiz dərəcəsi: {InterestRate}%, Hesablanmış faiz məbləği: {interest} AZN");
        }
    }
}
