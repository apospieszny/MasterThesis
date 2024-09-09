using Library.files.resources;
using NUnit.Framework;
/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 * testy zostały wykonane dla klasy Book, a nie Borrow
 */

namespace Library.Tests.gemini.first
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
/*

        [Test]
        public void AddBook_ShouldIncrementBookID()
        {
            // Arrange
            int initialBookCount = _borrow.Books.Count;

            // Act
            _borrow.AddBook("Title 1", "Author 1", 2023);

            // Assert
            Assert.AreEqual(initialBookCount + 1, _borrow.Books.Count);
            Assert.AreEqual(1, _borrow.Books[0].GetID());
        }

        [Test]
        public void AddBook_ShouldAddBookToBooksList()
        {
            // Arrange
            int initialBookCount = _borrow.Books.Count;

            // Act
            _borrow.AddBook("Title 1", "Author 1", 2023);

            // Assert
            Assert.AreEqual(initialBookCount + 1, _borrow.Books.Count);
            Assert.AreEqual("Title 1", _borrow.Books[0].Title);
            Assert.AreEqual("Author 1", _borrow.Books[0].Author);
            Assert.AreEqual(2023, _borrow.Books[0].Year);
        }

        [Test]
        public void RemoveBook_ShouldRemoveBookById()
        {
            // Arrange
            _borrow.AddBook("Title 1", "Author 1", 2023);
            int bookID = _borrow.Books[0].GetID();
            int initialBookCount = _borrow.Books.Count;

            // Act
            _borrow.RemoveBook(bookID);

            // Assert
            Assert.AreEqual(initialBookCount - 1, _borrow.Books.Count);
            Assert.IsNull(_borrow.Books.Find(b => b.GetID() == bookID));
        }

        [Test]
        public void RemoveBook_ShouldNotRemoveNonexistentBook()
        {
            // Arrange
            int initialBookCount = _borrow.Books.Count;

            // Act
            _borrow.RemoveBook(100); // Non-existent ID

            // Assert
            Assert.AreEqual(initialBookCount, _borrow.Books.Count);
        }

        [Test]
        public void BorrowBook_ShouldBorrowAvailableBook()
        {
            // Arrange
            _borrow.AddBook("Title 1", "Author 1", 2023);
            _borrow.AddUser("User 1");
            int bookID = _borrow.Books[0].GetID();
            int userID = _borrow.Users[0].GetID();

            // Act
            bool result = _borrow.BorrowBook(bookID, userID);

            // Assert
            Assert.IsTrue(result);
            Assert.IsFalse(_borrow.Books[0].GetStatus());
            Assert.AreEqual(userID, _borrow.Books[0].GetUserID());
            Assert.IsTrue(_borrow.Users[0].BorrowedBooks.Contains(_borrow.Books[0]));
        }

        [Test]
        public void BorrowBook_ShouldNotBorrowUnavailableBook()
        {
            // Arrange
            _borrow.AddBook("Title 1", "Author 1", 2023);
            _borrow.AddUser("User 1");
            _borrow.BorrowBook(_borrow.Books[0].GetID(), _borrow.Users[0].GetID());
            int bookID = _borrow.Books[0].GetID();
            int userID = _borrow.Users[0].GetID();

            // Act
            bool result = _borrow.BorrowBook(bookID, userID);

            // Assert
            Assert.IsFalse(result);
            Assert.IsFalse(_borrow.Books[0].GetStatus());
            Assert.AreEqual(userID, _borrow.Books[0].GetUserID());
        }

        [Test]
        public void ReturnBook_ShouldReturnBorrowedBook()
        {
            // Arrange
            _borrow.AddBook("Title 1", "Author 1", 2023);
            _borrow.AddUser("User 1");
            _borrow.BorrowBook(_borrow.Books[0].GetID(), _borrow.Users[0].GetID());
            int bookID = _borrow.Books[0].GetID();
            int userID = _borrow.Users[0].GetID();
            int rate = 4;

            // Act
            bool result = _borrow.ReturnBook(bookID, rate);

            // Assert
            Assert.IsTrue(result);
            Assert.IsTrue(_borrow.Books[0].GetStatus());
            Assert.AreEqual(0, _borrow.Books[0].GetUserID());
            Assert.IsFalse(_borrow.Users[0].BorrowedBooks.Contains(_borrow.Books[0]));
            Assert.AreEqual(rate, _borrow.Books[0].Ratings[0]);
        }

        [Test]
        public void ReturnBook_ShouldNotReturnNonBorrowedBook()
        {
            // Arrange
            _borrow.AddBook("Title 1", "Author 1", 2023);
            _borrow.AddUser("User 1");
            int bookID = _borrow.Books[0].GetID();

            // Act
            bool result = _borrow.ReturnBook(bookID, 4);

            // Assert
            Assert.IsFalse(result);
        }
*/

        #endregion

        #region User Tests

        // ... (add similar tests for user-related methods)

        #endregion
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
        public void AddBook_ShouldIncrementBookID()
        {
            // Arrange
            int initialBookCount = _borrow.Books.Count;

            // Act
            _borrow.AddBook("Title 1", "Author 1", 2023);

            // Assert
            Assert.AreEqual(initialBookCount + 1, _borrow.Books.Count);
            Assert.AreEqual(1, _borrow.Books[0].GetID());
        }

        [Test]
        public void AddBook_ShouldAddBookToBooksList()
        {
            // Arrange
            int initialBookCount = _borrow.Books.Count;

            // Act
            _borrow.AddBook("Title 1", "Author 1", 2023);

            // Assert
            Assert.AreEqual(initialBookCount + 1, _borrow.Books.Count);
            Assert.AreEqual("Title 1", _borrow.Books[0].Title);
            Assert.AreEqual("Author 1", _borrow.Books[0].Author);
            Assert.AreEqual(2023, _borrow.Books[0].Year);
        }

        [Test]
        public void RemoveBook_ShouldRemoveBookById()
        {
            // Arrange
            _borrow.AddBook("Title 1", "Author 1", 2023);
            int bookID = _borrow.Books[0].GetID();
            int initialBookCount = _borrow.Books.Count;

            // Act
            _borrow.RemoveBook(bookID);

            // Assert
            Assert.AreEqual(initialBookCount - 1, _borrow.Books.Count);
            Assert.IsNull(_borrow.Books.Find(b => b.GetID() == bookID));
        }

        [Test]
        public void RemoveBook_ShouldNotRemoveNonexistentBook()
        {
            // Arrange
            int initialBookCount = _borrow.Books.Count;

            // Act
            _borrow.RemoveBook(100); // Non-existent ID

            // Assert
            Assert.AreEqual(initialBookCount, _borrow.Books.Count);
        }

        [Test]
        public void BorrowBook_ShouldBorrowAvailableBook()
        {
            // Arrange
            _borrow.AddBook("Title 1", "Author 1", 2023);
            _borrow.AddUser("User 1");
            int bookID = _borrow.Books[0].GetID();
            int userID = _borrow.Users[0].GetID();

            // Act
            bool result = _borrow.BorrowBook(bookID, userID);

            // Assert
            Assert.IsTrue(result);
            Assert.IsFalse(_borrow.Books[0].GetStatus());
            Assert.AreEqual(userID, _borrow.Books[0].GetUserID());
            Assert.IsTrue(_borrow.Users[0].BorrowedBooks.Contains(_borrow.Books[0]));
        }

        [Test]
        public void BorrowBook_ShouldNotBorrowUnavailableBook()
        {
            // Arrange
            _borrow.AddBook("Title 1", "Author 1", 2023);
            _borrow.AddUser("User 1");
            _borrow.BorrowBook(_borrow.Books[0].GetID(), _borrow.Users[0].GetID());
            int bookID = _borrow.Books[0].GetID();
            int userID = _borrow.Users[0].GetID();

            // Act
            bool result = _borrow.BorrowBook(bookID, userID);

            // Assert
            Assert.IsFalse(result);
            Assert.IsFalse(_borrow.Books[0].GetStatus());
            Assert.AreEqual(userID, _borrow.Books[0].GetUserID());
        }

        [Test]
        public void ReturnBook_ShouldReturnBorrowedBook()
        {
            // Arrange
            _borrow.AddBook("Title 1", "Author 1", 2023);
            _borrow.AddUser("User 1");
            _borrow.BorrowBook(_borrow.Books[0].GetID(), _borrow.Users[0].GetID());
            int bookID = _borrow.Books[0].GetID();
            int userID = _borrow.Users[0].GetID();
            int rate = 4;

            // Act
            bool result = _borrow.ReturnBook(bookID, rate);

            // Assert
            Assert.IsTrue(result);
            Assert.IsTrue(_borrow.Books[0].GetStatus());
            Assert.AreEqual(0, _borrow.Books[0].GetUserID());
            Assert.IsFalse(_borrow.Users[0].BorrowedBooks.Contains(_borrow.Books[0]));
            Assert.AreEqual(rate, _borrow.Books[0].Ratings[0]);
        }

        [Test]
        public void ReturnBook_ShouldNotReturnNonBorrowedBook()
        {
            // Arrange
            _borrow.AddBook("Title 1", "Author 1", 2023);
            _borrow.AddUser("User 1");
            int bookID = _borrow.Books[0].GetID();

            // Act
            bool result = _borrow.ReturnBook(bookID, 4);

            // Assert
            Assert.IsFalse(result);
        }

        // ... (add more tests for edge cases and different scenarios)

        #endregion

        #region User Tests

        // ... (add similar tests for user-related methods)

        #endregion
    }
}
*/