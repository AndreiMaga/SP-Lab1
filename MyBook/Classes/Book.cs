using MyBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyBook.Classes
{
    class Book
    {
        readonly List<IPrintable> mPrintables;
        readonly List<Author> mAuthors;
        string mTitle;
        public Book(string title)
        {
            mTitle = title;
            mPrintables = new List<IPrintable>();
            mAuthors = new List<Author>();
        }

        public void AddAuthor(Author author)
        {
            mAuthors.Add(author);
        }

        public int CreateChapter(string title)
        {
            Chapter chapter = new Chapter(title);

            mPrintables.Add(chapter);

            return mPrintables.IndexOf(chapter);
        }

        public void AddContent(IPrintable printable) 
        {
            mPrintables.Add(printable);
        }

        public void Print()
        {
            Console.WriteLine($"Book Title : {mTitle}\n");

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

            mPrintables.ForEach(chapter => chapter.Print());
        }

    }
}
