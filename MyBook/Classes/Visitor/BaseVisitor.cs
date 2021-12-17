using MyBook.Classes.Printable;
using MyBook.Interfaces;

namespace MyBook.Classes.Visitor
{
    abstract class BaseVisitor : IVisitor
    {
        public virtual void Visit(Book book)
        {
            book.Printables.ForEach(p => { p.Accept(this); });
        }

        public virtual void Visit(Section section)
        {
            section.Printables.ForEach(p => { p.Accept(this); });
        }

        public abstract void Visit(TableOfContents tableOfContents);

        public abstract void Visit(Paragraph paragraph);

        public abstract void Visit(ImageProxy imageProxy);

        public abstract void Visit(Image image);


        public abstract void Visit(Table table);

    }
}
