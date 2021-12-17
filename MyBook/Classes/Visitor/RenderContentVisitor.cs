using MyBook.Classes.Printable;

namespace MyBook.Classes.Visitor
{
    class RenderContentVisitor : BaseVisitor
    {
        public override void Visit(Book book)
        {
            book.Render();
            base.Visit(book);
        }

        public override void Visit(Section section)
        {
            section.Render();
            base.Visit(section);
        }

        public override void Visit(TableOfContents tableOfContents)
        {
            tableOfContents.Render();
        }

        public override void Visit(Paragraph paragraph)
        {
            paragraph.Render();
        }

        public override void Visit(ImageProxy imageProxy)
        {
            imageProxy.Render();
        }

        public override void Visit(Image image)
        {
            image.Render();
        }

        public override void Visit(Table table)
        {
            table.Render();
        }
    }
}
