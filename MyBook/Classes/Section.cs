using MyBook.Interfaces;
using System;
using System.Collections.Generic;

namespace MyBook.Classes
{
    public class Section : IPrintable
    {
        public string Title { get; set; } = "Unknown";

        public bool ShouldPrintTitle { get; set; } = true;

        public readonly List<IPrintable> Printables;

        public Section(string title)
        {
            Title = title;
            Printables = new List<IPrintable>();
        }

        public virtual void Print()
        {
            if(ShouldPrintTitle)
                Console.WriteLine($"{Title}");
            Printables.ForEach(chapter => chapter.Print());
        }

        public IPrintable Add(IPrintable printable)
        {
            IPrintable cloned = (IPrintable)printable.Clone();
            Printables.Add(cloned);
            return cloned;
        }

        public void Remove(IPrintable printable)
        {
            Printables.Remove(printable);
        }

        public IPrintable Get(int index)
        {
            return Printables[index];
        }

        public virtual object Clone()
        {
            Section s = new Section(Title);
            Printables.ForEach(b => s.Add(b));
            return s;
        }
    }
}
