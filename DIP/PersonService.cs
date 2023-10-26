using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRP.DTOs;
using SRP.Entities;
using SRP.Repositories;
using SRP.Services;

namespace SRP
{
    public class PersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IServiceBusService _serviceBusService;
        private readonly IErpSyncService _erpSyncService;
        public PersonService(IPersonRepository personRepository, IServiceBusService serviceBusService, IErpSyncService erpSyncService)
        {
            _personRepository = personRepository;
            _serviceBusService = serviceBusService;
            _erpSyncService = erpSyncService;
        }

        //Old
        public void Add(PersonDto dto)
        {
            var person = new Person(dto.Name, dto.Document);

            //Realizar a persistência do objeto Pessoa, usando o EF Core, Dapper, ou ADO.NET

            //Realizar a sincronia com o ERP através de uma API, chamando diretamente o HttpClient

            //Public a mensagem na fila do Azure Service Bus

            //Fere o princípio da responsabilidade única, Ele tem muitas responsabilidades
        }

        //New
        public void AddSrp(PersonDto dto)
        {
            var person = new Person(dto.Name, dto.Document);

            //Realizar a persistência do objeto Pessoa, usando o EF Core, Dapper, ou ADO.NET
            _personRepository.Add(person);

            //Realizar a sincronia com o ERP atr avés de uma API, chamando diretamente o HttpClient
            _erpSyncService.SyncProduct(person);

            //Public a mensagem na fila do Azure Service Bus
            _serviceBusService.Publish("PRODUCT_SERVICE", person);
        }
    }
}
