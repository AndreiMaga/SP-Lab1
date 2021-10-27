using MyBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyBook.Classes
{
    class Book : Section
    {
        readonly List<Author> mAuthors;
        public Book(string title) : base(title)
        {
            mAuthors = new List<Author>();
            ShouldPrintTitle = false;
        }

        public void AddAuthor(Author author)
        {
            mAuthors.Add(author);
        }

        public override void Print()
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
            base.Print();
            //mPrintables.ForEach(chapter => chapter.Print());
        }

        public override object Clone()
        {
            Book b = (Book)base.Clone();
            mAuthors.ForEach(b.AddAuthor);
            return b;
        }
    }
}
