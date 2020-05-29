using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem01.Tests
{
    
    [TestFixture]
    public class BankAccount
    {
        public BankAccount(decimal amount)
        {
            this.Amount = amount;
        }
        private decimal Amount { get; set; }

        [Test]
        public void Account()
        {
            BankAccount bankAccount = new BankAccount(2000m);
            Assert.That(bankAccount.Amount, Is.EqualTo(2000));

        }
    }
}
