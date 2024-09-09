﻿using Library.files.resources;
using NUnit.Framework;
/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Library.Tests.gemini.alsoFirst
{
    [TestFixture]
    public class BookTests
    {
        [Test]
        public void Constructor_InitializesPropertiesCorrectly()
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
        public void GetStatus_ReturnsCorrectAvailability()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act and Assert
            Assert.IsTrue(book.GetStatus());

            // Change status
            book.ChangeStatus();

            // Assert
            Assert.IsFalse(book.GetStatus());
        }

        [Test]
        public void ChangeUser_UpdatesUserId()
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
        public void RateBook_ThrowsException_NegativeRating()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);
            double rating = -1;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => book.RateBook(rating));
        }

        [Test]
        public void GetAverageRating_CalculatesCorrectly_MultipleRatings()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);
            book.RateBook(4.5);
            book.RateBook(3.0);
            book.RateBook(5.0);

            // Act
            double averageRating = book.GetAverageRating();

            // Assert
            Assert.AreEqual(4.166666666666667, averageRating);
        }

        [Test]
        public void GetAverageRating_ReturnsZero_NoRatings()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act
            double averageRating = book.GetAverageRating();

            // Assert
            Assert.AreEqual(0, averageRating);
        }
    }
}

/*
using Library.files.resources;
using NUnit.Framework;

namespace Library.files.tests
{
    [TestFixture]
    public class BookTests
    {
        [Test]
        public void Constructor_InitializesPropertiesCorrectly()
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
            Assert.AreEqual(title, book.Title);
            Assert.AreEqual(author, book.Author);
            Assert.AreEqual(year, book.Year);
            Assert.IsTrue(book.GetStatus());
            Assert.AreEqual(0, book.GetUserID());
            Assert.IsEmpty(book.Ratings);
        }

        [Test]
        public void DisplayInfo_PrintsCorrectInformation()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act
            using (var consoleOutput = new ConsoleOutputCapture())
            {
                book.DisplayInfo();

                // Assert
                Assert.AreEqual($"ID: 1, Title: Test Book, Author: Test Author, Year: 2023", consoleOutput.GetOutput());
            }
        }

        [Test]
        public void GetStatus_ReturnsCorrectAvailability()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act and Assert
            Assert.IsTrue(book.GetStatus());

            // Change status
            book.ChangeStatus();

            // Assert
            Assert.IsFalse(book.GetStatus());
        }

        [Test]
        public void ChangeUser_UpdatesUserId()
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
        public void RateBook_AddsRating_PositiveRating()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);
            double rating = 4.5;

            // Act
            book.RateBook(rating);

            // Assert
            Assert.AreEqual(1, book.Ratings.Count);
            Assert.AreEqual(rating, book.Ratings[0]);
        }

        [Test]
        public void RateBook_ThrowsException_NegativeRating()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);
            double rating = -1;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => book.RateBook(rating));
        }

        [Test]
        public void GetAverageRating_CalculatesCorrectly_MultipleRatings()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);
            book.RateBook(4.5);
            book.RateBook(3.0);
            book.RateBook(5.0);

            // Act
            double averageRating = book.GetAverageRating();

            // Assert
            Assert.AreEqual(4.166666666666667, averageRating);
        }

        [Test]
        public void GetAverageRating_ReturnsZero_NoRatings()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act
            double averageRating = book.GetAverageRating();

            // Assert
            Assert.AreEqual(0, averageRating);
        }
    }
}

*/