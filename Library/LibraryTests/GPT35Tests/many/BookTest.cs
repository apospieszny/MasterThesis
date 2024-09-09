using NUnit.Framework;
using System;
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
    public class BookTests
    {
        private Book _book;

        [SetUp]
        public void SetUp()
        {
            _book = new Book(1, "Title", "Author", 2024);
        }

        [Test]
        public void Constructor_ShouldInitializeProperties()
        {
            Assert.AreEqual(1, _book.GetID());
            Assert.IsTrue(_book.GetStatus());
            Assert.AreEqual(0, _book.GetUserID());
        }

        [Test]
        public void DisplayInfo_ShouldDisplayCorrectInfo()
        {
            // Redirect Console output for testing purposes
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                _book.DisplayInfo();
                var output = sw.ToString().Trim();

                Assert.AreEqual("ID: 1, Title: Title, Author: Author, Year: 2024", output);
            }
        }

        [Test]
        public void GetStatus_ShouldReturnTrueInitially()
        {
            Assert.IsTrue(_book.GetStatus());
        }

        [Test]
        public void ChangeStatus_ShouldToggleAvailability()
        {
            _book.ChangeStatus();
            Assert.IsFalse(_book.GetStatus());

            _book.ChangeStatus();
            Assert.IsTrue(_book.GetStatus());
        }

        [Test]
        public void ChangeUser_ShouldUpdateUserId()
        {
            _book.ChangeUser(42);
            Assert.AreEqual(42, _book.GetUserID());
        }

        [Test]
        public void RateBook_ShouldAddRating()
        {
            _book.RateBook(4.5);
            Assert.AreEqual(4.5, _book.GetAverageRating());

            _book.RateBook(3.0);
            Assert.AreEqual(3.75, _book.GetAverageRating());
        }

        [Test]
        public void RateBook_ShouldThrowExceptionForNegativeRating()
        {
            var ex = Assert.Throws<ArgumentException>(() => _book.RateBook(-1));
            Assert.AreEqual("Ocena powinna być nieujemna.", ex.Message);
        }

        [Test]
        public void GetAverageRating_ShouldReturnZeroIfNoRatings()
        {
            Assert.AreEqual(0, _book.GetAverageRating());
        }

        // dodatkowe testy


        [Test]
        public void GetAverageRating_ShouldCalculateCorrectlyWithMultipleRatings()
        {
            _book.RateBook(5.0);
            _book.RateBook(3.0);
            _book.RateBook(4.0);

            Assert.AreEqual((5.0 + 3.0 + 4.0) / 3, _book.GetAverageRating());
        }

        [Test]
        public void GetAverageRating_ShouldCalculateCorrectlyAfterAddingNegativeRatings()
        {
            _book.RateBook(5.0);
            _book.RateBook(2.0);
            _book.RateBook(1.0);

            Assert.AreEqual((5.0 + 2.0 + 1.0) / 3, _book.GetAverageRating());
        }
    }
}


/*
using NUnit.Framework;
using System;
using System.Linq;

namespace Library.files.resources.Tests
{
    [TestFixture]
    public class BookTests
    {
        private Book _book;

        [SetUp]
        public void SetUp()
        {
            _book = new Book(1, "Title", "Author", 2024);
        }

        [Test]
        public void Constructor_ShouldInitializeProperties()
        {
            Assert.AreEqual(1, _book.GetID());
            Assert.AreEqual("Title", _book.Title);
            Assert.AreEqual("Author", _book.Author);
            Assert.AreEqual(2024, _book.Year);
            Assert.IsTrue(_book.GetStatus());
            Assert.AreEqual(0, _book.GetUserID());
        }

        [Test]
        public void DisplayInfo_ShouldDisplayCorrectInfo()
        {
            // Redirect Console output for testing purposes
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                _book.DisplayInfo();
                var output = sw.ToString().Trim();

                Assert.AreEqual("ID: 1, Title: Title, Author: Author, Year: 2024", output);
            }
        }

        [Test]
        public void GetStatus_ShouldReturnTrueInitially()
        {
            Assert.IsTrue(_book.GetStatus());
        }

        [Test]
        public void ChangeStatus_ShouldToggleAvailability()
        {
            _book.ChangeStatus();
            Assert.IsFalse(_book.GetStatus());

            _book.ChangeStatus();
            Assert.IsTrue(_book.GetStatus());
        }

        [Test]
        public void ChangeUser_ShouldUpdateUserId()
        {
            _book.ChangeUser(42);
            Assert.AreEqual(42, _book.GetUserID());
        }

        [Test]
        public void RateBook_ShouldAddRating()
        {
            _book.RateBook(4.5);
            Assert.AreEqual(4.5, _book.GetAverageRating());

            _book.RateBook(3.0);
            Assert.AreEqual(3.75, _book.GetAverageRating());
        }

        [Test]
        public void RateBook_ShouldThrowExceptionForNegativeRating()
        {
            var ex = Assert.Throws<ArgumentException>(() => _book.RateBook(-1));
            Assert.AreEqual("Ocena powinna być nieujemna.", ex.Message);
        }

        [Test]
        public void GetAverageRating_ShouldReturnZeroIfNoRatings()
        {
            Assert.AreEqual(0, _book.GetAverageRating());
        }

        // dodatkowe testy

        [Test]
        public void GetAverageRating_ShouldReturnZeroIfNoRatings()
        {
            Assert.AreEqual(0, _book.GetAverageRating());
        }

        [Test]
        public void RatingsList_ShouldBeEmptyAfterInitialization()
        {
            Assert.AreEqual(0, _book.Ratings.Count);
        }

        [Test]
        public void GetAverageRating_ShouldCalculateCorrectlyWithMultipleRatings()
        {
            _book.RateBook(5.0);
            _book.RateBook(3.0);
            _book.RateBook(4.0);

            Assert.AreEqual((5.0 + 3.0 + 4.0) / 3, _book.GetAverageRating());
        }

        [Test]
        public void GetAverageRating_ShouldCalculateCorrectlyAfterAddingNegativeRatings()
        {
            _book.RateBook(5.0);
            _book.RateBook(2.0);
            _book.RateBook(1.0);

            Assert.AreEqual((5.0 + 2.0 + 1.0) / 3, _book.GetAverageRating());
        }
    }
}
*/