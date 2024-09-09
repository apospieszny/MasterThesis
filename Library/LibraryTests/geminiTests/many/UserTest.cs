using Library.files.resources;
using NUnit.Framework;
using Library.files.resources;


/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Library.Tests.gemini.many
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void Constructor_InitializesPropertiesCorrectly()
        {
            // Arrange
            int userId = 1;
            string name = "John Doe";

            // Act
            User user = new User(userId, name);

            // Assert
            Assert.AreEqual(userId, user.GetID());
        }


        [Test]
        public void ReturnBook_RemovesBookFromBorrowedBooks()
        {
            // Arrange
            User user = new User(5, "Charlie Clark");
            Book book = new Book(3, "Yet Another Book", "Yet Another Author", 2025);
            user.BorrowBook(book);

            // Act
            user.ReturnBook(book);

            // Assert
            Assert.IsTrue(book.GetStatus());
        }

        //dodatkowe testy


        [Test]
        public void RateBook_ThrowsExceptionForNegativeRating()
        {
            Book book = new Book(1, "Title", "Author", 2023);
            Assert.Throws<ArgumentException>(() => book.RateBook(-1));
        }

        [Test]
        public void GetAverageRating_ReturnsZeroForEmptyList()
        {
            Book book = new Book(1, "Title", "Author", 2023);
            Assert.AreEqual(0, book.GetAverageRating());
        }


        /* Testy odrzucone
         
        [Test]
        public void BorrowBook_AddsBookToBorrowedBooks()
        {
            // Arrange
            User user = new User(3, "Alice Johnson");
            Book book = new Book(1, "Book Title", "Author", 2023);

            // Act
            user.BorrowBook(book);

            // Assert
            Assert.IsFalse(book.GetStatus());
        }

        [Test]
        public void BorrowBook_ThrowsExceptionIfBookIsAlreadyBorrowed()
        {
            // Arrange
            User user = new User(4, "Bob Brown");
            Book book = new Book(2, "Another Book", "Another Author", 2024);
            user.BorrowBook(book);

            // Act and Assert
            Assert.Throws<InvalidOperationException>(() => user.BorrowBook(book));
        }         
         
        [Test]
        public void Constructor_ThrowsExceptionForNegativeUserId()
        {
            Assert.Throws<ArgumentException>(() => new User(-1, "John Doe"));
        }         
         

        [Test]
        public void ReturnBook_ThrowsExceptionIfBookIsNotBorrowed()
        {
            // Arrange
            User user = new User(6, "David Davis");
            Book book = new Book(4, "The Last Book", "The Last Author", 2026);

            // Act and Assert
            Assert.Throws<InvalidOperationException>(() => user.ReturnBook(book));
        }         
         

        */
    }
}

/*
using Library.files.resources;
using NUnit.Framework;

namespace Library.files.tests
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void Constructor_InitializesPropertiesCorrectly()
        {
            // Arrange
            int userId = 1;
            string name = "John Doe";

            // Act
            User user = new User(userId, name);

            // Assert
            Assert.AreEqual(userId, user.GetID());
            Assert.AreEqual(name, user.Name);
            Assert.IsNotNull(user.BorrowedBooks);
            Assert.AreEqual(0, user.BorrowedBooks.Count);
        }

        [Test]
        public void DisplayInfo_PrintsCorrectInformation()
        {
            // Arrange
            int userId = 2;
            string name = "Jane Smith";
            User user = new User(userId, name);

            // Act
            using (var consoleOutput = new ConsoleOutputHelper())
            {
                user.DisplayInfo();
                var output = consoleOutput.ToString();

                // Assert
                Assert.AreEqual($"ID: {userId}, User: {name}", output.Trim());
            }
        }

        [Test]
        public void BorrowBook_AddsBookToBorrowedBooks()
        {
            // Arrange
            User user = new User(3, "Alice Johnson");
            Book book = new Book(1, "Book Title", "Author", 2023);

            // Act
            user.BorrowBook(book);

            // Assert
            Assert.AreEqual(1, user.BorrowedBooks.Count);
            Assert.AreEqual(book, user.BorrowedBooks[0]);
            Assert.IsFalse(book.GetStatus());
        }

        [Test]
        public void BorrowBook_ThrowsExceptionIfBookIsAlreadyBorrowed()
        {
            // Arrange
            User user = new User(4, "Bob Brown");
            Book book = new Book(2, "Another Book", "Another Author", 2024);
            user.BorrowBook(book);

            // Act and Assert
            Assert.Throws<InvalidOperationException>(() => user.BorrowBook(book));
        }

        [Test]
        public void ReturnBook_RemovesBookFromBorrowedBooks()
        {
            // Arrange
            User user = new User(5, "Charlie Clark");
            Book book = new Book(3, "Yet Another Book", "Yet Another Author", 2025);
            user.BorrowBook(book);

            // Act
            user.ReturnBook(book);

            // Assert
            Assert.AreEqual(0, user.BorrowedBooks.Count);
            Assert.IsTrue(book.GetStatus());
        }

        [Test]
        public void ReturnBook_ThrowsExceptionIfBookIsNotBorrowed()
        {
            // Arrange
            User user = new User(6, "David Davis");
            Book book = new Book(4, "The Last Book", "The Last Author", 2026);

            // Act and Assert
            Assert.Throws<InvalidOperationException>(() => user.ReturnBook(book));
        }

        [Test]
        public void DisplayAllBorrowedBooks_PrintsCorrectInformation()
        {
            // Arrange
            User user = new User(7, "Emily Evans");
            Book book1 = new Book(5, "First Book", "First Author", 2027);
            Book book2 = new Book(6, "Second Book", "Second Author", 2028);
            user.BorrowBook(book1);
            user.BorrowBook(book2);

            // Act
            using (var consoleOutput = new ConsoleOutputHelper())
            {
                user.DisplayAllBorrowedBooks();
                var output = consoleOutput.ToString();

                // Assert
                Assert.IsTrue(output.Contains($"ID: {book1.GetID()}, Title: {book1.Title}, Author: {book1.Author}, Year: {book1.Year}"));
                Assert.IsTrue(output.Contains($"ID: {book2.GetID()}, Title: {book2.Title}, Author: {book2.Author}, Year: {book2.Year}"));
            }
        }

        //dodatkowe testy

        [Test]
        public void Constructor_ThrowsExceptionForNegativeUserId()
        {
            Assert.Throws<ArgumentException>(() => new User(-1, "John Doe"));
        }

        [Test]
        public void RateBook_ThrowsExceptionForNegativeRating()
        {
            Book book = new Book(1, "Title", "Author", 2023);
            Assert.Throws<ArgumentException>(() => book.RateBook(-1));
        }

        [Test]
        public void GetAverageRating_ReturnsZeroForEmptyList()
        {
            Book book = new Book(1, "Title", "Author", 2023);
            Assert.AreEqual(0, book.GetAverageRating());
        }
    }
}
*/