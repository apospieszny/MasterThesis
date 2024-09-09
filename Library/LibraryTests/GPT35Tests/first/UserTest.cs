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

namespace Library.Tests.GPT35.first
{
    [TestFixture]
    public class UserTests
    {
        private User _user;
        private Book _book;

        [SetUp]
        public void Setup()
        {
            _user = new User(1, "Test User");
            _book = new Book(1, "Test Title", "Test Author", 2024);
        }

        [Test]
        public void User_Constructor_ShouldInitializeProperties()
        {
            // Act
            var user = new User(1, "John Doe");

            // Assert
            Assert.AreEqual(1, user.GetID());
        }

        [Test]
        public void DisplayInfo_ShouldPrintCorrectInfo()
        {
            // Arrange
            var expectedOutput = "ID: 1, User: Test User";

            using (var consoleOutput = new ConsoleOutput())
            {
                // Act
                _user.DisplayInfo();

                // Assert
                Assert.AreEqual(expectedOutput, consoleOutput.GetOutput().Trim());
            }
        }

        [Test]
        public void GetID_ShouldReturnCorrectID()
        {
            // Act
            var id = _user.GetID();

            // Assert
            Assert.AreEqual(1, id);
        }


        [Test]
        public void DisplayAllBorrowedBooks_ShouldDisplayAllBooks()
        {
            // Arrange
            _user.BorrowBook(_book);

            using (var consoleOutput = new ConsoleOutput())
            {
                // Act
                _user.DisplayAllBorrowedBooks();

                // Assert
                Assert.IsTrue(consoleOutput.GetOutput().Contains("ID: 1, Title: Test Title, Author: Test Author, Year: 2024"));
            }
        }

        [Test]
        public void DisplayAllBorrowedBooks_ShouldNotDisplayAnyBooksIfNoneBorrowed()
        {
            using (var consoleOutput = new ConsoleOutput())
            {
                // Act
                _user.DisplayAllBorrowedBooks();

                // Assert
                Assert.IsEmpty(consoleOutput.GetOutput().Trim());
            }
        }
    }

    public class ConsoleOutput : IDisposable
    {
        private readonly System.IO.StringWriter _stringWriter;
        private readonly System.IO.TextWriter _originalOutput;

        public ConsoleOutput()
        {
            _stringWriter = new System.IO.StringWriter();
            _originalOutput = Console.Out;
            Console.SetOut(_stringWriter);
        }

        public string GetOutput()
        {
            return _stringWriter.ToString();
        }

        public void Dispose()
        {
            Console.SetOut(_originalOutput);
            _stringWriter.Dispose();
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
        public void Setup()
        {
            _user = new User(1, "Test User");
            _book = new Book(1, "Test Title", "Test Author", 2024);
        }

        [Test]
        public void User_Constructor_ShouldInitializeProperties()
        {
            // Act
            var user = new User(1, "John Doe");

            // Assert
            Assert.AreEqual(1, user.GetID());
            Assert.AreEqual("John Doe", user.Name);
        }

        [Test]
        public void DisplayInfo_ShouldPrintCorrectInfo()
        {
            // Arrange
            var expectedOutput = "ID: 1, User: Test User";

            using (var consoleOutput = new ConsoleOutput())
            {
                // Act
                _user.DisplayInfo();

                // Assert
                Assert.AreEqual(expectedOutput, consoleOutput.GetOutput().Trim());
            }
        }

        [Test]
        public void GetID_ShouldReturnCorrectID()
        {
            // Act
            var id = _user.GetID();

            // Assert
            Assert.AreEqual(1, id);
        }

        [Test]
        public void BorrowBook_ShouldAddBookToBorrowedBooks()
        {
            // Act
            _user.BorrowBook(_book);

            // Assert
            Assert.Contains(_book, _user.BorrowedBooks);
        }

        [Test]
        public void ReturnBook_ShouldRemoveBookFromBorrowedBooks()
        {
            // Arrange
            _user.BorrowBook(_book);

            // Act
            _user.ReturnBook(_book);

            // Assert
            Assert.IsFalse(_user.BorrowedBooks.Contains(_book));
        }

        [Test]
        public void DisplayAllBorrowedBooks_ShouldDisplayAllBooks()
        {
            // Arrange
            _user.BorrowBook(_book);

            using (var consoleOutput = new ConsoleOutput())
            {
                // Act
                _user.DisplayAllBorrowedBooks();

                // Assert
                Assert.IsTrue(consoleOutput.GetOutput().Contains("ID: 1, Title: Test Title, Author: Test Author, Year: 2024"));
            }
        }

        [Test]
        public void DisplayAllBorrowedBooks_ShouldNotDisplayAnyBooksIfNoneBorrowed()
        {
            using (var consoleOutput = new ConsoleOutput())
            {
                // Act
                _user.DisplayAllBorrowedBooks();

                // Assert
                Assert.IsEmpty(consoleOutput.GetOutput().Trim());
            }
        }
    }

    public class ConsoleOutput : IDisposable
    {
        private readonly System.IO.StringWriter _stringWriter;
        private readonly System.IO.TextWriter _originalOutput;

        public ConsoleOutput()
        {
            _stringWriter = new System.IO.StringWriter();
            _originalOutput = Console.Out;
            Console.SetOut(_stringWriter);
        }

        public string GetOutput()
        {
            return _stringWriter.ToString();
        }

        public void Dispose()
        {
            Console.SetOut(_originalOutput);
            _stringWriter.Dispose();
        }
    }
}
*/