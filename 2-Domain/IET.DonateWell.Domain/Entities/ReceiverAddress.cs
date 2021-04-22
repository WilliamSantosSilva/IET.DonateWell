using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IET.DonateWell.Domain.Entities
{
    public class ReceiverAddress : Comum.Model.ValueObjects.EntitySingle
    {
        public Guid ReceiverId { get; set; }
        public Receiver Receiver { get; set; }

        public Guid AddressId { get; set; }
        public Address Address { get; set; }

        public string AliasTypication { get; set; }
    }
}
