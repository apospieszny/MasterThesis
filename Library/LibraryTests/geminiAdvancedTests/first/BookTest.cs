using Library.files.interfaces;
using Library.files.resources;
using NUnit.Framework;
using System;
/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Library.Tests.geminiAdvanced.first
{
    [TestFixture]
    public class BookTests
    {
        [Test]
        public void Constructor_SetsPropertiesCorrectly()
        {
            // Arrange
            int id = 1;
            string title = "Test Book";
            string author = "Test Author";
            int year = 2023;

            // Act
            Book book = new Book(id, title, author, year);

            // Assert
            Assert.AreEqual(id, book.GetID());
            Assert.IsTrue(book.GetStatus());
            Assert.AreEqual(0, book.GetUserID());
        }

        [Test]
        public void DisplayInfo_WritesCorrectOutput()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);
            var currentConsoleOut = Console.Out;
            using (var consoleOutput = new StringWriter())
            {
                Console.SetOut(consoleOutput);

                // Act
                book.DisplayInfo();

                // Assert
                var expectedOutput = $"ID: 1, Title: Test Book, Author: Test Author, Year: 2023{Environment.NewLine}";
                Assert.AreEqual(expectedOutput, consoleOutput.ToString());
            }
        }

        [Test]
        public void GetStatus_ReturnsCorrectStatus()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act & Assert
            Assert.IsTrue(book.GetStatus());
        }

        [Test]
        public void ChangeStatus_ChangesStatusCorrectly()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act
            book.ChangeStatus();

            // Assert
            Assert.IsFalse(book.GetStatus());
        }

        [Test]
        public void ChangeUser_ChangesUserCorrectly()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);
            int newUserId = 5;

            // Act
            book.ChangeUser(newUserId);

            // Assert
            Assert.AreEqual(newUserId, book.GetUserID());
        }

        [Test]
        public void GetID_ReturnsCorrectID()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act & Assert
            Assert.AreEqual(1, book.GetID());
        }

        [Test]
        public void GetUserID_ReturnsCorrectUserID()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act & Assert
            Assert.AreEqual(0, book.GetUserID());
        }

        [Test]
        public void RateBook_AddsRatingCorrectly()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);
            double rating = 4.5;

            // Act
            book.RateBook(rating);

            // Assert
            Assert.AreEqual(rating, book.GetAverageRating());
        }

        [Test]
        public void RateBook_ThrowsExceptionForNegativeRating()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => book.RateBook(-1));
        }

        [Test]
        public void GetAverageRating_ReturnsCorrectAverage()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);
            book.RateBook(4);
            book.RateBook(5);

            // Act & Assert
            Assert.AreEqual(4.5, book.GetAverageRating());
        }

        [Test]
        public void GetAverageRating_ReturnsZeroForNoRatings()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act & Assert
            Assert.AreEqual(0, book.GetAverageRating());
        }
    }
}

/*
using Library.files.interfaces;
using Library.files.resources;
using NUnit.Framework;
using System;

namespace Library.files.tests
{
    [TestFixture]
    public class BookTests
    {
        [Test]
        public void Constructor_SetsPropertiesCorrectly()
        {
            // Arrange
            int id = 1;
            string title = "Test Book";
            string author = "Test Author";
            int year = 2023;

            // Act
            Book book = new Book(id, title, author, year);

            // Assert
            Assert.AreEqual(id, book.GetID());
            Assert.AreEqual(title, book.Title); // Assuming Title is public for testing
            Assert.AreEqual(author, book.Author); // Assuming Author is public for testing
            Assert.AreEqual(year, book.Year); // Assuming Year is public for testing
            Assert.IsTrue(book.GetStatus());
            Assert.AreEqual(0, book.GetUserID());
        }

        [Test]
        public void DisplayInfo_WritesCorrectOutput()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);
            var currentConsoleOut = Console.Out;
            using (var consoleOutput = new StringWriter())
            {
                Console.SetOut(consoleOutput);

                // Act
                book.DisplayInfo();

                // Assert
                var expectedOutput = $"ID: 1, Title: Test Book, Author: Test Author, Year: 2023{Environment.NewLine}";
                Assert.AreEqual(expectedOutput, consoleOutput.ToString());
            }
            finally
            {
                Console.SetOut(currentConsoleOut);
            }
        }

        [Test]
        public void GetStatus_ReturnsCorrectStatus()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act & Assert
            Assert.IsTrue(book.GetStatus());
        }

        [Test]
        public void ChangeStatus_ChangesStatusCorrectly()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act
            book.ChangeStatus();

            // Assert
            Assert.IsFalse(book.GetStatus());
        }

        [Test]
        public void ChangeUser_ChangesUserCorrectly()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);
            int newUserId = 5;

            // Act
            book.ChangeUser(newUserId);

            // Assert
            Assert.AreEqual(newUserId, book.GetUserID());
        }

        [Test]
        public void GetID_ReturnsCorrectID()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act & Assert
            Assert.AreEqual(1, book.GetID());
        }

        [Test]
        public void GetUserID_ReturnsCorrectUserID()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act & Assert
            Assert.AreEqual(0, book.GetUserID());
        }

        [Test]
        public void RateBook_AddsRatingCorrectly()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);
            double rating = 4.5;

            // Act
            book.RateBook(rating);

            // Assert
            Assert.AreEqual(rating, book.GetAverageRating());
        }

        [Test]
        public void RateBook_ThrowsExceptionForNegativeRating()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => book.RateBook(-1));
        }

        [Test]
        public void GetAverageRating_ReturnsCorrectAverage()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);
            book.RateBook(4);
            book.RateBook(5);

            // Act & Assert
            Assert.AreEqual(4.5, book.GetAverageRating());
        }

        [Test]
        public void GetAverageRating_ReturnsZeroForNoRatings()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act & Assert
            Assert.AreEqual(0, book.GetAverageRating());
        }
    }
}
*/