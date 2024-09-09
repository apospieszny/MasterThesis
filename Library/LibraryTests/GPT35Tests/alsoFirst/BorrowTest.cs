using System;
using System.Linq;
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
    public class BorrowTests
    {
        /* Test odrzucony
        [Test]
        public void GetNextBookID_ShouldReturnNextID_WhenBooksArePresent()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddBook("Book1", "Author1", 2000);
            borrow.AddBook("Book2", "Author2", 2001);

            // Act
            var nextId = borrow.GetNextBookID();

            // Assert
            Assert.Equals(3, nextId);
        }

        [Test]
        public void GetNextBookID_ShouldReturn1_WhenNoBooksArePresent()
        {
            // Arrange
            var borrow = new Borrow();

            // Act
            var nextId = borrow.GetNextBookID();

            // Assert
            Assert.Equals(1, nextId);
        }



        [Test]
        public void GetNextUserID_ShouldReturnNextID_WhenUsersArePresent()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddUser("User1");
            borrow.AddUser("User2");

            // Act
            var nextId = borrow.GetNextUserID();

            // Assert
            Assert.Equals(3, nextId);
        }

        [Test]
        public void GetNextUserID_ShouldReturn1_WhenNoUsersArePresent()
        {
            // Arrange
            var borrow = new Borrow();

            // Act
            var nextId = borrow.GetNextUserID();

            // Assert
            Assert.Equals(1, nextId);
        }*/

    }
}


