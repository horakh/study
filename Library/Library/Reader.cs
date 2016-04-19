using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Reader: Person
    {
               public int LibraryCard { get; set; }

        public Reader() { }
       
       

        public override string ToString()
        {
            return $"Name:{Name},Library card: {LibraryCard}";
        }
    }
}