using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Entities
{
    public class GymUnit
    {
        public GymUnit(Guid id, string name, string fullAddress, DateTime createdAt)
        {
            Id = id;
            Name = name;
            FullAddress = fullAddress;
            CreatedAt = createdAt;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FullAddress { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