/*
using System;
using System.Linq;
using Xunit;

namespace Library.files.resources.Tests
{
    public class BorrowTests
    {
        [Fact]
        public void GetNextBookID_ShouldReturnNextID_WhenBooksArePresent()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddBook("Book1", "Author1", 2000);
            borrow.AddBook("Book2", "Author2", 2001);

            // Act
            var nextId = borrow.GetNextBookID();

            // Assert
            Assert.Equal(3, nextId);
        }

        [Fact]
        public void GetNextBookID_ShouldReturn1_WhenNoBooksArePresent()
        {
            // Arrange
            var borrow = new Borrow();

            // Act
            var nextId = borrow.GetNextBookID();

            // Assert
            Assert.Equal(1, nextId);
        }

        [Fact]
        public void AddBook_ShouldAddBookToList()
        {
            // Arrange
            var borrow = new Borrow();

            // Act
            borrow.AddBook("Book1", "Author1", 2000);

            // Assert
            Assert.Single(borrow.Books);
        }

        [Fact]
        public void RemoveBook_ShouldRemoveBookFromList()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddBook("Book1", "Author1", 2000);
            var bookId = borrow.Books.First().GetID();

            // Act
            borrow.RemoveBook(bookId);

            // Assert
            Assert.Empty(borrow.Books);
        }

        [Fact]
        public void GetNextUserID_ShouldReturnNextID_WhenUsersArePresent()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddUser("User1");
            borrow.AddUser("User2");

            // Act
            var nextId = borrow.GetNextUserID();

            // Assert
            Assert.Equal(3, nextId);
        }

        [Fact]
        public void GetNextUserID_ShouldReturn1_WhenNoUsersArePresent()
        {
            // Arrange
            var borrow = new Borrow();

            // Act
            var nextId = borrow.GetNextUserID();

            // Assert
            Assert.Equal(1, nextId);
        }

        [Fact]
        public void AddUser_ShouldAddUserToList()
        {
            // Arrange
            var borrow = new Borrow();

            // Act
            borrow.AddUser("User1");

            // Assert
            Assert.Single(borrow.Users);
        }

        [Fact]
        public void RemoveUser_ShouldRemoveUserFromList()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddUser("User1");
            var userId = borrow.Users.First().GetID();

            // Act
            borrow.RemoveUser(userId);

            // Assert
            Assert.Empty(borrow.Users);
        }

        [Fact]
        public void BorrowBook_ShouldSetBookStatusToUnavailableAndAssignToUser()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddBook("Book1", "Author1", 2000);
            borrow.AddUser("User1");
            var bookId = borrow.Books.First().GetID();
            var userId = borrow.Users.First().GetID();

            // Act
            var result = borrow.BorrowBook(bookId, userId);

            // Assert
            Assert.True(result);
            Assert.False(borrow.Books.First().GetStatus());
            Assert.Single(borrow.Users.First().BorrowedBooks);
        }

        [Fact]
        public void BorrowBook_ShouldNotBorrowIfBookIsUnavailableOrUserDoesNotExist()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddBook("Book1", "Author1", 2000);
            borrow.AddUser("User1");
            var bookId = borrow.Books.First().GetID();
            var userId = borrow.Users.First().GetID();
            borrow.BorrowBook(bookId, userId);

            // Act
            var result = borrow.BorrowBook(bookId, userId);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ReturnBook_ShouldMakeBookAvailableAgainAndRemoveFromUser()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddBook("Book1", "Author1", 2000);
            borrow.AddUser("User1");
            var bookId = borrow.Books.First().GetID();
            var userId = borrow.Users.First().GetID();
            borrow.BorrowBook(bookId, userId);

            // Act
            var result = borrow.ReturnBook(bookId, 5);

            // Assert
            Assert.True(result);
            Assert.True(borrow.Books.First().GetStatus());
            Assert.Empty(borrow.Users.First().BorrowedBooks);
        }

        [Fact]
        public void ReturnBook_ShouldNotReturnIfBookIsNotBorrowedOrUserDoesNotExist()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddBook("Book1", "Author1", 2000);
            var bookId = borrow.Books.First().GetID();

            // Act
            var result = borrow.ReturnBook(bookId, 5);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void DisplayAllBooks_ShouldDisplayAllBooks()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddBook("Book1", "Author1", 2000);
            borrow.AddBook("Book2", "Author2", 2001);

            // Act
            using var consoleOutput = new ConsoleOutput();
            borrow.DisplayAllBooks();
            var output = consoleOutput.GetOutput();

            // Assert
            Assert.Contains("ID: 1, Title: Book1, Author: Author1, Year: 2000", output);
            Assert.Contains("ID: 2, Title: Book2, Author: Author2, Year: 2001", output);
        }

        [Fact]
        public void DisplayAllUsers_ShouldDisplayAllUsers()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddUser("User1");
            borrow.AddUser("User2");

            // Act
            using var consoleOutput = new ConsoleOutput();
            borrow.DisplayAllUsers();
            var output = consoleOutput.GetOutput();

            // Assert
            Assert.Contains("ID: 1, User: User1", output);
            Assert.Contains("ID: 2, User: User2", output);
        }

        [Fact]
        public void DisplayAllBorrowedBooks_ShouldDisplayAllBorrowedBooks()
        {
            // Arrange
            var borrow = new Borrow();
            borrow.AddBook("Book1", "Author1", 2000);
            borrow.AddUser("User1");
            var bookId = borrow.Books.First().GetID();
            var userId = borrow.Users.First().GetID();
            borrow.BorrowBook(bookId, userId);

            // Act
            using var consoleOutput = new ConsoleOutput();
            borrow.DisplayAllBorrowedBooks();
            var output = consoleOutput.GetOutput();

            // Assert
            Assert.Contains("ID: 1, Title: Book1, Author: Author1, Year: 2000", output);
        }
    }

    // Helper class to capture console output
    public class ConsoleOutput : IDisposable
    {
        private readonly StringWriter _stringWriter;
        private readonly TextWriter _originalOutput;

        public ConsoleOutput()
        {
            _originalOutput = Console.Out;
            _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);
        }

        public string GetOutput() => _stringWriter.ToString();

        public void Dispose()
        {
            Console.SetOut(_originalOutput);
            _stringWriter.Dispose();
        }
    }
}
*/