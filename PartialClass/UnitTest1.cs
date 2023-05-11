using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PartialClass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Introduce()
        {
            var person = new Person("John", new DateTime(1998, 2, 26));
            Assert.AreEqual("Hi, my name is John and I'm 30 years old", person.Introduce());
            Assert.AreEqual("John", person.Name);
            Assert.AreEqual(new DateTime(1992, 2, 26), person.BirthDate);
        }
    }
}
