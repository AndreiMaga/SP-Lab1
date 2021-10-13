using MyBook.Interfaces;
using System;

namespace MyBook.Classes.Printable
{
    public class Paragraph : IPrintable
    {
        string mText;

        public Paragraph(string mText)
        {
            this.mText = mText;
        }

        public void Print()
        {
            Console.WriteLine(mText + "\n\n");
        }
    }
}
