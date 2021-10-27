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

        public void Add(IPrintable printable)
        {
            throw new NotImplementedException();
        }

        public IPrintable Get(int index)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("Paragraph: " + mText);
        }

        public void Remove(IPrintable printable)
        {
            throw new NotImplementedException();
        }
    }
}
