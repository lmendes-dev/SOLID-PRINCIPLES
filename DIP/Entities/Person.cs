using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Entities
{
    public class Person
    {
        public Person(string name, string document)
        {
            Name = name;
            Document = document;
        }

        public string Name { get; set; }
        public string Document { get; set; }
    }
}
