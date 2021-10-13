using MyBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyBook.Classes
{
    class Book
    {
        readonly List<Chapter> mChapters;
        readonly List<Author> mAuthors;
        string mTitle;
        public Book(string title)
        {
            mTitle = title;
            mChapters = new List<Chapter>();
            mAuthors = new List<Author>();
        }

        public void AddAuthor(Author author)
        {
            mAuthors.Add(author);
        }

        public int CreateChapter(string title)
        {
            Chapter chapter = new Chapter(title);

            mChapters.Add(chapter);

            return mChapters.IndexOf(chapter);
        }

        public Chapter GetChapter(int indexChapterOne)
        {
            return mChapters[indexChapterOne];
        }


        void Print()
        {
            Console.WriteLine($"Book Title : {mTitle}");

            if (mAuthors.Count != 0)
            {
                Console.Write($"Authors : ");
                Author last = mAuthors.Last();
                mAuthors.ForEach(a =>
                {
                    a.Print();
                    if (last != a)
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
