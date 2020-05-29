using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestFixture]
    public class DummyTests
    {
        private const int DummyHealth = 10;
        private const int DummyExperience = 10;
        private const int AttackPoints = 10;
        private Dummy dummy;

        public DummyTests()
        {
            this.dummy = new Dummy(DummyHealth, DummyExperience);
        }

            [Test]
        public void DummyTestIfDieOrNo()
        {
            Dummy dummy = new Dummy(10, 10);
            Axe axe = new Axe(15, 15);

            //dummy.TakeAttack(15);
            dummy.TakeAttack(10);

            Assert.IsTrue(dummy.Health < DummyHealth, "Dummy is dead");
        }

        [Test]
        public void DeadDummyThrowExceptionIfAtacked()
        {
           // Dummy dummy = new Dummy(15,15);
            this.dummy.TakeAttack(6);
            this.dummy.TakeAttack(6);
            Axe axe = new Axe(10,15);
            //var ex = Assert.Throws<InvalidOperationException>(() => this.dummy.TakeAttack(6));
            //Assert.That(ex.Message,Is.EqualTo("Dummy is dead"));

            Assert.Throws(typeof(InvalidOperationException), () => axe.Attack(dummy));
        }

        [Test]
        public void DeadDummyCanGiveXP()
        {
            
             Dummy dummy = new Dummy(0 , 123);
            var expResl = 123;
            var actualResul = dummy.GiveExperience();

            Assert.AreEqual(expResl, actualResul);
        }
        [Test]
        public void AliveDummyCantGiveXP()
        {
            Dummy dummy = new Dummy(10,123);

         

            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());


        }
    }
}
