using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    class Book
    {
        readonly List<IPrintable> mPrintables;
        string mTitle = "";

        public Book(string title)
        {
            mTitle = title;
            mPrintables = new List<IPrintable>();
        }

        public void CreateNewParagraph(string text)
        {
            AddNewParagraph(new Paragraph(text));
        }

        public void AddNewParagraph(Paragraph paragraph)
        {
            mPrintables.Add(paragraph);
        }

        public void CreateNewTable(string table)
        {
            AddNewTable(new Table(table));
        }

        public void AddNewTable(Table table)
        {
            mPrintables.Add(table);
        }

        public void print()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var printable in mPrintables)
            {
                sb.Append(printable.Print());
            }

            Console.WriteLine(sb.ToString());
        }

    }
}
