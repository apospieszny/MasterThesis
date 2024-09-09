using System;
using System.Collections.Generic;
using Library.files.resources;


/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Library.Tests.GPT35.alsoFirst
{
    public class UserTests
    {
        /* Test odrzucony
        [Test]
        public void Constructor_ShouldInitializeFields()
        {
            // Arrange
            int id = 1;
            string name = "John Doe";

            // Act
            var user = new User(id, name);

            // Assert
            Assert.Equals(id, user.GetID());
        }

        [Test]
        public void BorrowBook_ShouldAddBookToBorrowedBooks()
        {
            // Arrange
            var user = new User(1, "John Doe");
            var book = new Book(1, "Book Title", "Author", 2022);

            // Act
            user.BorrowBook(book);

            // Assert
            user.DisplayAllBorrowedBooks(); // Ensure book is in the list.
            // We would need a method to check the borrowed books to validate this.
        }*/

        [Test]
        public void ReturnBook_ShouldRemoveBookFromBorrowedBooks()
        {
            // Arrange
            var user = new User(1, "John Doe");
            var book = new Book(1, "Book Title", "Author", 2022);
            user.BorrowBook(book);

            // Act
            user.ReturnBook(book);

            // Assert
            user.DisplayAllBorrowedBooks(); // Ensure book is no longer in the list.
            // We would need a method to check the borrowed books to validate this.
        }

        private string CaptureConsoleOutput(Action action)
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                action();
                return sw.ToString().Trim();
            }
        }
    }
}


/*
using System;
using System.Collections.Generic;
using Xunit;
using Library.files.resources;

namespace Library.files.tests
{
    public class UserTests
    {
        [Fact]
        public void Constructor_ShouldInitializeFields()
        {
            // Arrange
            int id = 1;
            string name = "John Doe";

            // Act
            var user = new User(id, name);

            // Assert
            Assert.Equal(id, user.GetID());
            Assert.Equal(name, user.DisplayInfo()); // DisplayInfo is for console output, but we can use GetID() as proxy to check if it was set correctly.
        }

        [Fact]
        public void DisplayInfo_ShouldDisplayCorrectInfo()
        {
            // Arrange
            int id = 1;
            string name = "John Doe";
            var user = new User(id, name);

            // Act and Assert
            var output = CaptureConsoleOutput(() => user.DisplayInfo());
            Assert.Contains($"ID: {id}, User: {name}", output);
        }

        [Fact]
        public void BorrowBook_ShouldAddBookToBorrowedBooks()
        {
            // Arrange
            var user = new User(1, "John Doe");
            var book = new Book(1, "Book Title", "Author", 2022);

            // Act
            user.BorrowBook(book);

            // Assert
            user.DisplayAllBorrowedBooks(); // Ensure book is in the list.
            // We would need a method to check the borrowed books to validate this.
        }

        [Fact]
        public void ReturnBook_ShouldRemoveBookFromBorrowedBooks()
        {
            // Arrange
            var user = new User(1, "John Doe");
            var book = new Book(1, "Book Title", "Author", 2022);
            user.BorrowBook(book);

            // Act
            user.ReturnBook(book);

            // Assert
            user.DisplayAllBorrowedBooks(); // Ensure book is no longer in the list.
            // We would need a method to check the borrowed books to validate this.
        }

        [Fact]
        public void DisplayAllBorrowedBooks_ShouldDisplayAllBorrowedBooks()
        {
            // Arrange
            var user = new User(1, "John Doe");
            var book1 = new Book(1, "Book Title 1", "Author 1", 2022);
            var book2 = new Book(2, "Book Title 2", "Author 2", 2023);
            user.BorrowBook(book1);
            user.BorrowBook(book2);

            // Act and Assert
            var output = CaptureConsoleOutput(() => user.DisplayAllBorrowedBooks());
            Assert.Contains("ID: 1, Title: Book Title 1, Author: Author 1, Year: 2022", output);
            Assert.Contains("ID: 2, Title: Book Title 2, Author: Author 2, Year: 2023", output);
        }

        private string CaptureConsoleOutput(Action action)
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                action();
                return sw.ToString().Trim();
            }
        }
    }
}

*/