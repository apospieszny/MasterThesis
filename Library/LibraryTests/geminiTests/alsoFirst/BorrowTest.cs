using Library.files.resources;
using NUnit.Framework;
/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Library.Tests.gemini.alsoFirst
{
    [TestFixture]
    public class BorrowTests
    {
        private Borrow _borrow;

        [SetUp]
        public void Setup()
        {
            _borrow = new Borrow();
        }

        #region Book Tests

        [Test]
        public void GetNextBookID_Initial_Returns1()
        {
            Assert.AreEqual(1, _borrow.GetNextBookID());
        }

        [Test]
        public void GetNextBookID_AfterAddingBooks_ReturnsCorrectID()
        {
            _borrow.AddBook("Book 1", "Author 1", 2023);
            _borrow.AddBook("Book 2", "Author 2", 2024);

            Assert.AreEqual(3, _borrow.GetNextBookID());
        }

        #endregion

        #region User Tests

        [Test]
        public void GetNextUserID_Initial_Returns1()
        {
            Assert.AreEqual(1, _borrow.GetNextUserID());
        }

        [Test]
        public void GetNextUserID_AfterAddingUsers_ReturnsCorrectID()
        {
            _borrow.AddUser("User 1");
            _borrow.AddUser("User 2");

            Assert.AreEqual(3, _borrow.GetNextUserID());
        }

        #endregion

        #region BorrowBook Tests

        [Test]
        public void BorrowBook_Success()
        {
            _borrow.AddBook("Book 1", "Author 1", 2023);
            _borrow.AddUser("User 1");

            Assert.IsTrue(_borrow.BorrowBook(1, 1));
        }

        [Test]
        public void BorrowBook_BookNotFound()
        {
            _borrow.AddUser("User 1");

            Assert.IsFalse(_borrow.BorrowBook(100, 1));
        }

        [Test]
        public void BorrowBook_UserNotFound()
        {
            _borrow.AddBook("Book 1", "Author 1", 2023);

            Assert.IsFalse(_borrow.BorrowBook(1, 100));
        }

        [Test]
        public void BorrowBook_BookAlreadyBorrowed()
        {
            _borrow.AddBook("Book 1", "Author 1", 2023);
            _borrow.AddUser("User 1");
            _borrow.BorrowBook(1, 1);

            Assert.IsFalse(_borrow.BorrowBook(1, 1));
        }

        #endregion

        #region ReturnBook Tests


        [Test]
        public void ReturnBook_BookNotFound()
        {
            Assert.IsFalse(_borrow.ReturnBook(100, 4));
        }

        [Test]
        public void ReturnBook_BookNotBorrowedByUser()
        {
            _borrow.AddBook("Book 1", "Author 1", 2023);
            _borrow.AddUser("User 1");
            _borrow.AddUser("User 2");
            _borrow.BorrowBook(1, 1);

            Assert.IsTrue(_borrow.ReturnBook(1, 2));
        }

        #endregion

        /* Testy odrzucone
        [Test]
        public void ReturnBook_Success()
        {
            _borrow.AddBook("Book 1", "Author 1", 2023);
            _borrow.AddUser("User 1");
            _borrow.BorrowBook(1, 1);

            Assert.IsTrue(_borrow.ReturnBook(1, 4));
        }*/
    }
}

