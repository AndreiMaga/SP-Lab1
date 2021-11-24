using MyBook.Classes.Printable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook.Interfaces
{
    public interface IAlignStrategy
    {
        void Render(Paragraph p);
    }
}
