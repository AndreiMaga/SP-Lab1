using MyBook.Interfaces;
using System;
using System.Collections.Generic;

namespace MyBook.Classes
{
    public class TableOfContents : IPrintable
    {
        int mDepth = 0;
        TableOfContents(int depth)
        {
            mDepth = depth;
        }
        readonly List<IPrintable> mPrintables = new List<IPrintable>();
        public IPrintable Add(IPrintable printable)
        {
            IPrintable clone = (IPrintable)printable.Clone();
            mPrintables.Add(clone);
            return clone;
        }

        public object Clone()
        {
            return this;
        }

        public IPrintable Get(int index)
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
                    TableOfContents toc = (TableOfContents)printable;
                    if (toc.mPrintables.Count != 0)
                    {
                        toc.Print();
                    }
                }


            });
        }

        public void Remove(IPrintable printable)
        {
            throw new NotImplementedException();
        }


        public static TableOfContents FromSection(Section section, int depth = 0)
        {
            TableOfContents toc = new TableOfContents(depth);

            section.Printables.ForEach(printable =>
            {
                if (printable.GetType() != typeof(Section))
                    return;

                toc.Add(printable);
                toc.Add(FromSection((Section)printable, depth + 1));
            });


            return toc;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void Render()
        {
            Print(); // this will print the whole ToC
        }
    }
}
