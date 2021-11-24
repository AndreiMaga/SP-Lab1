using MyBook.Classes;
using MyBook.Classes.Align;
using MyBook.Classes.Printable;
using System;

namespace MyBook
{
    class Program
    {
        static void Printing()
        {
            DocumentManager.Instance.Book.Print();
        }
        
        static void Main(string[] args)
        {
            Book myBook = new Book("My Book");
            DocumentManager.Instance.Book = myBook;
            Author me = new Author("My Self");
            myBook.AddAuthor(me);
            Section cap1 = new Section("Capitolul 1");
            
            Paragraph p1 = new Paragraph("Paragraph 1")
            {
                AlignStrategy = AlignFactory.GetAlignStrategy(AlignTypes.AlignCenter)
            };
            cap1.Add(p1);
            Paragraph p2 = new Paragraph("Paragraph 2", new AlignRight());
            cap1.Add(p2);
            Paragraph p3 = new Paragraph("Paragraph 3")
            {
                AlignStrategy = new AlignLeft()
            };
            cap1.Add(p3);
            Paragraph p4 = new Paragraph("Paragraph 4");
            cap1.Add(p4);
            Console.WriteLine("Printing with Alignment");
            Console.WriteLine();
            cap1.Print();
            myBook.Add(cap1); // after cap1 is added to, as it will be added as a clone in myBook.
            Printing();
        }
    }
}
