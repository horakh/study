using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Admin : Person
    {
        public string Position { get; set; }

        public Admin() { }



        public override string ToString()
        {
            return $"Name:{Name},position: {Position}";
        }
    }
}