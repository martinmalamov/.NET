using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestFixture]
    public    class AxeTests
    {
        
            [Test]
        public void  AxeLooseDurabilityAfterAtack()
        {
            Axe axe = new Axe(10 ,10 );
            Dummy dummy = new Dummy(15,15);

            axe.Attack(dummy);

            Assert.That(axe.DurabilityPoints, Is.EqualTo(9), "Axe durability doesn't change  after attack");


        }

    }
}
