using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Lord of the Rings");
            book.CreateNewParagraph("The world is changed.");
            book.CreateNewParagraph("I feel it in the water.");
            book.CreateNewParagraph("I feel it in the earth.");
            book.CreateNewParagraph("I smell it in the air.");
            book.CreateNewParagraph("Much that once was is lost, for none now live who remember it.");
            book.CreateNewTable("It began with the forging of the Great Rings. Three were given to the Elves, immortal, wisest and fairest of all beings. Seven to the Dwarf-Lords, great miners and craftsmen of the mountain halls. And nine, nine rings were gifted to the race of Men, who above all else desire power. For within these rings was bound the strength and the will to govern each race. But they were all of them deceived, for another ring was made. Deep in the land of Mordor, in the Fires of Mount Doom, the Dark Lord Sauron forged a master ring, and into this ring he poured his cruelty, his malice and his will to dominate all life.");
            book.print();
        }
    }
}
