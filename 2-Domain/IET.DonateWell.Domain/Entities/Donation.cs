using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IET.DonateWell.Domain.Entities
{
    public class Donation : Comum.Model.ValueObjects.EntitySingle
    {
        public Guid DonorId { get; set; }
        public Donor Donor { get; set; }
        public Guid ReceiverId { get; set; }
        public Receiver Receiver { get; set; }

        public DateTime DtWithdrawal { get; set; }
        public bool IsEmergencial { get; set; }
        public bool IsDelivered { get; set; }
        public bool OwnVehicleDonor { get; set; }
        public decimal? Amount { get; set; }
    }
}
