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

namespace Library.Tests.geminiAdvanced.alsoFirst
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
            int newUserId = 123;

            // Act
            book.ChangeUser(newUserId);

            // Assert
            Assert.AreEqual(newUserId, book.GetUserID());
        }

        [Test]
        public void GetID_ReturnsCorrectID()
        {
            // Arrange
            int id = 1;
            Book book = new Book(id, "Test Book", "Test Author", 2023);

            // Act & Assert
            Assert.AreEqual(id, book.GetID());
        }

        [Test]
        public void GetUserID_ReturnsCorrectUserID()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);
            int newUserId = 123;
            book.ChangeUser(newUserId);

            // Act & Assert
            Assert.AreEqual(newUserId, book.GetUserID());
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
        public void GetAverageRating_ReturnsZeroForNoRatings()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act & Assert
            Assert.AreEqual(0, book.GetAverageRating());
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
            Assert.AreEqual(title, book.GetTitle()); // Zakładamy, że istnieje metoda GetTitle()
            Assert.AreEqual(author, book.GetAuthor()); // Zakładamy, że istnieje metoda GetAuthor()
            Assert.AreEqual(year, book.GetYear()); // Zakładamy, że istnieje metoda GetYear()
            Assert.IsTrue(book.GetStatus());
            Assert.AreEqual(0, book.GetUserID());
        }

        [Test]
        public void DisplayInfo_DisplaysCorrectInformation()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act
            // Tutaj przechwycimy i sprawdzimy output konsoli, ale to wymaga dodatkowych narzędzi
            // W praktyce, można by użyć np. biblioteki do mockowania konsoli

            // Assert
            // Sprawdź, czy output konsoli zawiera oczekiwany tekst
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
            int newUserId = 123;

            // Act
            book.ChangeUser(newUserId);

            // Assert
            Assert.AreEqual(newUserId, book.GetUserID());
        }

        [Test]
        public void GetID_ReturnsCorrectID()
        {
            // Arrange
            int id = 1;
            Book book = new Book(id, "Test Book", "Test Author", 2023);

            // Act & Assert
            Assert.AreEqual(id, book.GetID());
        }

        [Test]
        public void GetUserID_ReturnsCorrectUserID()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);
            int newUserId = 123;
            book.ChangeUser(newUserId);

            // Act & Assert
            Assert.AreEqual(newUserId, book.GetUserID());
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
        public void GetAverageRating_ReturnsZeroForNoRatings()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act & Assert
            Assert.AreEqual(0, book.GetAverageRating());
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
    }
}
*/