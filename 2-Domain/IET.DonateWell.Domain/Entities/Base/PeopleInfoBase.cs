using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IET.DonateWell.Domain.Entities.Base
{
    public abstract class PeopleInfoBase : Comum.Model.ValueObjects.EntitySingle
    {
        public string FullName { get; set; }
        public string FirstName { get; set; }

        public string RegisterNumber { get; set; }

        public EnumTypeRegister TypeRegister { get; set; }

        public DateTime DtBirthday { get; set; }
    }
}
