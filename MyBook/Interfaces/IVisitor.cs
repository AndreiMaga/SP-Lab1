using MyBook.Classes;
using MyBook.Classes.Printable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook.Interfaces
{
    public interface IVisitor
    {
        void Visit(Book book);

        void Visit(Section section);

        void Visit(TableOfContents tableOfContents);

        void Visit(Paragraph paragraph);

        void Visit(ImageProxy imageProxy);

        void Visit(Image image);

        void Visit(Table table);
    }
}
