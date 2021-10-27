using MyBook.Interfaces;
using System;
using System.Collections.Generic;

namespace MyBook.Classes
{
    public class Section : IPrintable
    {
        string mTitle;

        public bool ShouldPrintTitle { get; set; } = true;

        readonly List<IPrintable> mPrintables;

        public Section(string title)
        {
            mTitle = title;
            mPrintables = new List<IPrintable>();
        }

        public int CreateSubChapter(string title)
        {
            Section chapter = new Section(title);

            mPrintables.Add(chapter);

            return mPrintables.IndexOf(chapter);
        }

        public virtual void Print()
        {
            if(ShouldPrintTitle)
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
