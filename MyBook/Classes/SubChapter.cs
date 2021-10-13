﻿using MyBook.Classes.Printable;
using MyBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook.Classes
{
    class SubChapter : ISubChapter
    {
        readonly List<IPrintable> mPrintables;
        string mTitle;

        public SubChapter(string title)
        {
            mPrintables = new List<IPrintable>();
            mTitle = title;
        }

        public void CreateNewParagraph(string text)
        {
            AddNewParagraph(new Paragraph(text));
        }

        public void AddNewParagraph(Paragraph paragraph)
        {
            mPrintables.Add(paragraph);
        }

        public void CreateNewTable(string table)
        {
            AddNewTable(new Table(table));
        }

        public void AddNewTable(Table table)
        {
            mPrintables.Add(table);
        }

        public void Print()
        {
            Console.WriteLine($"SubChapter: {mTitle}");

            mPrintables.ForEach(printable => printable.Print());

        }

        public void CreateNewImage(string image)
        {
            AddNewImage(image);
        }

        private void AddNewImage(string v)
        {
            mPrintables.Add(new Image(v));
        }
    }
}
