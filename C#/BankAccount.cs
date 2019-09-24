using System;
using System.Text;
using System.Collections.Generic;


namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var account = new BankAccount("John", 10000);
                Console.WriteLine($"Account {account.Number} was created for {account.Owner} with amount of ${account.Balance}.");

                account.MakeWithdrawal(60, DateTime.Now, "Xbox Game");
                Console.WriteLine(account.Balance);

                Console.WriteLine(account.GetAccountHistory());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }

    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in oTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        private static int NumberSeed = 1000;

        private List<Transaction> oTransactions = new List<Transaction>();

        public BankAccount(string name, decimal balance)
        {
            this.Owner = name;

            MakeDeposit(balance, DateTime.Now, "Initial Balance");

            this.Number = NumberSeed.ToString();

            NumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }

            var deposit = new Transaction(amount, date, note);
            oTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient funds");
            }

            var withdrawal = new Transaction(-amount, date, note);
            oTransactions.Add(withdrawal);
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();

            report.AppendLine("Date \t\t Amount \t\t Note");

            foreach(var item in oTransactions)
            {
                report.AppendLine($"{item.Date.ToShortDateString()} \t ${item.Amount} \t {item.Notes}");
            }

            return report.ToString();
        }
    }

    public class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}