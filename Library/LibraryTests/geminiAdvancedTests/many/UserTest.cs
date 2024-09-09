using Library.files.resources;
using NUnit.Framework;
using System.Collections.Generic;


/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 */

namespace Library.Tests.geminiAdvanced.many
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void Constructor_SetsPropertiesCorrectly()
        {
            // Arrange
            int expectedId = 1;
            string expectedName = "John Doe";

            // Act
            User user = new User(expectedId, expectedName);

            // Assert
            Assert.AreEqual(expectedId, user.GetID());
            // Możemy sprawdzić nazwę tylko pośrednio, przez DisplayInfo, gdyż nie ma publicznego gettera
            var expectedOutput = $"ID: {expectedId}, User: {expectedName}";
            var stringWriter = new System.IO.StringWriter();
            Console.SetOut(stringWriter);
            user.DisplayInfo();
            var output = stringWriter.ToString().Trim();
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void DisplayInfo_WritesCorrectOutput()
        {
            // Arrange
            User user = new User(1, "John Doe");
            var expectedOutput = $"ID: 1, User: John Doe";
            var stringWriter = new System.IO.StringWriter();
            Console.SetOut(stringWriter);

            // Act
            user.DisplayInfo();

            // Assert
            var output = stringWriter.ToString().Trim();
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void GetID_ReturnsCorrectID()
        {
            // Arrange
            int expectedId = 1;
            User user = new User(expectedId, "John Doe");

            // Act
            int actualId = user.GetID();

            // Assert
            Assert.AreEqual(expectedId, actualId);
        }

        [Test]
        public void BorrowBook_AddsBookToList()
        {
            // Arrange
            User user = new User(1, "John Doe");
            Book book = new Book(101, "The Lord of the Rings", "J.R.R. Tolkien", 1954);

            // Act
            user.BorrowBook(book);

            // Assert
            // Możemy sprawdzić tylko pośrednio, przez DisplayAllBorrowedBooks
            var expectedOutput = $"ID: 101, Title: The Lord of the Rings, Author: J.R.R. Tolkien, Year: 1954";
            var stringWriter = new System.IO.StringWriter();
            Console.SetOut(stringWriter);
            user.DisplayAllBorrowedBooks();
            var output = stringWriter.ToString().Trim();
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void ReturnBook_RemovesBookFromList()
        {
            // Arrange
            User user = new User(1, "John Doe");
            Book book1 = new Book(101, "The Lord of the Rings", "J.R.R. Tolkien", 1954);
            Book book2 = new Book(102, "The Hobbit", "J.R.R. Tolkien", 1937);
            user.BorrowBook(book1);
            user.BorrowBook(book2);

            // Act
            user.ReturnBook(book1);

            // Assert
            // Sprawdźmy, czy została tylko druga książka
            var expectedOutput = $"ID: 102, Title: The Hobbit, Author: J.R.R. Tolkien, Year: 1937";
            var stringWriter = new System.IO.StringWriter();
            Console.SetOut(stringWriter);
            user.DisplayAllBorrowedBooks();
            var output = stringWriter.ToString().Trim();
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void DisplayAllBorrowedBooks_WritesCorrectOutput_WhenListIsNotEmpty()
        {
            // Arrange
            User user = new User(1, "John Doe");
            Book book1 = new Book(101, "The Lord of the Rings", "J.R.R. Tolkien", 1954);
            Book book2 = new Book(102, "The Hobbit", "J.R.R. Tolkien", 1937);
            user.BorrowBook(book1);
            user.BorrowBook(book2);

            var expectedOutput =
                $"ID: 101, Title: The Lord of the Rings, Author: J.R.R. Tolkien, Year: 1954\r\n" +
                $"ID: 102, Title: The Hobbit, Author: J.R.R. Tolkien, Year: 1937";
            var stringWriter = new System.IO.StringWriter();
            Console.SetOut(stringWriter);

            // Act
            user.DisplayAllBorrowedBooks();

            // Assert
            var output = stringWriter.ToString().Trim();
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void DisplayAllBorrowedBooks_DoesNotWriteOutput_WhenListIsEmpty()
        {
            // Arrange
            User user = new User(1, "John Doe");
            var stringWriter = new System.IO.StringWriter();
            Console.SetOut(stringWriter);

            // Act
            user.DisplayAllBorrowedBooks();

            // Assert
            var output = stringWriter.ToString().Trim();
            Assert.AreEqual("", output); // Oczekujemy pustego wyjścia
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
            int expectedId = 1;
            string expectedName = "John Doe";

            // Act
            User user = new User(expectedId, expectedName);

            // Assert
            Assert.AreEqual(expectedId, user.GetID());
            // Możemy sprawdzić nazwę tylko pośrednio, przez DisplayInfo, gdyż nie ma publicznego gettera
            var expectedOutput = $"ID: {expectedId}, User: {expectedName}";
            var stringWriter = new System.IO.StringWriter();
            Console.SetOut(stringWriter);
            user.DisplayInfo();
            var output = stringWriter.ToString().Trim();
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void DisplayInfo_WritesCorrectOutput()
        {
            // Arrange
            User user = new User(1, "John Doe");
            var expectedOutput = $"ID: 1, User: John Doe";
            var stringWriter = new System.IO.StringWriter();
            Console.SetOut(stringWriter);

            // Act
            user.DisplayInfo();

            // Assert
            var output = stringWriter.ToString().Trim();
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void GetID_ReturnsCorrectID()
        {
            // Arrange
            int expectedId = 1;
            User user = new User(expectedId, "John Doe");

            // Act
            int actualId = user.GetID();

            // Assert
            Assert.AreEqual(expectedId, actualId);
        }

        [Test]
        public void BorrowBook_AddsBookToList()
        {
            // Arrange
            User user = new User(1, "John Doe");
            Book book = new Book(101, "The Lord of the Rings", "J.R.R. Tolkien", 1954);

            // Act
            user.BorrowBook(book);

            // Assert
            // Możemy sprawdzić tylko pośrednio, przez DisplayAllBorrowedBooks
            var expectedOutput = $"ID: 101, Title: The Lord of the Rings, Author: J.R.R. Tolkien, Year: 1954";
            var stringWriter = new System.IO.StringWriter();
            Console.SetOut(stringWriter);
            user.DisplayAllBorrowedBooks();
            var output = stringWriter.ToString().Trim();
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void ReturnBook_RemovesBookFromList()
        {
            // Arrange
            User user = new User(1, "John Doe");
            Book book1 = new Book(101, "The Lord of the Rings", "J.R.R. Tolkien", 1954);
            Book book2 = new Book(102, "The Hobbit", "J.R.R. Tolkien", 1937);
            user.BorrowBook(book1);
            user.BorrowBook(book2);

            // Act
            user.ReturnBook(book1);

            // Assert
            // Sprawdźmy, czy została tylko druga książka
            var expectedOutput = $"ID: 102, Title: The Hobbit, Author: J.R.R. Tolkien, Year: 1937";
            var stringWriter = new System.IO.StringWriter();
            Console.SetOut(stringWriter);
            user.DisplayAllBorrowedBooks();
            var output = stringWriter.ToString().Trim();
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void DisplayAllBorrowedBooks_WritesCorrectOutput_WhenListIsNotEmpty()
        {
            // Arrange
            User user = new User(1, "John Doe");
            Book book1 = new Book(101, "The Lord of the Rings", "J.R.R. Tolkien", 1954);
            Book book2 = new Book(102, "The Hobbit", "J.R.R. Tolkien", 1937);
            user.BorrowBook(book1);
            user.BorrowBook(book2);

            var expectedOutput = 
                $"ID: 101, Title: The Lord of the Rings, Author: J.R.R. Tolkien, Year: 1954\r\n" +
                $"ID: 102, Title: The Hobbit, Author: J.R.R. Tolkien, Year: 1937";
            var stringWriter = new System.IO.StringWriter();
            Console.SetOut(stringWriter);

            // Act
            user.DisplayAllBorrowedBooks();

            // Assert
            var output = stringWriter.ToString().Trim();
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void DisplayAllBorrowedBooks_DoesNotWriteOutput_WhenListIsEmpty()
        {
            // Arrange
            User user = new User(1, "John Doe");
            var stringWriter = new System.IO.StringWriter();
            Console.SetOut(stringWriter);

            // Act
            user.DisplayAllBorrowedBooks();

            // Assert
            var output = stringWriter.ToString().Trim();
            Assert.AreEqual("", output); // Oczekujemy pustego wyjścia
        }
    }
}
*/