using NUnit.Framework;
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
    public class BorrowTests
    {
        private Borrow _borrow;
        private User _user;
        private Book _book;

        [SetUp]
        public void Setup()
        {
            _borrow = new Borrow();
            _user = new User(1, "Test User");
            _book = new Book(1, "Test Title", "Test Author", 2024);
        }

        [Test]
        public void GetNextBookID_ShouldReturnCorrectID()
        {
            _borrow.AddBook("Book1", "Author1", 2021);
            Assert.AreEqual(2, _borrow.GetNextBookID());
        }

        [Test]
        public void GetNextUserID_ShouldReturnCorrectID()
        {
            _borrow.AddUser("User1");
            Assert.AreEqual(2, _borrow.GetNextUserID());
        }


        [Test]
        public void BorrowBook_ShouldReturnFalseIfBookUnavailable()
        {
            _borrow.AddBook("Book Title", "Author", 2024);
            _borrow.AddUser("User Name");
            _borrow.BorrowBook(1, 1); // Borrow the book first

            bool result = _borrow.BorrowBook(1, 1); // Try to borrow again
            Assert.IsFalse(result);
        }

        /* Test odrzucony
        [Test]
        public void ReturnBook_ShouldChangeStatusAndUpdateUser()
        {
            _borrow.AddBook("Book Title", "Author", 2024);
            _borrow.AddUser("User Name");
            _borrow.BorrowBook(1, 1);
            bool result = _borrow.ReturnBook(1, 5);

            Assert.IsTrue(result);
        }*/

        [Test]
        public void ReturnBook_ShouldReturnFalseIfBookNotBorrowed()
        {
            _borrow.AddBook("Book Title", "Author", 2024);
            bool result = _borrow.ReturnBook(1, 5);
            Assert.IsFalse(result);
        }

        [Test]
        public void DisplayAllBooks_ShouldDisplayAllBooks()
        {
            _borrow.AddBook("Book Title", "Author", 2024);
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                _borrow.DisplayAllBooks();
                var output = sw.ToString().Trim();
                Assert.IsTrue(output.Contains("ID: 1, Title: Book Title, Author: Author, Year: 2024"));
            }
        }

        [Test]
        public void DisplayAllUsers_ShouldDisplayAllUsers()
        {
            _borrow.AddUser("User Name");
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                _borrow.DisplayAllUsers();
                var output = sw.ToString().Trim();
                Assert.IsTrue(output.Contains("ID: 1, User: User Name"));
            }
        }

        [Test]
        public void DisplayAllBorrowedBooks_ShouldDisplayAllBorrowedBooks()
        {
            _borrow.AddBook("Book Title", "Author", 2024);
            _borrow.AddUser("User Name");
            _borrow.BorrowBook(1, 1);
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                _borrow.DisplayAllBorrowedBooks();
                var output = sw.ToString().Trim();
                Assert.IsTrue(output.Contains("ID: 1, Title: Book Title, Author: Author, Year: 2024"));
            }
        }
         
    }
}

