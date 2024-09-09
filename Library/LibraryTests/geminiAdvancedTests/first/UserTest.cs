using Library.files.resources;
using NUnit.Framework;
using System.Collections.Generic;


/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 */

namespace Library.Tests.geminiAdvanced.first
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void Constructor_SetsPropertiesCorrectly()
        {
            // Arrange
            int id = 123;
            string name = "John Doe";

            // Act
            User user = new User(id, name);

            // Assert
            Assert.AreEqual(id, user.GetID());
            // Można dodać więcej asercji, jeśli klasa User ma więcej właściwości
        }

        [Test]
        public void DisplayInfo_WritesCorrectOutput()
        {
            // Arrange
            int id = 456;
            string name = "Jane Smith";
            User user = new User(id, name);

            // Act
            // Przechwyć wyjście konsoli
            var currentOut = Console.Out;
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                user.DisplayInfo();
                var result = sw.ToString().Trim();
                Assert.AreEqual($"ID: {id}, User: {name}", result);
            }
            Console.SetOut(currentOut);

            // Assert - Sprawdzenie wyjścia konsoli jest wykonane w sekcji Act
        }

        [Test]
        public void GetID_ReturnsCorrectID()
        {
            // Arrange
            int id = 789;
            string name = "Test User";
            User user = new User(id, name);

            // Act
            int result = user.GetID();

            // Assert
            Assert.AreEqual(id, result);
        }

    }
}

/*
using Library.files.resources;
using NUnit.Framework;
using System.Collections.Generic;

namespace Library.files.tests
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void Constructor_SetsPropertiesCorrectly()
        {
            // Arrange
            int id = 123;
            string name = "John Doe";

            // Act
            User user = new User(id, name);

            // Assert
            Assert.AreEqual(id, user.GetID());
            // Można dodać więcej asercji, jeśli klasa User ma więcej właściwości
        }

        [Test]
        public void DisplayInfo_WritesCorrectOutput()
        {
            // Arrange
            int id = 456;
            string name = "Jane Smith";
            User user = new User(id, name);

            // Act
            // Przechwyć wyjście konsoli
            var currentOut = Console.Out;
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                user.DisplayInfo();
                var result = sw.ToString().Trim();
                Assert.AreEqual($"ID: {id}, User: {name}", result);
            }
            Console.SetOut(currentOut);

            // Assert - Sprawdzenie wyjścia konsoli jest wykonane w sekcji Act
        }

        [Test]
        public void GetID_ReturnsCorrectID()
        {
            // Arrange
            int id = 789;
            string name = "Test User";
            User user = new User(id, name);

            // Act
            int result = user.GetID();

            // Assert
            Assert.AreEqual(id, result);
        }

        [Test]
        public void BorrowBook_AddsBookToBorrowedBooks()
        {
            // Arrange
            User user = new User(1, "User1");
            Book book = new Book(101, "Book Title", "Author Name", 2023);

            // Act
            user.BorrowBook(book);

            // Assert
            // Zakładamy, że klasa User ma metodę do pobrania listy BorrowedBooks
            // lub że BorrowedBooks jest publiczne
            Assert.IsTrue(user.BorrowedBooks.Contains(book)); 
        }

        [Test]
        public void ReturnBook_RemovesBookFromBorrowedBooks()
        {
            // Arrange
            User user = new User(2, "User2");
            Book book1 = new Book(201, "Book1", "Author1", 2022);
            Book book2 = new Book(202, "Book2", "Author2", 2021);
            user.BorrowBook(book1);
            user.BorrowBook(book2);

            // Act
            user.ReturnBook(book1);

            // Assert
            Assert.IsFalse(user.BorrowedBooks.Contains(book1));
            Assert.IsTrue(user.BorrowedBooks.Contains(book2));
        }

        [Test]
        public void DisplayAllBorrowedBooks_WritesCorrectOutput()
        {
            // Arrange
            User user = new User(3, "User3");
            Book book1 = new Book(301, "Book1", "Author1", 2020);
            Book book2 = new Book(302, "Book2", "Author2", 2019);
            user.BorrowBook(book1);
            user.BorrowBook(book2);

            // Act
            // Przechwyć wyjście konsoli
            var currentOut = Console.Out;
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                user.DisplayAllBorrowedBooks();
                var result = sw.ToString().Trim();
                var expectedOutput = 
                    $"ID: {book1.GetID()}, Title: {book1.Title}, Author: {book1.Author}, Year: {book1.Year}\r\n" +
                    $"ID: {book2.GetID()}, Title: {book2.Title}, Author: {book2.Author}, Year: {book2.Year}";
                Assert.AreEqual(expectedOutput, result);
            }
            Console.SetOut(currentOut);

            // Assert - Sprawdzenie wyjścia konsoli jest wykonane w sekcji Act
        }
    }
}
*/