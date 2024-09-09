using Library.files.resources;
using NUnit.Framework;


/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 */

namespace Library.Tests.geminiAdvanced.alsoFirst
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

        // GetNextBookID
        [Test]
        public void GetNextBookID_NoBooks_Returns1()
        {
            var result = _borrow.GetNextBookID();
            Assert.AreEqual(1, result);
        }

        [Test]
        public void GetNextBookID_WithBooks_ReturnsNextID()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            _borrow.AddBook("Book2", "Author2", 2022);
            var result = _borrow.GetNextBookID();
            Assert.AreEqual(3, result);
        }

        // AddBook
        [Test]
        public void AddBook_AddsBookToList()
        {
            _borrow.AddBook("New Book", "New Author", 2024);
            Assert.AreEqual(1, _borrow.GetNextBookID() - 1); // Sprawdza, czy książka została dodana
        }

        // RemoveBook
        [Test]
        public void RemoveBook_RemovesBookFromList()
        {
            _borrow.AddBook("Book to Remove", "Author", 2023);
            var bookId = _borrow.GetNextBookID() - 1;
            _borrow.RemoveBook(bookId);
            Assert.AreEqual(0, _borrow.GetNextBookID() - 1); // Sprawdza, czy książka została usunięta
        }

        // GetNextUserID
        [Test]
        public void GetNextUserID_NoUsers_Returns1()
        {
            var result = _borrow.GetNextUserID();
            Assert.AreEqual(1, result);
        }

        [Test]
        public void GetNextUserID_WithUsers_ReturnsNextID()
        {
            _borrow.AddUser("User1");
            _borrow.AddUser("User2");
            var result = _borrow.GetNextUserID();
            Assert.AreEqual(3, result);
        }

        // AddUser
        [Test]
        public void AddUser_AddsUserToList()
        {
            _borrow.AddUser("New User");
            Assert.AreEqual(1, _borrow.GetNextUserID() - 1); // Sprawdza, czy użytkownik został dodany
        }

        // RemoveUser
        [Test]
        public void RemoveUser_RemovesUserFromList()
        {
            _borrow.AddUser("User to Remove");
            var userId = _borrow.GetNextUserID() - 1;
            _borrow.RemoveUser(userId);
            Assert.AreEqual(0, _borrow.GetNextUserID() - 1); // Sprawdza, czy użytkownik został usunięty
        }

        // BorrowBook
        [Test]
        public void BorrowBook_AvailableBookAndUser_ReturnsTrue()
        {
            _borrow.AddBook("Available Book", "Author", 2023);
            _borrow.AddUser("Borrower");
            var bookId = _borrow.GetNextBookID() - 1;
            var userId = _borrow.GetNextUserID() - 1;
            var result = _borrow.BorrowBook(bookId, userId);
            Assert.IsTrue(result);
        }

        [Test]
        public void BorrowBook_UnavailableBook_ReturnsFalse()
        {
            _borrow.AddBook("Unavailable Book", "Author", 2023);
            _borrow.AddUser("Borrower");
            var bookId = _borrow.GetNextBookID() - 1;
            var userId = _borrow.GetNextUserID() - 1;
            _borrow.BorrowBook(bookId, userId); // Wypożycz książkę, aby stała się niedostępna
            var result = _borrow.BorrowBook(bookId, userId);
            Assert.IsFalse(result);
        }

        [Test]
        public void BorrowBook_NonexistentUser_ReturnsFalse()
        {
            _borrow.AddBook("Available Book", "Author", 2023);
            var bookId = _borrow.GetNextBookID() - 1;
            var result = _borrow.BorrowBook(bookId, 999); // Nieistniejący użytkownik
            Assert.IsFalse(result);
        }

        // ReturnBook

        [Test]
        public void ReturnBook_UnavailableBook_ReturnsFalse()
        {
            _borrow.AddBook("Available Book", "Author", 2023);
            var bookId = _borrow.GetNextBookID() - 1;
            var result = _borrow.ReturnBook(bookId, 4); // Próba zwrócenia dostępnej książki
            Assert.IsFalse(result);
        }

        /* testy odrzucone
        [Test]
        public void ReturnBook_BorrowedBook_ReturnsTrue()
        {
            _borrow.AddBook("Borrowed Book", "Author", 2023);
            _borrow.AddUser("Returner");
            var bookId = _borrow.GetNextBookID() - 1;
            var userId = _borrow.GetNextUserID() - 1;
            _borrow.BorrowBook(bookId, userId);
            var result = _borrow.ReturnBook(bookId, 5); // Zwróć książkę z oceną 5
            Assert.IsTrue(result);
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
    public class BorrowTests
    {
        private Borrow _borrow;

        [SetUp]
        public void Setup()
        {
            _borrow = new Borrow();
        }

        // GetNextBookID
        [Test]
        public void GetNextBookID_NoBooks_Returns1()
        {
            var result = _borrow.GetNextBookID();
            Assert.AreEqual(1, result);
        }

        [Test]
        public void GetNextBookID_WithBooks_ReturnsNextID()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            _borrow.AddBook("Book2", "Author2", 2022);
            var result = _borrow.GetNextBookID();
            Assert.AreEqual(3, result);
        }

        // AddBook
        [Test]
        public void AddBook_AddsBookToList()
        {
            _borrow.AddBook("New Book", "New Author", 2024);
            Assert.AreEqual(1, _borrow.GetNextBookID() - 1); // Sprawdza, czy książka została dodana
        }

        // RemoveBook
        [Test]
        public void RemoveBook_RemovesBookFromList()
        {
            _borrow.AddBook("Book to Remove", "Author", 2023);
            var bookId = _borrow.GetNextBookID() - 1;
            _borrow.RemoveBook(bookId);
            Assert.AreEqual(0, _borrow.GetNextBookID() - 1); // Sprawdza, czy książka została usunięta
        }

        // GetNextUserID
        [Test]
        public void GetNextUserID_NoUsers_Returns1()
        {
            var result = _borrow.GetNextUserID();
            Assert.AreEqual(1, result);
        }

        [Test]
        public void GetNextUserID_WithUsers_ReturnsNextID()
        {
            _borrow.AddUser("User1");
            _borrow.AddUser("User2");
            var result = _borrow.GetNextUserID();
            Assert.AreEqual(3, result);
        }

        // AddUser
        [Test]
        public void AddUser_AddsUserToList()
        {
            _borrow.AddUser("New User");
            Assert.AreEqual(1, _borrow.GetNextUserID() - 1); // Sprawdza, czy użytkownik został dodany
        }

        // RemoveUser
        [Test]
        public void RemoveUser_RemovesUserFromList()
        {
            _borrow.AddUser("User to Remove");
            var userId = _borrow.GetNextUserID() - 1;
            _borrow.RemoveUser(userId);
            Assert.AreEqual(0, _borrow.GetNextUserID() - 1); // Sprawdza, czy użytkownik został usunięty
        }

        // BorrowBook
        [Test]
        public void BorrowBook_AvailableBookAndUser_ReturnsTrue()
        {
            _borrow.AddBook("Available Book", "Author", 2023);
            _borrow.AddUser("Borrower");
            var bookId = _borrow.GetNextBookID() - 1;
            var userId = _borrow.GetNextUserID() - 1;
            var result = _borrow.BorrowBook(bookId, userId);
            Assert.IsTrue(result);
        }

        [Test]
        public void BorrowBook_UnavailableBook_ReturnsFalse()
        {
            _borrow.AddBook("Unavailable Book", "Author", 2023);
            _borrow.AddUser("Borrower");
            var bookId = _borrow.GetNextBookID() - 1;
            var userId = _borrow.GetNextUserID() - 1;
            _borrow.BorrowBook(bookId, userId); // Wypożycz książkę, aby stała się niedostępna
            var result = _borrow.BorrowBook(bookId, userId);
            Assert.IsFalse(result);
        }

        [Test]
        public void BorrowBook_NonexistentUser_ReturnsFalse()
        {
            _borrow.AddBook("Available Book", "Author", 2023);
            var bookId = _borrow.GetNextBookID() - 1;
            var result = _borrow.BorrowBook(bookId, 999); // Nieistniejący użytkownik
            Assert.IsFalse(result);
        }

        // ReturnBook
        [Test]
        public void ReturnBook_BorrowedBook_ReturnsTrue()
        {
            _borrow.AddBook("Borrowed Book", "Author", 2023);
            _borrow.AddUser("Returner");
            var bookId = _borrow.GetNextBookID() - 1;
            var userId = _borrow.GetNextUserID() - 1;
            _borrow.BorrowBook(bookId, userId);
            var result = _borrow.ReturnBook(bookId, 5); // Zwróć książkę z oceną 5
            Assert.IsTrue(result);
        }

        [Test]
        public void ReturnBook_UnavailableBook_ReturnsFalse()
        {
            _borrow.AddBook("Available Book", "Author", 2023);
            var bookId = _borrow.GetNextBookID() - 1;
            var result = _borrow.ReturnBook(bookId, 4); // Próba zwrócenia dostępnej książki
            Assert.IsFalse(result);
        }


    }
}
*/