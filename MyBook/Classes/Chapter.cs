using MyBook.Interfaces;
using System;
using System.Collections.Generic;

namespace MyBook.Classes
{
    public class Chapter : IPrintable
    {
        string mTitle;

        readonly List<IPrintable> mPrintables;

        public Chapter(string title)
        {
            mTitle = title;
            mPrintables = new List<IPrintable>();
        }

        public int CreateSubChapter(string title)
        {
            Chapter chapter = new Chapter(title);

            mPrintables.Add(chapter);

            return mPrintables.IndexOf(chapter);
        }

        public void Print()
        {
            Console.WriteLine($"{mTitle}");
            mPrintables.ForEach(chapter => chapter.Print());
        }

        public void Add(IPrintable printable)
        {
            mPrintables.Add(printable);
        }

        public void Remove(IPrintable printable)
        {
            mPrintables.Remove(printable);
        }

        public IPrintable Get(int index)
        {
            return mPrintables[index];
        }
    }
}
