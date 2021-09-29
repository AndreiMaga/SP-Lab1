using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    class Table : IPrintable
    {
        private string mTable;

        public Table(string table)
        {
            this.mTable = table;
        }

        public string Print()
        {
            return string.Join(".\n", mTable.Split(new string[] { ". " }, StringSplitOptions.None)); ;
        }
    }
}
