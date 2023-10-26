using OCP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Entities
{
    public class OrderPaymentInfo
    {
        public Guid OrderId { get; set; }
        public decimal TotalPrice { get; set; }
        public PaymentType Type { get; set; }
    }
}
