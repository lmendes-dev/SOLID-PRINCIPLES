using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Repositories
{
    public interface IRepository<T>
    {
        void Add(T data);
        void Update(T data);
        void Delete(Guid id);
        IEnumerable<T> GetAll(Guid id);
        T GetById(Guid id);

    }
}
