using MyBook.Classes;
using MyBook.Classes.Printable;
using MyBook.Interfaces;

namespace MyBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book noapteBuna = new Book("Noapte buna, copii!");
            Author rpGheo = new Author("Radu Pavel Gheo");
            noapteBuna.AddAuthor(rpGheo);
            Chapter cap1 = new Chapter("Capitolul 1");
            Chapter cap11 = new Chapter("Capitolul 1.1");
            Chapter cap111 = new Chapter("Capitolul 1.1.1");
            Chapter cap1111 = new Chapter("Subchapter 1.1.1.1");
            noapteBuna.AddContent(new Paragraph("Multumesc celor care ..."));
            noapteBuna.AddContent(cap1);
            cap1.Add(new Paragraph("Moto capitol"));
            cap1.Add(cap11);
            cap11.Add(new Paragraph("Text from subchapter 1.1"));

            cap11.Add(cap111);
            cap111.Add(new Paragraph("Text from subchapter 1.1.1"));
            cap111.Add(cap1111);
            cap1111.Add(new Image("Image subchapter 1.1.1.1"));
            noapteBuna.Print();
        }
    }
}
