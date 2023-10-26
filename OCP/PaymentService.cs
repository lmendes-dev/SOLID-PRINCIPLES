using OCP.Entities;
using OCP.Enums;
using OCP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class PaymentService
    {
        //Old
        public void Process(OrderPaymentInfo paymentInfo)
        {
            if (paymentInfo.Type == PaymentType.Credit)
            {                
                // Integrar com Gateway de Pagamento A
            } 
            else if(paymentInfo.Type == PaymentType.Debit)
            {
                // Integrar com Gateway de Pagamento B            
            } 
            else if (paymentInfo.Type == PaymentType.LoyaltyPoints) 
            {
                // Chamar serviço interno de Pontos de Fidelidade
            }
        }

        //New
        public void ProcessOCP(IOrderPaymentMethod paymentMethod)
        {
            paymentMethod.Process();
        }
    }
}
