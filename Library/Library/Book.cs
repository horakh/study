using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public string Booktitle { get; set; }
        public string Autor { get; set; }
        public string Edition { get; set; }
        public DateTime DateOfIssue { get; set; }
        public string Language{ get; set; }
        public int Pages { get; set; }

        public Book () { }
              
        public override string ToString()
        {
            return $"Booktitle:{Booktitle}, Autor: {Autor}";
        }

       
    }
}