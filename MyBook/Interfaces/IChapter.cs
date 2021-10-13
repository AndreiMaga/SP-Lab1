namespace MyBook.Interfaces
{
    public interface IChapter : IPrintable
    {
        int CreateSubChapter(string v);
        ISubChapter GetSubChapter(int indexSubChapterOneOne);
    }
}
