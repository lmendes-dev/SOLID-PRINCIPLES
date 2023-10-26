using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Services
{
    public interface IServiceBusService
    {
        void Publish(string queue, object data);
    }
}
