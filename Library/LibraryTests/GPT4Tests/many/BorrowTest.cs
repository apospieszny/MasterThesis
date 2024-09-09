using NUnit.Framework;
using Library.files.resources;
using System.Collections.Generic;
using System;


/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 */

namespace Library.Tests.GPT4.many
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
        /* Test odrzucony
        [Test]
        public void AddBook_BookAddedToList()
        {
            _borrow.AddBook("Sample Title", "Sample Author", 2020);
            Assert.AreEqual(1, _borrow.GetNextBookID());
        }*/

        [Test]
        public void RemoveBook_BookRemovedFromList()
        {
            _borrow.AddBook("Sample Title", "Sample Author", 2020);
            _borrow.RemoveBook(1);
            Assert.AreEqual(1, _borrow.GetNextBookID());
        }

        [Test]
        public void AddUser_UserAddedToList()
        {
            _borrow.AddUser("Sample User");
            Assert.AreEqual(2, _borrow.GetNextUserID());
        }

        [Test]
        public void RemoveUser_UserRemovedFromList()
        {
            _borrow.AddUser("Sample User");
            _borrow.RemoveUser(1);
            Assert.AreEqual(1, _borrow.GetNextUserID());
        }

        [Test]
        public void BorrowBook_ValidUserAndBook_ReturnsTrue()
        {
            _borrow.AddBook("Sample Title", "Sample Author", 2020);
            _borrow.AddUser("Sample User");
            var result = _borrow.BorrowBook(1, 1);
            Assert.IsTrue(result);
        }

        [Test]
        public void BorrowBook_InvalidUserOrBook_ReturnsFalse()
        {
            var result = _borrow.BorrowBook(1, 1);
            Assert.IsFalse(result);
        }
        /* Test odrzucony
        [Test]
        public void ReturnBook_ValidBookAndRating_ReturnsTrue()
        {
            _borrow.AddBook("Sample Title", "Sample Author", 2020);
            _borrow.AddUser("Sample User");
            _borrow.BorrowBook(1, 1);
            var result = _borrow.ReturnBook(1, 5);
            Assert.IsTrue(result);
        }*/

        [Test]
        public void ReturnBook_InvalidBook_ReturnsFalse()
        {
            var result = _borrow.ReturnBook(1, 5);
            Assert.IsFalse(result);
        }

        [Test]
        public void DisplayAllBooks_ShowsAllBooks()
        {
            _borrow.AddBook("Book1", "Author1", 2001);
            _borrow.AddBook("Book2", "Author2", 2002);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                _borrow.DisplayAllBooks();

                var expected = string.Format("ID: 1, Title: Book1, Author: Author1, Year: 2001{0}ID: 2, Title: Book2, Author: Author2, Year: 2002{0}", Environment.NewLine);
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void DisplayAllUsers_ShowsAllUsers()
        {
            _borrow.AddUser("User1");
            _borrow.AddUser("User2");

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                _borrow.DisplayAllUsers();

                var expected = string.Format("ID: 1, User: User1{0}ID: 2, User: User2{0}", Environment.NewLine);
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void DisplayAllBorrowedBooks_ShowsBorrowedBooks()
        {
            _borrow.AddUser("User1");
            _borrow.AddBook("Book1", "Author1", 2001);
            _borrow.BorrowBook(1, 1);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                _borrow.DisplayAllBorrowedBooks();

                var expected = string.Format("ID: 1, Title: Book1, Author: Author1, Year: 2001{0}", Environment.NewLine);
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        // dodatkowe testy

        [Test]
        public void RemoveBook_BookDoesNotExist_NoExceptionThrown()
        {
            Assert.DoesNotThrow(() => _borrow.RemoveBook(999));
        }

        [Test]
        public void RemoveUser_UserDoesNotExist_NoExceptionThrown()
        {
            Assert.DoesNotThrow(() => _borrow.RemoveUser(999));
        }

        [Test]
        public void BorrowBook_BookAlreadyBorrowed_ReturnsFalse()
        {
            _borrow.AddBook("Sample Title", "Sample Author", 2020);
            _borrow.AddUser("Sample User");
            _borrow.BorrowBook(1, 1); 
            var result = _borrow.BorrowBook(1, 1); 
            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnBook_BookNotBorrowed_ReturnsFalse()
        {
            _borrow.AddBook("Sample Title", "Sample Author", 2020);
            var result = _borrow.ReturnBook(1, 5);
            Assert.IsFalse(result);
        }
        /* Test odrzucony
        [Test]
        public void ReturnBook_InvalidRating_ThrowsArgumentException()
        {
            _borrow.AddBook("Sample Title", "Sample Author", 2020);
            _borrow.AddUser("Sample User");
            _borrow.BorrowBook(1, 1);
            Assert.Throws<ArgumentException>(() => _borrow.ReturnBook(1, -1));
        }*/

        [Test]
        public void GetAverageRating_NoRatings_ReturnsZero()
        {
            _borrow.AddBook("Sample Title", "Sample Author", 2020);
            Book book = new Book(1, "Sample Title", "Sample Author", 2020);
            var averageRating = book.GetAverageRating();
            Assert.AreEqual(0, averageRating);
        }

    }
}


/*
using NUnit.Framework;
using Moq;
using Library.files.resources;
using System.Collections.Generic;
using System;

namespace LibraryTests
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

        [Test]
        public void AddBook_BookAddedToList()
        {
            _borrow.AddBook("Sample Title", "Sample Author", 2020);
            Assert.AreEqual(1, _borrow.GetNextBookID());
        }

        [Test]
        public void RemoveBook_BookRemovedFromList()
        {
            _borrow.AddBook("Sample Title", "Sample Author", 2020);
            _borrow.RemoveBook(1);
            Assert.AreEqual(1, _borrow.GetNextBookID());
        }

        [Test]
        public void AddUser_UserAddedToList()
        {
            _borrow.AddUser("Sample User");
            Assert.AreEqual(2, _borrow.GetNextUserID());
        }

        [Test]
        public void RemoveUser_UserRemovedFromList()
        {
            _borrow.AddUser("Sample User");
            _borrow.RemoveUser(1);
            Assert.AreEqual(1, _borrow.GetNextUserID());
        }

        [Test]
        public void BorrowBook_ValidUserAndBook_ReturnsTrue()
        {
            _borrow.AddBook("Sample Title", "Sample Author", 2020);
            _borrow.AddUser("Sample User");
            var result = _borrow.BorrowBook(1, 1);
            Assert.IsTrue(result);
        }

        [Test]
        public void BorrowBook_InvalidUserOrBook_ReturnsFalse()
        {
            var result = _borrow.BorrowBook(1, 1);
            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnBook_ValidBookAndRating_ReturnsTrue()
        {
            _borrow.AddBook("Sample Title", "Sample Author", 2020);
            _borrow.AddUser("Sample User");
            _borrow.BorrowBook(1, 1);
            var result = _borrow.ReturnBook(1, 5);
            Assert.IsTrue(result);
        }

        [Test]
        public void ReturnBook_InvalidBook_ReturnsFalse()
        {
            var result = _borrow.ReturnBook(1, 5);
            Assert.IsFalse(result);
        }

        [Test]
        public void DisplayAllBooks_ShowsAllBooks()
        {
            _borrow.AddBook("Book1", "Author1", 2001);
            _borrow.AddBook("Book2", "Author2", 2002);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                _borrow.DisplayAllBooks();

                var expected = string.Format("ID: 1, Title: Book1, Author: Author1, Year: 2001{0}ID: 2, Title: Book2, Author: Author2, Year: 2002{0}", Environment.NewLine);
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void DisplayAllUsers_ShowsAllUsers()
        {
            _borrow.AddUser("User1");
            _borrow.AddUser("User2");

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                _borrow.DisplayAllUsers();

                var expected = string.Format("ID: 1, User: User1{0}ID: 2, User: User2{0}", Environment.NewLine);
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void DisplayAllBorrowedBooks_ShowsBorrowedBooks()
        {
            _borrow.AddUser("User1");
            _borrow.AddBook("Book1", "Author1", 2001);
            _borrow.BorrowBook(1, 1);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                _borrow.DisplayAllBorrowedBooks();

                var expected = string.Format("ID: 1, Title: Book1, Author: Author1, Year: 2001{0}", Environment.NewLine);
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        // dodatkowe testy

        [Test]
        public void RemoveBook_BookDoesNotExist_NoExceptionThrown()
        {
            Assert.DoesNotThrow(() => _borrow.RemoveBook(999));
        }

        [Test]
        public void RemoveUser_UserDoesNotExist_NoExceptionThrown()
        {
            Assert.DoesNotThrow(() => _borrow.RemoveUser(999));
        }

        [Test]
        public void BorrowBook_BookAlreadyBorrowed_ReturnsFalse()
        {
            _borrow.AddBook("Sample Title", "Sample Author", 2020);
            _borrow.AddUser("Sample User");
            _borrow.BorrowBook(1, 1); 
            var result = _borrow.BorrowBook(1, 1); 
            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnBook_BookNotBorrowed_ReturnsFalse()
        {
            _borrow.AddBook("Sample Title", "Sample Author", 2020);
            var result = _borrow.ReturnBook(1, 5);
            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnBook_InvalidRating_ThrowsArgumentException()
        {
            _borrow.AddBook("Sample Title", "Sample Author", 2020);
            _borrow.AddUser("Sample User");
            _borrow.BorrowBook(1, 1);
            Assert.Throws<ArgumentException>(() => _borrow.ReturnBook(1, -1));
        }

        [Test]
        public void GetAverageRating_NoRatings_ReturnsZero()
        {
            _borrow.AddBook("Sample Title", "Sample Author", 2020);
            Book book = new Book(1, "Sample Title", "Sample Author", 2020);
            var averageRating = book.GetAverageRating();
            Assert.AreEqual(0, averageRating);
        }

    }
}
*/