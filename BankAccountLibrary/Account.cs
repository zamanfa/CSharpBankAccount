using DocumentFormat.OpenXml.Wordprocessing;
using System.ComponentModel.Design;

namespace BankAccountLibrary
{
    public class Account
    {
        private string Name = "Default Account";
        private Name name;
        private decimal Balance = 0.0m;
        private string accountNumber = "000000";

        public Account(string name = "Default Account", decimal Balance = 0.0m, string accountNumber = "000000")
        {
            this.Name = name;
            this.Balance = Balance;
            this.accountNumber = accountNumber;
        }

        public Account(Name name, decimal balance, string accountNumber)
        {
            this.name = name;
            Balance = balance;
            this.accountNumber = accountNumber;
        }

        public string AccountName
        {
            set
            {
                while (value.Length < 10)
                { 
                    value = value + "*";
                }
                this.Name = value;
            }
        
        }

        public decimal AccountBalance
        {
            get { return this.Balance; }
            set { this.Balance = value; }
        }

        public string AccountNumber
        {
            set
            {
                while (value.Length < 10)
                { 
                    value = "0" + value;
                }

                if (value.Length > 10)
                {
                    value = value.Substring(value.Length - 10);
                }

                this.accountNumber = value;
            }
        }

        public void Credit(decimal amount)
        {
            if (amount < 0)
            {
                return;
            }
            this.Balance += amount;
        }

        public void Debit(decimal amount)
        {
            if (amount < 0 || amount > this.Balance)
            {
                return;
            }
            this.Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account Name: {this.Name}, Account Number: {this.accountNumber}, Balance: {this.Balance:C}";
        }
    }
}
