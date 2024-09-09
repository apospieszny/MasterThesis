using NUnit.Framework;
using Library.files.resources;
using System.Collections.Generic;
using System;


/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 */

namespace Library.Tests.GPT4.alsoFirst
{
    [TestFixture]
    public class UserTests
    {
        private User _user;

        [SetUp]
        public void Setup()
        {
            _user = new User(1, "John Doe");
        }

        /* Test odrzucony
        [Test]
        public void Constructor_SetsUserIDAndName()
        {
            Assert.AreEqual(1, _user.GetID());
            Assert.AreEqual("John Doe", _user.GetType().GetProperty("Name", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_user));
        }*/

        [Test]
        public void DisplayInfo_OutputsUserIDAndName()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                _user.DisplayInfo();

                var expected = string.Format($"ID: 1, User: John Doe{Environment.NewLine}");
                Assert.That(sw.ToString(), Is.EqualTo(expected));
            }
        }

    }
}

/*
using NUnit.Framework;
using Library.files.resources;
using System.Collections.Generic;
using System;

namespace LibraryUnitTests
{
    [TestFixture]
    public class UserTests
    {
        private User _user;

        [SetUp]
        public void Setup()
        {
            _user = new User(1, "John Doe");
        }

        [Test]
        public void Constructor_SetsUserIDAndName()
        {
            Assert.AreEqual(1, _user.GetID());
            Assert.AreEqual("John Doe", _user.GetType().GetProperty("Name", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_user));
        }

        [Test]
        public void DisplayInfo_OutputsUserIDAndName()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                _user.DisplayInfo();

                var expected = string.Format($"ID: 1, User: John Doe{Environment.NewLine}");
                Assert.That(sw.ToString(), Is.EqualTo(expected));
            }
        }

    }
}
*/