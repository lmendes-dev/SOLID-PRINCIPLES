using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSP.Entities;

namespace LSP.Infrastructure
{
    internal class TargetClient : Client
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public TargetClient(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }
        public override bool ClientPremium()
        {
            throw new NotImplementedException();
        }
    }
}
