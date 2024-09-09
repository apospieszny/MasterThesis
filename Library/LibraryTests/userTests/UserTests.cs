using Library.files.resources;
using NUnit.Framework;

namespace Library.Test.LibraryTests
{
    [TestFixture]
    public class UserTests
    {
        [SetUp]
        public void Setup()
        {
            List<string> testUsers = new List<string> { "x", "y", "z" };

            var library = new Borrow();
            testUsers.ForEach(x => library.AddUser(x));
            library.AddBook("a", "n", 1000);
            library.AddBook("b", "m", 1500);
            library.AddBook("c", "l", 2000);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void BorrowBook_IncorrectBookID()
        {
            List<string> testUsers = new List<string> { "x", "y", "z" };

            var library = new Borrow();
            testUsers.ForEach(x => library.AddUser(x));
            library.AddBook("a", "n", 1000);
            library.AddBook("b", "m", 1500);
            library.AddBook("c", "l", 2000);

            var actual = library.BorrowBook(4, 3);

            Assert.That(actual, Is.False);
        }
        [Test]
        public void BorrowBook_IncorrectUserID()
        {
            List<string> testUsers = new List<string> { "x", "y", "z" };

            var library = new Borrow();
            testUsers.ForEach(x => library.AddUser(x));
            library.AddBook("a", "n", 1000);
            library.AddBook("b", "m", 1500);
            library.AddBook("c", "l", 2000);

            var actual = library.BorrowBook(3, 4);

            Assert.That(actual, Is.False);
        }
        [Test]
        public void BorrowBook_CorrectData()
        {
            List<string> testUsers = new List<string> { "x", "y", "z" };

            var library = new Borrow();
            testUsers.ForEach(x => library.AddUser(x));
            library.AddBook("a", "n", 1000);
            library.AddBook("b", "m", 1500);
            library.AddBook("c", "l", 2000);

            var actual = library.BorrowBook(3, 3);

            Assert.That(actual, Is.True);
        }
        [Test]
        public void ReturnBook_CorrectData()
        {
            List<string> testUsers = new List<string> { "x", "y", "z" };

            var library = new Borrow();
            testUsers.ForEach(x => library.AddUser(x));
            library.AddBook("a", "n", 1000);
            library.AddBook("b", "m", 1500);
            library.AddBook("c", "l", 2000);

            library.BorrowBook(2, 2);
            var actual = library.ReturnBook(2, 8);

            Assert.That(actual, Is.True);
        }
        [Test]
        public void ReturnBook_NonExistingBook()
        {
            List<string> testUsers = new List<string> { "x", "y", "z" };

            var library = new Borrow();
            testUsers.ForEach(x => library.AddUser(x));
            library.AddBook("a", "n", 1000);
            library.AddBook("b", "m", 1500);
            library.AddBook("c", "l", 2000);

            library.BorrowBook(3, 3);
            var actual = library.ReturnBook(4, 8);

            Assert.That(actual, Is.False);
        }
        [Test]
        public void ReturnBook_NonBorrowedBook()
        {
            List<string> testUsers = new List<string> { "x", "y", "z" };

            var library = new Borrow();
            testUsers.ForEach(x => library.AddUser(x));
            library.AddBook("a", "n", 1000);
            library.AddBook("b", "m", 1500);
            library.AddBook("c", "l", 2000);

            library.BorrowBook(3, 3);
            var actual = library.ReturnBook(2, 8);

            Assert.That(actual, Is.False);
        }
        [Test]
        public void ReturnBook_NegativeRatingError()
        {
            List<string> testUsers = new List<string> { "x", "y", "z" };

            var library = new Borrow();
            testUsers.ForEach(x => library.AddUser(x));
            library.AddBook("a", "n", 1000);
            library.AddBook("b", "m", 1500);
            library.AddBook("c", "l", 2000);

            library.BorrowBook(2, 2);

            var ex = Assert.Throws<ArgumentException>(() => library.ReturnBook(2, -5));
            Assert.That(ex.Message, Is.EqualTo("Ocena powinna być nieujemna."));
        }
    }
}