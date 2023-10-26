using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRP.Entities;

namespace SRP.Repositories
{
    public interface IProductRepository
    {
        void Add(Product product);
    }
}
