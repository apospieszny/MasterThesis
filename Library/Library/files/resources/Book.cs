using Library.files.interfaces;

namespace Library.files.resources
{
    public class Book : IBook
    {
        private int BookID;
        private string Title;
        private string Author;
        private int Year;
        private bool IsAvailable;
        private int UserId;
        private List<double> Ratings = new List<double>();

        public Book(int id, string title, string author, int year)
        {
            BookID = id;
            Title = title;
            Author = author;
            Year = year;
            IsAvailable = true;
            UserId = 0;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {BookID}, Title: {Title}, Author: {Author}, Year: {Year}");
        }

        public bool GetStatus()
        {
            return IsAvailable;
        }

        public void ChangeStatus()
        {
            IsAvailable = !IsAvailable;
        }

        public void ChangeUser(int id)
        {
            UserId = id;
        }

        public int GetID()
        {
            return BookID;
        }

        public int GetUserID()
        {
            return UserId;
        }

        public void RateBook(double rating)
        {
            if (rating < 0)
            {
                throw new ArgumentException("Ocena powinna być nieujemna.");
            }
            Ratings.Add(rating);
        }

        public double GetAverageRating()
        {
            if (Ratings.Count == 0) return 0;
            return Ratings.Average();
        }

    }
}
