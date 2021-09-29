using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    class Paragraph : IPrintable
    {
        string mText;

        public Paragraph(string mText)
        {
            this.mText = mText;
        }

        public string Print()
        {
            return mText + "\n\n";
        }
    }
}
