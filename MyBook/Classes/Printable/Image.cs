using MyBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
