using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IET.DonateWell.Domain.Entities
{
    public class Donor : Base.PeopleInfoBase
    {
        public Donor()
        {
            ValidateOlderAge(18);
        }

        public bool Anonymous { get; set; }

        public void ValidateOlderAge(int olderAger)
        {
            if (DateTime.UtcNow.Year - DtBirthday.Year < olderAger)
                throw new ArgumentException("The person is not of legal age");
        }
    }
}
