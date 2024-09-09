using NUnit.Framework;
using Library.files.resources;
using System;


/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Library.Tests.GPT4.first
{
    [TestFixture]
    public class BookTests
    {
        [Test]
        public void Constructor_WithValidParameters_InitializesPropertiesCorrectly()
        {
            var book = new Book(1, "Sample Title", "Sample Author", 2020);

            Assert.AreEqual(1, book.GetID());
            Assert.IsTrue(book.GetStatus());
            Assert.AreEqual(0, book.GetUserID());
        }

        [Test]
        public void DisplayInfo_DisplaysCorrectInformation()
        {
            var book = new Book(1, "Sample Title", "Sample Author", 2020);
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                book.DisplayInfo();

                var expected = $"ID: 1, Title: Sample Title, Author: Sample Author, Year: 2020{Environment.NewLine}";
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void GetStatus_InitiallyTrue_ReturnsTrue()
        {
            var book = new Book(1, "Sample Title", "Sample Author", 2020);

            Assert.IsTrue(book.GetStatus());
        }

        [Test]
        public void ChangeStatus_TogglesStatusCorrectly()
        {
            var book = new Book(1, "Sample Title", "Sample Author", 2020);
            book.ChangeStatus();

            Assert.IsFalse(book.GetStatus());

            book.ChangeStatus();

            Assert.IsTrue(book.GetStatus());
        }

        [Test]
        public void ChangeUser_UpdatesUserId()
        {
            var book = new Book(1, "Sample Title", "Sample Author", 2020);
            book.ChangeUser(100);

            Assert.AreEqual(100, book.GetUserID());
        }

        [Test]
        public void RateBook_WithValidRating_AddsRatingToList()
        {
            var book = new Book(1, "Sample Title", "Sample Author", 2020);
            book.RateBook(5);

            Assert.AreEqual(5, book.GetAverageRating());
        }

        [Test]
        public void RateBook_WithInvalidRating_ThrowsArgumentException()
        {
            var book = new Book(1, "Sample Title", "Sample Author", 2020);

            Assert.Throws<ArgumentException>(() => book.RateBook(-1));
        }

        [Test]
        public void GetAverageRating_WithMultipleRatings_CalculatesCorrectAverage()
        {
            var book = new Book(1, "Sample Title", "Sample Author", 2020);
            book.RateBook(3);
            book.RateBook(5);
            book.RateBook(4);

            var averageRating = book.GetAverageRating();

            Assert.AreEqual(4, averageRating);
        }

        [Test]
        public void GetAverageRating_WithNoRatings_ReturnsZero()
        {
            var book = new Book(1, "Sample Title", "Sample Author", 2020);

            Assert.AreEqual(0, book.GetAverageRating());
        }
    }
}

/*
using NUnit.Framework;
using Library.files.resources;
using System;

namespace Library.Tests
{
    [TestFixture]
    public class BookTests
    {
        [Test]
        public void Constructor_WithValidParameters_InitializesPropertiesCorrectly()
        {
            var book = new Book(1, "Sample Title", "Sample Author", 2020);

            Assert.AreEqual(1, book.GetID());
            Assert.AreEqual("Sample Title", book.Title);
            Assert.AreEqual("Sample Author", book.Author);
            Assert.AreEqual(2020, book.Year);
            Assert.IsTrue(book.GetStatus());
            Assert.AreEqual(0, book.GetUserID());
        }

        [Test]
        public void DisplayInfo_DisplaysCorrectInformation()
        {
            var book = new Book(1, "Sample Title", "Sample Author", 2020);
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                book.DisplayInfo();

                var expected = $"ID: 1, Title: Sample Title, Author: Sample Author, Year: 2020{Environment.NewLine}";
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void GetStatus_InitiallyTrue_ReturnsTrue()
        {
            var book = new Book(1, "Sample Title", "Sample Author", 2020);

            Assert.IsTrue(book.GetStatus());
        }

        [Test]
        public void ChangeStatus_TogglesStatusCorrectly()
        {
            var book = new Book(1, "Sample Title", "Sample Author", 2020);
            book.ChangeStatus();

            Assert.IsFalse(book.GetStatus());

            book.ChangeStatus();

            Assert.IsTrue(book.GetStatus());
        }

        [Test]
        public void ChangeUser_UpdatesUserId()
        {
            var book = new Book(1, "Sample Title", "Sample Author", 2020);
            book.ChangeUser(100);

            Assert.AreEqual(100, book.GetUserID());
        }

        [Test]
        public void RateBook_WithValidRating_AddsRatingToList()
        {
            var book = new Book(1, "Sample Title", "Sample Author", 2020);
            book.RateBook(5);

            Assert.AreEqual(5, book.GetAverageRating());
        }

        [Test]
        public void RateBook_WithInvalidRating_ThrowsArgumentException()
        {
            var book = new Book(1, "Sample Title", "Sample Author", 2020);

            Assert.Throws<ArgumentException>(() => book.RateBook(-1));
        }

        [Test]
        public void GetAverageRating_WithMultipleRatings_CalculatesCorrectAverage()
        {
            var book = new Book(1, "Sample Title", "Sample Author", 2020);
            book.RateBook(3);
            book.RateBook(5);
            book.RateBook(4);

            var averageRating = book.GetAverageRating();

            Assert.AreEqual(4, averageRating);
        }

        [Test]
        public void GetAverageRating_WithNoRatings_ReturnsZero()
        {
            var book = new Book(1, "Sample Title", "Sample Author", 2020);

            Assert.AreEqual(0, book.GetAverageRating());
        }
    }
}
*/