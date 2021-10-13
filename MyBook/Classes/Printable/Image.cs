using MyBook.Interfaces;
using System;

namespace MyBook.Classes.Printable
{
    class Image : IPrintable
    {
        string mImage;
        public Image(string image)
        {
            mImage = image;
        }
        public void Print()
        {
            Console.WriteLine($"{mImage}");
        }
    }
}
