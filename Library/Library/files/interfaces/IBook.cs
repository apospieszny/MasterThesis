namespace Library.files.interfaces
{
    public interface IBook
    {
        void DisplayInfo();
        bool GetStatus();
        void ChangeStatus();
        void ChangeUser(int id);
        int GetID();
        int GetUserID();
        void RateBook(double rating);
        double GetAverageRating();

    }
}
