using MyBook.Interfaces;
using System;

namespace MyBook.Classes
{
    public class Author
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