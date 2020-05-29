namespace DataBaseTests
{
    using NUnit.Framework;
    using Database.Ex1;
    using System.Reflection;
    using System;
    using System.Linq;

    [TestFixture]
    public class DbTests
    {
        private const int ArraySize = 16;   

        [Test]
        public void EmptyConstructorShouldInitData()
        {
            Database db = new Database();
            //Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = typeof(Database);

            var field =     (int[])type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).First(t => t.Name == "data")
                .GetValue(db);

            var lenght = field.Length;

            Assert.That(lenght, Is.EqualTo(ArraySize));

        }
    }


}