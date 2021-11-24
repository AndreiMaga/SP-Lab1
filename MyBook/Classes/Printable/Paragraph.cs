using MyBook.Classes.Align;
using MyBook.Interfaces;
using System;

namespace MyBook.Classes.Printable
{
    public class Paragraph : IPrintable
    {
        string mText;

        public IAlignStrategy AlignStrategy { get; set; }

        public Paragraph(string mText)
        {
            this.mText = mText;
        }

        public Paragraph(string mText, IAlignStrategy strategy)
        {
            this.mText = mText;
            AlignStrategy = strategy;
        }

        public IPrintable Add(IPrintable printable)
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            return new Paragraph(mText, AlignStrategy);
        }

        public IPrintable Get(int index)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            if(AlignStrategy != null)
            {
                AlignStrategy.Render(mText);
            }
            else
            {
                new AlignLeft().Render(mText);
            }
        }

        public void Remove(IPrintable printable)
        {
            throw new NotImplementedException();
        }
    }
}
