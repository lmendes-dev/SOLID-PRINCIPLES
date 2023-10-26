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
    public class ProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IServiceBusService _serviceBusService;
        private readonly IErpSyncService _erpSyncService;
        public ProductService(IProductRepository productRepository, IServiceBusService serviceBusService, IErpSyncService erpSyncService)
        {
            _productRepository = productRepository;
            _serviceBusService = serviceBusService;
            _erpSyncService = erpSyncService;
        }

        //Old
        public void Add(ProductDto dto)
        {
            var person = new Product(dto.Name, dto.Price, dto.Amount);

            //Realizar a persistência do objeto Pessoa, usando o EF Core, Dapper, ou ADO.NET

            //Realizar a sincronia com o ERP através de uma API, chamando diretamente o HttpClient

            //Public a mensagem na fila do Azure Service Bus

            //Fere o princípio da responsabilidade única, Ele tem muitas responsabilidades
        }

        //New
        public void AddSrp(ProductDto dto)
        {
            var product = new Product(dto.Name, dto.Price, dto.Amount);

            //Realizar a persistência do objeto Pessoa, usando o EF Core, Dapper, ou ADO.NET
            _productRepository.Add(product);

            //Realizar a sincronia com o ERP atr avés de uma API, chamando diretamente o HttpClient
            _erpSyncService.SyncProduct(product);

            //Public a mensagem na fila do Azure Service Bus
            _serviceBusService.Publish("PRODUCT_SERVICE", product);
        }
    }
}
