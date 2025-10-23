using BankAccountLibrary;
using System.Security.Principal;

namespace TestAccount
{
    [TestClass]
    public sealed class TestAccount
    {
        [TestMethod]
        public void TestCredit()
        {
            Account account = new Account("Saving", 1000, "10101011");
            account.Credit(500);
            Assert.AreEqual(1500, account.AccountBalance);
        }

        [TestMethod]
        public void TestDebit()
        {
            Account account = new Account("Saving", 1000, "10101011");
            account.Debit(300);
            Assert.AreEqual(700, account.AccountBalance);
        }

        [TestMethod]
        public void TestDebit_NegativeAmount()
        {
            Account account = new Account("Saving", 1000, "10101011");
            account.Debit(-200);
            Assert.AreEqual(1000, account.AccountBalance);

        }
    }
}