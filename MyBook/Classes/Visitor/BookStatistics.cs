using MyBook.Classes.Printable;
using System;
using System.Collections.Generic;

namespace MyBook.Classes.Visitor
{

    class BookStatistics : BaseVisitor
    {

        private readonly Dictionary<Type, int> statistics = new Dictionary<Type, int>();

        private void AddToDict(Object obj)
        {

            Type type = obj.GetType();

            statistics[type] = statistics.ContainsKey(type) ? statistics[type] + 1 : 1;

        }


        public void PrintStatistics()
        {
            Console.WriteLine("Statistics: ");
            foreach (var kvp in statistics)
            {
                Console.WriteLine($"*** Number of {kvp.Key.Name.ToLower()}: {kvp.Value}");
            }
        }

        public override void Visit(Book book)
        {
            AddToDict(book);
            base.Visit(book);
        }

        public override void Visit(Section section)
        {
            AddToDict(section);
            base.Visit(section);
        }

        public override void Visit(TableOfContents tableOfContents)
        {
            AddToDict(tableOfContents);
        }

        public override void Visit(Paragraph paragraph)
        {
            AddToDict(paragraph);
        }

        public override void Visit(ImageProxy imageProxy)
        {
            AddToDict(imageProxy);
        }

        public override void Visit(Image image)
        {
            AddToDict(image);
        }

        public override void Visit(Table table)
        {
            AddToDict(table);
        }
    }
}
