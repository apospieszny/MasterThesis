using NUnit.Framework;
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

namespace Library.Tests.GPT35.many
{
    [TestFixture]
    public class UserTests
    {
        private User _user;
        private Book _book;

        [SetUp]
        public void SetUp()
        {
            _user = new User(1, "John Doe");
            _book = new Book(1, "Book Title", "Author Name", 2020);
        }

        [Test]
        public void Constructor_ShouldInitializeUser()
        {
            // Arrange
            var user = new User(1, "Jane Doe");

            // Act
            var id = user.GetID();

            // Assert
            Assert.AreEqual(1, id);
        }

        [Test]
        public void DisplayInfo_ShouldOutputUserInfo()
        {
            // Arrange
            var expectedOutput = "ID: 1, User: John Doe";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                _user.DisplayInfo();

                // Assert
                var result = sw.ToString().Trim();
                Assert.AreEqual(expectedOutput, result);
            }
        }


        [Test]
        public void DisplayAllBorrowedBooks_ShouldOutputAllBooks()
        {
            // Arrange
            var book2 = new Book(2, "Another Book", "Another Author", 2021);
            _user.BorrowBook(_book);
            _user.BorrowBook(book2);

            var expectedOutput1 = "ID: 1, Title: Book Title, Author: Author Name, Year: 2020";
            var expectedOutput2 = "ID: 2, Title: Another Book, Author: Another Author, Year: 2021";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                _user.DisplayAllBorrowedBooks();

                // Assert
                var result = sw.ToString().Trim().Split(Environment.NewLine);
                Assert.Contains(expectedOutput1, result);
                Assert.Contains(expectedOutput2, result);
            }
        }

        // dodatkowe testy


        [Test]
        public void ReturnBook_ShouldNotThrowExceptionIfBookIsNotInList()
        {
            // Act
            var newBook = new Book(3, "Non-existent Book", "Unknown Author", 2022);
            // Act & Assert
            Assert.DoesNotThrow(() => _user.ReturnBook(newBook));
        }
    }
}

/*
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.files.resources.Tests
{
    [TestFixture]
    public class UserTests
    {
        private User _user;
        private Book _book;

        [SetUp]
        public void SetUp()
        {
            _user = new User(1, "John Doe");
            _book = new Book(1, "Book Title", "Author Name", 2020);
        }

        [Test]
        public void Constructor_ShouldInitializeUser()
        {
            // Arrange
            var user = new User(1, "Jane Doe");

            // Act
            var id = user.GetID();
            var name = user.GetName(); 

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual("Jane Doe", name);
        }

        [Test]
        public void DisplayInfo_ShouldOutputUserInfo()
        {
            // Arrange
            var expectedOutput = "ID: 1, User: John Doe";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                _user.DisplayInfo();

                // Assert
                var result = sw.ToString().Trim();
                Assert.AreEqual(expectedOutput, result);
            }
        }

        [Test]
        public void BorrowBook_ShouldAddBookToList()
        {
            // Act
            _user.BorrowBook(_book);

            // Assert
            var borrowedBooks = _user.GetBorrowedBooks(); 
            Assert.AreEqual(1, borrowedBooks.Count);
            Assert.AreEqual(_book, borrowedBooks.First());
        }

        [Test]
        public void ReturnBook_ShouldRemoveBookFromList()
        {
            // Arrange
            _user.BorrowBook(_book);

            // Act
            _user.ReturnBook(_book);

            // Assert
            var borrowedBooks = _user.GetBorrowedBooks(); 
            Assert.IsEmpty(borrowedBooks);
        }

        [Test]
        public void DisplayAllBorrowedBooks_ShouldOutputAllBooks()
        {
            // Arrange
            var book2 = new Book(2, "Another Book", "Another Author", 2021);
            _user.BorrowBook(_book);
            _user.BorrowBook(book2);

            var expectedOutput1 = "ID: 1, Title: Book Title, Author: Author Name, Year: 2020";
            var expectedOutput2 = "ID: 2, Title: Another Book, Author: Another Author, Year: 2021";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                _user.DisplayAllBorrowedBooks();

                // Assert
                var result = sw.ToString().Trim().Split(Environment.NewLine);
                Assert.Contains(expectedOutput1, result);
                Assert.Contains(expectedOutput2, result);
            }
        }

        // dodatkowe testy

        [Test]
        public void BorrowBook_ShouldNotAddDuplicateBooks()
        {
            // Act
            _user.BorrowBook(_book);
            _user.BorrowBook(_book);

            // Assert
            var borrowedBooks = _user.GetBorrowedBooks(); 
            Assert.AreEqual(1, borrowedBooks.Count); 
        }

        [Test]
        public void ReturnBook_ShouldNotThrowExceptionIfBookIsNotInList()
        {
            // Act
            var newBook = new Book(3, "Non-existent Book", "Unknown Author", 2022);
            // Act & Assert
            Assert.DoesNotThrow(() => _user.ReturnBook(newBook));
        }
    }
}
*/