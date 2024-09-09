using System;
using System.Collections.Generic;
using System.Linq;
using Library.files.resources;


/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Library.Tests.GPT35.first
{
    public class BookTests
    {
        /* Test odrzucony
        [Test]
        public void Constructor_ShouldInitializeProperties()
        {
            // Arrange
            int id = 1;
            string title = "Title";
            string author = "Author";
            int year = 2020;

            // Act
            var book = new Book(id, title, author, year);

            // Assert
            Assert.Equals(id, book.GetID());
            Assert.True(book.GetStatus());
            Assert.Equals(0, book.GetUserID());
        }

        [Test]
        public void DisplayInfo_ShouldPrintBookInfo()
        {
            // Arrange
            var book = new Book(1, "Title", "Author", 2020);

            // Act
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                book.DisplayInfo();
                var result = sw.ToString().Trim();

                // Assert
                Assert.Equals("ID: 1, Title: Title, Author: Author, Year: 2020", result);
            }
        }*/

        [Test]
        public void GetStatus_ShouldReturnTrueWhenAvailable()
        {
            // Arrange
            var book = new Book(1, "Title", "Author", 2020);

            // Act
            var status = book.GetStatus();

            // Assert
            Assert.True(status);
        }

        [Test]
        public void ChangeStatus_ShouldToggleAvailability()
        {
            // Arrange
            var book = new Book(1, "Title", "Author", 2020);

            // Act
            book.ChangeStatus();
            var statusAfterChange = book.GetStatus();

            // Assert
            Assert.False(statusAfterChange);
        }

        /* Test odrzucony
        [Test]
        public void ChangeUser_ShouldUpdateUserId()
        {
            // Arrange
            var book = new Book(1, "Title", "Author", 2020);
            int newUserId = 42;

            // Act
            book.ChangeUser(newUserId);
            var userId = book.GetUserID();

            // Assert
            Assert.Equals(newUserId, userId);
        }

        [Test]
        public void RateBook_ShouldAddRating()
        {
            // Arrange
            var book = new Book(1, "Title", "Author", 2020);
            double rating = 4.5;

            // Act
            book.RateBook(rating);
            var averageRating = book.GetAverageRating();

            // Assert
            Assert.Equals(rating, averageRating);
        }*/

        [Test]
        public void RateBook_ShouldThrowExceptionForNegativeRating()
        {
            // Arrange
            var book = new Book(1, "Title", "Author", 2020);
            double negativeRating = -1.0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => book.RateBook(negativeRating));
        }

        /* Test odrzucony
        [Test]
        public void GetAverageRating_ShouldReturnZeroWhenNoRatings()
        {
            // Arrange
            var book = new Book(1, "Title", "Author", 2020);

            // Act
            var averageRating = book.GetAverageRating();

            // Assert
            Assert.Equals(0, averageRating);
        }

        [Test]
        public void GetAverageRating_ShouldReturnCorrectAverage()
        {
            // Arrange
            var book = new Book(1, "Title", "Author", 2020);
            book.RateBook(4.0);
            book.RateBook(5.0);
            book.RateBook(3.0);

            // Act
            var averageRating = book.GetAverageRating();

            // Assert
            Assert.Equals(4.0, averageRating);
        }*/
    }
}

/*
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Library.files.resources.Tests
{
    public class BookTests
    {
        [Fact]
        public void Constructor_ShouldInitializeProperties()
        {
            // Arrange
            int id = 1;
            string title = "Title";
            string author = "Author";
            int year = 2020;

            // Act
            var book = new Book(id, title, author, year);

            // Assert
            Assert.Equal(id, book.GetID());
            Assert.Equal(title, book.Title);
            Assert.Equal(author, book.Author);
            Assert.Equal(year, book.Year);
            Assert.True(book.GetStatus());
            Assert.Equal(0, book.GetUserID());
        }

        [Fact]
        public void DisplayInfo_ShouldPrintBookInfo()
        {
            // Arrange
            var book = new Book(1, "Title", "Author", 2020);

            // Act
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                book.DisplayInfo();
                var result = sw.ToString().Trim();

                // Assert
                Assert.Equal("ID: 1, Title: Title, Author: Author, Year: 2020", result);
            }
        }

        [Fact]
        public void GetStatus_ShouldReturnTrueWhenAvailable()
        {
            // Arrange
            var book = new Book(1, "Title", "Author", 2020);

            // Act
            var status = book.GetStatus();

            // Assert
            Assert.True(status);
        }

        [Fact]
        public void ChangeStatus_ShouldToggleAvailability()
        {
            // Arrange
            var book = new Book(1, "Title", "Author", 2020);

            // Act
            book.ChangeStatus();
            var statusAfterChange = book.GetStatus();

            // Assert
            Assert.False(statusAfterChange);
        }

        [Fact]
        public void ChangeUser_ShouldUpdateUserId()
        {
            // Arrange
            var book = new Book(1, "Title", "Author", 2020);
            int newUserId = 42;

            // Act
            book.ChangeUser(newUserId);
            var userId = book.GetUserID();

            // Assert
            Assert.Equal(newUserId, userId);
        }

        [Fact]
        public void RateBook_ShouldAddRating()
        {
            // Arrange
            var book = new Book(1, "Title", "Author", 2020);
            double rating = 4.5;

            // Act
            book.RateBook(rating);
            var averageRating = book.GetAverageRating();

            // Assert
            Assert.Equal(rating, averageRating);
        }

        [Fact]
        public void RateBook_ShouldThrowExceptionForNegativeRating()
        {
            // Arrange
            var book = new Book(1, "Title", "Author", 2020);
            double negativeRating = -1.0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => book.RateBook(negativeRating));
        }

        [Fact]
        public void GetAverageRating_ShouldReturnZeroWhenNoRatings()
        {
            // Arrange
            var book = new Book(1, "Title", "Author", 2020);

            // Act
            var averageRating = book.GetAverageRating();

            // Assert
            Assert.Equal(0, averageRating);
        }

        [Fact]
        public void GetAverageRating_ShouldReturnCorrectAverage()
        {
            // Arrange
            var book = new Book(1, "Title", "Author", 2020);
            book.RateBook(4.0);
            book.RateBook(5.0);
            book.RateBook(3.0);

            // Act
            var averageRating = book.GetAverageRating();

            // Assert
            Assert.Equal(4.0, averageRating);
        }
    }
}
*/