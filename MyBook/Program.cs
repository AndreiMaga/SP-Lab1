using MyBook.Classes;
using MyBook.Interfaces;

namespace MyBook
{
    class Program
    {
        static void Main(string[] args)
        {
            IBook discoTitanic = new Book("Disco Titanic");
            IAuthor rpGheo = new Author("Radu Pavel Gheo");
            discoTitanic.AddAuthor(rpGheo);
            int indexChapterOne = discoTitanic.CreateChapter("Capitolul 1");
            IChapter chp1 = discoTitanic.GetChapter(indexChapterOne);
            int indexSubChapterOneOne = chp1.CreateSubChapter("Subcapitolul 1.1");
            ISubChapter scOneOne = chp1.GetSubChapter(indexSubChapterOneOne);
            scOneOne.CreateNewParagraph("Paragraph 1");
            scOneOne.CreateNewParagraph("Paragraph 2");
            scOneOne.CreateNewParagraph("Paragraph 3");
            scOneOne.CreateNewImage("Image 1");
            scOneOne.CreateNewParagraph("Paragraph 4");
            scOneOne.CreateNewTable("Table 1");
            scOneOne.CreateNewParagraph("Paragraph 5");
            //scOneOne.Print();

            discoTitanic.Print();
        }
    }
}
