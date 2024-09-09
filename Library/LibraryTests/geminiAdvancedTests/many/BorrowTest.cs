using Library.files.resources;
using NUnit.Framework;


/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 */

namespace Library.Tests.geminiAdvanced.many
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
        public void GetNextBookID_WithBooks_ReturnsMaxIdPlus1()
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
            _borrow.AddBook("Book1", "Author1", 2023);
            Assert.AreEqual(1, _borrow.GetNextBookID() - 1); // Sprawdza, czy książka została dodana
        }

        // RemoveBook
        [Test]
        public void RemoveBook_RemovesBookFromList()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            _borrow.RemoveBook(1);
            Assert.AreEqual(0, _borrow.GetNextBookID() - 1);
        }

        [Test]
        public void RemoveBook_NonExistentId_DoesNothing()
        {
            _borrow.RemoveBook(999); // Próba usunięcia książki o nieistniejącym ID
            Assert.Pass(); // Powinno przejść bez wyjątku
        }

        // GetNextUserID
        [Test]
        public void GetNextUserID_NoUsers_Returns1()
        {
            var result = _borrow.GetNextUserID();
            Assert.AreEqual(1, result);
        }

        [Test]
        public void GetNextUserID_WithUsers_ReturnsMaxIdPlus1()
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
            _borrow.AddUser("User1");
            Assert.AreEqual(1, _borrow.GetNextUserID() - 1);
        }

        // RemoveUser
        [Test]
        public void RemoveUser_RemovesUserFromList()
        {
            _borrow.AddUser("User1");
            _borrow.RemoveUser(1);
            Assert.AreEqual(0, _borrow.GetNextUserID() - 1);
        }

        [Test]
        public void RemoveUser_NonExistentId_DoesNothing()
        {
            _borrow.RemoveUser(999);
            Assert.Pass();
        }

        // BorrowBook
        [Test]
        public void BorrowBook_AvailableBookAndUser_ReturnsTrue()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            _borrow.AddUser("User1");
            var result = _borrow.BorrowBook(1, 1);
            Assert.IsTrue(result);
        }

        [Test]
        public void BorrowBook_UnavailableBook_ReturnsFalse()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            _borrow.AddUser("User1");
            _borrow.BorrowBook(1, 1);
            var result = _borrow.BorrowBook(1, 1);
            Assert.IsFalse(result);
        }

        [Test]
        public void BorrowBook_NonExistentBook_ReturnsFalse()
        {
            _borrow.AddUser("User1");
            var result = _borrow.BorrowBook(999, 1);
            Assert.IsFalse(result);
        }

        [Test]
        public void BorrowBook_NonExistentUser_ReturnsFalse()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            var result = _borrow.BorrowBook(1, 999);
            Assert.IsFalse(result);
        }

        /* Test odrzucony
        // ReturnBook
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
        public void ReturnBook_NotBorrowedBook_ReturnsFalse()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            var result = _borrow.ReturnBook(1, 5);
            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnBook_NonExistentBook_ReturnsFalse()
        {
            var result = _borrow.ReturnBook(999, 5);
            Assert.IsFalse(result);
        }

        /* Test odrzucony
        // DisplayAllBooks 
        [Test]
        public void DisplayAllBooks_DisplaysBooks()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            _borrow.DisplayAllBooks();
            Assert.Pass(); // Sprawdzenie, czy nie ma wyjątku
        }

        // DisplayAllUsers
        [Test]
        public void DisplayAllUsers_DisplaysUsers()
        {
            _borrow.AddUser("User1");
            _borrow.DisplayAllUsers();
            Assert.Pass();
        }

        // DisplayAllBorrowedBooks
        [Test]
        public void DisplayAllBorrowedBooks_DisplaysBorrowedBooks()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            _borrow.AddUser("User1");
            _borrow.BorrowBook(1, 1);
            _borrow.DisplayAllBorrowedBooks();
            Assert.Pass();
        }*/

        // dodatkowe testy

        [Test]
        public void ReturnBook_NonExistentUser_ReturnsFalse()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            _borrow.AddUser("User1");
            _borrow.BorrowBook(1, 1);
            _borrow.RemoveUser(1); // Usuwamy użytkownika, który wypożyczył książkę
            var result = _borrow.ReturnBook(1, 5);
            Assert.IsFalse(result);
        }

        /* Test odrzucony
        [Test]
        public void ReturnBook_InvalidRating_ThrowsException()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            _borrow.AddUser("User1");
            _borrow.BorrowBook(1, 1);
            Assert.Throws<ArgumentException>(() => _borrow.ReturnBook(1, -1));
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

        // GetNextBookID
        [Test]
        public void GetNextBookID_NoBooks_Returns1()
        {
            var result = _borrow.GetNextBookID();
            Assert.AreEqual(1, result);
        }

        [Test]
        public void GetNextBookID_WithBooks_ReturnsMaxIdPlus1()
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
            _borrow.AddBook("Book1", "Author1", 2023);
            Assert.AreEqual(1, _borrow.GetNextBookID() - 1); // Sprawdza, czy książka została dodana
        }

        // RemoveBook
        [Test]
        public void RemoveBook_RemovesBookFromList()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            _borrow.RemoveBook(1);
            Assert.AreEqual(0, _borrow.GetNextBookID() - 1);
        }

        [Test]
        public void RemoveBook_NonExistentId_DoesNothing()
        {
            _borrow.RemoveBook(999); // Próba usunięcia książki o nieistniejącym ID
            Assert.Pass(); // Powinno przejść bez wyjątku
        }

        // GetNextUserID
        [Test]
        public void GetNextUserID_NoUsers_Returns1()
        {
            var result = _borrow.GetNextUserID();
            Assert.AreEqual(1, result);
        }

        [Test]
        public void GetNextUserID_WithUsers_ReturnsMaxIdPlus1()
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
            _borrow.AddUser("User1");
            Assert.AreEqual(1, _borrow.GetNextUserID() - 1);
        }

        // RemoveUser
        [Test]
        public void RemoveUser_RemovesUserFromList()
        {
            _borrow.AddUser("User1");
            _borrow.RemoveUser(1);
            Assert.AreEqual(0, _borrow.GetNextUserID() - 1);
        }

        [Test]
        public void RemoveUser_NonExistentId_DoesNothing()
        {
            _borrow.RemoveUser(999);
            Assert.Pass();
        }

        // BorrowBook
        [Test]
        public void BorrowBook_AvailableBookAndUser_ReturnsTrue()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            _borrow.AddUser("User1");
            var result = _borrow.BorrowBook(1, 1);
            Assert.IsTrue(result);
        }

        [Test]
        public void BorrowBook_UnavailableBook_ReturnsFalse()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            _borrow.AddUser("User1");
            _borrow.BorrowBook(1, 1);
            var result = _borrow.BorrowBook(1, 1);
            Assert.IsFalse(result);
        }

        [Test]
        public void BorrowBook_NonExistentBook_ReturnsFalse()
        {
            _borrow.AddUser("User1");
            var result = _borrow.BorrowBook(999, 1);
            Assert.IsFalse(result);
        }

        [Test]
        public void BorrowBook_NonExistentUser_ReturnsFalse()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            var result = _borrow.BorrowBook(1, 999);
            Assert.IsFalse(result);
        }

        // ReturnBook
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
        public void ReturnBook_NotBorrowedBook_ReturnsFalse()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            var result = _borrow.ReturnBook(1, 5);
            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnBook_NonExistentBook_ReturnsFalse()
        {
            var result = _borrow.ReturnBook(999, 5);
            Assert.IsFalse(result);
        }

        // DisplayAllBooks 
        [Test]
        public void DisplayAllBooks_DisplaysBooks()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            _borrow.DisplayAllBooks();
            Assert.Pass(); // Sprawdzenie, czy nie ma wyjątku
        }

        // DisplayAllUsers
        [Test]
        public void DisplayAllUsers_DisplaysUsers()
        {
            _borrow.AddUser("User1");
            _borrow.DisplayAllUsers();
            Assert.Pass();
        }

        // DisplayAllBorrowedBooks
        [Test]
        public void DisplayAllBorrowedBooks_DisplaysBorrowedBooks()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            _borrow.AddUser("User1");
            _borrow.BorrowBook(1, 1);
            _borrow.DisplayAllBorrowedBooks();
            Assert.Pass();
        }

        // dodatkowe testy

        [Test]
        public void ReturnBook_NonExistentUser_ReturnsFalse()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            _borrow.AddUser("User1");
            _borrow.BorrowBook(1, 1);
            _borrow.RemoveUser(1); // Usuwamy użytkownika, który wypożyczył książkę
            var result = _borrow.ReturnBook(1, 5);
            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnBook_InvalidRating_ThrowsException()
        {
            _borrow.AddBook("Book1", "Author1", 2023);
            _borrow.AddUser("User1");
            _borrow.BorrowBook(1, 1);
            Assert.Throws<ArgumentException>(() => _borrow.ReturnBook(1, -1));
        }
    }
}
*/