using MyBook.Classes.Printable;

namespace MyBook.Interfaces
{
    public interface ISubChapter : IPrintable
    {
        void CreateNewParagraph(string text);
        void AddNewParagraph(Paragraph paragraph);
        void CreateNewTable(string table);
        void AddNewTable(Table table);
        void CreateNewImage(string v);
    }
}
