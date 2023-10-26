using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRP.Entities;

namespace SRP.Services
{
    public interface IErpSyncService
    {
        void SyncProduct(Person person);
    }
}
