using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IET.DonateWell.Domain.Entities
{
    public class Address : Comum.Model.ValueObjects.EntitySingle
    {
        public string PublicPlace { get; set; }

        public int Number { get; set; }
        public string Complement { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }
        public string Country { get; set; }

        public long Lat { get; set; }

        public long Long { get; set; }
    }
}
