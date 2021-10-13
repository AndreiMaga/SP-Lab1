using MyBook.Classes.Printable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
