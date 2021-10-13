using MyBook.Classes;

namespace MyBook.Interfaces
{
    interface IBook : IPrintable
    {
        void AddAuthor(IAuthor author);
        int CreateChapter(string title);
        IChapter GetChapter(int indexChapterOne);
    }
}
