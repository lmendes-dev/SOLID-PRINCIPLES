using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRP.Services;

namespace SRP.Infrastructure
{
    public class ServiceBusService : IServiceBusService
    {
        public void Publish(string queue, object data)
        {
            throw new NotImplementedException();
        }
    }
}
