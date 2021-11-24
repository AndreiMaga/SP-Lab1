using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook.Classes
{
    class DocumentManager
    {

        public Book Book { get; set; }

        private static object sync = new object();
        private static volatile DocumentManager instance;

        private DocumentManager() { }

        public static DocumentManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (sync)
                    {
                        if (instance == null)
                            instance = new DocumentManager();
                    }
                }
                return instance;
            }
        }
    }
}