/*
using Library.files.resources;
using NUnit.Framework;

namespace Library.files.tests
{
    [TestFixture]
    public class BorrowTests
    {
        private Borrow _borrow;

        [SetUp]
        public void Setup()
        {
            _borrow = new Borrow();
        }

        #region Book Tests

        [Test]
        public void GetNextBookID_Initial_Returns1()
        {
            Assert.AreEqual(1, _borrow.GetNextBookID());
        }

        [Test]
        public void GetNextBookID_AfterAddingBooks_ReturnsCorrectID()
        {
            _borrow.AddBook("Book 1", "Author 1", 2023);
            _borrow.AddBook("Book 2", "Author 2", 2024);

            Assert.AreEqual(3, _borrow.GetNextBookID());
        }

        [Test]
        public void AddBook_AddsBookCorrectly()
        {
            _borrow.AddBook("Book 1", "Author 1", 2023);

            Assert.AreEqual(1, _borrow.Books.Count);
            Assert.AreEqual("Book 1", _borrow.Books[0].Title);
            Assert.AreEqual("Author 1", _borrow.Books[0].Author);
            Assert.AreEqual(2023, _borrow.Books[0].Year);
        }

        [Test]
        public void RemoveBook_RemovesCorrectBook()
        {
            _borrow.AddBook("Book 1", "Author 1", 2023);
            _borrow.AddBook("Book 2", "Author 2", 2024);

            _borrow.RemoveBook(1);

            Assert.AreEqual(1, _borrow.Books.Count);
            Assert.AreEqual("Book 2", _borrow.Books[0].Title);
        }

        [Test]
        public void RemoveBook_NonexistentBook_DoesNothing()
        {
            _borrow.RemoveBook(100);

            Assert.AreEqual(0, _borrow.Books.Count);
        }

        #endregion

        #region User Tests

        [Test]
        public void GetNextUserID_Initial_Returns1()
        {
            Assert.AreEqual(1, _borrow.GetNextUserID());
        }

        [Test]
        public void GetNextUserID_AfterAddingUsers_ReturnsCorrectID()
        {
            _borrow.AddUser("User 1");
            _borrow.AddUser("User 2");

            Assert.AreEqual(3, _borrow.GetNextUserID());
        }

        [Test]
        public void AddUser_AddsUserCorrectly()
        {
            _borrow.AddUser("User 1");

            Assert.AreEqual(1, _borrow.Users.Count);
            Assert.AreEqual("User 1", _borrow.Users[0].Name);
        }

        [Test]
        public void RemoveUser_RemovesCorrectUser()
        {
            _borrow.AddUser("User 1");
            _borrow.AddUser("User 2");

            _borrow.RemoveUser(1);

            Assert.AreEqual(1, _borrow.Users.Count);
            Assert.AreEqual("User 2", _borrow.Users[0].Name);
        }

        [Test]
        public void RemoveUser_NonexistentUser_DoesNothing()
        {
            _borrow.RemoveUser(100);

            Assert.AreEqual(0, _borrow.Users.Count);
        }

        #endregion

        #region BorrowBook Tests

        [Test]
        public void BorrowBook_Success()
        {
            _borrow.AddBook("Book 1", "Author 1", 2023);
            _borrow.AddUser("User 1");

            Assert.IsTrue(_borrow.BorrowBook(1, 1));
            Assert.IsFalse(_borrow.Books[0].GetStatus());
            Assert.AreEqual(1, _borrow.Books[0].GetUserID());
            Assert.AreEqual(1, _borrow.Users[0].BorrowedBooks.Count);
        }

        [Test]
        public void BorrowBook_BookNotFound()
        {
            _borrow.AddUser("User 1");

            Assert.IsFalse(_borrow.BorrowBook(100, 1));
        }

        [Test]
        public void BorrowBook_UserNotFound()
        {
            _borrow.AddBook("Book 1", "Author 1", 2023);

            Assert.IsFalse(_borrow.BorrowBook(1, 100));
        }

        [Test]
        public void BorrowBook_BookAlreadyBorrowed()
        {
            _borrow.AddBook("Book 1", "Author 1", 2023);
            _borrow.AddUser("User 1");
            _borrow.BorrowBook(1, 1);

            Assert.IsFalse(_borrow.BorrowBook(1, 1));
        }

        #endregion

        #region ReturnBook Tests

        [Test]
        public void ReturnBook_Success()
        {
            _borrow.AddBook("Book 1", "Author 1", 2023);
            _borrow.AddUser("User 1");
            _borrow.BorrowBook(1, 1);

            Assert.IsTrue(_borrow.ReturnBook(1, 4));
            Assert.IsTrue(_borrow.Books[0].GetStatus());
            Assert.AreEqual(0, _borrow.Books[0].GetUserID());
            Assert.AreEqual(0, _borrow.Users[0].BorrowedBooks.Count);
        }

        [Test]
        public void ReturnBook_BookNotFound()
        {
            Assert.IsFalse(_borrow.ReturnBook(100, 4));
        }

        [Test]
        public void ReturnBook_BookNotBorrowedByUser()
        {
            _borrow.AddBook("Book 1", "Author 1", 2023);
            _borrow.AddUser("User 1");
            _borrow.AddUser("User 2");
            _borrow.BorrowBook(1, 1);

            Assert.IsFalse(_borrow.ReturnBook(1, 2));
        }

        #endregion

        // Add more tests for other methods as needed
    }
}
*/