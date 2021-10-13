using MyBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyBook.Classes
{
    class Book : IBook
    {
        readonly List<IChapter> mChapters;
        readonly List<IAuthor> mAuthors;
        string mTitle;
        public Book(string title)
        {
            mTitle = title;
            mChapters = new List<IChapter>();
            mAuthors = new List<IAuthor>();
        }

        public void AddAuthor(IAuthor author)
        {
            mAuthors.Add(author);
        }

        public int CreateChapter(string title)
        {
            IChapter chapter = new Chapter(title);

            mChapters.Add(chapter);

            return mChapters.IndexOf(chapter);
        }

        public IChapter GetChapter(int indexChapterOne)
        {
            return mChapters[indexChapterOne];
        }


        void IPrintable.Print()
        {
            Console.WriteLine($"Book Title : {mTitle}");

            if (mAuthors.Count != 0)
            {
                Console.Write($"Authors : ");
                mAuthors.ForEach(a =>
                {
                    a.Print();
                    if (mAuthors.Last() != a)
                    {
                        Console.Write(", ");
                    }
                });
                Console.WriteLine();
            }

            mChapters.ForEach(chapter => chapter.Print());
        }

    }
}
