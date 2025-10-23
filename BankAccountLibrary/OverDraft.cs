using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountLibrary
{
    public class OverDraft:Account
    {
        private static Name name;

        public OverDraft(string accountNumber, string accountHolder, decimal balance, decimal overdraftLimit)
            : base(name, Balance, accountNumber)
        {
            OverdraftLimit = overdraftLimit;
        }

        public static decimal Balance { get; }
        public decimal OverdraftLimit { get; }
    }
}
