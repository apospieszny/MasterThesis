using Library.files.resources;

namespace Library.files.interfaces
{
    public interface IBorrow
    {
        int GetNextBookID();
        void AddBook(string title, string author, int year);
        void RemoveBook(int id);
        int GetNextUserID();
        void AddUser(string name);
        void RemoveUser(int id);
        bool BorrowBook(int bookID, int userID);
        bool ReturnBook(int bookID, int rate);
        void DisplayAllBooks();
        void DisplayAllUsers();
        void DisplayAllBorrowedBooks();
    }
}
