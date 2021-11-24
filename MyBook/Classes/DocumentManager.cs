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

        private static DocumentManager _instance;

        private DocumentManager() { }

        public static DocumentManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DocumentManager();

                return _instance;
            }
        }
    }
}
