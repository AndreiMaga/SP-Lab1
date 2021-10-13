using MyBook.Interfaces;
using System;

namespace MyBook.Classes
{
    internal class Author : IAuthor
    {
        private string mName;
        public Author(string name)
        {
            mName = name;
        }

        public void Print()
        {
            Console.Write($"{mName}");
        }
    }
}