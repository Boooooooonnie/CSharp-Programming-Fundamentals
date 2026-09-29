using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期中指定考_3._25._03._29
{
    class Account
    {
        public string Name { get; set; }
        private decimal originalbalance;
        public Account(string accountname, decimal inputbalance)
        {
            Name = accountname;
            Balance = inputbalance;
        }
        public decimal Balance
        {
            get
            {
                return originalbalance;
            }
            private set
            {
                if(value > 0.0m)
                {
                    originalbalance = value;
                }
                else if(value < 0.0m)
                {
                    originalbalance = 0.0m;
                }
            }
        }
        public void Deposit(decimal depositAmount)
        {
            if(depositAmount > 0.0m)
            {
                Balance = Balance + depositAmount;
            }
        }
        public void Withdraw(decimal withdrawamount)
        {
            if (withdrawamount < Balance)
            {
                Balance = Balance - withdrawamount;
            }
            else
            {
                Console.WriteLine("Withdrawal amount exceeded account balance.");
            }
        }
    }
    class AccountTest
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Tom Bruice", 30.55m);
            Account account2 = new Account("John Wayne", -20.88m);

            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:c}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:c}");

            Console.Write("\nEnter deposite amount for account1: ");
            decimal depositeamount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"adding {depositeamount:c} to account1 balance\n");

            account1.Deposit(depositeamount);
            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:c}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:c}");

            Console.Write("\nEnter deposite amount for account2: ");
            depositeamount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"adding {depositeamount:c} to account2 balance\n");

            account2.Deposit(depositeamount);
            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:c}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:c}");

            Console.Write("\nEnter withdraw amount for account1: ");
            decimal withdrawamount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"subtracting {withdrawamount:c} to account1 balance\n");

            account1.Withdraw(withdrawamount);
            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:c}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:c}");

            Console.Write("\nEnter withdraw amount for account2: ");
            withdrawamount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"subtracting {withdrawamount:c} to account2 balance\n");

            account2.Withdraw(withdrawamount);
            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:c}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:c}");

            Console.ReadLine();
        }
    }

}
