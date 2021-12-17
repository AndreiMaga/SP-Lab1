using MyBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyBook.Classes
{
    public class Book : Section
    {
        readonly List<Author> mAuthors;
        private TableOfContents mTOC;
        public Book(string title) : base(title)
        {
            mAuthors = new List<Author>();
            ShouldPrintTitle = false;
        }

        public void AddAuthor(Author author)
        {
            mAuthors.Add(author);
        }

        public void AddTOC(TableOfContents toc)
        {
            mTOC = toc;
        }

        public override void Print()
        {
            RenderAuthors();

            base.Print();
            //mPrintables.ForEach(chapter => chapter.Print());
        }

        private void RenderAuthors()
        {
            Console.WriteLine($"Book Title : {Title}\n");

            if (mAuthors.Count != 0)
            {

                Console.Write(mAuthors.Count == 1 ? "Author : " : "Authors : ");
                Author last = mAuthors.Last();
                mAuthors.ForEach(a =>
                {
                    a.Print();
                    if (last != a)
                    {
                        Console.Write(", ");
                    }
                });
                Console.WriteLine("\n");
            }
            if (mTOC != null)
            {
                mTOC.Print();
            }
            Console.WriteLine();
        }

        public override object Clone()
        {
            Book b = (Book)base.Clone();
            mAuthors.ForEach(b.AddAuthor);
            return b;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void Render()
        {
            RenderAuthors();

            base.Render();
        }
    }
}
