using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IET.DonateWell.Domain.Entities
{
    public class Product : Comum.Model.ValueObjects.EntitySingle
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
    }
}
