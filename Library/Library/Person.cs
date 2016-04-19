using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Person
    {
       public string Name { get; set; }
       public DateTime DateBirthday { get; set; }
       public string Address { get; set; }
        public DateTime Date { get; set; }

        public Person () { }
    
        public override string ToString ()
        {
            return $" Name {Name}, Date {Date}";
                    }
            }
}