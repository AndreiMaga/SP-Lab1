using MyBook.Interfaces;
using System;
using System.Collections.Generic;

namespace MyBook.Classes
{
    public class Chapter : IChapter
    {
        string mTitle;

        readonly List<ISubChapter> mSubChapters;

        public Chapter(string title)
        {
            mTitle = title;
            mSubChapters = new List<ISubChapter>();
        }

        public int CreateSubChapter(string title)
        {
            ISubChapter chapter = new SubChapter(title);

            mSubChapters.Add(chapter);

            return mSubChapters.IndexOf(chapter);
        }

        public ISubChapter GetSubChapter(int indexSubChapterOneOne)
        {
            return mSubChapters[indexSubChapterOneOne];
        }

        public void Print()
        {
            Console.WriteLine($"Chapter:  {mTitle}");
            mSubChapters.ForEach(chapter => chapter.Print());
        }
    }
}
