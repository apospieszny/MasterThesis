using NUnit.Framework;
using Library.files.resources;
using System;

/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Library.Tests.GPT4.alsoFirst
{
    [TestFixture]
    public class BookTests
    {
        [Test]
        public void Constructor_WhenCalled_SetsPropertiesCorrectly()
        {
            // Arrange
            int id = 1;
            string title = "Test Title";
            string author = "Test Author";
            int year = 2021;

            // Act
            Book book = new Book(id, title, author, year);

            // Assert
            Assert.AreEqual(id, book.GetID());
            Assert.IsTrue(book.GetStatus());
            Assert.AreEqual(0, book.GetUserID());
        }

        /* Test odrzucony
        [Test]
        public void DisplayInfo_WhenCalled_OutputsCorrectInfo()
        {
            // Arrange
            Book book = new Book(1, "Test Title", "Test Author", 2021);
            using var consoleOutput = new ConsoleOutput();

            // Act
            book.DisplayInfo();

            // Assert
            Assert.AreEqual("ID: 1, Title: Test Title, Author: Test Author, Year: 2021\n", consoleOutput.GetOuput());
        }*/

        [Test]
        public void GetStatus_Initially_ReturnsTrue()
        {
            // Arrange
            Book book = new Book(1, "Test Title", "Test Author", 2021);

            // Act & Assert
            Assert.IsTrue(book.GetStatus());
        }

        [Test]
        public void ChangeStatus_TogglesStatusCorrectly()
        {
            // Arrange
            Book book = new Book(1, "Test Title", "Test Author", 2021);

            // Act
            book.ChangeStatus();

            // Assert
            Assert.IsFalse(book.GetStatus());

            // Act
            book.ChangeStatus();

            // Assert
            Assert.IsTrue(book.GetStatus());
        }

        [Test]
        public void ChangeUser_WhenCalled_UpdatesUserId()
        {
            // Arrange
            Book book = new Book(1, "Test Title", "Test Author", 2021);
            int newUserId = 123;

            // Act
            book.ChangeUser(newUserId);

            // Assert
            Assert.AreEqual(newUserId, book.GetUserID());
        }

        [Test]
        public void RateBook_WithValidRating_AddsRatingToList()
        {
            // Arrange
            Book book = new Book(1, "Test Title", "Test Author", 2021);
            double rating = 4.5;

            // Act
            book.RateBook(rating);

            // Assert
            Assert.AreEqual(rating, book.GetAverageRating());
        }

        [Test]
        public void RateBook_WithNegativeRating_ThrowsArgumentException()
        {
            // Arrange
            Book book = new Book(1, "Test Title", "Test Author", 2021);

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => book.RateBook(-1));
            Assert.That(ex.Message, Is.EqualTo("Ocena powinna być nieujemna."));
        }

        [Test]
        public void GetAverageRating_WhenNoRatings_ReturnsZero()
        {
            // Arrange
            Book book = new Book(1, "Test Title", "Test Author", 2021);

            // Act
            var averageRating = book.GetAverageRating();

            // Assert
            Assert.AreEqual(0, averageRating);
        }

        [Test]
        public void GetAverageRating_WhenRatingsExist_CalculatesCorrectAverage()
        {
            // Arrange
            Book book = new Book(1, "Test Title", "Test Author", 2021);
            book.RateBook(5);
            book.RateBook(3);

            // Act
            var averageRating = book.GetAverageRating();

            // Assert
            Assert.AreEqual(4, averageRating);
        }
    }

    public class ConsoleOutput : IDisposable
    {
        private StringWriter stringWriter;
        private TextWriter originalOutput;

        public ConsoleOutput()
        {
            stringWriter = new StringWriter();
            originalOutput = Console.Out;
            Console.SetOut(stringWriter);
        }

        public string GetOuput()
        {
            return stringWriter.ToString();
        }

        public void Dispose()
        {
            Console.SetOut(originalOutput);
            stringWriter.Dispose();
        }
    }
}


