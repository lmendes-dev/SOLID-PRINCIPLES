using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.DTOs
{
    public class PersonDto
    {
        public PersonDto(string name, string document)
        {
            Name = name;
            Document = document;
        }

        public string Name { get; set; }
        public string Document { get; set; }
    }
}
