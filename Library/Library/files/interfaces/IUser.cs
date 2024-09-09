using Library.files.resources;

namespace Library.files.interfaces
{
    public interface IUser
    {
        void DisplayInfo();
        int GetID();
        void BorrowBook(Book book);
        void ReturnBook(Book book);
        void DisplayAllBorrowedBooks();
    }
}
