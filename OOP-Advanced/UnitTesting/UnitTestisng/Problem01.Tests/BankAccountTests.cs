using NUnit.Framework;
using System;
using System.Linq;

namespace Problem01.Tests
{
    public class BankAccountTests
    {
        [Test]
        public void ValidateDepositAmount()
        {
            string actual = "123";
            var collection = Enumerable.Range(1, 100);

          //  Assert.That(actual, Does.Contain("2"));

            Assert.That(collection,Has.Member(4));

            
        }
    }
}
