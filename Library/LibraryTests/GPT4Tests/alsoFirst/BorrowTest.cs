using NUnit.Framework;
using Library.files.resources;
using System;


/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Library.Tests.GPT4.alsoFirst
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
        public void Test_AddBook_IncreasesBookCount()
        {
            borrow.AddBook("Sample Title", "Sample Author", 2021);
            Assert.AreEqual(1, borrow.GetNextBookID());
        }*/

        [Test]
        public void Test_AddUser_IncreasesUserCount()
        {
            borrow.AddUser("Sample User");
            Assert.AreEqual(2, borrow.GetNextUserID());  
        }

        [Test]
        public void Test_RemoveBook_DecreasesBookCount()
        {
            borrow.AddBook("Sample Title", "Sample Author", 2021);
            int bookId = borrow.GetNextBookID() - 1;
            borrow.RemoveBook(bookId);
            Assert.AreEqual(1, borrow.GetNextBookID());
        }

        [Test]
        public void Test_RemoveUser_DecreasesUserCount()
        {
            borrow.AddUser("Sample User");
            int userId = borrow.GetNextUserID() - 1;
            borrow.RemoveUser(userId);
            Assert.AreEqual(1, borrow.GetNextUserID());
        }

        [Test]
        public void Test_BorrowBook_SetsBookAsUnavailable()
        {
            borrow.AddBook("Sample Title", "Sample Author", 2021);
            borrow.AddUser("Sample User");
            bool result = borrow.BorrowBook(1, 1);

            Assert.IsTrue(result);
        }

        /* Test odrzucony
        [Test]
        public void Test_ReturnBook_SetsBookAsAvailable()
        {
            borrow.AddBook("Sample Title", "Sample Author", 2021);
            borrow.AddUser("Sample User");
            borrow.BorrowBook(1, 1);
            bool result = borrow.ReturnBook(1, 5);

            Assert.IsTrue(result);
        }*/


        [Test]
        public void Test_BorrowBook_FailsIfBookDoesNotExist()
        {
            borrow.AddUser("Sample User");
            bool result = borrow.BorrowBook(99, 1);

            Assert.IsFalse(result);
        }

        [Test]
        public void Test_BorrowBook_FailsIfUserDoesNotExist()
        {
            borrow.AddBook("Sample Title", "Sample Author", 2021);
            bool result = borrow.BorrowBook(1, 99); 

            Assert.IsFalse(result);
        }

        [Test]
        public void Test_ReturnBook_FailsIfBookDoesNotExist()
        {
            borrow.AddUser("Sample User");
            bool result = borrow.ReturnBook(99, 5); 

            Assert.IsFalse(result);
        }

        /* Test odrzucony
        [Test]
        public void Test_DisplayAllBooks_OutputsBooks()
        {
            borrow.AddBook("Sample Title", "Sample Author", 2021);
            Assert.DoesNotThrow(() => borrow.DisplayAllBooks());
        }

        [Test]
        public void Test_DisplayAllUsers_OutputsUsers()
        {
            borrow.AddUser("Sample User");
            Assert.DoesNotThrow(() => borrow.DisplayAllUsers());
        }

        [Test]
        public void Test_DisplayAllBorrowedBooks_OutputsBorrowedBooks()
        {
            borrow.AddBook("Sample Title", "Sample Author", 2021);
            borrow.AddUser("Sample User");
            borrow.BorrowBook(1, 1);
            Assert.DoesNotThrow(() => borrow.DisplayAllBorrowedBooks());
        }*/
    }
}


/*
using NUnit.Framework;
using Library.files.resources;
using System;

namespace LibraryUnitTests
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
        public void Test_AddBook_IncreasesBookCount()
        {
            borrow.AddBook("Sample Title", "Sample Author", 2021);
            Assert.AreEqual(1, borrow.GetNextBookID());
        }

        [Test]
        public void Test_AddUser_IncreasesUserCount()
        {
            borrow.AddUser("Sample User");
            Assert.AreEqual(2, borrow.GetNextUserID());  
        }

        [Test]
        public void Test_RemoveBook_DecreasesBookCount()
        {
            borrow.AddBook("Sample Title", "Sample Author", 2021);
            int bookId = borrow.GetNextBookID() - 1;
            borrow.RemoveBook(bookId);
            Assert.AreEqual(1, borrow.GetNextBookID());
        }

        [Test]
        public void Test_RemoveUser_DecreasesUserCount()
        {
            borrow.AddUser("Sample User");
            int userId = borrow.GetNextUserID() - 1;
            borrow.RemoveUser(userId);
            Assert.AreEqual(1, borrow.GetNextUserID());
        }

        [Test]
        public void Test_BorrowBook_SetsBookAsUnavailable()
        {
            borrow.AddBook("Sample Title", "Sample Author", 2021);
            borrow.AddUser("Sample User");
            bool result = borrow.BorrowBook(1, 1);

            Assert.IsTrue(result);
            Assert.IsFalse(borrow.Books.Find(b => b.GetID() == 1).GetStatus());
        }

        [Test]
        public void Test_ReturnBook_SetsBookAsAvailable()
        {
            borrow.AddBook("Sample Title", "Sample Author", 2021);
            borrow.AddUser("Sample User");
            borrow.BorrowBook(1, 1);
            bool result = borrow.ReturnBook(1, 5);

            Assert.IsTrue(result);
            Assert.IsTrue(borrow.Books.Find(b => b.GetID() == 1).GetStatus());
        }

        [Test]
        public void Test_ReturnBook_RecordsRating()
        {
            borrow.AddBook("Sample Title", "Sample Author", 2021);
            borrow.AddUser("Sample User");
            borrow.BorrowBook(1, 1);
            borrow.ReturnBook(1, 5);

            double rating = borrow.Books.Find(b => b.GetID() == 1).GetAverageRating();
            Assert.AreEqual(5, rating);
        }

        [Test]
        public void Test_BorrowBook_FailsIfBookDoesNotExist()
        {
            borrow.AddUser("Sample User");
            bool result = borrow.BorrowBook(99, 1); // Non-existent book ID

            Assert.IsFalse(result);
        }

        [Test]
        public void Test_BorrowBook_FailsIfUserDoesNotExist()
        {
            borrow.AddBook("Sample Title", "Sample Author", 2021);
            bool result = borrow.BorrowBook(1, 99); 

            Assert.IsFalse(result);
        }

        [Test]
        public void Test_ReturnBook_FailsIfBookDoesNotExist()
        {
            borrow.AddUser("Sample User");
            bool result = borrow.ReturnBook(99, 5); 

            Assert.IsFalse(result);
        }

        [Test]
        public void Test_DisplayAllBooks_OutputsBooks()
        {
            borrow.AddBook("Sample Title", "Sample Author", 2021);
            Assert.DoesNotThrow(() => borrow.DisplayAllBooks());
        }

        [Test]
        public void Test_DisplayAllUsers_OutputsUsers()
        {
            borrow.AddUser("Sample User");
            Assert.DoesNotThrow(() => borrow.DisplayAllUsers());
        }

        [Test]
        public void Test_DisplayAllBorrowedBooks_OutputsBorrowedBooks()
        {
            borrow.AddBook("Sample Title", "Sample Author", 2021);
            borrow.AddUser("Sample User");
            borrow.BorrowBook(1, 1);
            Assert.DoesNotThrow(() => borrow.DisplayAllBorrowedBooks());
        }
    }
}
*/