/*
 * using NUnit.Framework;
using Library.files.resources;
using System;

namespace LibraryTests
{
    [TestFixture]
    public class BookTests
    {
        [Test]
        public void Constructor_WhenCalled_SetsPropertiesCorrectly()
        {
            // Arrange
            int id = 1;
            string title = "Test Title";
            string author = "Test Author";
            int year = 2021;

            // Act
            Book book = new Book(id, title, author, year);

            // Assert
            Assert.AreEqual(id, book.GetID());
            Assert.AreEqual(title, book.Title);
            Assert.AreEqual(author, book.Author);
            Assert.AreEqual(year, book.Year);
            Assert.IsTrue(book.GetStatus());
            Assert.AreEqual(0, book.GetUserID());
        }

        [Test]
        public void DisplayInfo_WhenCalled_OutputsCorrectInfo()
        {
            // Arrange
            Book book = new Book(1, "Test Title", "Test Author", 2021);
            using var consoleOutput = new ConsoleOutput();

            // Act
            book.DisplayInfo();

            // Assert
            Assert.AreEqual("ID: 1, Title: Test Title, Author: Test Author, Year: 2021\n", consoleOutput.GetOuput());
        }

        [Test]
        public void GetStatus_Initially_ReturnsTrue()
        {
            // Arrange
            Book book = new Book(1, "Test Title", "Test Author", 2021);

            // Act & Assert
            Assert.IsTrue(book.GetStatus());
        }

        [Test]
        public void ChangeStatus_TogglesStatusCorrectly()
        {
            // Arrange
            Book book = new Book(1, "Test Title", "Test Author", 2021);

            // Act
            book.ChangeStatus();

            // Assert
            Assert.IsFalse(book.GetStatus());

            // Act
            book.ChangeStatus();

            // Assert
            Assert.IsTrue(book.GetStatus());
        }

        [Test]
        public void ChangeUser_WhenCalled_UpdatesUserId()
        {
            // Arrange
            Book book = new Book(1, "Test Title", "Test Author", 2021);
            int newUserId = 123;

            // Act
            book.ChangeUser(newUserId);

            // Assert
            Assert.AreEqual(newUserId, book.GetUserID());
        }

        [Test]
        public void RateBook_WithValidRating_AddsRatingToList()
        {
            // Arrange
            Book book = new Book(1, "Test Title", "Test Author", 2021);
            double rating = 4.5;

            // Act
            book.RateBook(rating);

            // Assert
            Assert.AreEqual(rating, book.GetAverageRating());
        }

        [Test]
        public void RateBook_WithNegativeRating_ThrowsArgumentException()
        {
            // Arrange
            Book book = new Book(1, "Test Title", "Test Author", 2021);

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => book.RateBook(-1));
            Assert.That(ex.Message, Is.EqualTo("Ocena powinna być nieujemna."));
        }

        [Test]
        public void GetAverageRating_WhenNoRatings_ReturnsZero()
        {
            // Arrange
            Book book = new Book(1, "Test Title", "Test Author", 2021);

            // Act
            var averageRating = book.GetAverageRating();

            // Assert
            Assert.AreEqual(0, averageRating);
        }

        [Test]
        public void GetAverageRating_WhenRatingsExist_CalculatesCorrectAverage()
        {
            // Arrange
            Book book = new Book(1, "Test Title", "Test Author", 2021);
            book.RateBook(5);
            book.RateBook(3);

            // Act
            var averageRating = book.GetAverageRating();

            // Assert
            Assert.AreEqual(4, averageRating);
        }
    }

    public class ConsoleOutput : IDisposable
    {
        private StringWriter stringWriter;
        private TextWriter originalOutput;

        public ConsoleOutput()
        {
            stringWriter = new StringWriter();
            originalOutput = Console.Out;
            Console.SetOut(stringWriter);
        }

        public string GetOuput()
        {
            return stringWriter.ToString();
        }

        public void Dispose()
        {
            Console.SetOut(originalOutput);
            stringWriter.Dispose();
        }
    }
}
*/