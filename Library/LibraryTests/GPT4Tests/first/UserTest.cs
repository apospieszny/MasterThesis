using System;
using System.Collections.Generic;
using Library.files.resources;

/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 * testy nie zostały napisane we frameworku NUnit
 * Dodanie dodatkowej przestrzeni nazw
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 * Użycie metody wbudowanej pod złą nazwą
 */

namespace Library.Tests.GPT4.first;

[TestFixture]
public class UserTests
{
    public void Constructor_AssignsCorrectValues()
    {
        // Arrange
        int expectedId = 1;
        string expectedName = "John Doe";

        // Act
        User user = new User(expectedId, expectedName);

        // Assert
        Assert.Equals(expectedId, user.GetID());
    }
    /* Test odrzucony
    [Test]
    public void DisplayInfo_PrintsCorrectInfo()
    {
        // Arrange
        User user = new User(1, "John Doe");
        var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        user.DisplayInfo();

        // Assert
        var output = writer.GetStringBuilder().ToString().Trim();
        Assert.Equals("ID: 1, User: John Doe", output);
    }*/

}


/*
using System;
using System.Collections.Generic;
using Xunit;
using Library.files.resources;

public class UserTests
{
    [Fact]
    public void Constructor_AssignsCorrectValues()
    {
        // Arrange
        int expectedId = 1;
        string expectedName = "John Doe";

        // Act
        User user = new User(expectedId, expectedName);

        // Assert
        Assert.Equal(expectedId, user.GetID());
        Assert.Equal(expectedName, user.Name);  
    }

    [Fact]
    public void DisplayInfo_PrintsCorrectInfo()
    {
        // Arrange
        User user = new User(1, "John Doe");
        var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        user.DisplayInfo();

        // Assert
        var output = writer.GetStringBuilder().ToString().Trim();
        Assert.Equal("ID: 1, User: John Doe", output);
    }

    [Fact]
    public void BorrowBook_AddsBookToList()
    {
        // Arrange
        User user = new User(1, "John Doe");
        Book book = new Book(1, "Sample Book", "Author Name", 2020);

        // Act
        user.BorrowBook(book);

        // Assert
        Assert.Contains(book, user.BorrowedBooks);  
    }

    [Fact]
    public void ReturnBook_RemovesBookFromList()
    {
        // Arrange
        User user = new User(1, "John Doe");
        Book book = new Book(1, "Sample Book", "Author Name", 2020);
        user.BorrowBook(book);

        // Act
        user.ReturnBook(book);

        // Assert
        Assert.DoesNotContain(book, user.BorrowedBooks);
    }

    [Fact]
    public void ReturnBook_WhenBookNotInList_DoesNotThrow()
    {
        // Arrange
        User user = new User(1, "John Doe");
        Book book = new Book(1, "Sample Book", "Author Name", 2020);

        // Act & Assert
        var exception = Record.Exception(() => user.ReturnBook(book));
        Assert.Null(exception);  
    }

    [Fact]
    public void DisplayAllBorrowedBooks_PrintsAllBookInfo()
    {
        // Arrange
        User user = new User(1, "John Doe");
        Book book1 = new Book(1, "Book One", "Author One", 2001);
        Book book2 = new Book(2, "Book Two", "Author Two", 2002);
        user.BorrowBook(book1);
        user.BorrowBook(book2);
        var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        user.DisplayAllBorrowedBooks();

        // Assert
        var output = writer.GetStringBuilder().ToString().Trim();
        Assert.Contains("ID: 1, Title: Book One, Author: Author One, Year: 2001", output);
        Assert.Contains("ID: 2, Title: Book Two, Author: Author Two, Year: 2002", output);
    }

    [Fact]
    public void BorrowedBooksList_IsInitiallyEmpty()
    {
        // Arrange
        User user = new User(1, "John Doe");

        // Assert
        Assert.Empty(user.BorrowedBooks);
    }
}
*/