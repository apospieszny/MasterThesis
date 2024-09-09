using Library.files.resources;
using NUnit.Framework;
/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Library.Tests.gemini.first
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
        public void DisplayInfo_PrintsCorrectInformation()
        {
            // Arrange
            int userId = 2;
            string name = "Jane Smith";
            User user = new User(userId, name);

            // Act
            using (var consoleOutput = new StringWriter())
            {
                Console.SetOut(consoleOutput);
                user.DisplayInfo();
                string output = consoleOutput.ToString();

                // Assert
                Assert.AreEqual($"ID: {userId}, User: {name}", output.Trim());
            }
        }


        [Test]
        public void ReturnBook_RemovesBookFromBorrowedBooks()
        {
            // Arrange
            User user = new User(5, "Charlie Carter");
            Book book = new Book(2, "Another Book", "Another Author", 2024);
            user.BorrowBook(book);

            // Act
            user.ReturnBook(book);

            // Assert
            Assert.AreEqual(0, book.GetUserID());
            Assert.IsTrue(book.GetStatus());
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
            Assert.AreEqual(user.GetID(), book.GetUserID());
            Assert.IsFalse(book.GetStatus());
        }

        [Test]
        public void BorrowBook_HandlesNullBook()
        {
            // Arrange
            User user = new User(4, "Bob Brown");

            // Act
            Assert.Throws<ArgumentNullException>(() => user.BorrowBook(null));
        }

        [Test]
        public void ReturnBook_HandlesBookNotFound()
        {
            // Arrange
            User user = new User(6, "David Davis");
            Book book1 = new Book(3, "Yet Another Book", "Yet Another Author", 2025);
            Book book2 = new Book(4, "One More Book", "One More Author", 2026);
            user.BorrowBook(book1);

            // Act
            Assert.Throws<InvalidOperationException>(() => user.ReturnBook(book2));
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
            Assert.IsInstanceOf<List<Book>>(user.BorrowedBooks);
            Assert.IsEmpty(user.BorrowedBooks);
        }

        [Test]
        public void DisplayInfo_PrintsCorrectInformation()
        {
            // Arrange
            int userId = 2;
            string name = "Jane Smith";
            User user = new User(userId, name);

            // Act
            using (var consoleOutput = new StringWriter())
            {
                Console.SetOut(consoleOutput);
                user.DisplayInfo();
                string output = consoleOutput.ToString();

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
            Assert.AreEqual(user.GetID(), book.GetUserID());
            Assert.IsFalse(book.GetStatus());
        }

        [Test]
        public void BorrowBook_HandlesNullBook()
        {
            // Arrange
            User user = new User(4, "Bob Brown");

            // Act
            Assert.Throws<ArgumentNullException>(() => user.BorrowBook(null));
        }

        [Test]
        public void ReturnBook_RemovesBookFromBorrowedBooks()
        {
            // Arrange
            User user = new User(5, "Charlie Carter");
            Book book = new Book(2, "Another Book", "Another Author", 2024);
            user.BorrowBook(book);

            // Act
            user.ReturnBook(book);

            // Assert
            Assert.AreEqual(0, user.BorrowedBooks.Count);
            Assert.AreEqual(0, book.GetUserID());
            Assert.IsTrue(book.GetStatus());
        }

        [Test]
        public void ReturnBook_HandlesBookNotFound()
        {
            // Arrange
            User user = new User(6, "David Davis");
            Book book1 = new Book(3, "Yet Another Book", "Yet Another Author", 2025);
            Book book2 = new Book(4, "One More Book", "One More Author", 2026);
            user.BorrowBook(book1);

            // Act
            Assert.Throws<InvalidOperationException>(() => user.ReturnBook(book2));
        }

        [Test]
        public void DisplayAllBorrowedBooks_PrintsCorrectInformation()
        {
            // Arrange
            User user = new User(7, "Emily Evans");
            Book book1 = new Book(5, "Book 1", "Author 1", 2027);
            Book book2 = new Book(6, "Book 2", "Author 2", 2028);
            user.BorrowBook(book1);
            user.BorrowBook(book2);

            // Act
            using (var consoleOutput = new StringWriter())
            {
                Console.SetOut(consoleOutput);
                user.DisplayAllBorrowedBooks();
                string output = consoleOutput.ToString();

                // Assert
                Assert.AreEqual($"ID: {book1.GetID()}, Title: {book1.Title}, Author: {book1.Author}, Year: {book1.Year}\nID: {book2.GetID()}, Title: {book2.Title}, Author: {book2.Author}, Year: {book2.Year}", output.Trim());
            }
        }
    }
}
*/