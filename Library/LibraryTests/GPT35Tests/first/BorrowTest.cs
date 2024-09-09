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

namespace Library.Tests.GPT35.first
{
    public class BorrowTests
    {
        /* Test odrzucony
        [Test]
        public void GetNextBookID_ShouldReturnNextID()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddBook("Book Title 1", "Author 1", 2022);
            borrow.AddBook("Book Title 2", "Author 2", 2023);

            // Act
            var nextId = borrow.GetNextBookID();

            // Assert
            Assert.Equals(3, nextId);
        }

        [Test]
        public void GetNextUserID_ShouldReturnNextID()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddUser("User Name 1");
            borrow.AddUser("User Name 2");

            // Act
            var nextId = borrow.GetNextUserID();

            // Assert
            Assert.Equals(3, nextId);
        }*/

    }
}


/*
using System;
using System.Collections.Generic;
using Xunit;

namespace Library.files.resources.Tests
{
    public class BorrowTests
    {
        [Fact]
        public void AddBook_ShouldAddBookToList()
        {
            // Arrange
            var borrow = new Borrow();

            // Act
            borrow.AddBook("Book Title", "Book Author", 2023);

            // Assert
            var books = borrow.GetBooks(); // Assuming you have a method to get the books for testing
            Assert.Single(books);
            Assert.Equal("Book Title", books[0].Title);
        }

        [Fact]
        public void RemoveBook_ShouldRemoveBookFromList()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddBook("Book Title", "Book Author", 2023);
            var bookId = borrow.GetBooks()[0].GetID();

            // Act
            borrow.RemoveBook(bookId);

            // Assert
            var books = borrow.GetBooks(); // Assuming you have a method to get the books for testing
            Assert.Empty(books);
        }

        [Fact]
        public void GetNextBookID_ShouldReturnNextID()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddBook("Book Title 1", "Author 1", 2022);
            borrow.AddBook("Book Title 2", "Author 2", 2023);

            // Act
            var nextId = borrow.GetNextBookID();

            // Assert
            Assert.Equal(3, nextId);
        }

        [Fact]
        public void AddUser_ShouldAddUserToList()
        {
            // Arrange
            var borrow = new Borrow();

            // Act
            borrow.AddUser("User Name");

            // Assert
            var users = borrow.GetUsers(); // Assuming you have a method to get the users for testing
            Assert.Single(users);
            Assert.Equal("User Name", users[0].Name);
        }

        [Fact]
        public void RemoveUser_ShouldRemoveUserFromList()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddUser("User Name");
            var userId = borrow.GetUsers()[0].GetID();

            // Act
            borrow.RemoveUser(userId);

            // Assert
            var users = borrow.GetUsers(); // Assuming you have a method to get the users for testing
            Assert.Empty(users);
        }

        [Fact]
        public void GetNextUserID_ShouldReturnNextID()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddUser("User Name 1");
            borrow.AddUser("User Name 2");

            // Act
            var nextId = borrow.GetNextUserID();

            // Assert
            Assert.Equal(3, nextId);
        }

        [Fact]
        public void BorrowBook_ShouldBorrowBookSuccessfully()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddBook("Book Title", "Book Author", 2023);
            borrow.AddUser("User Name");
            var bookId = borrow.GetBooks()[0].GetID();
            var userId = borrow.GetUsers()[0].GetID();

            // Act
            var result = borrow.BorrowBook(bookId, userId);

            // Assert
            Assert.True(result);
            Assert.False(borrow.GetBooks()[0].GetStatus());
            Assert.Single(borrow.GetUsers()[0].GetBorrowedBooks()); // Assuming you have a method to get the borrowed books for testing
        }

        [Fact]
        public void BorrowBook_ShouldFailIfBookNotAvailable()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddBook("Book Title", "Book Author", 2023);
            borrow.AddUser("User Name");
            var bookId = borrow.GetBooks()[0].GetID();
            var userId = borrow.GetUsers()[0].GetID();
            borrow.BorrowBook(bookId, userId); // Borrow the book once

            // Act
            var result = borrow.BorrowBook(bookId, userId); // Try to borrow again

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ReturnBook_ShouldReturnBookSuccessfully()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddBook("Book Title", "Book Author", 2023);
            borrow.AddUser("User Name");
            var bookId = borrow.GetBooks()[0].GetID();
            var userId = borrow.GetUsers()[0].GetID();
            borrow.BorrowBook(bookId, userId);

            // Act
            var result = borrow.ReturnBook(bookId, 5);

            // Assert
            Assert.True(result);
            Assert.True(borrow.GetBooks()[0].GetStatus());
            Assert.Empty(borrow.GetUsers()[0].GetBorrowedBooks()); // Assuming you have a method to get the borrowed books for testing
            Assert.Equal(5, borrow.GetBooks()[0].GetAverageRating());
        }

        [Fact]
        public void ReturnBook_ShouldFailIfBookNotBorrowed()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddBook("Book Title", "Book Author", 2023);
            borrow.AddUser("User Name");
            var bookId = borrow.GetBooks()[0].GetID();

            // Act
            var result = borrow.ReturnBook(bookId, 5);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void DisplayAllBooks_ShouldDisplayBooks()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddBook("Book Title", "Book Author", 2023);
            var output = new List<string>();
            Console.SetOut(new System.IO.StringWriter(output));

            // Act
            borrow.DisplayAllBooks();

            // Assert
            Assert.Contains("ID: 1, Title: Book Title, Author: Book Author, Year: 2023", output[0]);
        }

        [Fact]
        public void DisplayAllUsers_ShouldDisplayUsers()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddUser("User Name");
            var output = new List<string>();
            Console.SetOut(new System.IO.StringWriter(output));

            // Act
            borrow.DisplayAllUsers();

            // Assert
            Assert.Contains("ID: 1, User: User Name", output[0]);
        }

        [Fact]
        public void DisplayAllBorrowedBooks_ShouldDisplayAllBorrowedBooks()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddBook("Book Title", "Book Author", 2023);
            borrow.AddUser("User Name");
            var bookId = borrow.GetBooks()[0].GetID();
            var userId = borrow.GetUsers()[0].GetID();
            borrow.BorrowBook(bookId, userId);
            var output = new List<string>();
            Console.SetOut(new System.IO.StringWriter(output));

            // Act
            borrow.DisplayAllBorrowedBooks();

            // Assert
            Assert.Contains("ID: 1, Title: Book Title, Author: Book Author, Year: 2023", output[0]);
        }
    }
}
*/