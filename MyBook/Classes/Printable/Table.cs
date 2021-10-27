using MyBook.Interfaces;
using System;

namespace MyBook.Classes.Printable
{
    public class Table : IPrintable
    {
        private string mTable;

        public Table(string table)
        {
            this.mTable = table;
        }

        public void Print()
        {
            Console.WriteLine(string.Join(".\n", mTable.Split(new string[] { ". " }, StringSplitOptions.None)));
        }

        public void Add(IPrintable printable)
        {
            throw new NotImplementedException();
        }

        public IPrintable Get(int index)
        {
            throw new NotImplementedException();
        }

        public void Remove(IPrintable printable)
        {
            throw new NotImplementedException();
        }
    }
}
