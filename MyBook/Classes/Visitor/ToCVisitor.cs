using MyBook.Classes.Printable;
using MyBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook.Classes.Visitor
{


    class ToC : IPrintable
    {
        public ToC(int depth)
        {
            mDepth = depth;
        }


        public int mDepth;
        public List<IPrintable> mPrintables { get; set; } = new List<IPrintable>();

        public void Accept(IVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public void Render()
        {
            this.Print();
        }

        public IPrintable Add(IPrintable printable)
        {
            throw new NotImplementedException();
        }

        public void Remove(IPrintable printable)
        {
            throw new NotImplementedException();
        }

        public IPrintable Get(int index)
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        private void printDots()
        {
            for (int i = 0; i < mDepth * 2; i++)
            {
                Console.Write(".");
            }
        }
        public void Print()
        {
            mPrintables.ForEach(printable =>
            {
                if (printable.GetType() == typeof(Section))
                {
                    Section s = (Section)printable;
                    printDots();
                    Console.WriteLine(s.Title);
                }
                else
                {
                    ToC toc = (ToC)printable;
                    if (toc.mPrintables.Count != 0)
                    {
                        toc.Print();
                    }
                }


            });
        }

    }

    class ToCVisitor : BaseVisitor
    {
        int mDepth = 1;

        ToC mCurrentToC = new ToC(0);

        public void PrintToC()
        {
            Console.WriteLine("Table of Contents:");

            mCurrentToC.Print();
        }

        public override void Visit(Book book)
        {
            this.Visit((Section)book);
        }

        public override void Visit(Section section)
        {
            ToC newToc = new ToC(mDepth);

            ToC returnToThisToc = mCurrentToC;

            if (mDepth == 1 && mCurrentToC.mPrintables.Count == 0)
            {
                mCurrentToC.mPrintables.Add(section); // add the current section, it's the first visit ever
            }

            mCurrentToC.mPrintables.Add(newToc);
            mCurrentToC = newToc;
            mDepth += 1;

            section.Printables.ForEach(printable =>
            {
                if (printable.GetType() != typeof(Section))
                    return;

                mCurrentToC.mPrintables.Add(printable);

                printable.Accept(this);
            });

            mCurrentToC = returnToThisToc;
            mDepth -= 1;
        }

        public override void Visit(TableOfContents tableOfContents)
        {
            mCurrentToC.mPrintables.Add(tableOfContents);
        }

        public override void Visit(Paragraph paragraph)
        {
            mCurrentToC.mPrintables.Add(paragraph);
        }

        public override void Visit(ImageProxy imageProxy)
        {
            mCurrentToC.mPrintables.Add(imageProxy);
        }

        public override void Visit(Image image)
        {
            mCurrentToC.mPrintables.Add(image);
        }

        public override void Visit(Table table)
        {
            mCurrentToC.mPrintables.Add(table);
        }
    }
}
