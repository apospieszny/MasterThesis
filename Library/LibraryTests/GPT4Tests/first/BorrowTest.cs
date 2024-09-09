using NUnit.Framework;
using Library.files.resources;
using System;


/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 */

namespace Library.Tests.GPT4.first
{
    [TestFixture]
    public class BorrowTests
    {
        private Borrow borrow;

        [SetUp]
        public void Setup()
        {
            borrow = new Borrow();
        }
        /* Test odrzucony
        [Test]
        public void AddBook_ShouldAddBookCorrectly()
        {
            borrow.AddBook("Test Title", "Test Author", 2020);
            Assert.AreEqual(1, borrow.GetNextBookID());
        }*/

        [Test]
        public void RemoveBook_ShouldRemoveBookById()
        {
            borrow.AddBook("Test Title", "Test Author", 2020);
            int bookId = borrow.GetNextBookID() - 1;
            borrow.RemoveBook(bookId);
            Assert.AreEqual(1, borrow.GetNextBookID());
        }
        /* Test odrzucony
        [Test]
        public void AddUser_ShouldAddUserCorrectly()
        {
            borrow.AddUser("Test User");
            Assert.AreEqual(1, borrow.GetNextUserID());
        }*/

        [Test]
        public void RemoveUser_ShouldRemoveUserById()
        {
            borrow.AddUser("Test User");
            int userId = borrow.GetNextUserID() - 1;
            borrow.RemoveUser(userId);
            Assert.AreEqual(1, borrow.GetNextUserID());
        }

        [Test]
        public void BorrowBook_ShouldBorrowBookCorrectly()
        {
            borrow.AddBook("Test Title", "Test Author", 2020);
            borrow.AddUser("Test User");
            bool result = borrow.BorrowBook(1, 1);
            Assert.IsTrue(result);
        }

        [Test]
        public void BorrowBook_ShouldFailIfBookOrUserDoesNotExist()
        {
            bool result = borrow.BorrowBook(1, 1);
            Assert.IsFalse(result);
        }
        /* Test odrzucony
        [Test]
        public void ReturnBook_ShouldReturnBookCorrectly()
        {
            borrow.AddBook("Test Title", "Test Author", 2020);
            borrow.AddUser("Test User");
            borrow.BorrowBook(1, 1);
            bool result = borrow.ReturnBook(1, 5);
            Assert.IsTrue(result);
        }*/

        [Test]
        public void ReturnBook_ShouldFailIfBookIsNotBorrowed()
        {
            borrow.AddBook("Test Title", "Test Author", 2020);
            bool result = borrow.ReturnBook(1, 5);
            Assert.IsFalse(result);
        }
        /* Test odrzucony
        [Test]
        public void DisplayAllBooks_ShouldDisplayBooks()
        {
            borrow.AddBook("Test Title", "Test Author", 2020);
            Assert.DoesNotThrow(() => borrow.DisplayAllBooks());
        }

        [Test]
        public void DisplayAllUsers_ShouldDisplayUsers()
        {
            borrow.AddUser("Test User");
            Assert.DoesNotThrow(() => borrow.DisplayAllUsers());
        }

        [Test]
        public void DisplayAllBorrowedBooks_ShouldDisplayBorrowedBooks()
        {
            borrow.AddUser("Test User");
            borrow.AddBook("Test Title", "Test Author", 2020);
            borrow.BorrowBook(1, 1);
            Assert.DoesNotThrow(() => borrow.DisplayAllBorrowedBooks());
        }*/
    }
}


/*
using NUnit.Framework;
using Library.files.resources;
using System;

namespace LibraryTests
{
    [TestFixture]
    public class BorrowTests
    {
        private Borrow borrow;

        [SetUp]
        public void Setup()
        {
            borrow = new Borrow();
        }

        [Test]
        public void AddBook_ShouldAddBookCorrectly()
        {
            borrow.AddBook("Test Title", "Test Author", 2020);
            Assert.AreEqual(1, borrow.GetNextBookID());
        }

        [Test]
        public void RemoveBook_ShouldRemoveBookById()
        {
            borrow.AddBook("Test Title", "Test Author", 2020);
            int bookId = borrow.GetNextBookID() - 1;
            borrow.RemoveBook(bookId);
            Assert.AreEqual(1, borrow.GetNextBookID());
        }

        [Test]
        public void AddUser_ShouldAddUserCorrectly()
        {
            borrow.AddUser("Test User");
            Assert.AreEqual(1, borrow.GetNextUserID());
        }

        [Test]
        public void RemoveUser_ShouldRemoveUserById()
        {
            borrow.AddUser("Test User");
            int userId = borrow.GetNextUserID() - 1;
            borrow.RemoveUser(userId);
            Assert.AreEqual(1, borrow.GetNextUserID());
        }

        [Test]
        public void BorrowBook_ShouldBorrowBookCorrectly()
        {
            borrow.AddBook("Test Title", "Test Author", 2020);
            borrow.AddUser("Test User");
            bool result = borrow.BorrowBook(1, 1);
            Assert.IsTrue(result);
        }

        [Test]
        public void BorrowBook_ShouldFailIfBookOrUserDoesNotExist()
        {
            bool result = borrow.BorrowBook(1, 1);
            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnBook_ShouldReturnBookCorrectly()
        {
            borrow.AddBook("Test Title", "Test Author", 2020);
            borrow.AddUser("Test User");
            borrow.BorrowBook(1, 1);
            bool result = borrow.ReturnBook(1, 5);
            Assert.IsTrue(result);
        }

        [Test]
        public void ReturnBook_ShouldFailIfBookIsNotBorrowed()
        {
            borrow.AddBook("Test Title", "Test Author", 2020);
            bool result = borrow.ReturnBook(1, 5);
            Assert.IsFalse(result);
        }

        [Test]
        public void DisplayAllBooks_ShouldDisplayBooks()
        {
            borrow.AddBook("Test Title", "Test Author", 2020);
            Assert.DoesNotThrow(() => borrow.DisplayAllBooks());
        }

        [Test]
        public void DisplayAllUsers_ShouldDisplayUsers()
        {
            borrow.AddUser("Test User");
            Assert.DoesNotThrow(() => borrow.DisplayAllUsers());
        }

        [Test]
        public void DisplayAllBorrowedBooks_ShouldDisplayBorrowedBooks()
        {
            borrow.AddUser("Test User");
            borrow.AddBook("Test Title", "Test Author", 2020);
            borrow.BorrowBook(1, 1);
            Assert.DoesNotThrow(() => borrow.DisplayAllBorrowedBooks());
        }
    }
}
*/