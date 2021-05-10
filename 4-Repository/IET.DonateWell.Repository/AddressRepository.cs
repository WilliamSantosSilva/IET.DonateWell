using IET.Comum.Patterns.DomainDriver.Repositories.EFCore;
using IET.DonateWell.Domain.Interface.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IET.DonateWell.Repository
{
    public class AddressRepository : RepositoryBase<Domain.Entities.Address>, IAddressRepository
    {
        public AddressRepository(DbContext context) : base(context)
        {
        }
    }
}
