using Library.files.interfaces;

namespace Library.files.resources
{
    public class Borrow : IBorrow
    {
        private List<Book> Books = new List<Book>();
        private List<User> Users = new List<User>();

        public Borrow()
        {

        }

        public int GetNextBookID()
        {
            return Books.Count > 0 ? Books.Max(x => x.GetID()) + 1 : 1;
        }
        public void AddBook(string title, string author, int year)
        {
            Books.Add(new Book(GetNextBookID(), title, author, year));
        }

        public void RemoveBook(int id)
        {
            Books.RemoveAll(b => b.GetID() == id);
        }
        public int GetNextUserID()
        {
            return Users.Count > 0 ? Users.Max(x => x.GetID()) + 1 : 1;
        }
        public void AddUser(string name) 
        {
            Users.Add(new User(GetNextUserID(), name));
        }
        public void RemoveUser(int id) 
        {
            Users.RemoveAll(u => u.GetID() == id);
        }

        public bool BorrowBook(int bookID, int userID)
        {
            var book = Books.Find(b => b.GetID() == bookID && b.GetStatus());
            var user = Users.Find(u => u.GetID() == userID);
            if (book != null && user != null)
            {
                book.ChangeStatus();
                user.BorrowBook(book);
                book.ChangeUser(user.GetID());

                return true;
            }
            return false;
        }

        public bool ReturnBook(int bookID, int rate)
        {
            var book = Books.Find(b => b.GetID() == bookID && !b.GetStatus());
            if (book != null)
            {
                var user = Users.Find(u => u.GetID() == book.GetUserID());
                if(user != null)
                {
                    book.ChangeStatus();
                    user.ReturnBook(book);
                    book.ChangeUser(0);
                    book.RateBook(rate);
                    return true;
                }
            }
            return false;
        }

        public void DisplayAllBooks()
        {
            foreach (var book in Books)
            {
                book.DisplayInfo();
            }
        }

        public void DisplayAllUsers()
        {
            foreach (var user in Users)
            {
                user.DisplayInfo();
            }
        }

        public void DisplayAllBorrowedBooks()
        {
            foreach (var user in Users)
            {
                user.DisplayAllBorrowedBooks();
            }
        }
    }
}
