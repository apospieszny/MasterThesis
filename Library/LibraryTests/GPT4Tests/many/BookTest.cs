using NUnit.Framework;
using Library.files.resources;
using System;


/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Library.Tests.GPT4.many
{
    [TestFixture]
    public class BookTests
    {
        private Book book;

        [SetUp]
        public void Setup()
        {
            book = new Book(1, "Test Title", "Test Author", 2020);
        }

        [Test]
        public void Constructor_ShouldInitializeFieldsCorrectly()
        {
            Assert.AreEqual(1, book.GetID());
            Assert.IsTrue(book.GetStatus());
            Assert.AreEqual(0, book.GetUserID());
        }

        [Test]
        public void DisplayInfo_ShouldOutputCorrectInformation()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                book.DisplayInfo();

                var result = sw.ToString().Trim();
                Assert.AreEqual($"ID: 1, Title: Test Title, Author: Test Author, Year: 2020", result);
            }
        }

        [Test]
        public void GetStatus_InitiallyTrue()
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
            book.ChangeUser(123);
            Assert.AreEqual(123, book.GetUserID());
        }

        [Test]
        public void RateBook_ShouldAddRatingCorrectly()
        {
            book.RateBook(5);
            Assert.AreEqual(5, book.GetAverageRating());
        }

        [Test]
        public void RateBook_WithNegativeRating_ShouldThrowArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => book.RateBook(-1));
            Assert.That(ex.Message, Is.EqualTo("Ocena powinna być nieujemna."));
        }

        [Test]
        public void GetAverageRating_WithMultipleRatings_ShouldCalculateCorrectAverage()
        {
            book.RateBook(5);
            book.RateBook(3);
            book.RateBook(4);
            double expectedAverage = (5 + 3 + 4) / 3.0;
            Assert.AreEqual(expectedAverage, book.GetAverageRating());
        }

        [Test]
        public void GetAverageRating_WithNoRatings_ShouldReturnZero()
        {
            Assert.AreEqual(0, book.GetAverageRating());
        }

        // dodatkowe testy

        [Test]
        public void InitialStatus_ShouldBeAvailable()
        {
            Assert.IsTrue(book.GetStatus());
        }

        [Test]
        public void Constructor_ShouldSetInitialUserIdToZero()
        {
            Assert.AreEqual(0, book.GetUserID());
        }

        [Test]
        public void ResetUser_ShouldSetUserIdToZero()
        {
            book.ChangeUser(123);
            book.ChangeUser(0);
            Assert.AreEqual(0, book.GetUserID());
        }

        [Test]
        public void RateBook_WithExtremeHighRating_ShouldAddCorrectly()
        {
            book.RateBook(1000);
            Assert.AreEqual(1000, book.GetAverageRating());
        }

    }
}


/*
using NUnit.Framework;
using Library.files.resources;
using System;

namespace Library.UnitTests
{
    [TestFixture]
    public class BookTests
    {
        private Book book;

        [SetUp]
        public void Setup()
        {
            book = new Book(1, "Test Title", "Test Author", 2020);
        }

        [Test]
        public void Constructor_ShouldInitializeFieldsCorrectly()
        {
            Assert.AreEqual(1, book.GetID());
            Assert.AreEqual("Test Title", book.Title);
            Assert.AreEqual("Test Author", book.Author);
            Assert.AreEqual(2020, book.Year);
            Assert.IsTrue(book.GetStatus());
            Assert.AreEqual(0, book.GetUserID());
        }

        [Test]
        public void DisplayInfo_ShouldOutputCorrectInformation()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                book.DisplayInfo();

                var result = sw.ToString().Trim();
                Assert.AreEqual($"ID: 1, Title: Test Title, Author: Test Author, Year: 2020", result);
            }
        }

        [Test]
        public void GetStatus_InitiallyTrue()
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
            book.ChangeUser(123);
            Assert.AreEqual(123, book.GetUserID());
        }

        [Test]
        public void RateBook_ShouldAddRatingCorrectly()
        {
            book.RateBook(5);
            Assert.AreEqual(5, book.GetAverageRating());
        }

        [Test]
        public void RateBook_WithNegativeRating_ShouldThrowArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => book.RateBook(-1));
            Assert.That(ex.Message, Is.EqualTo("Ocena powinna być nieujemna."));
        }

        [Test]
        public void GetAverageRating_WithMultipleRatings_ShouldCalculateCorrectAverage()
        {
            book.RateBook(5);
            book.RateBook(3);
            book.RateBook(4);
            double expectedAverage = (5 + 3 + 4) / 3.0;
            Assert.AreEqual(expectedAverage, book.GetAverageRating());
        }

        [Test]
        public void GetAverageRating_WithNoRatings_ShouldReturnZero()
        {
            Assert.AreEqual(0, book.GetAverageRating());
        }

        // dodatkowe testy

        [Test]
        public void InitialStatus_ShouldBeAvailable()
        {
            Assert.IsTrue(book.GetStatus());
        }

        [Test]
        public void Constructor_ShouldSetInitialUserIdToZero()
        {
            Assert.AreEqual(0, book.GetUserID());
        }

        [Test]
        public void ResetUser_ShouldSetUserIdToZero()
        {
            book.ChangeUser(123);
            book.ChangeUser(0);
            Assert.AreEqual(0, book.GetUserID());
        }

        [Test]
        public void RateBook_WithExtremeHighRating_ShouldAddCorrectly()
        {
            book.RateBook(1000);
            Assert.AreEqual(1000, book.GetAverageRating());
        }

        [Test]
        public void Constructor_ShouldSetCorrectTitleAuthorAndYear()
        {
            Assert.AreEqual("Test Title", book.Title);
            Assert.AreEqual("Test Author", book.Author);
            Assert.AreEqual(2020, book.Year);
        }

    }
}
*/