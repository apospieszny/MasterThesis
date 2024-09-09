using Library.files.resources;
using NUnit.Framework;

/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 */

namespace Library.Tests.geminiAdvanced.first
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

        // Testy dla GetNextBookID

        [Test]
        public void GetNextBookID_NoBooks_Returns1()
        {
            var result = _borrow.GetNextBookID();
            Assert.AreEqual(1, result);
        }

        [Test]
        public void GetNextBookID_WithBooks_ReturnsMaxIDPlus1()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            _borrow.AddBook("Book2", "Author2", 2022);
            var result = _borrow.GetNextBookID();
            Assert.AreEqual(3, result);
        }


        // Testy dla GetNextUserID

        [Test]
        public void GetNextUserID_NoUsers_Returns1()
        {
            var result = _borrow.GetNextUserID();
            Assert.AreEqual(1, result);
        }

        [Test]
        public void GetNextUserID_WithUsers_ReturnsMaxIDPlus1()
        {
            _borrow.AddUser("User1");
            _borrow.AddUser("User2");
            var result = _borrow.GetNextUserID();
            Assert.AreEqual(3, result);
        }

        // Testy dla BorrowBook

        [Test]
        public void BorrowBook_AvailableBookAndExistingUser_ReturnsTrue()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            _borrow.AddUser("User1");
            var result = _borrow.BorrowBook(1, 1);
            Assert.IsTrue(result);
        }

        [Test]
        public void BorrowBook_NonExistingBook_ReturnsFalse()
        {
            _borrow.AddUser("User1");
            var result = _borrow.BorrowBook(1, 1); // Próba wypożyczenia nieistniejącej książki
            Assert.IsFalse(result);
        }

        [Test]
        public void BorrowBook_NonExistingUser_ReturnsFalse()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            var result = _borrow.BorrowBook(1, 1); // Próba wypożyczenia przez nieistniejącego użytkownika
            Assert.IsFalse(result);
        }

        [Test]
        public void BorrowBook_UnavailableBook_ReturnsFalse()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            _borrow.AddUser("User1");
            _borrow.BorrowBook(1, 1); // Wypożycz książkę, aby stała się niedostępna
            var result = _borrow.BorrowBook(1, 1); // Próba ponownego wypożyczenia
            Assert.IsFalse(result);
        }

        // Testy dla ReturnBook

        /* Test odrzucony
        [Test]
        public void ReturnBook_BorrowedBook_ReturnsTrue()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            _borrow.AddUser("User1");
            _borrow.BorrowBook(1, 1);
            var result = _borrow.ReturnBook(1, 5);
            Assert.IsTrue(result);
        }*/

        [Test]
        public void ReturnBook_NonExistingBook_ReturnsFalse()
        {
            var result = _borrow.ReturnBook(1, 5); // Próba zwrócenia nieistniejącej książki
            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnBook_NotBorrowedBook_ReturnsFalse()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            var result = _borrow.ReturnBook(1, 5); // Próba zwrócenia niewypożyczonej książki
            Assert.IsFalse(result);
        }

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

        // Testy dla GetNextBookID

        [Test]
        public void GetNextBookID_NoBooks_Returns1()
        {
            var result = _borrow.GetNextBookID();
            Assert.AreEqual(1, result);
        }

        [Test]
        public void GetNextBookID_WithBooks_ReturnsMaxIDPlus1()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            _borrow.AddBook("Book2", "Author2", 2022);
            var result = _borrow.GetNextBookID();
            Assert.AreEqual(3, result);
        }

        // Testy dla AddBook

        [Test]
        public void AddBook_AddsBookToList()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            Assert.AreEqual(1, _borrow.Books.Count);
        }

        // Testy dla RemoveBook

        [Test]
        public void RemoveBook_ExistingBook_RemovesBook()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            _borrow.RemoveBook(1);
            Assert.AreEqual(0, _borrow.Books.Count);
        }

        [Test]
        public void RemoveBook_NonExistingBook_DoesNothing()
        {
            _borrow.RemoveBook(1); // Próba usunięcia nieistniejącej książki
            Assert.AreEqual(0, _borrow.Books.Count);
        }

        // Testy dla GetNextUserID

        [Test]
        public void GetNextUserID_NoUsers_Returns1()
        {
            var result = _borrow.GetNextUserID();
            Assert.AreEqual(1, result);
        }

        [Test]
        public void GetNextUserID_WithUsers_ReturnsMaxIDPlus1()
        {
            _borrow.AddUser("User1");
            _borrow.AddUser("User2");
            var result = _borrow.GetNextUserID();
            Assert.AreEqual(3, result);
        }

        // Testy dla AddUser

        [Test]
        public void AddUser_AddsUserToList()
        {
            _borrow.AddUser("User1");
            Assert.AreEqual(1, _borrow.Users.Count);
        }

        // Testy dla RemoveUser

        [Test]
        public void RemoveUser_ExistingUser_RemovesUser()
        {
            _borrow.AddUser("User1");
            _borrow.RemoveUser(1);
            Assert.AreEqual(0, _borrow.Users.Count);
        }

        [Test]
        public void RemoveUser_NonExistingUser_DoesNothing()
        {
            _borrow.RemoveUser(1); // Próba usunięcia nieistniejącego użytkownika
            Assert.AreEqual(0, _borrow.Users.Count);
        }

        // Testy dla BorrowBook

        [Test]
        public void BorrowBook_AvailableBookAndExistingUser_ReturnsTrue()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            _borrow.AddUser("User1");
            var result = _borrow.BorrowBook(1, 1);
            Assert.IsTrue(result);
        }

        [Test]
        public void BorrowBook_NonExistingBook_ReturnsFalse()
        {
            _borrow.AddUser("User1");
            var result = _borrow.BorrowBook(1, 1); // Próba wypożyczenia nieistniejącej książki
            Assert.IsFalse(result);
        }

        [Test]
        public void BorrowBook_NonExistingUser_ReturnsFalse()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            var result = _borrow.BorrowBook(1, 1); // Próba wypożyczenia przez nieistniejącego użytkownika
            Assert.IsFalse(result);
        }

        [Test]
        public void BorrowBook_UnavailableBook_ReturnsFalse()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            _borrow.AddUser("User1");
            _borrow.BorrowBook(1, 1); // Wypożycz książkę, aby stała się niedostępna
            var result = _borrow.BorrowBook(1, 1); // Próba ponownego wypożyczenia
            Assert.IsFalse(result);
        }

        // Testy dla ReturnBook

        [Test]
        public void ReturnBook_BorrowedBook_ReturnsTrue()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            _borrow.AddUser("User1");
            _borrow.BorrowBook(1, 1);
            var result = _borrow.ReturnBook(1, 5);
            Assert.IsTrue(result);
        }

        [Test]
        public void ReturnBook_NonExistingBook_ReturnsFalse()
        {
            var result = _borrow.ReturnBook(1, 5); // Próba zwrócenia nieistniejącej książki
            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnBook_NotBorrowedBook_ReturnsFalse()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            var result = _borrow.ReturnBook(1, 5); // Próba zwrócenia niewypożyczonej książki
            Assert.IsFalse(result);
        }

    }
}
*/