/*
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Library.files.resources.Tests
{
    [TestFixture]
    public class BorrowTests
    {
        private Borrow _borrow;
        private User _user;
        private Book _book;

        [SetUp]
        public void Setup()
        {
            _borrow = new Borrow();
            _user = new User(1, "Test User");
            _book = new Book(1, "Test Title", "Test Author", 2024);
        }

        [Test]
        public void GetNextBookID_ShouldReturnCorrectID()
        {
            _borrow.AddBook("Book1", "Author1", 2021);
            Assert.AreEqual(2, _borrow.GetNextBookID());
        }

        [Test]
        public void GetNextUserID_ShouldReturnCorrectID()
        {
            _borrow.AddUser("User1");
            Assert.AreEqual(2, _borrow.GetNextUserID());
        }

        [Test]
        public void AddBook_ShouldAddBookToList()
        {
            _borrow.AddBook("Book Title", "Author", 2024);
            Assert.AreEqual(1, _borrow.Books.Count);
        }

        [Test]
        public void RemoveBook_ShouldRemoveBookFromList()
        {
            _borrow.AddBook("Book Title", "Author", 2024);
            _borrow.RemoveBook(1);
            Assert.AreEqual(0, _borrow.Books.Count);
        }

        [Test]
        public void AddUser_ShouldAddUserToList()
        {
            _borrow.AddUser("User Name");
            Assert.AreEqual(1, _borrow.Users.Count);
        }

        [Test]
        public void RemoveUser_ShouldRemoveUserFromList()
        {
            _borrow.AddUser("User Name");
            _borrow.RemoveUser(1);
            Assert.AreEqual(0, _borrow.Users.Count);
        }

        [Test]
        public void BorrowBook_ShouldChangeStatusAndAssignBook()
        {
            _borrow.AddBook("Book Title", "Author", 2024);
            _borrow.AddUser("User Name");
            bool result = _borrow.BorrowBook(1, 1);

            Assert.IsTrue(result);
            Assert.IsFalse(_borrow.Books.First().GetStatus());
            Assert.AreEqual(1, _borrow.Users.First().BorrowedBooks.Count);
        }

        [Test]
        public void BorrowBook_ShouldReturnFalseIfBookUnavailable()
        {
            _borrow.AddBook("Book Title", "Author", 2024);
            _borrow.AddUser("User Name");
            _borrow.BorrowBook(1, 1); // Borrow the book first

            bool result = _borrow.BorrowBook(1, 1); // Try to borrow again
            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnBook_ShouldChangeStatusAndUpdateUser()
        {
            _borrow.AddBook("Book Title", "Author", 2024);
            _borrow.AddUser("User Name");
            _borrow.BorrowBook(1, 1);
            bool result = _borrow.ReturnBook(1, 5);

            Assert.IsTrue(result);
            Assert.IsTrue(_borrow.Books.First().GetStatus());
            Assert.AreEqual(0, _borrow.Users.First().BorrowedBooks.Count);
            Assert.AreEqual(5, _borrow.Books.First().GetAverageRating());
        }

        [Test]
        public void ReturnBook_ShouldReturnFalseIfBookNotBorrowed()
        {
            _borrow.AddBook("Book Title", "Author", 2024);
            bool result = _borrow.ReturnBook(1, 5);
            Assert.IsFalse(result);
        }

        [Test]
        public void DisplayAllBooks_ShouldDisplayAllBooks()
        {
            _borrow.AddBook("Book Title", "Author", 2024);
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                _borrow.DisplayAllBooks();
                var output = sw.ToString().Trim();
                Assert.IsTrue(output.Contains("ID: 1, Title: Book Title, Author: Author, Year: 2024"));
            }
        }

        [Test]
        public void DisplayAllUsers_ShouldDisplayAllUsers()
        {
            _borrow.AddUser("User Name");
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                _borrow.DisplayAllUsers();
                var output = sw.ToString().Trim();
                Assert.IsTrue(output.Contains("ID: 1, User: User Name"));
            }
        }

        [Test]
        public void DisplayAllBorrowedBooks_ShouldDisplayAllBorrowedBooks()
        {
            _borrow.AddBook("Book Title", "Author", 2024);
            _borrow.AddUser("User Name");
            _borrow.BorrowBook(1, 1);
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                _borrow.DisplayAllBorrowedBooks();
                var output = sw.ToString().Trim();
                Assert.IsTrue(output.Contains("ID: 1, Title: Book Title, Author: Author, Year: 2024"));
            }
        }

        // dodatkowe testy

        [Test]
        public void RateBook_ShouldNotAllowNegativeRatings()
        {
            _borrow.AddBook("Book Title", "Author", 2024);
            Assert.Throws<ArgumentException>(() => _borrow.Books.First().RateBook(-1));
        }

        [Test]
        public void GetAverageRating_ShouldReturnZeroWhenNoRatings()
        {
            _borrow.AddBook("Book Title", "Author", 2024);
            Assert.AreEqual(0, _borrow.Books.First().GetAverageRating());
        }

        [Test]
        public void GetAverageRating_ShouldCalculateCorrectAverage()
        {
            _borrow.AddBook("Book Title", "Author", 2024);
            _borrow.Books.First().RateBook(4);
            _borrow.Books.First().RateBook(6);

            Assert.AreEqual(5, _borrow.Books.First().GetAverageRating());
        }
    
    }
}
*/