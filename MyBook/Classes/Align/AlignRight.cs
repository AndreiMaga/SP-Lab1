using MyBook.Classes.Printable;
using MyBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook.Classes.Align
{
    class AlignRight : IAlignStrategy
    {
        public void Render(string p)
        {
            // in C# we can use String.Format to align right
            Console.WriteLine(String.Format("|{0, 80}|", p));
        }
    }
}
