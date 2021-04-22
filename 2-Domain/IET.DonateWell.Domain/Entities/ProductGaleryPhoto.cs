using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IET.DonateWell.Domain.Entities
{
    public class ProductGaleryPhoto : Comum.Model.ValueObjects.EntitySingle
    {
        public virtual Guid GaleryPhotoId { get; set; }
        public virtual GaleryPhoto GaleryPhoto { get; set; }

        public virtual Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
