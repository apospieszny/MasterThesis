using Library.files.interfaces;

namespace Library.files.resources
{
    public class User : IUser
    {
        private int UserID;
        private string Name;
        private List<Book> BorrowedBooks { get; } = new List<Book>();

        public User(int id, string name)
        {
            UserID = id;
            Name = name;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {UserID}, User: {Name}");
        }

        public int GetID()
        {
            return UserID;
        }


        public void BorrowBook(Book book)
        {
            BorrowedBooks.Add(book);
        }

        public void ReturnBook(Book book)
        {
            var tempbook = BorrowedBooks.Find(b => b.GetID() == book.GetID());
            BorrowedBooks.Remove(tempbook);
        }

        public void DisplayAllBorrowedBooks()
        {
            foreach (var book in BorrowedBooks)
            {
                book.DisplayInfo();
            }
        }

    }
}
