using MyBook.Classes.Printable;
using MyBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook.Classes.Align
{
    class AlignCenter : IAlignStrategy
    {
        public void Render(string p)
        {
            Console.WriteLine(String.Format("##{0}##",p));
        }
    }
}
