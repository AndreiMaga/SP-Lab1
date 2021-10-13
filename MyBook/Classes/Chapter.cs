using MyBook.Interfaces;
using System;
using System.Collections.Generic;

namespace MyBook.Classes
{
    public class Chapter
    {
        string mTitle;

        readonly List<SubChapter> mSubChapters;

        public Chapter(string title)
        {
            mTitle = title;
            mSubChapters = new List<SubChapter>();
        }

        public int CreateSubChapter(string title)
        {
            SubChapter chapter = new SubChapter(title);

            mSubChapters.Add(chapter);

            return mSubChapters.IndexOf(chapter);
        }

        public SubChapter GetSubChapter(int indexSubChapterOneOne)
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
