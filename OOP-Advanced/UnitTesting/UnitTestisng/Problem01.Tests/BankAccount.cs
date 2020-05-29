using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem01.Tests
{
    [TestFixture]
    class BankAccount
    {
        private decimal v;

        public BankAccount(decimal v)
        {
            this.Ammount = v;
        }

        public decimal Ammount { get; private set; }

        public void Deposit(decimal amount)
        {
            this.Ammount = amount;
        }

        public void Withdraw(decimal amount)
        {
            if (this.Ammount - amount >= 0)
            {
                this.Ammount -= amount;
            }
        }
        

        //public void Test()
        //{
        //    BankAccount bankAccount = new BankAccount(2000m);
        //    Assert.That(bankAccount.Ammount, Is.EqualTo(2000m));

        //}
    }
}
