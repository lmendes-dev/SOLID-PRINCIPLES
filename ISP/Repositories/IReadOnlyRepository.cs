using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Repositories
{
    public interface IReadOnlyRepository<T>
    {
        IEnumerable<T> GetAll(Guid id);
        T GetById(Guid id);
    }
}
