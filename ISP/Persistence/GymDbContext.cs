using ISP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Persistence
{
    public class GymDbContext
    {
        public List<GymUnit> Gyms { get; set; }
    }
}
