using LSP.Entities;

namespace LSP.Infrastructure
{
    public class ContractedClient : Client
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public ContractedClient(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }

        public override bool ClientPremium()
        {
            return false;
        }
    }
}
