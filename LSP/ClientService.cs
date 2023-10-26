using LSP.Entities;
using LSP.Infrastructure;

namespace LSP
{
    public class ClientService
    {
        public void ClientProcess()
        {
            Client clientContracted = new ContractedClient("Luiz Augusto Mendes", DateTime.Today);
            var premiumContracted = clientContracted.ClientPremium();

            //XXXXXXXXXX - ERROR - XXXXXXXXXXX
            Client clientTarget = new TargetClient("Luiz Augusto Mendes", DateTime.Today);
            var premiumTarget = clientTarget.ClientPremium();
        }

    }
}
