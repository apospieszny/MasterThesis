using NUnit.Framework;
using System;
using Library.files.resources;


/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Library.Tests.GPT35.alsoFirst
{
    [TestFixture]
    public class BookTests
    {
        private Book book;

        [SetUp]
        public void SetUp()
        {
            book = new Book(1, "Sample Title", "Sample Author", 2020);
        }

        [Test]
        public void Constructor_ShouldInitializeProperties()
        {
            Assert.AreEqual(1, book.GetID());
            Assert.IsTrue(book.GetStatus());
            Assert.AreEqual(0, book.GetUserID());
        }

        [Test]
        public void DisplayInfo_ShouldOutputCorrectInformation()
        {
            // Redirect Console output to a string writer
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                book.DisplayInfo();
                var result = sw.ToString().Trim();
                Assert.AreEqual("ID: 1, Title: Sample Title, Author: Sample Author, Year: 2020", result);
            }
        }

        [Test]
        public void GetStatus_ShouldReturnAvailabilityStatus()
        {
            Assert.IsTrue(book.GetStatus());
        }

        [Test]
        public void ChangeStatus_ShouldToggleAvailability()
        {
            book.ChangeStatus();
            Assert.IsFalse(book.GetStatus());
            book.ChangeStatus();
            Assert.IsTrue(book.GetStatus());
        }

        [Test]
        public void ChangeUser_ShouldUpdateUserId()
        {
            book.ChangeUser(5);
            Assert.AreEqual(5, book.GetUserID());
        }

        [Test]
        public void RateBook_ShouldAddRating()
        {
            book.RateBook(4.5);
            Assert.AreEqual(4.5, book.GetAverageRating());
        }

        [Test]
        public void RateBook_ShouldThrowExceptionForNegativeRating()
        {
            var ex = Assert.Throws<ArgumentException>(() => book.RateBook(-1));
            Assert.AreEqual("Ocena powinna być nieujemna.", ex.Message);
        }

        [Test]
        public void GetAverageRating_ShouldReturnZeroIfNoRatings()
        {
            Assert.AreEqual(0, book.GetAverageRating());
        }

        [Test]
        public void GetAverageRating_ShouldReturnCorrectAverage()
        {
            book.RateBook(3.0);
            book.RateBook(4.0);
            book.RateBook(5.0);
            Assert.AreEqual(4.0, book.GetAverageRating());
        }
    }
}


/*
using NUnit.Framework;
using System;

namespace Library.files.resources.Tests
{
    [TestFixture]
    public class BookTests
    {
        private Book book;

        [SetUp]
        public void SetUp()
        {
            book = new Book(1, "Sample Title", "Sample Author", 2020);
        }

        [Test]
        public void Constructor_ShouldInitializeProperties()
        {
            Assert.AreEqual(1, book.GetID());
            Assert.AreEqual("Sample Title", book.GetTitle());
            Assert.AreEqual("Sample Author", book.GetAuthor());
            Assert.AreEqual(2020, book.GetYear());
            Assert.IsTrue(book.GetStatus());
            Assert.AreEqual(0, book.GetUserID());
        }

        [Test]
        public void DisplayInfo_ShouldOutputCorrectInformation()
        {
            // Redirect Console output to a string writer
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                book.DisplayInfo();
                var result = sw.ToString().Trim();
                Assert.AreEqual("ID: 1, Title: Sample Title, Author: Sample Author, Year: 2020", result);
            }
        }

        [Test]
        public void GetStatus_ShouldReturnAvailabilityStatus()
        {
            Assert.IsTrue(book.GetStatus());
        }

        [Test]
        public void ChangeStatus_ShouldToggleAvailability()
        {
            book.ChangeStatus();
            Assert.IsFalse(book.GetStatus());
            book.ChangeStatus();
            Assert.IsTrue(book.GetStatus());
        }

        [Test]
        public void ChangeUser_ShouldUpdateUserId()
        {
            book.ChangeUser(5);
            Assert.AreEqual(5, book.GetUserID());
        }

        [Test]
        public void RateBook_ShouldAddRating()
        {
            book.RateBook(4.5);
            Assert.AreEqual(4.5, book.GetAverageRating());
        }

        [Test]
        public void RateBook_ShouldThrowExceptionForNegativeRating()
        {
            var ex = Assert.Throws<ArgumentException>(() => book.RateBook(-1));
            Assert.AreEqual("Ocena powinna być nieujemna.", ex.Message);
        }

        [Test]
        public void GetAverageRating_ShouldReturnZeroIfNoRatings()
        {
            Assert.AreEqual(0, book.GetAverageRating());
        }

        [Test]
        public void GetAverageRating_ShouldReturnCorrectAverage()
        {
            book.RateBook(3.0);
            book.RateBook(4.0);
            book.RateBook(5.0);
            Assert.AreEqual(4.0, book.GetAverageRating());
        }
    }
}
*/