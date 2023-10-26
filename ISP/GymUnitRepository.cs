using ISP.Entities;
using ISP.Persistence;
using ISP.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Old
namespace ISP
{
    public class GymUnitRepository : IRepository<GymUnit>
    {
        private readonly GymDbContext _context;
        public GymUnitRepository(GymDbContext context)
        {
            _context = context;
        }
        public void Add(GymUnit data)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GymUnit> GetAll(Guid id)
        {
            throw new NotImplementedException();
        }

        public GymUnit GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(GymUnit data)
        {
            throw new NotImplementedException();
        }
    }
}


//New
namespace ISP.ReadOnly
{
    public class GymUnitRepository : IReadOnlyRepository<GymUnit>
    {
        private readonly GymDbContext _context;
        public GymUnitRepository(GymDbContext context)
        {
            _context = context;
        }

        public IEnumerable<GymUnit> GetAll(Guid id)
        {
            throw new NotImplementedException();
        }

        public GymUnit GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

namespace ISP.WriteOnly
{
    public class GymUnitRepository : IWriteOnlyRepository<GymUnit>
    {
        private readonly GymDbContext _context;
        public GymUnitRepository(GymDbContext context)
        {
            _context = context;
        }
        public void Add(GymUnit data)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(GymUnit data)
        {
            throw new NotImplementedException();
        }
    }
}