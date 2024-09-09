using Library.files.resources;
using NUnit.Framework;
using System;


/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Library.Tests.gemini.many
{
    [TestFixture]
    public class BookTests
    {
        [Test]
        public void Constructor_CreatesBookWithCorrectValues()
        {
            var book = new Book(1, "Title", "Author", 2023);

            Assert.AreEqual(1, book.GetID());
            Assert.IsTrue(book.GetStatus());
            Assert.AreEqual(0, book.GetUserID());
        }

        [Test]
        public void GetStatus_ReturnsCorrectAvailability()
        {
            var book = new Book(3, "Third Title", "Third Author", 2021);

            Assert.IsTrue(book.GetStatus());

            book.ChangeStatus();
            Assert.IsFalse(book.GetStatus());
        }

        [Test]
        public void ChangeUser_UpdatesUserId()
        {
            var book = new Book(4, "Fourth Title", "Fourth Author", 2020);

            book.ChangeUser(123);

            Assert.AreEqual(123, book.GetUserID());
        }

        [Test]
        public void RateBook_ThrowsException_NegativeRating()
        {
            var book = new Book(6, "Sixth Title", "Sixth Author", 2018);

            Assert.Throws<ArgumentException>(() => book.RateBook(-1));
        }

        [Test]
        public void GetAverageRating_CalculatesCorrectAverage()
        {
            var book = new Book(7, "Seventh Title", "Seventh Author", 2017);

            book.RateBook(3.5);
            book.RateBook(4.0);
            book.RateBook(5.0);

            Assert.AreEqual(4.166666666666667, book.GetAverageRating());
        }

        [Test]
        public void GetAverageRating_ReturnsZero_NoRatings()
        {
            var book = new Book(8, "Eighth Title", "Eighth Author", 2016);

            Assert.AreEqual(0, book.GetAverageRating());
        }

        // dodatkowe testy


        [Test]
        public void GetAverageRating_EmptyList()
        {
            var book = new Book(1, "Title", "Author", 2023);
            Assert.AreEqual(0, book.GetAverageRating());
        }

        [Test]
        public void ChangeStatus_MultipleTimes()
        {
            var book = new Book(1, "Title", "Author", 2023);
            book.ChangeStatus();
            book.ChangeStatus();
            Assert.IsTrue(book.GetStatus());
        }

        [Test]
        public void ChangeUser_MultipleTimes()
        {
            var book = new Book(1, "Title", "Author", 2023);
            book.ChangeUser(123);
            book.ChangeUser(456);
            Assert.AreEqual(456, book.GetUserID());
        }

        /* Testy odrzucone
        [Test]
        public void RateBook_ThrowsException_NullRating()
        {
            var book = new Book(1, "Title", "Author", 2023);
            Assert.Throws<ArgumentNullException>(() => book.RateBook(0));
        }
        */
    }
}

/*
using Library.files.resources;
using NUnit.Framework;
using System;

namespace Library.files.tests
{
    [TestFixture]
    public class BookTests
    {
        [Test]
        public void Constructor_CreatesBookWithCorrectValues()
        {
            var book = new Book(1, "Title", "Author", 2023);

            Assert.AreEqual(1, book.GetID());
            Assert.AreEqual("Title", book.Title);
            Assert.AreEqual("Author", book.Author);
            Assert.AreEqual(2023, book.Year);
            Assert.IsTrue(book.GetStatus());
            Assert.AreEqual(0, book.GetUserID());
            Assert.AreEqual(0, book.Ratings.Count);
        }

        [Test]
        public void DisplayInfo_PrintsCorrectInformation()
        {
            var book = new Book(2, "Another Title", "Another Author", 2022);

            var consoleOutput = TestContext.Out.Capture();
            book.DisplayInfo();
            var capturedOutput = consoleOutput.ToString();

            Assert.IsTrue(capturedOutput.Contains("ID: 2"));
            Assert.IsTrue(capturedOutput.Contains("Title: Another Title"));
            Assert.IsTrue(capturedOutput.Contains("Author: Another Author"));
            Assert.IsTrue(capturedOutput.Contains("Year: 2022"));
        }

        [Test]
        public void GetStatus_ReturnsCorrectAvailability()
        {
            var book = new Book(3, "Third Title", "Third Author", 2021);

            Assert.IsTrue(book.GetStatus());

            book.ChangeStatus();
            Assert.IsFalse(book.GetStatus());
        }

        [Test]
        public void ChangeUser_UpdatesUserId()
        {
            var book = new Book(4, "Fourth Title", "Fourth Author", 2020);

            book.ChangeUser(123);

            Assert.AreEqual(123, book.GetUserID());
        }

        [Test]
        public void RateBook_AddsRating_PositiveRating()
        {
            var book = new Book(5, "Fifth Title", "Fifth Author", 2019);

            book.RateBook(4.5);

            Assert.AreEqual(1, book.Ratings.Count);
            Assert.AreEqual(4.5, book.Ratings[0]);
        }

        [Test]
        public void RateBook_ThrowsException_NegativeRating()
        {
            var book = new Book(6, "Sixth Title", "Sixth Author", 2018);

            Assert.Throws<ArgumentException>(() => book.RateBook(-1));
        }

        [Test]
        public void GetAverageRating_CalculatesCorrectAverage()
        {
            var book = new Book(7, "Seventh Title", "Seventh Author", 2017);

            book.RateBook(3.5);
            book.RateBook(4.0);
            book.RateBook(5.0);

            Assert.AreEqual(4.166666666666667, book.GetAverageRating());
        }

        [Test]
        public void GetAverageRating_ReturnsZero_NoRatings()
        {
            var book = new Book(8, "Eighth Title", "Eighth Author", 2016);

            Assert.AreEqual(0, book.GetAverageRating());
        }

        // dodatkowe testy

        [Test]
        public void RateBook_AddsZeroRating()
        {
            var book = new Book(1, "Title", "Author", 2023);
            book.RateBook(0);
            Assert.AreEqual(0, book.Ratings[0]);
        }

        [Test]
        public void GetAverageRating_EmptyList()
        {
            var book = new Book(1, "Title", "Author", 2023);
            Assert.AreEqual(0, book.GetAverageRating());
        }

        [Test]
        public void ChangeStatus_MultipleTimes()
        {
            var book = new Book(1, "Title", "Author", 2023);
            book.ChangeStatus();
            book.ChangeStatus();
            Assert.IsTrue(book.GetStatus());
        }

        [Test]
        public void ChangeUser_MultipleTimes()
        {
            var book = new Book(1, "Title", "Author", 2023);
            book.ChangeUser(123);
            book.ChangeUser(456);
            Assert.AreEqual(456, book.GetUserID());
        }

        [Test]
        public void RateBook_ThrowsException_NullRating()
        {
            var book = new Book(1, "Title", "Author", 2023);
            Assert.Throws<ArgumentNullException>(() => book.RateBook(null));
        }
    }
}
*/