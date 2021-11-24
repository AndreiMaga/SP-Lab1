using MyBook.Classes.Printable;
using MyBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBook.Extensions;

namespace MyBook.Classes.Align
{
    class AlignCenter : IAlignStrategy
    {
        public void Render(string p)
        {
            Console.WriteLine(string.Format("|{0}|", p.Center(80)));
        }
    }
}
