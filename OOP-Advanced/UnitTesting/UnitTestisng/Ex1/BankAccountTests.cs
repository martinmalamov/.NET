using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Tests
{
    [TestFixture]
   public class BankAccountTests
    {
       

        public BankAccountTests(decimal amount)
        {
            this.Amount = amount;
        }
        private decimal Amount { get; set; }

        [Test]
        public void Account()
        {
            BankAccountTests bankAccount = new BankAccountTests(2000m);
            Assert.That(bankAccount.Amount, Is.EqualTo(2000));

        }
    }
}
