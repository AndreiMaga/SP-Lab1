using MyBook.Interfaces;
using System;
using System.Collections.Generic;

namespace MyBook.Classes
{
    public class Section : IPrintable
    {
        public string Title { get; set; } = "Unknown";

        public bool ShouldPrintTitle { get; set; } = true;

        readonly List<IPrintable> mPrintables;

        public Section(string title)
        {
            Title = title;
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
                Console.WriteLine($"{Title}");
            mPrintables.ForEach(chapter => chapter.Print());
        }

        public IPrintable Add(IPrintable printable)
        {
            IPrintable cloned = (IPrintable)printable.Clone();
            mPrintables.Add(cloned);
            return cloned;
        }

        public void Remove(IPrintable printable)
        {
            mPrintables.Remove(printable);
        }

        public IPrintable Get(int index)
        {
            return mPrintables[index];
        }

        public virtual object Clone()
        {
            Section s = new Section(Title);
            mPrintables.ForEach(b => s.Add(b));
            return s;
        }
    }
}
