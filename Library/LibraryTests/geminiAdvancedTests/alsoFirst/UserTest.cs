using Library.files.interfaces;
using Library.files.resources;
using NUnit.Framework;
using System;
using System.Collections.Generic;


/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Library.Tests.geminiAdvanced.alsoFirst
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void Constructor_SetsPropertiesCorrectly()
        {
            // Arrange
            int expectedId = 123;
            string expectedName = "John Doe";

            // Act
            User user = new User(expectedId, expectedName);

            // Assert
            Assert.AreEqual(expectedId, user.GetID());
            // Nie możemy bezpośrednio sprawdzić Name, więc sprawdzimy przez DisplayInfo
        }

        [Test]
        public void DisplayInfo_PrintsCorrectInformation()
        {
            // Arrange
            int id = 456;
            string name = "Jane Smith";
            User user = new User(id, name);

            // Act & Assert
            // Przechwycimy wyjście konsoli
            var currentOut = Console.Out;
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                user.DisplayInfo();
                var result = sw.ToString().Trim(); // Usuniemy białe znaki na początku i końcu
                Assert.AreEqual($"ID: {id}, User: {name}", result);
            }
            Console.SetOut(currentOut); // Przywrócimy oryginalne wyjście
        }

        [Test]
        public void GetID_ReturnsCorrectID()
        {
            // Arrange
            int expectedId = 789;
            User user = new User(expectedId, "Some Name");

            // Act
            int actualId = user.GetID();

            // Assert
            Assert.AreEqual(expectedId, actualId);
        }

        [Test]
        public void DisplayAllBorrowedBooks_PrintsNothingWhenListIsEmpty()
        {
            // Arrange
            User user = new User(4, "User4"); // Zaczyna z pustą listą

            // Act & Assert
            // Przechwycimy wyjście i sprawdzimy czy jest puste
            var currentOut = Console.Out;
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                user.DisplayAllBorrowedBooks();
                var result = sw.ToString().Trim();
                Assert.AreEqual("", result); // Oczekujemy pustego stringa
            }
            Console.SetOut(currentOut);
        }
    }
}

/*
using Library.files.interfaces;
using Library.files.resources;
using NUnit.Framework;
using System;
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
            int expectedId = 123;
            string expectedName = "John Doe";

            // Act
            User user = new User(expectedId, expectedName);

            // Assert
            Assert.AreEqual(expectedId, user.GetID());
            // Nie możemy bezpośrednio sprawdzić Name, więc sprawdzimy przez DisplayInfo
        }

        [Test]
        public void DisplayInfo_PrintsCorrectInformation()
        {
            // Arrange
            int id = 456;
            string name = "Jane Smith";
            User user = new User(id, name);

            // Act & Assert
            // Przechwycimy wyjście konsoli
            var currentOut = Console.Out;
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                user.DisplayInfo();
                var result = sw.ToString().Trim(); // Usuniemy białe znaki na początku i końcu
                Assert.AreEqual($"ID: {id}, User: {name}", result);
            }
            Console.SetOut(currentOut); // Przywrócimy oryginalne wyjście
        }

        [Test]
        public void GetID_ReturnsCorrectID()
        {
            // Arrange
            int expectedId = 789;
            User user = new User(expectedId, "Some Name");

            // Act
            int actualId = user.GetID();

            // Assert
            Assert.AreEqual(expectedId, actualId);
        }

        [Test]
        public void BorrowBook_AddsBookToList()
        {
            // Arrange
            User user = new User(1, "User1");
            Book book = new Book(101, "Book Title", "Author Name", 2023);

            // Act
            user.BorrowBook(book);

            // Assert
            // Nie mamy bezpośredniego dostępu do listy, więc sprawdzimy przez DisplayAllBorrowedBooks
            // Podobnie jak w DisplayInfo, przechwycimy wyjście konsoli
            var currentOut = Console.Out;
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                user.DisplayAllBorrowedBooks();
                var result = sw.ToString().Trim();
                Assert.AreEqual($"ID: {book.GetID()}, Title: {book.Title}, Author: {book.Author}, Year: {book.Year}", result);
            }
            Console.SetOut(currentOut);
        }

        [Test]
        public void ReturnBook_RemovesBookFromList()
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
            // Znów sprawdzimy przez DisplayAllBorrowedBooks
            var currentOut = Console.Out;
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                user.DisplayAllBorrowedBooks();
                var result = sw.ToString().Trim();
                Assert.AreEqual($"ID: {book2.GetID()}, Title: {book2.Title}, Author: {book2.Author}, Year: {book2.Year}", result);
            }
            Console.SetOut(currentOut);
        }

        [Test]
        public void DisplayAllBorrowedBooks_PrintsAllBooksWhenListIsNotEmpty()
        {
            // Arrange
            User user = new User(3, "User3");
            Book book1 = new Book(301, "BookA", "AuthorA", 2020);
            Book book2 = new Book(302, "BookB", "AuthorB", 2019);
            user.BorrowBook(book1);
            user.BorrowBook(book2);

            // Act & Assert
            // Przechwycimy wyjście i sprawdzimy czy zawiera informacje o obu książkach
            var currentOut = Console.Out;
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                user.DisplayAllBorrowedBooks();
                var result = sw.ToString().Trim();
                Assert.IsTrue(result.Contains($"ID: {book1.GetID()}, Title: {book1.Title}, Author: {book1.Author}, Year: {book1.Year}"));
                Assert.IsTrue(result.Contains($"ID: {book2.GetID()}, Title: {book2.Title}, Author: {book2.Author}, Year: {book2.Year}"));
            }
            Console.SetOut(currentOut);
        }

        [Test]
        public void DisplayAllBorrowedBooks_PrintsNothingWhenListIsEmpty()
        {
            // Arrange
            User user = new User(4, "User4"); // Zaczyna z pustą listą

            // Act & Assert
            // Przechwycimy wyjście i sprawdzimy czy jest puste
            var currentOut = Console.Out;
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                user.DisplayAllBorrowedBooks();
                var result = sw.ToString().Trim();
                Assert.AreEqual("", result); // Oczekujemy pustego stringa
            }
            Console.SetOut(currentOut);
        }

    }
}
*/