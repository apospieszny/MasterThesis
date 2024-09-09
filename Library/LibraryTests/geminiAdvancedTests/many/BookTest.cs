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

namespace Library.Tests.geminiAdvanced.many
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
        public void DisplayInfo_WritesCorrectInformation()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act
            // Aby przetestować DisplayInfo, przechwycimy standardowe wyjście konsoli
            var currentOut = Console.Out;
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                book.DisplayInfo();

                // Assert
                var expectedOutput = $"ID: 1, Title: Test Book, Author: Test Author, Year: 2023{Environment.NewLine}";
                Assert.AreEqual(expectedOutput, sw.ToString());
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

            // Act (zmień ponownie)
            book.ChangeStatus();

            // Assert
            Assert.IsTrue(book.GetStatus());
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

            // Act
            book.RateBook(4.5);

            // Assert
            Assert.AreEqual(4.5, book.GetAverageRating());
        }

        [Test]
        public void RateBook_ThrowsExceptionForNegativeRating()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => book.RateBook(-2));
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
        public void GetAverageRating_CalculatesAverageCorrectly()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act
            book.RateBook(3);
            book.RateBook(5);

            // Assert
            Assert.AreEqual(4, book.GetAverageRating());
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
            Assert.AreEqual(title, book.GetTitle());
            Assert.AreEqual(author, book.GetAuthor());
            Assert.AreEqual(year, book.GetYear());
            Assert.IsTrue(book.GetStatus());
            Assert.AreEqual(0, book.GetUserID());
        }

        [Test]
        public void DisplayInfo_WritesCorrectInformation()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act
            // Aby przetestować DisplayInfo, przechwycimy standardowe wyjście konsoli
            var currentOut = Console.Out;
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                book.DisplayInfo();

                // Assert
                var expectedOutput = $"ID: 1, Title: Test Book, Author: Test Author, Year: 2023{Environment.NewLine}";
                Assert.AreEqual(expectedOutput, sw.ToString());
            }
            finally
            {
                // Przywróć standardowe wyjście konsoli
                Console.SetOut(currentOut);
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

            // Act (zmień ponownie)
            book.ChangeStatus();

            // Assert
            Assert.IsTrue(book.GetStatus());
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

            // Act
            book.RateBook(4.5);

            // Assert
            Assert.AreEqual(4.5, book.GetAverageRating());
        }

        [Test]
        public void RateBook_ThrowsExceptionForNegativeRating()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => book.RateBook(-2));
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
        public void GetAverageRating_CalculatesAverageCorrectly()
        {
            // Arrange
            Book book = new Book(1, "Test Book", "Test Author", 2023);

            // Act
            book.RateBook(3);
            book.RateBook(5);

            // Assert
            Assert.AreEqual(4, book.GetAverageRating());
        }

        // Dodatkowe testy dla metod GetTitle, GetAuthor i GetYear

        [Test]
        public void GetTitle_ReturnsCorrectTitle()
        {
            Book book = new Book(1, "Test Book", "Test Author", 2023);
            Assert.AreEqual("Test Book", book.GetTitle());
        }

        [Test]
        public void GetAuthor_ReturnsCorrectAuthor()
        {
            Book book = new Book(1, "Test Book", "Test Author", 2023);
            Assert.AreEqual("Test Author", book.GetAuthor());
        }

        [Test]
        public void GetYear_ReturnsCorrectYear()
        {
            Book book = new Book(1, "Test Book", "Test Author", 2023);
            Assert.AreEqual(2023, book.GetYear());
        }
    }
}
*/