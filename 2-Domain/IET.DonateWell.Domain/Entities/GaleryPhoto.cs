using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IET.DonateWell.Domain.Entities
{
    public class GaleryPhoto : Comum.Model.ValueObjects.EntitySingle
    {
        public string Archive { get; set; }
        public string Format { get; set; }
        public double Size { get; set; }
        public string MymeType { get; set; }
    }
}
