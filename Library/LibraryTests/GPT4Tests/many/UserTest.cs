using NUnit.Framework;
using Library.files.resources;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 */

namespace Library.Tests.GPT4.many;

[TestFixture]
public class UserTests
{
    private User _user;
    private Book _book1;
    private Book _book2;

    [SetUp]
    public void SetUp()
    {
        _user = new User(1, "John Doe");
        _book1 = new Book(101, "Book Title One", "Author One", 2001);
        _book2 = new Book(102, "Book Title Two", "Author Two", 2002);
    }

    /* Test odrzucony
    [Test]
    public void Constructor_ShouldInitializePropertiesCorrectly()
    {
        Assert.AreEqual(1, _user.GetID());
        Assert.AreEqual("John Doe", typeof(User).GetProperty("Name", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_user));
    }


    [Test]
    public void DisplayInfo_ShouldPrintUserIDAndName()
    {
        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            _user.DisplayInfo();
            Assert.AreEqual($"ID: 1, User: John Doe\n", sw.ToString());
        }
    }*/

    [Test]
    public void BorrowBook_ShouldAddBookToBorrowedList()
    {
        _user.BorrowBook(_book1);
        Assert.Contains(_book1, typeof(User).GetProperty("BorrowedBooks", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_user) as List<Book>);
    }

    [Test]
    public void ReturnBook_ShouldRemoveBookFromBorrowedList()
    {
        _user.BorrowBook(_book1);
        _user.ReturnBook(_book1);
        Assert.IsFalse(((List<Book>)typeof(User).GetProperty("BorrowedBooks", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_user)).Contains(_book1));
    }

    /* Test odrzucony
    [Test]
    public void DisplayAllBorrowedBooks_ShouldPrintAllBorrowedBooksInfo()
    {
        _user.BorrowBook(_book1);
        _user.BorrowBook(_book2);

        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            _user.DisplayAllBorrowedBooks();
            var expected = $"ID: 101, Title: Book Title One, Author: Author One, Year: 2001\nID: 102, Title: Book Title Two, Author: Author Two, Year: 2002\n";
            Assert.AreEqual(expected, sw.ToString());
        }
    }*/

    [Test]
    public void ReturnBook_ShouldHandleTryingToRemoveNonexistentBook()
    {
        _user.BorrowBook(_book1);
        _user.ReturnBook(_book2); 
        Assert.Contains(_book1, ((List<Book>)typeof(User).GetProperty("BorrowedBooks", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_user)));
    }

    //dodatkowe testy

    [Test]
    public void ReturnBook_WhenBookNotBorrowed_ShouldNotModifyBorrowedBooksList()
    {
        _user.BorrowBook(_book1);
        int initialCount = ((List<Book>)typeof(User).GetProperty("BorrowedBooks", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_user)).Count;

        _user.ReturnBook(_book2); 
        int postReturnCount = ((List<Book>)typeof(User).GetProperty("BorrowedBooks", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_user)).Count;

        Assert.AreEqual(initialCount, postReturnCount);
    }

    [Test]
    public void ReturnBook_WhenNoBooksAreBorrowed_ShouldDoNothing()
    {
        _user.ReturnBook(_book1); 
        int postReturnCount = ((List<Book>)typeof(User).GetProperty("BorrowedBooks", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_user)).Count;

        Assert.AreEqual(0, postReturnCount);
    }

    [Test]
    public void DisplayAllBorrowedBooks_WhenNoBooksBorrowed_ShouldOutputNothing()
    {
        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            _user.DisplayAllBorrowedBooks();
            Assert.IsEmpty(sw.ToString());
        }
    }
}

/*
[TestFixture]
public class UserTests
{
    private User _user;
    private Book _book1;
    private Book _book2;

    [SetUp]
    public void SetUp()
    {
        _user = new User(1, "John Doe");
        _book1 = new Book(101, "Book Title One", "Author One", 2001);
        _book2 = new Book(102, "Book Title Two", "Author Two", 2002);
    }

    [Test]
    public void Constructor_ShouldInitializePropertiesCorrectly()
    {
        Assert.AreEqual(1, _user.GetID());
        Assert.AreEqual("John Doe", typeof(User).GetProperty("Name", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_user));
    }

    [Test]
    public void DisplayInfo_ShouldPrintUserIDAndName()
    {
        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            _user.DisplayInfo();
            Assert.AreEqual($"ID: 1, User: John Doe\n", sw.ToString());
        }
    }

    [Test]
    public void BorrowBook_ShouldAddBookToBorrowedList()
    {
        _user.BorrowBook(_book1);
        Assert.Contains(_book1, typeof(User).GetProperty("BorrowedBooks", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_user) as List<Book>);
    }

    [Test]
    public void ReturnBook_ShouldRemoveBookFromBorrowedList()
    {
        _user.BorrowBook(_book1);
        _user.ReturnBook(_book1);
        Assert.IsFalse(((List<Book>)typeof(User).GetProperty("BorrowedBooks", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_user)).Contains(_book1));
    }

    [Test]
    public void DisplayAllBorrowedBooks_ShouldPrintAllBorrowedBooksInfo()
    {
        _user.BorrowBook(_book1);
        _user.BorrowBook(_book2);

        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            _user.DisplayAllBorrowedBooks();
            var expected = $"ID: 101, Title: Book Title One, Author: Author One, Year: 2001\nID: 102, Title: Book Title Two, Author: Author Two, Year: 2002\n";
            Assert.AreEqual(expected, sw.ToString());
        }
    }

    [Test]
    public void ReturnBook_ShouldHandleTryingToRemoveNonexistentBook()
    {
        _user.BorrowBook(_book1);
        _user.ReturnBook(_book2); 
        Assert.Contains(_book1, ((List<Book>)typeof(User).GetProperty("BorrowedBooks", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_user)));
    }

    //dodatkowe testy

    [Test]
    public void ReturnBook_WhenBookNotBorrowed_ShouldNotModifyBorrowedBooksList()
    {
        _user.BorrowBook(_book1);
        int initialCount = ((List<Book>)typeof(User).GetProperty("BorrowedBooks", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_user)).Count;

        _user.ReturnBook(_book2); 
        int postReturnCount = ((List<Book>)typeof(User).GetProperty("BorrowedBooks", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_user)).Count;

        Assert.AreEqual(initialCount, postReturnCount);
    }

    [Test]
    public void ReturnBook_WhenNoBooksAreBorrowed_ShouldDoNothing()
    {
        _user.ReturnBook(_book1); 
        int postReturnCount = ((List<Book>)typeof(User).GetProperty("BorrowedBooks", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_user)).Count;

        Assert.AreEqual(0, postReturnCount);
    }

    [Test]
    public void DisplayAllBorrowedBooks_WhenNoBooksBorrowed_ShouldOutputNothing()
    {
        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            _user.DisplayAllBorrowedBooks();
            Assert.IsEmpty(sw.ToString());
        }
    }
}
*/