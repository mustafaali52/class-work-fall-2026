using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Account
{
    public class BankAccount
    {
        private decimal _balance;       // private backing field
        private string _owner;

        // Full property — logic in setter prevents negative balance
        public decimal Balance
        {
            get { return _balance; }
            private set                  // only this class can write
            {
                if (value < 0)
                    throw new ArgumentException("Balance cannot be negative.");
                _balance = value;
            }
        }

        // Auto-implemented property (compiler creates backing field)
        public string AccountNumber { get; private set; }

        // Expression-bodied read-only property (C# 6+)
        public bool IsOverdrawn => _balance < 0;

        // Init-only property — can only be set during object creation (C# 9+)
        public string Owner { get; init; }

        public BankAccount(string owner, string accountNumber)
        {
            Owner = owner;
            AccountNumber = accountNumber;
            Balance = 0;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Amount must be positive.");
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance) throw new InvalidOperationException("Insufficient funds.");
            Balance -= amount;
        }

        public override string ToString()
            => $"Account {AccountNumber} ({Owner}): {Balance:C}";

    }
}
