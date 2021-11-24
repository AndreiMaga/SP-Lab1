using MyBook.Classes;
using MyBook.Classes.Align;
using MyBook.Classes.Printable;
using System;

namespace MyBook
{
    class Program
    {

        static void Main(string[] args)
        {
            Section cap1 = new Section("Capitolul 1");
            Paragraph p1 = new Paragraph("Paragraph 1");
            p1.AlignStrategy = new AlignCenter();
            cap1.Add(p1);
            Paragraph p2 = new Paragraph("Paragraph 2");
            p2.AlignStrategy = new AlignRight();
            cap1.Add(p2);
            Paragraph p3 = new Paragraph("Paragraph 3");
            p3.AlignStrategy =  new AlignLeft();
            cap1.Add(p3);
            Paragraph p4 = new Paragraph("Paragraph 4");
            cap1.Add(p4);
            Console.WriteLine("Printing with Alignment");
            Console.WriteLine();
            cap1.Print();

        }
    }
}
